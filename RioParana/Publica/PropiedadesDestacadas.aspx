<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PropiedadesDestacadas.aspx.cs" Inherits="RioParana.Publica.PropiedadesDestacadas" MasterPageFile="~/Site.Master" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<asp:Content ID="content" ContentPlaceHolderID="MainContent">

    <asp:DataGrid ID="dgDestacados" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" BackColor="#4382AB" 
        BorderColor="#CCCCCC" BorderWidth="1px" CellPadding="2" Font-Bold="False" 
        Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
        Font-Underline="False" ForeColor="#333333" GridLines="Horizontal" 
        Height="132px" OnPageIndexChanged="DataGrid1_PageIndexChanged" PageSize="4" 
        Width="100%">
        <EditItemStyle BackColor="#999999" />
        <SelectedItemStyle BackColor="#E2DED6" BorderColor="White" BorderWidth="0px" 
            Font-Bold="True" ForeColor="#333333" />
        <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
        <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <HeaderStyle BackColor="#D7D7D7" Font-Bold="True" Font-Italic="False" 
            Font-Overline="False" Font-Size="13px" Font-Strikeout="False" 
            Font-Underline="False" ForeColor="Black" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:TemplateColumn>
                <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                    Font-Strikeout="False" Font-Underline="False" ForeColor="Black" 
                    HorizontalAlign="Center" />
                <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                    Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                    VerticalAlign="Middle" />
                <HeaderTemplate>
                    <strong>Foto</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:ImageButton ID="Image1" runat="server" BorderWidth="0px" 
                        CommandArgument='<%#Eval("IdInmueble")%>' ImageAlign="Middle" 
                        ImageUrl='<%# URLImagen((string)Eval("IdInmueble").ToString()) %>' 
                        OnCommand="CargarFicha" />
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:TemplateColumn>
                <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                    Font-Strikeout="False" Font-Underline="False" ForeColor="Black" 
                    HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Justify" VerticalAlign="Top" />
                <HeaderTemplate>
                    <strong>Propiedades</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <b>Tipo de Inmueble: </b><%# Eval("TipoDeInmueble")%>
                    <br><b>Dirección: </b><b><font color="blue"><%# Eval("Calle")%>
                    <%# Eval("Numero")%><%# piso((string)Eval("Piso"))%><%# Eval("Departamento")%>
                    </font></b>- entre <%# Eval("Calle1") %>y <%# Eval("Calle2") %>
                    <br><b>Operación: </b><%# Eval("Operacion")%>
                    <br><b>Estado: </b><%# Eval("Estado")%>
                    <br><b>Precio de Venta: </b><%# Moneda((string)Eval("MonedaVenta"))%><b>
                    <font color="red"><%# precio((string)Eval("PrecioVenta").ToString())%></font>
                    </b>
                    <br><b>Precio de Alquiler: </b><%# Moneda((string)Eval("MonedaAlquiler"))%><b>
                    <font color="red"><%# precio ((string)Eval("PrecioAlquiler").ToString()) %>
                    </font></b>
                    <br><b>Comisión: </b><%# Eval("Comision")%>%
                    <br><b>Localidad: </b><%# Eval("NombreLocalidad")%>/
                    <%# Eval("NombreProvincia")%>
                    <br><b>Inmobiliaria: </b><%# Eval("NombreInmobiliaria")%>
                    <!--
                                <br />                                
                                <asp:LinkButton runat="server" Text="Ficha" CommandName="Edit" ForeColor="Blue" ID="Linkbutton1"
                                    OnCommand="CargarFicha" CommandArgument='<%#Eval("IdInmueble")%>' />
                                    -->
                </ItemTemplate>
            </asp:TemplateColumn>
        </Columns>
        <PagerStyle BackColor="#4382AB" Font-Bold="True" Font-Italic="False" 
            Font-Overline="False" Font-Size="16px" Font-Strikeout="False" 
            Font-Underline="False" ForeColor="#2C2C2C" HorizontalAlign="Center" 
            Mode="NumericPages" Position="TopAndBottom" />
    </asp:DataGrid>

</asp:Content>