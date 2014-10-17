<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" EnableEventValidation="false" AutoEventWireup="true"
    CodeBehind="ListaPropiedades.aspx.cs" Inherits="RioParana.ListaPropiedades" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link type="text/css" rel="Stylesheet" href="accordion.css" />
    <link href="Styles/bordes_esquinas.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .invisible
        {
            visibility: hidden;
        }
        .modalPopup
        {
            border: 3px solid Gray;
            background-color: #EEEEEE;
            font-family: Verdana;
            font-size: medium;
            padding: 3px;
            }
        .modalBackground
        {
            background-color: Black;
            filter: alpha(opacity=50);
            opacity: 0.5;
        }
        .style1
        {
            height: 30px;
        }
    </style>
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="contenido_menu_resultados">
        <asp:objectdatasource ID="odsCasas" runat="server" SelectMethod="FetchCasas" 
            TypeName="RioParana.ListaPropiedades" />
        <asp:objectdatasource ID="odsDepartamentos" runat="server" SelectMethod="FetchDepartamentos"
            TypeName="RioParana.ListaPropiedades" />
        <asp:objectdatasource ID="odsOtrosInmuebles" runat="server" SelectMethod="FetchOtrosInmuebles"
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
                 
                   
                 
                    <asp:RadioButtonList ID="rblOperacion" runat="server" RepeatDirection="Horizontal" Width="206px">
                        <asp:ListItem Text="Alquiler" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Venta" Selected="True" Value="1"></asp:ListItem>
                    </asp:RadioButtonList>
                 
                 
                 
                 
                 
                    <ajaxtoolkit:accordion ID="accordion" runat="server" FadeTransitions="true" FramesPerSecond="100"
                        TransitionDuration="250" CssClass="accordion" HeaderCssClass="header" ContentCssClass="content"
                        RequireOpenedPane="true" AutoSize="None" SelectedIndex="0" SuppressHeaderPostbacks="true"
                        Width="208px">
                        <Panes>
                            <ajaxToolkit:AccordionPane ID="Ventas" runat="server">
                                <Header>
                                    <div style="background-image: url(img/flecha.png); background-position: right; margin-right: 8px">
                                        <span>Casas</span>
                                    </div>
                                </Header>
                                <Content>
                                    <asp:ListView ID="lvCasas" runat="server" DataSourceID="odsCasas">
                                        <LayoutTemplate>
                                            <ul>
                                                <li id="itemPlaceholder" runat="server" />
                                            </ul>
                                        </LayoutTemplate>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButtonCasas" runat="server" OnCommand="CargarGrilla" CommandArgument='<%# "CASA" + " " + Eval("Name") %>'>
                                                        
                                                        <%--<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# CargarGrilla()%>' >
                                                        <li style='background-image:url(<%# Eval("ImageUrl") %>)'><%# Eval("Name") %></li>
                                                        </asp:HyperLink>--%>
                                                        
                                                        <li ><%# Eval("Name") %></li>
                                            </asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:ListView>
                                </Content>
                            </ajaxToolkit:AccordionPane>
                            <ajaxToolkit:AccordionPane ID="APAlquileres" runat="server">
                                <Header>
                                    <div style="background-image: url(img/flecha.png); background-position: right; margin-right: 8px">
                                        <span>Departamentos</span>
                                    </div>
                                </Header>
                                <Content>
                                    <asp:ListView ID="lvDepartamentos" runat="server" DataSourceID="odsDepartamentos">
                                        <LayoutTemplate>
                                            <ul>
                                                <li id="itemPlaceholder" runat="server" />
                                            </ul>
                                        </LayoutTemplate>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButtonDepartamentos" runat="server" OnCommand="CargarGrilla"
                                                CommandArgument='<%# "DEPARTAMENTO" + " " + Eval("Name") %>'>
                                                        
                                                        <li><%# Eval("Name") %></li>
                                            </asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:ListView>
                                </Content>
                            </ajaxToolkit:AccordionPane>
                            <ajaxToolkit:AccordionPane ID="ofertas" runat="server">
                                <Header>
                                    <div style="background-image: url(img/flecha.png); background-position: right; margin-right: 8px">
                                        <span>Otros Inmuebles</span>
                                    </div>
                                </Header>
                                <Content>
                                    <asp:ListView ID="lvOtrosInmuebles" runat="server" DataSourceID="odsOtrosInmuebles">
                                        <LayoutTemplate>
                                            <ul>
                                                <li id="itemPlaceholder" runat="server" />
                                            </ul>
                                        </LayoutTemplate>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButtonOtrosInmuebles" runat="server" OnCommand="CargarGrilla"
                                                CommandArgument='<%# "OTRO" + " " + Eval("Name") %>'>
                                                        
                                                        <li><%# Eval("Name") %></li>

                                            </asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:ListView>
                                </Content>
                            </ajaxToolkit:AccordionPane>
                        </Panes>
                    </ajaxtoolkit:accordion>
              
              
              
              
              
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




                    <asp:datagrid ID="DataGrid1" runat="server" CellPadding="2" AllowPaging="True" AutoGenerateColumns="False"
                        Width="100%" PageSize="4" ForeColor="#333333" Height="132px" AllowSorting="True"
                        OnPageIndexChanged="DataGrid1_PageIndexChanged" BackColor="#4382AB" BorderColor="#CCCCCC"
                        BorderWidth="0px" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                        Font-Strikeout="False" Font-Underline="False" GridLines="Horizontal">
                        <EditItemStyle BackColor="#999999" />
                        <SelectedItemStyle Font-Bold="True" ForeColor="#333333" BackColor="#E2DED6" BorderColor="White"
                            BorderWidth="0px"></SelectedItemStyle>
                        <AlternatingItemStyle BackColor="White" ForeColor="#284775"></AlternatingItemStyle>
                        <ItemStyle BackColor="#F7F6F3" ForeColor="#333333"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#999999" BackColor="#D7D7D7" Font-Italic="False"
                            Font-Overline="False" Font-Size="13px" Font-Strikeout="False" 
                            Font-Underline="False">
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
                                    <b>Dirección: </b><b><font color="blue">
                                        <%# Eval("Calle")%>
                                        <%# Eval("Numero")%>
                                        <%# piso((string)Eval("Piso"))%>
                                        <%# Eval("Departamento")%>
                                    </font></b>- entre
                                    <%# Eval("Calle1") %>
                                    y
                                    <%# Eval("Calle2") %>
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
                                        <%# precio ((string)Eval("PrecioAlquiler").ToString()) %>
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
                        <PagerStyle HorizontalAlign="Center" ForeColor="#333333" BackColor="#CCCCCC" Mode="NumericPages"
                            Position="TopAndBottom" Font-Bold="True" Font-Italic="False" Font-Overline="False"
                            Font-Size="16px" Font-Strikeout="False" Font-Underline="False"></PagerStyle>
                    </asp:datagrid>
                    <asp:button ID="Button100000" runat="server" Text="Button" 
                        CssClass="invisible" />
                    <ajaxtoolkit:modalpopupextender ID="MPEDatosUsuario" runat="server" TargetControlID="Button100000"
                        PopupControlID="PanelDatosUsuario" BackgroundCssClass="modalBackground" DropShadow="True"
                        OkControlID="txtAceptar" CancelControlID="txtCancelar" />
                    <asp:panel ID="PanelDatosUsuario" CssClass="modalPopup" runat="server" 
                        BackColor="#E5E5E5" Width="532px">
                      
                      
                      
                        <table style="width: 494px; height: 177px;" align="center">
                            <tr>
                                <td colspan="2" 
                                    style="font-family: 'Trebuchet MS'; font-size: 13px; font-weight: bold; color: #000000;" 
                                    class="style1">
                                    Llene le formulario para poder visualizar los detalles completos:</td>
                            </tr>
                            <tr>
                                <td style="font-family: Arial; font-size: 10pt; font-weight: 700;" 
                                    align="right">
                                    <asp:Label ID="Label4" runat="server" Height="23px" Text="Direccion e-mail:"></asp:Label>
                                </td>
                                <td style="font-family: Arial; font-size: 10pt; font-weight: 700;">
                                    <asp:TextBox ID="txtEmailAddress" runat="server" Width="100%" BackColor="White" 
                                        ForeColor="Black"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-family: Arial; font-size: 10pt; font-weight: 700;" 
                                    align="right">
                                    <asp:Label ID="Label6" runat="server" Height="23px" Text="Nombre :"></asp:Label>
                                </td>
                                <td style="font-family: Arial; font-size: 10pt; font-weight: 700;">
                                    <asp:TextBox ID="txtFirstName" runat="server" Width="100%" BackColor="White" 
                                        ForeColor="Black"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-family: Arial; font-size: 10pt; font-weight: 700;" 
                                    align="right">
                                    <asp:Label ID="Label7" runat="server" Height="23px" Text="Apellido :"></asp:Label>
                                </td>
                                <td style="font-family: Arial; font-size: 10pt; font-weight: 700;">
                                    <asp:TextBox ID="txtLastName" runat="server" Width="100%" BackColor="White" 
                                        ForeColor="Black"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-family: Arial; font-size: 10pt; font-weight: 700;" 
                                    align="right">
                                    <asp:Label ID="Label5" runat="server" Height="23px" Text="Telefono:"></asp:Label>
                                </td>
                                <td style="font-family: Arial; font-size: 10pt; font-weight: 700;">
                                    <asp:TextBox ID="txtTelefono" runat="server" Width="100%" BackColor="White" 
                                        ForeColor="Black"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 104px; height: 26px;">
                                </td>
                                <td style="width: 179px; height: 26px;" align="right">
                                    <asp:Button
                                        ID="txtAceptar" runat="server" Text="Aceptar" OnClick="AceptarPopUp" 
                                        BackColor="#999999" />
                                    <asp:Button ID="txtCancelar" runat="server" Text="Cancelar" 
                                        BackColor="#999999" />
                                </td>
                            </tr>
                        </table>
                    </asp:panel>




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
</asp:content>
