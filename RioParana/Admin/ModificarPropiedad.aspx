<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeBehind="ModificarPropiedad.aspx.cs" Inherits="RioParana.Admin.ModificarPropiedad" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="HTMLEditor" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center" style="margin-top: 25px">
        <script type="text/javascript">
            AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '710', 'height', '50', 'src', 'secciones?textoweb= -  Modificar Propiedad - ', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'wmode', 'transparent', 'movie', 'secciones?textoweb= -  Modificar Propiedad - '); //end AC code
        </script>
        <noscript>
            <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0"
                width="710" height="50">
                <param name="movie" value="secciones.swf?textoweb= -  Modificar Propiedad - " />
                <param name="quality" value="high" />
                <param name="wmode" value="transparent" />
                <embed src="secciones.swf?textoweb= -  Modificar Propiedad - " width="710" height="50"
                    quality="high" pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"
                    type="application/x-shockwave-flash" wmode="transparent"></embed>
            </object>
        </noscript>
    </div>
    <script language="JavaScript">
        function pantallacompleta(pagina) {
            var opciones = ("toolbar=no,location=no, directories=no, status=no, menubar=no ,scrollbars=no, resizable=no, fullscreen=yes");
            window.open(pagina, "", opciones);
        }
    </script>
    <div id="content33">
        <div class="post">
            <p class="byline">
                <script type="text/javascript">
                    AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '709', 'height', '23', 'src', 'texto?textoweb=..:: Tipo de Propiedad ::..', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'wmode', 'transparent', 'movie', 'texto?textoweb=..:: Tipo de Propiedad ::..'); //end AC code
                </script>
                <noscript>
                    <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0"
                        width="709" height="23">
                        <param name="movie" value="texto.swf?textoweb=..:: Tipo de Propiedad ::.." />
                        <param name="quality" value="high" />
                        <param name="wmode" value="transparent" />
                        <embed src="texto.swf?textoweb=..:: Tipo de Propiedad ::.." width="709" height="23"
                            quality="high" pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"
                            type="application/x-shockwave-flash" wmode="transparent"></embed>
                    </object>
                </noscript>
            </p>
            <div class="entry">
                <table align="center">
                    <tr>
                        <td>
                            <div align="right">
                                Tipo de Inmueble:
                            </div>
                        </td>
                        <td>
                            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel7">
                                <ProgressTemplate>
                                    <img src="../Css/ajax-loader.gif" />
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel7" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlTipoDeInmueble" runat="server" DataSourceID="OdsTipoDeInmueble"
                                        DataTextField="Tipo" DataValueField="IdTipoDeInmueble" OnSelectedIndexChanged="ddlTipoDeInmueble_SelectedIndexChanged"
                                        AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvTipoInmueble" runat="server" ControlToValidate="ddlTipoDeInmueble"
                                        InitialValue="0" ErrorMessage="Ingrese un tipo de Inmueble" SetFocusOnError="True"
                                        Font-Underline="False" Style=""></asp:RequiredFieldValidator>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlTipoDeInmueble" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 8px">
                            <div align="right">
                                Estado:
                            </div>
                        </td>
                        <td style="height: 8px">
                            &nbsp;
                        </td>
                        <td style="height: 8px">
                            <asp:DropDownList ID="ddlEstado" runat="server" DataSourceID="odsEstado" DataTextField="Estado"
                                DataValueField="IdEstado">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvEstado" runat="server" ControlToValidate="ddlEstado"
                                ErrorMessage="Ingrese un estado de Inmueble" InitialValue="0" SetFocusOnError="True"
                                Font-Underline="False" Style=""></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Operación:
                            </div>
                        </td>
                        <td>
                            <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                                <ProgressTemplate>
                                    <img src="../Css/ajax-loader.gif" />
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlOperacion" runat="server" DataSourceID="odsOperacion" DataTextField="Operacion"
                                        DataValueField="IdOperacion" AutoPostBack="True" OnSelectedIndexChanged="ddlOperacion_SelectedIndexChanged"
                                        Font-Underline="False">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvOperacion" runat="server" ControlToValidate="ddlOperacion"
                                        ErrorMessage="Ingrese una Operacion de Inmueble" InitialValue="0" SetFocusOnError="True"
                                        Font-Underline="False" Style=""></asp:RequiredFieldValidator>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlOperacion" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 7px">
                            <div align="right">
                                Visible:
                            </div>
                        </td>
                        <td style="height: 7px">
                            &nbsp;
                        </td>
                        <td style="height: 7px">
                            <asp:RadioButtonList ID="rblVisible" runat="server" RepeatDirection="Horizontal"
                                Font-Underline="False">
                                <asp:ListItem Selected="True">Si</asp:ListItem>
                                <asp:ListItem>No</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="post">
            <div class="byline">
                <script type="text/javascript">
                    AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '709', 'height', '23', 'src', 'texto?textoweb=..:: Ubicación de Propiedad ::..', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'wmode', 'transparent', 'movie', 'texto?textoweb=..:: Ubicación de Propiedad ::..'); //end AC code
                </script>
                <noscript>
                    <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0"
                        width="709" height="23">
                        <param name="movie" value="texto.swf?textoweb=..:: Ubicación de Propiedad ::.." />
                        <param name="quality" value="high" />
                        <param name="wmode" value="transparent" />
                        <embed src="texto.swf?textoweb=..:: Ubicación de Propiedad ::.." width="709" height="23"
                            quality="high" pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"
                            type="application/x-shockwave-flash" wmode="transparent"></embed>
                    </object>
                </noscript>

                &nbsp;</div>
            <div class="entry">
                <table align="center" style="height: 82px; width: 486px;">
                    <tr>
                        <td>
                            <div align="right">
                                Calle:
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:TextBox ID="txtCalle" runat="server" Width="222px" MaxLength="99"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCalle"
                                ErrorMessage="Ingrese una Calle" SetFocusOnError="True" Font-Underline="False"
                                Style=""></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Numero:
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:TextBox ID="txtNumero" runat="server" Width="222px" MaxLength="40"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNumero"
                                ErrorMessage="Ingrese la Altura" SetFocusOnError="True" Font-Underline="False"
                                Style=""></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Piso:
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox ID="txtPiso" onkeypress="return isNumberKey(event)" runat="server" Width="222px"
                                        Enabled="False" MaxLength="49"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPiso" runat="server" ControlToValidate="txtPiso"
                                        Enabled="False" ErrorMessage="Ingrese el Piso" Font-Underline="False" SetFocusOnError="True"
                                        Style=""></asp:RequiredFieldValidator>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlTipoDeInmueble" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Departamento:
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox ID="txtDepartamento" runat="server" Width="222px" Enabled="False" MaxLength="49"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvDepartamento" runat="server" ControlToValidate="txtDepartamento"
                                        Enabled="False" ErrorMessage="Ingrese el Departamento" Font-Underline="False"
                                        SetFocusOnError="True" Style=""></asp:RequiredFieldValidator>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlTipoDeInmueble" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Entre Calle:
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:TextBox ID="txtCalle1" runat="server" Width="222px" MaxLength="99"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCalle1"
                                ErrorMessage="Ingrese una Calle" SetFocusOnError="True" Font-Underline="False"
                                Style=""></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 26px">
                            <div align="right">
                                Y Calle:
                            </div>
                        </td>
                        <td style="height: 26px">
                            &nbsp;
                        </td>
                        <td style="height: 26px">
                            <asp:TextBox ID="txtCalle2" runat="server" Width="222px" MaxLength="99"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvCalle2" runat="server" ControlToValidate="txtCalle2"
                                ErrorMessage="Ingrese una Calle" SetFocusOnError="True" Font-Underline="False"
                                Style=""></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Provincia:
                            </div>
                        </td>
                        <td>
                            <asp:UpdateProgress ID="UpdateProgress3" runat="server" AssociatedUpdatePanelID="UpdatePanel8">
                                <ProgressTemplate>
                                    <img src="../Css/ajax-loader.gif" />
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                        <td style="text-align: left">
                            <asp:UpdatePanel ID="UpdatePanel8" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlProvincias" runat="server" AutoPostBack="True" DataSourceID="odsProvincias"
                                        DataTextField="Nombre" DataValueField="idProvincia" Width="220px" OnDataBound="ddlProvincias_DataBound">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvProvincias" runat="server" ControlToValidate="ddlProvincias"
                                        ErrorMessage="Ingrese una Provincia" InitialValue="0" SetFocusOnError="True"
                                        Font-Underline="False" Style=""></asp:RequiredFieldValidator>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlProvincias" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 5px">
                            <div align="right">
                                Localidad:
                            </div>
                        </td>
                        <td style="height: 5px">
                            <asp:UpdateProgress ID="UpdateProgress5" runat="server" AssociatedUpdatePanelID="UpdatePanel2">
                                <ProgressTemplate>
                                    <img src="../Css/ajax-loader.gif" />
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                        <td style="height: 5px">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlLocalidades" runat="server" AutoPostBack="True" DataSourceID="odsLocalidades"
                                        DataTextField="Nombre" DataValueField="idLocalidad" Width="220px" OnSelectedIndexChanged="ddlLocalidades_SelectedIndexChanged"
                                        OnDataBound="ddlLocalidades_DataBound">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvLocalidades" runat="server" ControlToValidate="ddlLocalidades"
                                        ErrorMessage="Ingrese una Localidad" InitialValue="0" SetFocusOnError="True"
                                        Font-Underline="False" Style=""></asp:RequiredFieldValidator>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlProvincias" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 5px">
                            <div align="right">
                                Zona:
                            </div>
                        </td>
                        <td style="height: 5px">
                            &nbsp;
                        </td>
                        <td style="height: 5px">
                            <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlZonas" runat="server" DataSourceID="odsZonas" DataTextField="Nombre"
                                        DataValueField="IdZona" Width="220px" OnDataBound="ddlZonas_DataBound">
                                    </asp:DropDownList>
                                    &nbsp;<a class="Estilo1" href="javascript:pantallacompleta('../images/defaultcss/full.html')">
                                        Ver</a> &nbsp;
                                    <asp:RequiredFieldValidator ID="rfvZonas" runat="server" ControlToValidate="ddlZonas"
                                        ErrorMessage="Ingrese una Zona" Font-Underline="False" InitialValue="0" SetFocusOnError="True"
                                        Style=""></asp:RequiredFieldValidator>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="post">
            <p class="byline">
                <span id=":69" style="padding-right: 10px;">
                    <script type="text/javascript">
                        AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '709', 'height', '23', 'src', 'texto?textoweb=..:: Descripción ::..', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'wmode', 'transparent', 'movie', 'texto?textoweb=..:: Descripción ::..'); //end AC code
                    </script>
                    <noscript>
                        <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0"
                            width="709" height="23">
                            <param name="movie" value="texto.swf?textoweb=..:: Descripción ::.." />
                            <param name="quality" value="high" />
                            <param name="wmode" value="transparent" />
                            <embed src="texto.swf?textoweb=..:: Descripción ::.." width="709" height="23" quality="high"
                                pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"
                                type="application/x-shockwave-flash" wmode="transparent"></embed>
                        </object>
                    </noscript>
                </span>
            </p>
            <div class="entry">
                <table align="center" style="height: 66px">
                    <tr>
                        <td style="height: 14px">
                            <div align="right">
                                Antigüedad:
                            </div>
                        </td>
                        <td style="height: 14px">
                            <asp:UpdateProgress ID="UpdateProgress4" runat="server" AssociatedUpdatePanelID="UpdatePanel9">
                                <ProgressTemplate>
                                    <img src="../Css/ajax-loader.gif" />
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                        <td style="height: 14px">
                            <asp:UpdatePanel ID="UpdatePanel9" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:RadioButtonList ID="rblAntiguedad" runat="server" RepeatDirection="Horizontal"
                                        AutoPostBack="True" OnSelectedIndexChanged="rblAntiguedad_SelectedIndexChanged">
                                        <asp:ListItem Value="Usado">Usado</asp:ListItem>
                                        <asp:ListItem Value="A Estrenar">A Estrenar</asp:ListItem>
                                        <asp:ListItem Value="En Construcción">En Construcción</asp:ListItem>
                                    </asp:RadioButtonList>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="rblAntiguedad" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                        <td style="height: 14px">
                            <asp:RequiredFieldValidator ID="rfvAntiguedad" runat="server" ControlToValidate="rblAntiguedad"
                                ErrorMessage="Ingrese la Antigüedad" Font-Underline="False" SetFocusOnError="True"
                                Style=""></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Años de Antigüedad:
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td colspan="2">
                            <asp:UpdatePanel ID="UpdatePanel10" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox ID="txtAntiguedad" onKeypress="return isNumberKey(event)" runat="server"
                                        Width="222px" Enabled="False" MaxLength="4"></asp:TextBox>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="rblAntiguedad" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Metros Cuadrados Cubiertos:
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="txtMetrosCuadrados" onKeypress="return isNumberKeyComa(event)" runat="server"
                                Width="222px" MaxLength="10"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMetrosCuadrados"
                                ErrorMessage="Ingrese un valor" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Metros Cuadrados Semicubiertos:
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="txtMetrosCuadradosSemi" onKeypress="return isNumberKeyComa(event)"
                                runat="server" Width="222px" MaxLength="10"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Frente:
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td colspan="2">
                            <asp:UpdatePanel ID="UpdatePanel12" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox ID="txtFrente" runat="server" Enabled="False" MaxLength="10" onKeypress="return isNumberKeyComa(event)"
                                        Width="222px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvFrente" runat="server" ControlToValidate="txtFrente"
                                        ErrorMessage="Ingrese un valor" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlTipoDeInmueble" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Fondo:
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td colspan="2">
                            <asp:UpdatePanel ID="UpdatePanel13" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox ID="txtFondo" runat="server" Enabled="False" MaxLength="10" onKeypress="return isNumberKeyComa(event)"
                                        Width="222px">
                                    </asp:TextBox>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlTipoDeInmueble" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 24px">
                            <div align="right">
                                Posición:
                            </div>
                        </td>
                        <td style="height: 24px">
                            &nbsp;
                        </td>
                        <td style="height: 24px" colspan="2">
                            <asp:RadioButtonList ID="rblPosicion" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem Value="Al Frente">Al Frente</asp:ListItem>
                                <asp:ListItem Value="Contrafrente">Contrafrente</asp:ListItem>
                                <asp:ListItem Value="Ambos">Ambos</asp:ListItem>
                                <asp:ListItem>Esquina</asp:ListItem>
                                <asp:ListItem>Sin Posición</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Cochera:
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:RadioButtonList ID="rblCocheras" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>Si</asp:ListItem>
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Pasante</asp:ListItem>
                                <asp:ListItem>Posibilidad</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="rfvCochera" runat="server" ControlToValidate="rblCocheras"
                                ErrorMessage="Ingrese si posee Cochera" Font-Underline="False" Style="" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="post">
            <p class="byline">
                <span id="Span1" style="padding-right: 10px;">
                    <script type="text/javascript">
                        AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '709', 'height', '23', 'src', 'texto?textoweb=..:: Precio ::..', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'wmode', 'transparent', 'movie', 'texto?textoweb=..:: Precio ::..'); //end AC code
                    </script>
                    <noscript>
                        <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0"
                            width="709" height="23">
                            <param name="movie" value="texto.swf?textoweb=..:: Precio ::.." />
                            <param name="quality" value="high" />
                            <param name="wmode" value="transparent" />
                            <embed src="texto.swf?textoweb=..:: Precio ::.." width="709" height="23" quality="high"
                                pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"
                                type="application/x-shockwave-flash" wmode="transparent"></embed>
                        </object>
                    </noscript>
                </span>
            </p>
            <div class="entry">
                <table align="center">
                    <tr>
                        <td>
                            <div align="right">
                                Precio de Venta:
                            </div>
                        </td>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlMonedaVenta" runat="server" Enabled="False">
                                        <asp:ListItem Value="P">Pesos</asp:ListItem>
                                        <asp:ListItem Value="D" Selected="True">Dólares</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:TextBox ID="txtPrecioDeVenta" onKeypress="return isNumberKey(event)" runat="server"
                                        Width="152px" Enabled="False" MaxLength="10"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPrecioDeVenta" runat="server" ControlToValidate="txtPrecioDeVenta"
                                        ErrorMessage="Ingrese un Precio" SetFocusOnError="True" Enabled="False" Font-Underline="False"
                                        Style=""></asp:RequiredFieldValidator>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlOperacion" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div align="right">
                                Precio de Alquiler:
                            </div>
                        </td>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlMonedaAlquiler" runat="server" Enabled="False">
                                        <asp:ListItem Value="P" Selected="True">Pesos</asp:ListItem>
                                        <asp:ListItem Value="D">Dólares</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:TextBox ID="txtPrecioDeAlquiler" onKeypress="return isNumberKey(event)" runat="server"
                                        Width="152px" AutoPostBack="True" Enabled="False" MaxLength="10"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPrecioDeAlquiler" runat="server" ControlToValidate="txtPrecioDeAlquiler"
                                        ErrorMessage="Ingrese un Precio" SetFocusOnError="True" Enabled="False" Font-Underline="False"
                                        Style=""></asp:RequiredFieldValidator>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlOperacion" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="post">
            <div class="byline">
                <script type="text/javascript">
                    AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '709', 'height', '23', 'src', 'texto?textoweb=..:: Observaciones ::..', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'wmode', 'transparent', 'movie', 'texto?textoweb=..:: Observaciones ::..'); //end AC code
                </script>
                <noscript>
                    <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0"
                        width="709" height="23">
                        <param name="movie" value="texto.swf?textoweb=..:: Observaciones ::.." />
                        <param name="quality" value="high" />
                        <param name="wmode" value="transparent" />
                        <embed src="texto.swf?textoweb=..:: Observaciones ::.." width="709" height="23" quality="high"
                            pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"
                            type="application/x-shockwave-flash" wmode="transparent"></embed>
                    </object>
                </noscript>
            </div>
            <div style="height: 390px">
                <table align="center" cellpadding="0" cellspacing="0" style="width: 390px">
                    <tr>
                        <td align="center">
                            <span id="Span4">
                                <HTMLEditor:Editor ID="txtObservaciones" runat="server" Height="300px" Width="100%"
                                    AutoFocus="False" EnableTheming="True" />
                            </span>&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <div id="Span1">
                                <asp:Label ID="lblError" runat="server" CssClass="ErrorText" Font-Underline="False"
                                    Style=""></asp:Label>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <table style="width: 100%">
                                <tr>
                                    <td>
                                        <span id="Span5"><span id="Span6">
                                            <asp:Button ID="btnAceptar0" runat="server" Text="Finalizar" Width="120px" OnClick="btnAceptar0_Click"
                                                Font-Underline="False" />
                                        </span></span>
                                    </td>
                                    <td>
                                        <div id="Div1">
                                            <asp:Button ID="btnAceptar" runat="server" Text="Siguiente" Width="120px" OnClick="btnAceptar_Click1"
                                                Font-Underline="False" />
                                        </div>
                                    </td>
                                    <td>
                                        <span id="Span9"><span id="Span10">
                                            <asp:Button ID="btnFinalizar" runat="server" CausesValidation="False" Text="Cancelar"
                                                Width="120px" OnClick="btnCancelar_Click" />
                                        </span></span>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="post">
            <asp:ObjectDataSource ID="odsOperacion" runat="server" SelectMethod="SeleccionarOperacionDeInmuebles"
                TypeName="RioParanaBLL.OperacionesBLL"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="odsEstado" runat="server" SelectMethod="SeleccionarEstadosDeInmuebles"
                TypeName="RioParanaBLL.EstadosBLL"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="odsProvincias" runat="server" SelectMethod="SelectProvincias"
                TypeName="RioParanaBLL.ProvinciasBLL"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="OdsTipoDeInmueble" runat="server" SelectMethod="SeleccionarTiposInmuebles"
                TypeName="RioParanaBLL.TiposBLL"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="odsLocalidades" runat="server" SelectMethod="SelectLocalidades"
                TypeName="RioParanaBLL.LocalidadesBLL">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlProvincias" DefaultValue="0" Name="idProvincia"
                        PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="odsZonas" runat="server" SelectMethod="SelectLocalidadesPorProvincia"
                TypeName="RioParanaBLL.ZonasBLL">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlLocalidades" DefaultValue="0" Name="IdLocalidad"
                        PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </div>
</asp:Content>
