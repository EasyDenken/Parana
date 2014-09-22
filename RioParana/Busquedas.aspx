<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Busquedas.aspx.cs" Inherits="RioParana.Busquedas" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<link href="Styles/bordes_esquinas.css" rel="stylesheet" type="text/css" />
<link href="Styles/contacto.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">










 <div id="lado_izder">
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




     
<div style="min-height:850px; padding-top:10px; color:Black;" >
                 
                 
                 
                 
<div align="center">
 
 
        <script type="text/javascript">
            AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '710', 'height', '50', 'src', 'secciones?textoweb= -  Busquedas - ', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'wmode', 'transparent', 'movie', 'secciones?textoweb= -  Busquedas - '); //end AC code
        </script>
        <noscript>
            <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0"
                width="710" height="50">
                <param name="movie" value="secciones.swf?textoweb= -  Busquedas - " />
                <param name="quality" value="high" />
                <param name="wmode" value="transparent" />
                <embed src="secciones.swf?textoweb= -  Busquedas - " width="710" height="50" quality="high"
                    pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"
                    type="application/x-shockwave-flash" wmode="transparent"></embed>
            </object>
        </noscript>
    </div>
    <asp:Panel ID="PanelCollapseExpand" runat="server">
        <table align="center" class="style1" style="width: 100%;">
            <tr>
                <td align="center" bgcolor="#434343">
                    <asp:Label ID="labelExpandedCollapsed" runat="server" Text="Label" ForeColor="White"
                        Font-Bold="True" Font-Size="Medium" Font-Names="Verdana"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="PanelBusqueda" runat="server">
        <table align="center" class="style1" style="width: 100%;">
            <tr>
                <td width="128" style="width: 128px">&nbsp;                </td>
                <td colspan="2">&nbsp;                </td>
                <td>&nbsp;                </td>
                <td width="635">&nbsp;                </td>
            </tr>
            <tr>
                <td style="width: 128px">
                    <div align="right">
                        Tipo de Inmueble:                    </div>                </td>
                <td colspan="4">
                    <asp:DropDownList ID="ddlTipoDeInmueble" runat="server" DataSourceID="OdsTipoDeInmueble"
                        DataTextField="Tipo" DataValueField="IdTipoDeInmueble">                    </asp:DropDownList>                </td>
            </tr>
            <tr>
                <td style="width: 128px">
                    <div align="right">
                        Operación:                    </div>                </td>
                <td colspan="2">
                    <asp:DropDownList ID="ddlOperacion" runat="server" DataSourceID="odsOperacion" DataTextField="Operacion"
                        DataValueField="IdOperacion">                    </asp:DropDownList>                </td>
                <td >&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
              <td><div align="right"> Pais: </div></td>
              <td colspan="2"> <asp:DropDownList ID="ddlPaises" runat="server" Width="200px">                    </asp:DropDownList></td>
              <td style="text-align:right"> Provincia:</td>
              <td><asp:DropDownList ID="ddlProvincias" runat="server" Width="220px"> </asp:DropDownList>              </td>
            </tr>
            <tr>
              <td><div align="right"> Localidad: </div></td>
                <td colspan="2"><asp:DropDownList ID="ddlLocalidades" runat="server" Width="200px"> </asp:DropDownList></td>
                <td align="right"> Zona: </td>
                <td><asp:DropDownList ID="ddlZonas" runat="server" Width="200px"> </asp:DropDownList></td>
            </tr>
            <cc1:CascadingDropDown ID="CascadingDropDown1" runat="server" TargetControlID="ddlPaises"
                Category="Pais" ServicePath="cascading.asmx" ServiceMethod="GetPaisesBusqueda" />
            <cc1:CascadingDropDown ID="CascadingDropDown2" runat="server" TargetControlID="ddlProvincias"
                ParentControlID="ddlPaises" ServiceMethod="GetProvinciasBusqueda" ServicePath="cascading.asmx"
                Category="Provincia" />
            <cc1:CascadingDropDown ID="CascadingDropDown3" runat="server" TargetControlID="ddlLocalidades"
                ParentControlID="ddlProvincias" ServiceMethod="GetLocalidadesBusqueda" ServicePath="cascading.asmx"
                Category="Localidad" />
            <cc1:CascadingDropDown ID="CascadingDropDown4" runat="server" TargetControlID="ddlZonas"
                ParentControlID="ddlLocalidades" ServiceMethod="GetZonas" ServicePath="cascading.asmx"
                Category="Zona" />
            <tr>
                <td align="right">&nbsp;</td>
                <td width="64" align="left"><asp:Button ID="btnBuscar" runat="server" OnClick="Button1_Click" Text="Buscar" Width="125px" /></td>
                <td colspan="3">
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                        <ProgressTemplate>
                            &nbsp;<span style="font-size: 14px; vertical-align: middle;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                Actualizando...&nbsp;&nbsp; </span>&nbsp;<img src="images/25-1.gif" align="middle" />                        </ProgressTemplate>
                    </asp:UpdateProgress>                </td>
            </tr>
        </table>
    </asp:Panel>
    <cc1:CollapsiblePanelExtender ID="CollapsiblePanelExtenderBusqueda" runat="server"
        TargetControlID="PanelBusqueda" CollapsedSize="0" ExpandedSize="170" ExpandControlID="PanelCollapseExpand"
        CollapseControlID="PanelCollapseExpand" ExpandedText="▲▲     Ocultar elementos de busqueda     ▲▲"
        CollapsedText="▼▼     Mostrar elementos de busqueda (Click para mostrar)    ▼▼ " TextLabelID="labelExpandedCollapsed">
    </cc1:CollapsiblePanelExtender>
    <table align="center" class="style1" style="width: 100%;">
        <tr>
            <td colspan="7">
                <asp:DataGrid ID="DataGrid1" runat="server" CellPadding="2" AllowPaging="True" AutoGenerateColumns="False"
                    Width="100%" PageSize="4" ForeColor="#333333" Height="132px" AllowSorting="True"
                    OnPageIndexChanged="DataGrid1_PageIndexChanged" BackColor="#4382AB" BorderColor="#CCCCCC"
                    BorderWidth="1px" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                    Font-Strikeout="False" Font-Underline="False" GridLines="Horizontal">
                    <EditItemStyle BackColor="#999999" />
                    <SelectedItemStyle Font-Bold="True" ForeColor="#333333" BackColor="#E2DED6" BorderColor="White"
                        BorderWidth="0px"></SelectedItemStyle>
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775"></AlternatingItemStyle>
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333"></ItemStyle>
                    <HeaderStyle Font-Bold="True" ForeColor="Black" BackColor="#D7D7D7" Font-Italic="False"
                        Font-Overline="False" Font-Size="13px" Font-Strikeout="False" Font-Underline="False">
                    </HeaderStyle>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>
                    <Columns>
                        <asp:TemplateColumn>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                Font-Strikeout="False" Font-Underline="False" ForeColor="Black"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="False" Font-Italic="False"
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></ItemStyle>
                            <HeaderTemplate>
                                <strong>Foto</strong>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:ImageButton ImageUrl='<%# URLImagen((string)Eval("IdInmueble").ToString()) %>'
                                    runat="server" ID="Image1" BorderWidth="0px" ImageAlign="Middle" OnCommand="CargarFicha"
                                    CommandArgument='<%#Eval("IdInmueble")%>' />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                Font-Strikeout="False" Font-Underline="False" ForeColor="Black"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Justify" VerticalAlign="Top"></ItemStyle>
                            <HeaderTemplate>
                                <strong>Propiedades</strong>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <b>Tipo de Inmueble: </b>
                                <%# Eval("TipoDeInmueble")%>
                                <br>
                                <b>Dirección: </b><b><font color="blue">
                                    <%# Eval("Calle")%>
                                    <%# Eval("Numero")%>
                                    <%# piso((string)Eval("Piso"))%>
                                    <%# Eval("Departamento")%>
                                </font></b>- entre
                                <%# Eval("Calle1")%>
                                y
                                <%# Eval("Calle2")%>
                                <br>
                                <b>Operación: </b>
                                <%# Eval("Operacion")%>
                                <br>
                                <b>Precio de Venta: </b>
                                <%# Moneda((string)Eval("MonedaVenta"))%>
                                <b><font color="red">
                                    <%# precio((string)Eval("PrecioVenta").ToString())%>
                                </font></b>
                                <br>
                                <b>Precio de Alquiler: </b>
                                <%# Moneda((string)Eval("MonedaAlquiler"))%>
                                <b><font color="red">
                                    <%# precio((string)Eval("PrecioAlquiler").ToString())%>
                                </font></b>
                                <br>
                                <b>Localidad: </b>
                                <%# Eval("NombreLocalidad")%>
                                /
                                <%# Eval("NombreProvincia")%>
                                <!--
                                <br />                                
                                <asp:LinkButton runat="server" Text="Ficha" CommandName="Edit" ForeColor="Blue" ID="Linkbutton1"
                                    OnCommand="CargarFicha" CommandArgument='<%#Eval("IdInmueble")%>' />
                                    -->
                            </ItemTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                    <PagerStyle HorizontalAlign="Center" ForeColor="#2C2C2C" BackColor="#4382AB" Mode="NumericPages"
                        Position="TopAndBottom" Font-Bold="True" Font-Italic="False" Font-Overline="False"
                        Font-Size="16px" Font-Strikeout="False" Font-Underline="False"></PagerStyle>
                </asp:DataGrid>
            </td>
        </tr>
    </table>
    <asp:ObjectDataSource ID="odsOperacion" runat="server" SelectMethod="SeleccionarOperacionDeInmuebles"
        TypeName="RioParanaBLL.OperacionesBLL"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="OdsTipoDeInmueble" runat="server" SelectMethod="SeleccionarTiposInmuebles"
        TypeName="RioParanaBLL.TiposBLL"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsLocalidades" runat="server" SelectMethod="SelectLocalidades"
        TypeName="RioParanaBLL.LocalidadesBLL">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlProvincias" DefaultValue="0" Name="idProvincia"
                PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsProvincias" runat="server" SelectMethod="SelectProvincias"
        TypeName="RioParanaBLL.ProvinciasBLL"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsZonas" runat="server" SelectMethod="SelectLocalidadesPorProvincia"
        TypeName="RioParanaBLL.ZonasBLL">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlLocalidades" DefaultValue="0" Name="IdLocalidad"
                PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
                 
                 
                 
                 
                 
                 
                 
                 
                 
                 
                 
                 
                 
                 
                 
                 
                 
      

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
























  




</asp:Content>
