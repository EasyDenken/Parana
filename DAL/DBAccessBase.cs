using System;
using System.Data;
using System.Web;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;

public abstract class DBAccessBase : IDisposable
{
    #region Factory Section

    private string strProvider = "";
    private string strConnectionString = "";
    private DbProviderFactory dbFactory = null;

    public string Provider
    {
        get { return strProvider; }
    }

    public string ConnectionString
    {
        get { return strConnectionString; }
    }

    public void SetConfiguration()
    {
        try
        {
            string ConnectionStringName = ConfigurationManager.ConnectionStrings["InmoCon"].ConnectionString;
            if (ConnectionStringName == "")
            {
                strProvider = "";
                strConnectionString = "";
            }
            else
            {
                strProvider = ConfigurationManager.ConnectionStrings["InmoCon"].ProviderName;
                strConnectionString = ConfigurationManager.ConnectionStrings["InmoCon"].ConnectionString;
            }
            if (dbFactory != null)
            {
                dbFactory = null;
            }
            if (strProvider != "")
            {
                dbFactory = DbProviderFactories.GetFactory(strProvider);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

    #endregion

    private DbConnection dbConnection;
    private DbTransaction dbTransaction;

    public DbConnection Connection
    {
        get { return this.dbConnection; }
        set { dbConnection = value; }
    }

    public DbTransaction Transaction
    {
        get { return this.dbTransaction; }
        set { Transaction = value; }
    }

    protected DBAccessBase()
    {
        SetConfiguration();
        this.dbConnection = dbFactory.CreateConnection();
        this.dbConnection.ConnectionString = strConnectionString;
        this.dbTransaction = null;
    }

    protected DBAccessBase(DbConnection Connection, DbTransaction Transaction)
    {
        SetConfiguration();
        this.dbConnection = Connection;
        this.dbTransaction = Transaction;
    }

    protected DbDataReader ExecuteReader(string query, CommandType Type, string ParameterNames, params object[] Parameters)
    {
        using (DbCommand command = dbFactory.CreateCommand())
        {
            command.Connection = dbConnection;
            command.Transaction = dbTransaction;
            command.CommandText = query;
            command.CommandType = Type;
            string[] ParameterNamesArray = ParameterNames.Split(char.Parse(","));
            for (int i = 0; i < Parameters.Length; i++)
            {
                DbParameter dbparam = dbFactory.CreateParameter();
                dbparam.ParameterName = ParameterNamesArray[i].Trim();
                dbparam.Value = Parameters[i];
                dbparam.Direction = ParameterDirection.Input;
                command.Parameters.Add(dbparam);
            }
            return command.ExecuteReader();
        }
    }

    protected DataTable ExecuteTable(string query, CommandType Type, string ParameterNames, params object[] Parameters)
    {
        using (DbCommand command = dbFactory.CreateCommand())
        {
            command.Connection = dbConnection;
            command.Transaction = dbTransaction;
            command.CommandText = query;
            command.CommandType = Type;
            string[] ParameterNamesArray = ParameterNames.Split(char.Parse(","));
            for (int i = 0; i < Parameters.Length; i++)
            {
                DbParameter dbparam = dbFactory.CreateParameter();
                dbparam.ParameterName = ParameterNamesArray[i].Trim();
                dbparam.Value = Parameters[i];
                dbparam.Direction = ParameterDirection.Input;
                command.Parameters.Add(dbparam);
            }
            DbDataAdapter dataAdapter = dbFactory.CreateDataAdapter();
            dataAdapter.SelectCommand = command;

            DataTable Table = new DataTable("Table");
            dataAdapter.Fill(Table);
            return Table;
        }
    }

    protected int ExecuteNonQuery(string query, CommandType Type, string ParameterNames, params object[] Parameters)
    {
        using (DbCommand command = dbFactory.CreateCommand())
        {
            command.Connection = dbConnection;
            command.Transaction = dbTransaction;
            command.CommandText = query;
            command.CommandType = Type;
            string[] ParameterNamesArray = ParameterNames.Split(char.Parse(","));
            for (int i = 0; i < Parameters.Length; i++)
            {
                DbParameter dbparam = dbFactory.CreateParameter();
                dbparam.ParameterName = ParameterNamesArray[i].Trim();
                dbparam.Value = Parameters[i];
                dbparam.Direction = ParameterDirection.Input;
                command.Parameters.Add(dbparam);
            }
            return command.ExecuteNonQuery();
        }
    }

    protected object ExecuteScalar(string query, CommandType Type, string ParameterNames, params object[] Parameters)
    {
        using (DbCommand command = dbFactory.CreateCommand())
        {
            command.Connection = dbConnection;
            command.Transaction = dbTransaction;
            command.CommandText = query;
            command.CommandType = Type;
            string[] ParameterNamesArray = ParameterNames.Split(char.Parse(","));
            for (int i = 0; i < Parameters.Length; i++)
            {
                DbParameter dbparam = dbFactory.CreateParameter();
                dbparam.ParameterName = ParameterNamesArray[i].Trim();
                dbparam.Value = Parameters[i];
                dbparam.Direction = ParameterDirection.Input;
                command.Parameters.Add(dbparam);
            }
            return command.ExecuteScalar();
        }
    }

    #region Connection Management

    public void OpenConnection()
    {
        if (this.dbConnection == null)
            throw new Exception("OpenConnection Error: No se ha inicializado el objeto de conexión");
        else
            switch (this.dbConnection.State)
            {
                case ConnectionState.Closed:
                    this.dbConnection.Open();
                    break;
                case ConnectionState.Broken:
                case ConnectionState.Connecting:
                case ConnectionState.Executing:
                case ConnectionState.Fetching:
                    throw new Exception("OpenConnection Error: La conexíón ya se encuentra abierta y se encuentra ocupada");
                case ConnectionState.Open:
                    break;
                default:
                    break;
            }
    }

    public void CloseConnection()
    {
        if (this.dbConnection == null)
            throw new Exception("OpenConnection Error: No se ha inicializado el objeto de conexión");
        else
            switch (this.dbConnection.State)
            {
                case ConnectionState.Closed:
                    break;
                case ConnectionState.Broken:
                case ConnectionState.Connecting:
                case ConnectionState.Executing:
                case ConnectionState.Fetching:
                    throw new Exception("OpenConnection Error: La conexíón actualmente se encuentra ocupada");
                case ConnectionState.Open:
                    if (this.dbTransaction != null)
                        throw new Exception("CloseConnection Error: Existe una transacción pendiente");
                    else
                        this.dbConnection.Close();
                    break;
                default:
                    break;
            }
    }

    #endregion

    #region Transaction Management

    public void BeginTransaction()
    {
        if (this.dbTransaction != null)
            throw new Exception("BeginTransaction Error: Ya existe una transacción en proceso.");
        else
            this.dbTransaction = this.dbConnection.BeginTransaction(IsolationLevel.Serializable);
    }

    public void CommitTransaction()
    {
        if (this.dbTransaction == null)
            throw new Exception("CommitTransaction Error: No existe una transacción en proceso");
        else
        {
            this.dbTransaction.Commit();
            this.dbTransaction.Dispose();
            this.dbTransaction = null;
        }
    }

    public void RollbackTransaction()
    {
        if (this.dbTransaction == null)
            throw new Exception("RollbackTransaction Error: No existe una transacción en proceso");
        else
        {
            this.dbTransaction.Rollback();
            this.dbTransaction.Dispose();
            this.dbTransaction = null;
        }
    }

    #endregion


    #region IDisposable Members

    public virtual void Dispose()
    {
        this.CloseConnection();
        dbConnection.Dispose();
    }

    #endregion

    #region CreaParametro
   protected SqlParameter CreaParametro(string strNombre, SqlDbType sqlTipo, ParameterDirection pdDireccion, object objValor)
    {
        SqlParameter sqlParam = new SqlParameter(strNombre, sqlTipo);
        sqlParam.Direction = pdDireccion;
        sqlParam.Value = objValor;
        return sqlParam;
    }
    #endregion CreaParametro
}
