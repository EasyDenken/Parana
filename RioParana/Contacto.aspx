<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs"
    Inherits="RioParana.Contacto" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link href="Styles/bordes_esquinas.css" rel="stylesheet" type="text/css" />
    <link href="Styles/contacto.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style2
        {
            font-size: 10pt;
        }
    </style>
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
                        <b><font size="3">Nuestas Oficinas:</font></b><br />
                        San Lorenzo 1998<br />
                        S2000ARZ Rosario<br />
                        <br />
                        <b><font size="3">Tel:</font></b><br />
                        0341 - 4499107
                        <br />
                        <br />
                        <b><font size="3">Staff:</font><br />
                            <span class="style2"><span class="Apple-style-span" style="border-collapse: separate;
                                color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal;
                                font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2;
                                text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal;
                                widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px;
                                -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px;
                                font-size: medium;"><span class="Apple-style-span" style="border-collapse: collapse;
                                    font-family: 'Arial Narrow'; font-size: 13px;">GERENCIA: </span></span>
                                <br />
                            </span></b><span class="style2"><b>Gustavo Puche</b><br />
                                <a href="mailto:gustavopuche@rioparananet.com.ar">gustavopuche@rioparananet.com.ar</a><br />
                                <br />
                                <b><span class="Apple-style-span" style="border-collapse: separate; color: rgb(0, 0, 0);
                                    font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal;
                                    letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto;
                                    text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px;
                                    -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px;
                                    -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px;
                                    font-size: medium;"><span class="Apple-style-span" style="border-collapse: collapse;
                                        font-family: 'Arial Narrow'; font-size: 13px;">CONTADURIA:</span></span><br />
                                    Claudia Chiodi<br />
                                </b><a href="mailto:claudiachiodi@rioparananet.com.ar">claudiachiodi@rioparananet.com.ar</a><br />
                                <br />
                                <span class="Apple-style-span" style="border-collapse: separate; color: rgb(0, 0, 0);
                                    font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal;
                                    letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto;
                                    text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px;
                                    -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px;
                                    -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px;
                                    font-size: medium;"><span class="Apple-style-span" style="border-collapse: collapse;
                                        font-family: 'Arial Narrow'; font-size: 13px;">ARQUITECTURA:</span></span><br />
                                <b>Eduardo Puche</b><br />
                                <a href="mailto:eduardopuche@rioparananet.com.ar">eduardopuche@rioparananet.com.ar</a><br />
                                <br />
                                <span class="Apple-style-span" style="border-collapse: separate; color: rgb(0, 0, 0);
                                    font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal;
                                    letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto;
                                    text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px;
                                    -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px;
                                    -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px;
                                    font-size: medium;"><span class="Apple-style-span" style="border-collapse: collapse;
                                        font-family: 'Arial Narrow'; font-size: 13px;">ADMINISTRACION:</span></span><br />
                                <b>Gabriela Palou</b><br />
                                <a href="mailto:gabrielapalou@rioparananet.com.ar">gabrielapalou@rioparananet.com.ar</a><br />
                                <br />
                                <b>Celeste Chacur</b><br />
                                <a href="mailto:celestechacur@riopanananet.com.ar">celestechacur@riopanananet.com.ar</a><br />
                                <br />
                                <span class="Apple-style-span" style="border-collapse: separate; color: rgb(0, 0, 0);
                                    font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal;
                                    letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto;
                                    text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px;
                                    -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px;
                                    -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px;
                                    font-size: medium;"><span class="Apple-style-span" style="border-collapse: collapse;
                                        font-family: 'Arial Narrow'; font-size: 13px;">VENTAS:</span></span><br />
                                <b>Gladis Ezcurra</b><br />
                                <a href="mailto:gladisezcurra@rioparananet.com.ar">gladisezcurra@rioparananet.com.ar</a><br />
                                <br />
                                <b>Rodolfo Gomez<br />
                                </b><a href="mailto:rodolfogomez@rioparananet.com.ar">rodolfogomez@rioparananet.com.ar</a></span></div>
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
                            Contacto</h1>
                        <form action="enviarmailcontacto.php" method="post" name="contacto" id="contacto">
                        <input name="funcion" type="hidden" id="funcion" value="contacto" />
                        <p>
                            Deje sus datos y nosotros nos comunicaremos a la brevedad, para responder su consulta.</p>
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
                            <asp:TextBox ID="txtPais" runat="server"></asp:TextBox>
                        </label>
                        <label class="cmn_label" style="width: 91%;">
                            Consulta
                            <asp:TextBox ID="txtConsulta" runat="server" TextMode="MultiLine" Height="110px"
                                Width="617px"></asp:TextBox>
                        </label>
                        <div class="sep_gral">
                        </div>
                        <label class="button_label">
                            <asp:Button ID="btnContacto" runat="server" class="form_button" Text="ENVIAR MENSAJE"
                                OnClick="btnContacto_Click" />
                        </label>
                        <div id="update_container">
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <img src="images/fondo_parana_menu_contacto2.png" width="650" height="467" alt="" /></div>
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
