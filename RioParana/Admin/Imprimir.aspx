<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Imprimir.aspx.cs" Inherits="Members_Imprimir" %>

<%@ Register Assembly="Artem.GoogleMap" Namespace="Artem.Web.UI.Controls" TagPrefix="cc2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

 


    <title></title>
</head>
<body style="font-family: Arial, Helvetica, sans-serif; font-size: 11px">
    <form id="form1" runat="server" action="enviarmail.php" method="post">
    <table>
        <tr>
            <td>
                <div style="text-align: center; height: 66px;">
                    <asp:imagebutton ID="ImageButton1" runat="server" ImageAlign="Middle" 
                        ImageUrl="~/Css/logo_inci_2.png" />
                </div>
                <div style="width: 270px; overflow: hidden; float: left; margin-bottom: 10px;">
                    <div style="overflow: hidden; text-align: center; width: 267px; margin-bottom: 10px;">
                        <asp:image ID="Image1" runat="server" BorderStyle="Solid" BorderWidth="3px" BorderColor="#111111"
                            ImageAlign="Middle" />
                    </div>
                    <div>
                        <asp:image ID="Googleimagen" runat="server" BorderStyle="Solid" BorderWidth="3px"
                            BorderColor="#111111" />
                    </div>
                </div>
                <div style="width: 355px; overflow: hidden; float: right">
                    <asp:detailsview ID="DetailsView1" runat="server" CellPadding="1" ForeColor="#333333"
                        GridLines="Horizontal" AutoGenerateRows="False" DataKeyNames="IdInmueble" OnItemCommand="DetailsView1_ItemCommand"
                        CaptionAlign="Right" Style="margin-left: 0px" Width="355px" 
                        CellSpacing="1" HorizontalAlign="Left" headertext="DATOS PROPIEDAD">
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
                        <RowStyle BackColor="#EFF3FB" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" 
                            horizontalalign="Center" />
                        <EditRowStyle BackColor="#2461BF" />
                        <AlternatingRowStyle BackColor="White" />
                        <Fields>
                            <asp:TemplateField HeaderText="Dirección:" HeaderStyle-HorizontalAlign="Right">
                                <ItemTemplate>
                                    <div align="left" style="width: 120px">
                                        <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Calle") + " " + DataBinder.Eval(Container.DataItem,"Numero") %>'
                                            ID="Linkbutton1" Width="100px" />
                                    </div>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Right" />
                                <ItemStyle Width="240px" />
                            </asp:TemplateField>
                        </Fields>
                    </asp:detailsview>
                    
                </div>
            </td>
        </tr>
        <tr>
            <td>
             <div style="text-align:center; font-size:12px ; font-family:Verdana; font-weight:bold; margin-bottom:5px"> .: Observaciones :.
             </div>
             <div style="border:1px ; border-style:dashed; padding:5px" >
                   
                <asp:formview ID="DetailsView2" runat="server">
                        <ItemTemplate>
                            <%#DataBinder.Eval(Container.DataItem, "Observaciones")%>
                        </ItemTemplate>
                    </asp:formview>
                </div>
                <div>
                    <cc2:googlemap Visible="false" BorderStyle="Solid" BorderWidth="1" EnableDoubleClickZoom="false"
                        EnableScrollWheelZoom="false" Enabled="false" EnableGoogleBar="true" ID="GoogleMap1"
                        runat="server" Latitude="42.1229" Longitude="24.7879" Zoom="15" 
                        Width="0px" Height="0px"
                        
                        Key="ABQIAAAApU_iFCnQtFqCJz_RVHKf6hSIMON3V3yf7e-rtPXBV5YPjpYuCRQqSKQQMFkEFT-8V8ujIAr2-XcoIQ">
                    </cc2:googlemap>
                </div>
                <div>
                </div>
            </td>
        </tr>
    </table>


    <script language="javascript">
        window.print();
    </script>
  
   
    <asp:hiddenfield id="HiddenFielddireccion" runat="server" />
    <asp:hiddenfield id="HiddenFieldtipoinmueble" runat="server" />
    <asp:hiddenfield id="HiddenFieldestadoinmueble" runat="server" />
    <asp:hiddenfield id="HiddenFieldprovincia" runat="server" />
    <asp:hiddenfield id="HiddenFieldlocalidad" runat="server" />
    <asp:hiddenfield id="HiddenFieldzona" runat="server" />
    <asp:hiddenfield id="HiddenFieldpiso" runat="server" />
    <asp:hiddenfield id="HiddenFielddepartamento" runat="server" />
    <asp:hiddenfield id="HiddenFieldentrecalle" runat="server" />
    <asp:hiddenfield id="HiddenFieldycalle" runat="server" />
    <asp:hiddenfield id="HiddenFieldmetroscuadcubiertos" runat="server" />
    <asp:hiddenfield id="HiddenFieldmetroscuadsemicubiertos" runat="server" />
    <asp:hiddenfield id="HiddenFieldposicion" runat="server" />
    <asp:hiddenfield id="HiddenFieldcochera" runat="server" />
    <asp:hiddenfield id="HiddenFieldAntiguedad" runat="server" />
    <asp:hiddenfield id="HiddenFieldAntiguedadA" runat="server" />
    <asp:hiddenfield id="HiddenFieldOperacion" runat="server" />
    <asp:hiddenfield id="HiddenFieldPrecioVenta" runat="server" />
    <asp:hiddenfield id="HiddenFieldPrecioAlquiler" runat="server" />
    <asp:hiddenfield id="HiddenFieldComision" runat="server" />
    <asp:hiddenfield id="HiddenFieldFechaAlta" runat="server" />
    <asp:hiddenfield id="HiddenFieldFechaActualiza" runat="server" />
    <asp:hiddenfield id="HiddenFieldMailUsuario" runat="server" />
    <asp:hiddenfield id="HiddenFieldObservaciones" runat="server" />
    <asp:hiddenfield id="HiddenFieldimagen" runat="server" />
    <asp:hiddenfield id="HiddenFieldgooglemapsimage" runat="server" />
      <input type="submit" value="Enviar e-mail" />
    </form>


</body>
</html>
