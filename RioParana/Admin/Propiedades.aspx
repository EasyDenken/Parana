<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="Propiedades.aspx.cs" Inherits="RioParana.Admin.Propiedades" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content runat="server" ContentPlaceHolderID="head" ID="idHead">
    <script language="javascript" type="text/javascript">
        function Resaltar_On(GridView) {
            if (GridView != null) {
                GridView.originalBgColor = GridView.style.backgroundColor;
                GridView.style.backgroundColor = "#0000FF";
                GridView.style.color = "#FFFFFF"
                GridView.style.cursor = "hand";
            }
        }

        function Resaltar_Off(GridView) {
            if (GridView != null) {
                GridView.style.backgroundColor = GridView.originalBgColor;
                GridView.style.color = "#000000";
            }
        }
</script>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="idHolder" runat="server">
    <div style="margin-top:40px">
        <div align="center">

        <script type="text/javascript">
            AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '710', 'height', '50', 'src', 'secciones?textoweb= -  Mis Propiedades - ', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'wmode', 'transparent', 'movie', 'secciones?textoweb= -  Mis Propiedades - '); //end AC code
        </script>

        <noscript>
            <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0"
                width="710" height="50">
                <param name="movie" value="secciones.swf?textoweb= -  Mis Propiedades - " />
                <param name="quality" value="high" />
                <param name="wmode" value="transparent" />
                <embed src="secciones.swf?textoweb= -  Mis Propiedades - " width="710" height="50"
                    quality="high" pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"
                    type="application/x-shockwave-flash" wmode="transparent"></embed>
            </object>
        </noscript>
    </div>
    <table cellpadding="0" align="center" cellspacing="0" style="width: 100%; margin-bottom: 0px;">
        <tr>
            <td style="text-align: center" align="center" colspan="2">&nbsp;
                
            </td>
        </tr>
        <tr>
            <td style="text-align: center; height: 28px; width: 633px;" align="center">
                <table style="width: 158%">
                    <tr>
                        <td style="width: 92px">
                            <div align="right">
                                Tipo de Inmueble:
                            </div>
                        </td>
                        <td>
                            <div align="left">
                                <asp:DropDownList ID="ddlTipoDeInmueble" runat="server" DataSourceID="OdsTipoDeInmueble"
                                    DataTextField="Tipo" DataValueField="IdTipoDeInmueble" OnSelectedIndexChanged="ddlTipoDeInmueble_SelectedIndexChanged"
                                    AutoPostBack="True">
                                </asp:DropDownList>
                            </div>
                        </td>
                        <td>&nbsp;
                            
                        </td>
                    </tr>
                </table>
            </td>
            <td style="width: 147px">
                <div align="left">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:RadioButtonList ID="rdOperacion" runat="server" RepeatDirection="Horizontal"
                                Width="217px" AutoPostBack="True" 
                                OnSelectedIndexChanged="ddlTipoDeInmueble_SelectedIndexChanged" CellPadding="0" 
                                CellSpacing="0">
                                <asp:ListItem Value="1" Selected="True">Venta</asp:ListItem>
                                <asp:ListItem Value="2">Alquiler</asp:ListItem>
                            </asp:RadioButtonList>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="rdOperacion" EventName="SelectedIndexChanged" />
                        </Triggers>
                    </asp:UpdatePanel>
                </div>
            </td>
        </tr>
        <tr>
            <td style="width: 633px">
                <table cellpadding="0" cellspacing="0" style="width: 100%">
                    <tr>
                        <td style="width: 47px">
                            <div align="right" style="width: 93px; margin-right: 0px;">
                                Ordenar por:                             </div>
                        </td>
                        <td>
                            <div align="left">
                                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                    <ContentTemplate>
                                        &nbsp;
                                        <asp:DropDownList ID="ddlOrdenar" runat="server" AutoPostBack="True" 
                                            OnSelectedIndexChanged="ddlTipoDeInmueble_SelectedIndexChanged" 
                                            style="margin-left: 0px">
                                            <asp:ListItem Value="FechaActualiza">Fecha de Actualización</asp:ListItem>
                                            <asp:ListItem Value="FechaAlta">Fecha de Alta</asp:ListItem>
                                            <asp:ListItem Value="PrecioVenta">Precio de Venta</asp:ListItem>
                                            <asp:ListItem Value="PrecioAlquiler">Precio de Alquiler</asp:ListItem>
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="text-align: center; width: 147px;" align="center">
            </td>
        </tr>
        <tr>
            <td style="text-align: center; height: 22px;" align="center" colspan="2">&nbsp;
                
            </td>
        </tr>
        <tr>
            <td style="text-align: center" align="Center" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:GridView ID="gvInmuebles" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                            PageSize="30" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="IdInmueble"
                            Height="50px" OnPageIndexChanging="gvInmuebles_PageIndexChanging"
                            Width="100%" AllowSorting="True" onrowdatabound="gvInmuebles_RowDataBound" 
                            OnSelectedIndexChanged="gvInmuebles_SelectedIndexChanged" 
                            Font-Names="Arial" Font-Size="10pt">
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:CommandField ShowSelectButton="True"/>
                                <asp:TemplateField Visible="false">
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                                    <HeaderTemplate>
                                        <strong>IdInmueble</strong>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lb_IdInmueble" runat="server" Text='<%# Eval("IdInmueble") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                                    <HeaderTemplate>
                                        <strong>Calle</strong>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lb_Calle" runat="server" Text='<%# Eval("Calle") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                                    <HeaderTemplate>
                                        <strong>Número</strong>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lb_Numero" runat="server" Text='<%# Eval("Numero") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                                    <HeaderTemplate>
                                        <strong>Precio de Venta</strong>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <%# Moneda((string)Eval("MonedaVenta"))%>
                                        <asp:Label ID="lb_PrecioVenta" runat="server" Text='<%# Eval("PrecioVenta") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                                    <HeaderTemplate>
                                        <strong>Precio de Alquiler</strong>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <%# Moneda((string)Eval("MonedaAlquiler"))%>
                                        <asp:Label ID="lb_PrecioAlquiler" runat="server" Text='<%# Eval("PrecioAlquiler") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                                    <HeaderTemplate>
                                        <strong>Fecha de Alta</strong>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblFechaAlta" runat="server" Text='<%# Eval("FechaAlta") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                                    <HeaderTemplate>
                                        <strong>Fecha de última Actualización</strong>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblFechaActualizada" runat="server" Text='<%# Eval("FechaActualiza") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                                    <HeaderTemplate>
                                        <strong>Favorito</strong>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkFavoritos" runat="server" Checked='<%# Eval("Favoritos") %>'></asp:CheckBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        </asp:GridView>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlTipoDeInmueble" EventName="SelectedIndexChanged" />
                        <asp:AsyncPostBackTrigger ControlID="ddlOrdenar" EventName="SelectedIndexChanged" />
                        <asp:AsyncPostBackTrigger ControlID="rdOperacion" EventName="SelectedIndexChanged" />
                        <asp:AsyncPostBackTrigger ControlID="btnEliminar" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
                
            </td>
        </tr>
        <tr>
            <td style="text-align: center" colspan="2">&nbsp;
                
            </td>
        </tr>
        <tr>
            <td style="text-align: center" colspan="2">
            
            
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="btnGuardar" runat="server" onclick="btnGuardar_Click" 
                            Text="Guardar" />
                        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
                        <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" />
                        <asp:Button ID="btnFicha" runat="server" OnClick="btnFicha_Click" Text="Ficha" />
                        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                        <cc1:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" TargetControlID="btnEliminar"
                            ConfirmText="¿Desea Eliminar la Propiedad?">
                        </cc1:ConfirmButtonExtender>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdateProgress ID="upPGuardar" runat="server" AssociatedUpdatePanelID="UpdatePanel3">
                <ProgressTemplate>
                    Cargando...
                </ProgressTemplate>
            </asp:UpdateProgress>
            </td>
        </tr>
    </table>
    <asp:ObjectDataSource ID="OdsTipoDeInmueble" runat="server" SelectMethod="SeleccionarTiposInmuebles"
        TypeName="RioParanaBLL.TiposBLL"></asp:ObjectDataSource>
    </div>
</asp:Content>
