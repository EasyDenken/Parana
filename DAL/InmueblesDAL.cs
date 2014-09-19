using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using RioParanaOBJ;
using System.Data.SqlClient;
using System.Collections;

namespace RioParanaDAL
{
    public class InmueblesDAL : DBAccessBase
    {

        public DataTable SeleccionaInmuebles(int tipo, int operacion, string orden)
        {
            this.OpenConnection();

            string sql = "";

            if (tipo != 0)
            {
                sql += " and Inmuebles.IdTipoDeInmueble = " + tipo.ToString();
            }
            if (operacion != 0)
            {
                sql += " and Inmuebles.IdOperacion = " + operacion.ToString();
            }
            if (orden != "")
            {
                sql += " order by " + orden;
            }

            try
            {
                if (sql == "")
                {

                    return this.ExecuteTable(@"SELECT Inmuebles.*, Localidades.Nombre AS NombreLocalidad, Provincias.Nombre AS NombreProvincia, TiposDeInmuebles.Tipo AS TipoDeInmueble, Operaciones.Operacion AS Operacion FROM Inmuebles INNER JOIN
                                           TiposDeInmuebles ON Inmuebles.IdTipoDeInmueble = TiposDeInmuebles.IdTipoDeInmueble INNER JOIN 
                                           Operaciones ON Inmuebles.IdOperacion = Operaciones.IdOperacion INNER JOIN 
                                           Localidades ON Inmuebles.idLocalidad = Localidades.IdLocalidad INNER JOIN 
                                           Provincias ON Localidades.IdProvincia = Provincias.IdProvincia
                                               ", CommandType.Text, "");
                    /*inner join 
                    Usuarios ON Usuarios.IdUsuario = Inmuebles.IdUsuario 
                     WHERE Usuarios.IdUsuario in (select IdUsuario from Usuarios where IdInmobiliaria 
                    in 
                    (select IdInmobiliaria from Usuarios 
                    where IdUsuario = '" + IdUsuario + "')) order by FechaActualiza asc*/
                }
                else
                {
                    string g = @"SELECT Inmuebles.*, Localidades.Nombre AS NombreLocalidad, Provincias.Nombre AS NombreProvincia, TiposDeInmuebles.Tipo AS TipoDeInmueble, Operaciones.Operacion AS Operacion FROM Inmuebles INNER JOIN
                                           TiposDeInmuebles ON Inmuebles.IdTipoDeInmueble = TiposDeInmuebles.IdTipoDeInmueble INNER JOIN 
                                           Operaciones ON Inmuebles.IdOperacion = Operaciones.IdOperacion INNER JOIN 
                                           Localidades ON Inmuebles.idLocalidad = Localidades.IdLocalidad INNER JOIN 
                                           Provincias ON Localidades.IdProvincia = Provincias.IdProvincia
                                              WHERE 1=1 " + sql;

                    return this.ExecuteTable(@"SELECT Inmuebles.*, Localidades.Nombre AS NombreLocalidad, Provincias.Nombre AS NombreProvincia, TiposDeInmuebles.Tipo AS TipoDeInmueble, Operaciones.Operacion AS Operacion FROM Inmuebles INNER JOIN
                                           TiposDeInmuebles ON Inmuebles.IdTipoDeInmueble = TiposDeInmuebles.IdTipoDeInmueble INNER JOIN 
                                           Operaciones ON Inmuebles.IdOperacion = Operaciones.IdOperacion INNER JOIN 
                                           Localidades ON Inmuebles.idLocalidad = Localidades.IdLocalidad INNER JOIN 
                                           Provincias ON Localidades.IdProvincia = Provincias.IdProvincia
                                              WHERE 1=1 " + sql, CommandType.Text, "");
                    /*
                     *  inner join 
                                                                   Usuarios ON Usuarios.IdUsuario = Inmuebles.IdUsuario 
                                                                   WHERE Usuarios.IdUsuario in (select IdUsuario from Usuarios where IdInmobiliaria 
                                                                   in 
                                                                   (select IdInmobiliaria from Usuarios 
                                                                   where IdUsuario = '" + IdUsuario + "'))*/
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }



        public DataTable SeleccionaInmueblePorID(string IdPropiedad)
        {
            this.OpenConnection();
            try
            {
                //return this.ExecuteTable(@"SELECT * FROM Inmuebles WHERE IdUsuario = '" + IdUsuario + "' and IdInmueble = " + IdPropiedad, CommandType.Text, "");
                return this.ExecuteTable(@"SELECT * FROM Inmuebles WHERE IdInmueble = " + IdPropiedad, CommandType.Text, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public DataTable SeleccionaInmueblePorID(int IdPropiedad)
        {
            this.OpenConnection();
            try
            {                
                return this.ExecuteTable(@"SELECT Inmuebles.*, 
                      Localidades.Nombre AS NombreLocalidad, 
                      Provincias.Nombre AS NombreProvincia, 
                      Operaciones.Operacion AS Operacion, 
                      TiposDeInmuebles.Tipo AS TipoDeInmueble,
                      Estados.Estado AS Estado,
                      Zonas.Nombre AS Zona
                      FROM Inmuebles LEFT OUTER JOIN
                      Zonas ON Inmuebles.IdZona = Zonas.IdZona INNER JOIN
                      Localidades ON Inmuebles.idLocalidad = Localidades.IdLocalidad INNER JOIN
                      Provincias ON Localidades.IdProvincia = Provincias.IdProvincia INNER JOIN
					  Operaciones ON Inmuebles.IdOperacion = Operaciones.IdOperacion INNER JOIN
                      TiposDeInmuebles ON Inmuebles.IdTipoDeInmueble = TiposDeInmuebles.IdTipoDeInmueble INNER JOIN
                      Estados ON Inmuebles.IdEstado = Estados.IdEstado
                      WHERE Inmuebles.IdInmueble = " + IdPropiedad, CommandType.Text, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public DataTable SeleccionaInmueblesDistintosDeID(int IdPropiedad, int IdPropiedad2, int IdPropiedad3)
        {
            string sql = "";

            if (IdPropiedad2 != 0)
            {
                sql = " and Inmuebles.IdInmueble <> " + IdPropiedad2;

                if (IdPropiedad3 != 0)
                {
                    sql += " and Inmuebles.IdInmueble <> " + IdPropiedad3;
                }
            }

            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT Inmuebles.*, 
                      Localidades.Nombre AS NombreLocalidad, 
                      Provincias.Nombre AS NombreProvincia, 
                      Operaciones.Operacion AS Operacion, 
                      TiposDeInmuebles.Tipo AS TipoDeInmueble,
                      Estados.Estado AS Estado,
                      Zonas.Nombre AS Zona
                      FROM Inmuebles LEFT OUTER JOIN
                      Zonas ON Inmuebles.IdZona = Zonas.IdZona INNER JOIN
                      Localidades ON Inmuebles.idLocalidad = Localidades.IdLocalidad INNER JOIN
                      Provincias ON Localidades.IdProvincia = Provincias.IdProvincia INNER JOIN
					  Operaciones ON Inmuebles.IdOperacion = Operaciones.IdOperacion INNER JOIN
                      TiposDeInmuebles ON Inmuebles.IdTipoDeInmueble = TiposDeInmuebles.IdTipoDeInmueble INNER JOIN
                      Estados ON Inmuebles.IdEstado = Estados.IdEstado
                      WHERE Inmuebles.IdInmueble <> " + IdPropiedad + sql, CommandType.Text, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public DataTable SeleccionaInmuebles()
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT Inmuebles.*, 
                      Localidades.Nombre AS NombreLocalidad, 
                      Provincias.Nombre AS NombreProvincia, 
                      Operaciones.Operacion AS Operacion, 
                      TiposDeInmuebles.Tipo AS TipoDeInmueble,
                      Estados.Estado AS Estado,
                      Zonas.Nombre AS Zona
                      FROM Inmuebles LEFT OUTER JOIN
                      Zonas ON Inmuebles.IdZona = Zonas.IdZona INNER JOIN
                      Localidades ON Inmuebles.idLocalidad = Localidades.IdLocalidad INNER JOIN
                      Provincias ON Localidades.IdProvincia = Provincias.IdProvincia INNER JOIN
					  Operaciones ON Inmuebles.IdOperacion = Operaciones.IdOperacion INNER JOIN
                      TiposDeInmuebles ON Inmuebles.IdTipoDeInmueble = TiposDeInmuebles.IdTipoDeInmueble INNER JOIN
                      Estados ON Inmuebles.IdEstado = Estados.IdEstado
                      ", CommandType.Text, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        //public string SeleccionaIdDelUltimoInmueble(string IdUsuario)
        //{
        //    string ID = "0";

        //    this.OpenConnection();

        //    string ssqqll = @"use ProyectoInmo SELECT MAX(IdInmueble) as IdInmueble from Inmuebles WHERE IdUsuario = '" + IdUsuario + "'";

        //    DbDataReader myReader = this.ExecuteReader(@"use ProyectoInmo SELECT MAX(IdInmueble) as IdInmueble from Inmuebles WHERE IdUsuario = '" + IdUsuario + "'", CommandType.Text, "");

        //    while (myReader.Read())
        //    {
        //        if (!myReader.IsDBNull(0))
        //        {
        //            ID = (string)myReader["IdInmueble"];
        //        }
        //    }

        //    // Close the reader and the connection.
        //    myReader.Close();
        //    this.CloseConnection();

        //    return ID;
        //}

        public DataTable SeleccionaIdDelUltimoInmueble()
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT MAX(IdInmueble) as IdInmueble from Inmuebles", CommandType.Text, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public DataTable SeleccionaInmueblesBusqueda(Inmueble objInmueble, int tipoPropiedad)
        {
            string sql = " and Inmuebles.IdTipoDeInmueble = " + tipoPropiedad.ToString();

            this.OpenConnection();

            try
            {

                return this.ExecuteTable(@"SELECT Inmuebles.*, Localidades.Nombre AS NombreLocalidad, Provincias.Nombre AS NombreProvincia, Operaciones.Operacion AS Operacion, Estados.Estado AS Estado, TiposDeInmuebles.Tipo AS TipoDeInmueble
                                           FROM Inmuebles INNER JOIN 
                                           Localidades ON Inmuebles.idLocalidad = Localidades.IdLocalidad INNER JOIN 
                                           Provincias ON Localidades.IdProvincia = Provincias.IdProvincia INNER JOIN 
                                            
                                           Operaciones ON Inmuebles.IdOperacion = Operaciones.IdOperacion INNER JOIN
                                           TiposDeInmuebles ON Inmuebles.IdTipoDeInmueble = TiposDeInmuebles.IdTipoDeInmueble INNER JOIN
                                           Estados ON Inmuebles.IdEstado = Estados.IdEstado and Estados.Estado = 'Activo'" + sql, CommandType.Text, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public DataTable SeleccionaInmueblesFavoritos()
        {
            this.OpenConnection();

            string sql = @"SELECT Inmuebles.*, Localidades.Nombre AS NombreLocalidad, Provincias.Nombre AS NombreProvincia, 
                                           Operaciones.Operacion AS Operacion, Estados.Estado AS Estado, TiposDeInmuebles.Tipo AS TipoDeInmueble
                                           FROM Inmuebles INNER JOIN 
                                           Localidades ON Inmuebles.idLocalidad = Localidades.IdLocalidad INNER JOIN 
                                           Provincias ON Localidades.IdProvincia = Provincias.IdProvincia INNER JOIN 
                                            
                                           Operaciones ON Inmuebles.IdOperacion = Operaciones.IdOperacion INNER JOIN
                                           TiposDeInmuebles ON Inmuebles.IdTipoDeInmueble = TiposDeInmuebles.IdTipoDeInmueble INNER JOIN
                                           Estados ON Inmuebles.IdEstado = Estados.IdEstado and Estados.Estado = 'Activo' where Favoritos = 'True'";

            try
            {

                return this.ExecuteTable(@"SELECT Inmuebles.*, Localidades.Nombre AS NombreLocalidad, Provincias.Nombre AS NombreProvincia, 
                                           Operaciones.Operacion AS Operacion, Estados.Estado AS Estado, TiposDeInmuebles.Tipo AS TipoDeInmueble
                                           FROM Inmuebles INNER JOIN 
                                           Localidades ON Inmuebles.idLocalidad = Localidades.IdLocalidad INNER JOIN 
                                           Provincias ON Localidades.IdProvincia = Provincias.IdProvincia INNER JOIN 
                                            
                                           Operaciones ON Inmuebles.IdOperacion = Operaciones.IdOperacion INNER JOIN
                                           TiposDeInmuebles ON Inmuebles.IdTipoDeInmueble = TiposDeInmuebles.IdTipoDeInmueble INNER JOIN
                                           Estados ON Inmuebles.IdEstado = Estados.IdEstado and Estados.Estado = 'Activo' where Favoritos = 'True'", CommandType.Text, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public DataTable SeleccionaTiposDeInmueblesPorPadre(string tipoPadre)
        {
            string sql = "where Mostrar = 'SI' and TipoPadre = '" + tipoPadre + "'";

            this.OpenConnection();

            try
            {
                string g = "SELECT NombreMenu, IdTipoDeInmueble FROM TiposDeInmuebles " + sql;
                return this.ExecuteTable(@"SELECT NombreMenu, IdTipoDeInmueble FROM TiposDeInmuebles " + sql, CommandType.Text, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public DataTable SeleccionaTiposDeInmuebles()
        {


            this.OpenConnection();

            try
            {
                return this.ExecuteTable(@"SELECT TipoPadre, NombreMenu, IdTipoDeInmueble FROM TiposDeInmuebles ", CommandType.Text, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Inmueble objInmueble)
        {
            this.OpenConnection();
            this.BeginTransaction();

            try
            {

                string g = @"INSERT INTO [Inmuebles]                                           
                                           ([Calle]
                                           ,[Numero]
                                           ,[Piso]
                                           ,[Departamento]
                                           ,[Calle1]
                                           ,[Calle2]
                                           ,[idProvincia]
                                           ,[idLocalidad]
                                           ,[AntiguedadA]
                                           ,[Cocheras]
                                           ,[MetroCuadrados]
                                           ,[MetrosCuadradosSemiCub]
                                           ,[Frente]
                                           ,[Fondo]
                                           ,[PrecioVenta]
                                           ,[PrecioAlquiler]
                                           ,[Observaciones]
                                           ,[FechaAlta]
                                           ,[FechaActualiza]      
                                           ,[IdEstado]
                                           ,[IdTipoDeInmueble]
                                           ,[IdOperacion]
                                           ,[Publica]
                                           ,[MonedaAlquiler]
                                           ,[MonedaVenta]
                                           ,[Antiguedad]
                                           ,[Posicion]
                                           ,[IdZona]
                                           ,[Favoritos])
                                     VALUES
                                           (" + "'" + objInmueble.Calle +
                                           "','" + objInmueble.Numero +
                                           "','" + objInmueble.Piso +
                                           "','" + objInmueble.Departamento +
                                           "','" + objInmueble.Calle1 +
                                           "','" + objInmueble.Calle2 +
                                           "'," + objInmueble.IDProvincia +
                                           "," + objInmueble.IDLocalidad +
                                           "," + objInmueble.AntiguedadA +
                                           ",'" + objInmueble.Cocheras +
                                           "'," + objInmueble.MetrosCuadrados.ToString().Replace(",", ".") +
                                           "," + objInmueble.MetrosCuadradosSemiCubiertos.ToString().Replace(",", ".") +
                                           "," + objInmueble.Frente.ToString().Replace(",", ".") +
                                           "," + objInmueble.Fondo.ToString().Replace(",", ".") +
                                           "," + objInmueble.PrecioVenta.ToString().Replace(",", ".") +
                                           "," + objInmueble.PrecioAlquiler.ToString().Replace(",", ".") +
                                           ",'" + objInmueble.Observaciones +
                                           "', GETDATE()" +
                                           ", GETDATE()" +
                                           "," + objInmueble.IDEstado +
                                           "," + objInmueble.IDTipoDeInmueble +
                                           "," + objInmueble.IDOperacion +
                                           ",'" + objInmueble.Publica +
                                           "','" + objInmueble.MonedaAlquiler +
                                           "','" + objInmueble.MonedaVenta +
                                           "','" + objInmueble.Antiguedad +
                                           "','" + objInmueble.Posicion +
                                           "'," + objInmueble.IDZona +
                                           ", 'False'" +
                                           ")";



                this.ExecuteTable(@"INSERT INTO [Inmuebles]                                           
                                           ([Calle]
                                           ,[Numero]
                                           ,[Piso]
                                           ,[Departamento]
                                           ,[Calle1]
                                           ,[Calle2]
                                           ,[idProvincia]
                                           ,[idLocalidad]
                                           ,[AntiguedadA]
                                           ,[Cocheras]
                                           ,[MetroCuadrados]
                                           ,[MetrosCuadradosSemiCub]
                                           ,[Frente]
                                           ,[Fondo]
                                           ,[PrecioVenta]
                                           ,[PrecioAlquiler]
                                           ,[Observaciones]
                                           ,[FechaAlta]
                                           ,[FechaActualiza]      
                                           ,[IdEstado]
                                           ,[IdTipoDeInmueble]
                                           ,[IdOperacion]
                                           ,[Publica]
                                           ,[MonedaAlquiler]
                                           ,[MonedaVenta]
                                           ,[Antiguedad]
                                           ,[Posicion]
                                           ,[IdZona]
                                           ,[Favoritos])
                                     VALUES
                                           (" + "'" + objInmueble.Calle +
                                           "','" + objInmueble.Numero +
                                           "','" + objInmueble.Piso +
                                           "','" + objInmueble.Departamento +
                                           "','" + objInmueble.Calle1 +
                                           "','" + objInmueble.Calle2 +
                                           "'," + objInmueble.IDProvincia +
                                           "," + objInmueble.IDLocalidad +
                                           "," + objInmueble.AntiguedadA +
                                           ",'" + objInmueble.Cocheras +
                                           "'," + objInmueble.MetrosCuadrados.ToString().Replace(",", ".") +
                                           "," + objInmueble.MetrosCuadradosSemiCubiertos.ToString().Replace(",", ".") +
                                           "," + objInmueble.Frente.ToString().Replace(",", ".") +
                                           "," + objInmueble.Fondo.ToString().Replace(",", ".") +
                                           "," + objInmueble.PrecioVenta.ToString().Replace(",", ".") +
                                           "," + objInmueble.PrecioAlquiler.ToString().Replace(",", ".") +
                                           ",'" + objInmueble.Observaciones +
                                           "', GETDATE()" +
                                           ", GETDATE()" + 
                                           "," + objInmueble.IDEstado +
                                           "," + objInmueble.IDTipoDeInmueble +
                                           "," + objInmueble.IDOperacion +
                                           ",'" + objInmueble.Publica +
                                           "','" + objInmueble.MonedaAlquiler +
                                           "','" + objInmueble.MonedaVenta +
                                           "','" + objInmueble.Antiguedad +
                                           "','" + objInmueble.Posicion +
                                           "'," + objInmueble.IDZona + 
                                           ", 'False'"+
                                           ")", CommandType.Text, "");

                this.CommitTransaction();
            }
            catch (Exception ex)
            {
                this.RollbackTransaction();
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public void Update(Inmueble objInmueble)
        {
            this.OpenConnection();
            this.BeginTransaction();
            try
            {
                this.ExecuteTable(@"UPDATE [Inmuebles] set
                                           
                                           [Calle] = '" + objInmueble.Calle +
                                           "',[Numero] = '" + objInmueble.Numero +
                                           "', [Piso] = '" + objInmueble.Piso +
                                           "', [Departamento] = '" + objInmueble.Departamento +
                                           "',[Calle1] = '" + objInmueble.Calle1 +
                                           "', [Calle2] = '" + objInmueble.Calle2 +
                                           "', [idProvincia] = " + objInmueble.IDProvincia +
                                           ", [idLocalidad] = " + objInmueble.IDLocalidad +
                                           ", [AntiguedadA] = " + objInmueble.AntiguedadA +
                                           ", [Cocheras] = '" + objInmueble.Cocheras +
                                           "', [MetroCuadrados] = " + objInmueble.MetrosCuadrados.ToString().Replace(",", ".") +
                                           ", [MetrosCuadradosSemiCub] = " + objInmueble.MetrosCuadradosSemiCubiertos.ToString().Replace(",", ".") +
                                           ", [Frente] = " + objInmueble.Frente.ToString().Replace(",", ".") +
                                           ", [Fondo] = " + objInmueble.Fondo.ToString().Replace(",", ".") +
                                           ", [PrecioVenta] = " + objInmueble.PrecioVenta.ToString().Replace(",", ".") +
                                           ", [PrecioAlquiler] = " + objInmueble.PrecioAlquiler.ToString().Replace(",", ".") +
                                           ", [Observaciones] = '" + objInmueble.Observaciones +
                                           "', [FechaActualiza] = GETDATE()" +

                                           ", [IdEstado] = '" + objInmueble.IDEstado +
                                           "', [IdTipoDeInmueble] = " + objInmueble.IDTipoDeInmueble +
                                           ", [IdOperacion] = " + objInmueble.IDOperacion +
                                           ", [Publica] = '" + objInmueble.Publica +
                                           "', [MonedaAlquiler] = '" + objInmueble.MonedaAlquiler +
                                           "', [MonedaVenta] = '" + objInmueble.MonedaVenta +
                                           "', [Antiguedad] = '" + objInmueble.Antiguedad +
                                           "', [Posicion] = '" + objInmueble.Posicion +
                                           "', [IdZona] = " + objInmueble.IDZona +
                                           "WHERE IdInmueble = " + objInmueble.IDInmueble
                                                    , CommandType.Text, "");

                this.CommitTransaction();
            }
            catch (Exception ex)
            {
                this.RollbackTransaction();
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public void Delete(string IdInmueble)
        {
            this.OpenConnection();
            this.BeginTransaction();

            try
            {
                this.ExecuteTable(@"delete from Inmuebles where IdInmueble =" + IdInmueble, CommandType.Text, "");

                this.CommitTransaction();
            }
            catch (Exception ex)
            {
                this.RollbackTransaction();
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public DataTable SeleccionaCantidadInmueble(int numero)
        {
            this.OpenConnection();
            try
            {
                //return this.ExecuteTable(@"SELECT * FROM Inmuebles WHERE IdUsuario = '" + IdUsuario + "' and IdInmueble = " + IdPropiedad, CommandType.Text, "");
                return this.ExecuteTable(@"SELECT count(*) AS cantidad FROM Inmuebles WHERE IdTipoDeInmueble = " + numero + "and publica = 'SI'" , CommandType.Text, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void UpdateFavoritos(List<Inmueble> lstInmubles)
        {
            this.OpenConnection();
            this.BeginTransaction();
            try
            {
                string idsInmuebles = string.Empty;
                foreach (Inmueble inmu in lstInmubles)
                {
                    idsInmuebles += inmu.IDInmueble.ToString() + ",";
                }
                idsInmuebles = idsInmuebles.Substring(0, idsInmuebles.Length - 1);
                this.ExecuteTable(@"UPDATE [Inmuebles] SET [Favoritos] = 0", CommandType.Text, "");
                this.ExecuteTable(@"UPDATE [Inmuebles] SET [Favoritos] = 1 WHERE IdInmueble IN (" + idsInmuebles + ")"
                                                    , CommandType.Text, "");

                this.CommitTransaction();
            }
            catch (Exception ex)
            {
                this.RollbackTransaction();
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
