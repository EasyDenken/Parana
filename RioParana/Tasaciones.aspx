<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Tasaciones.aspx.cs"
    Inherits="RioParana.Tasaciones" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link href="Styles/bordes_esquinas.css" rel="stylesheet" type="text/css" />
    <link href="Styles/contacto.css" rel="stylesheet" type="text/css" />
    <!-- The JavaScript -->
    <script type="text/javascript" src="../Scripts/jquery.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.scrollablecombo.js"></script>
    <script type="text/javascript">
        $(function () {
            $('#operaciones').scrollablecombo();
            $('#propiedades').scrollablecombo();
        });
    </script>
    <!-- The JavaScript -->
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="contenido_menu_resultados">
        <asp:ObjectDataSource ID="odsCasas" runat="server" SelectMethod="FetchCasas" TypeName="RioParana.ListaPropiedades" />
        <asp:ObjectDataSource ID="odsDepartamentos" runat="server" SelectMethod="FetchDepartamentos"
            TypeName="RioParana.ListaPropiedades" />
        <asp:ObjectDataSource ID="odsOtrosInmuebles" runat="server" SelectMethod="FetchOtrosInmuebles"
            TypeName="RioParana.ListaPropiedades" />
        <div id="lado_izquierdo">
            <div id="top" class="top_divfondo">
                <div class="esquina_sup_izq">
                    <img src="img_divfondo/top_left.png" alt="Esquina superior izquierda" /></div>
                <div class="esquina_sup_med">
                </div>
                <div class="esquina_sup_der">
                    <img src="img_divfondo/top_right.png" alt="Esquina superior derecha" /></div>
            </div>
            <div id="content_imagenes" class="content_imagenes">
                <div id="boxcontrol" class="boxcontrol_menu">
                    <div style="min-height: 300px; padding-top: 10px; color: Black;">
                        <b><font size="3">En este momento comienza nuestro trabajo:</font></b><br />
                        <br />
                        <br />
                        Buscamos entre todos los inmuebles ofrecidos en el mercado, hasta hallar aquellos
                        que respondan a tus necesidades. Coordinamos las visitas, te asesoramos, negociamos,
                        y te acompañamos hasta que la operación concluya.<br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        &nbsp;<br />
                    </div>
                </div>
            </div>
            <div id="bottom" class="bottom_divfondo ">
                <div class="esquina_inf_izq">
                    <img src="img_divfondo/btm_left.png" alt="Esquina inferior izquierda" /></div>
                <div class="esquina_inf_med">
                </div>
                <div class="esquina_inf_der">
                    <img src="img_divfondo/btm_right.png" alt="Esquina inferior derecha" />
                </div>
            </div>
        </div>
        <div id="lado_derecho">
            <div id="Div12" class="top_divfondo">
                <div class="esquina_sup_izq">
                    <img src="img_divfondo/top_left.png" alt="Esquina superior izquierda" />
                </div>
                <div class="esquina_sup_med">
                </div>
                <div class="esquina_sup_der">
                    <img src="img_divfondo/top_right.png" alt="Esquina superior derecha" />
                </div>
            </div>
            <div id="Div22" class="content_imagenes">
                <div id="Div32" class="boxcontrol_resultados">
                    <div class="contacto">
                        <h1>
                            Tasaciones</h1>
                        <form action="" method="post" enctype="multipart/form-data" name="contacto" id="contacto">
                        <input name="funcion" type="hidden" id="funcion" value="contacto" />
                        <p>
                            “Ofrecemos una tasación rápida y adecuada teniendo en cuenta zona, superficie, distribución
                            de ambientes, características generales, estado de la propiedad entre otros&quot;.
                            Completá con tus datos y en breve nos comunicaremos.
                        </p>
                        <p>
                            Datos Personales:</p>
                        <label class="cmn_label">
                            Nombre y apellido
                            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                        </label>
                        <label class="cmn_label">
                            Empresa <span class="verdana9negro">(opcional) </span>
                            <asp:TextBox ID="txtEmpresa" runat="server"></asp:TextBox>
                        </label>
                        <label class="cmn_label">
                            E-mail
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rvEmail" ControlToValidate="txtEMail" Display="Dynamic"
                                runat="server" Text="*"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="valRegExpEmail" runat="server" ControlToValidate="txtEMail"
                                Display="Dynamic" ErrorMessage="Ingrese un mail valido" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"></asp:RegularExpressionValidator>
                        </label>
                        <label class="cmn_label">
                            Tel&eacute;fono
                            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                        </label>
                        <label class="cmn_label">
                            Ciudad / Provincia
                            <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
                        </label>
                        <label class="cmn_label">
                            Pa&iacute;s
                            <asp:TextBox ID="txtPais" runat="server" Text="Argentina"></asp:TextBox>
                        </label>
                        <label class="cmn_label">
                            Tipo de Propiedad: <span class="box">
                                <asp:DropDownList ID="ddlTipoPropiedad" runat="server">
                                    <asp:ListItem>Departamentos</asp:ListItem>
                                    <asp:ListItem>Casas</asp:ListItem>
                                    <asp:ListItem>Terrenos</asp:ListItem>
                                    <asp:ListItem>Otros</asp:ListItem>
                                </asp:DropDownList>
                            </span>
                        </label>
                        <label class="cmn_label">
                            Tipo de Operacion: <span class="box">
                                <asp:DropDownList ID="ddlTipoOperacion" runat="server">
                                    <asp:ListItem>Venta</asp:ListItem>
                                    <asp:ListItem>Alquiler</asp:ListItem>
                                    <asp:ListItem>Venta y/o alquiler</asp:ListItem>
                                    <asp:ListItem>Otra</asp:ListItem>
                                </asp:DropDownList>
                            </span>
                        </label>
                        <label class="cmn_label" style="width: 91%; margin-top: 20px;">
                            Consulta
                            <asp:TextBox ID="txtConsulta" runat="server" TextMode="MultiLine" Height="110px"
                                Width="617px"></asp:TextBox>
                        </label>
                        <div class="sep_gral">
                        </div>
                        <label class="button_label">
                            <asp:Button ID="btnContacto" runat="server" class="form_button" 
                            Text="SOLICITAR TASACION" onclick="btnContacto_Click" />
                        </label>
                        <div id="update_container">
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                        </div>
                        <div class="sep_gral">
                        </div>
                        </form>
                        <div class="sep_gral">
                        </div>
                    </div>
                </div>
            </div>
            <div id="Div4" class="bottom_divfondo ">
                <div class="esquina_inf_izq">
                    <img src="img_divfondo/btm_left.png" alt="Esquina inferior izquierda" /></div>
                <div class="esquina_inf_med">
                </div>
                <div class="esquina_inf_der">
                    <img src="img_divfondo/btm_right.png" alt="Esquina inferior derecha" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
