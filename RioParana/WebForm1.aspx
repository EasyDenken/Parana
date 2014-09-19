<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="WebForm1.aspx.cs" Inherits="RioParana.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link type="text/css" rel="Stylesheet" href="accordion.css" />
    <link href="Styles/bordes_esquinas.css" rel="stylesheet" type="text/css" />
    
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 
 
                <div id="contenido_menu_resultados">

                    <asp:ScriptManager ID="ScriptManager1" runat="server" />
                    <asp:ObjectDataSource ID="odsMailItems" runat="server" SelectMethod="FetchMailItems"
                        TypeName="RioParana.WebForm1" />
                    <asp:ObjectDataSource ID="odsNoteItems" runat="server" SelectMethod="FetchNoteItems"
                        TypeName="RioParana.WebForm1" />
                    <asp:ObjectDataSource ID="odsContactItems" runat="server" SelectMethod="FetchContactItems"
                        TypeName="RioParana.WebForm1" />
                  
                  
                  
                   

                            <div id="lado_izquierdo"><div id="top" class="top_divfondo"><div class="esquina_sup_izq"><img src="img_divfondo/top_left.png" alt="Esquina superior izquierda"  /></div>
                            <div class="esquina_sup_med"></div><div class="esquina_sup_der"><img src="img_divfondo/top_right.png" alt="Esquina superior derecha" /></div>
                            </div><div id="content_imagenes" class="content_imagenes"><div id="boxcontrol" class="boxcontrol_menu">


                            
                                <ajaxToolkit:Accordion ID="accordion" runat="server" FadeTransitions="true" FramesPerSecond="100"
                                    TransitionDuration="250" CssClass="accordion" HeaderCssClass="header" ContentCssClass="content"
                                    RequireOpenedPane="true" AutoSize="None" SelectedIndex="0" 
                                    SuppressHeaderPostbacks="true" Width="208px">
                                    <Panes>
                                        <ajaxToolkit:AccordionPane ID="Ventas" runat="server">
                                            <Header>
                                                <div style="background-image: url(img/flecha.png); background-position: right; margin-right: 8px">
                                                    <span>Casas</span>
                                                </div>
                                            </Header>
                                            <Content>
                                                <asp:ListView ID="lvMailItems" runat="server" DataSourceID="odsMailItems">
                                                    <LayoutTemplate>
                                                        <ul>
                                                            <li id="itemPlaceholder" runat="server" />
                                                        </ul>
                                                    </LayoutTemplate>
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="LinkButton1" runat="server" OnCommand="CargarGrilla" CommandArgument='<%# Eval("Name") %>'>
                                                        
                                                        <%--<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# CargarGrilla()%>' >
                                                        <li style='background-image:url(<%# Eval("ImageUrl") %>)'><%# Eval("Name") %></li>
                                                        </asp:HyperLink>--%>
                                                        
                                                        <li ><%# Eval("Name") %></li>
                                                        </asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                            </Content>
                                        </ajaxToolkit:AccordionPane>
                                        <ajaxToolkit:AccordionPane ID="Alquileres" runat="server"><Header>
                                                <div style="background-image: url(img/flecha.png); background-position: right; margin-right: 8px">
                                                    <span>Departamentos</span>
                                                </div>
                                            </Header>
                                            <Content>
                                                <asp:ListView ID="lvNoteItems" runat="server" DataSourceID="odsNoteItems">
                                                    <LayoutTemplate>
                                                        <ul>
                                                            <li id="itemPlaceholder" runat="server" />
                                                        </ul>
                                                    </LayoutTemplate>
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("url")%>'>
                                                        <li title='<%# Eval("Name")%>'>
                                                            <%# Eval("Name") %></li>
                                                        </asp:HyperLink>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                            </Content>
                                        </ajaxToolkit:AccordionPane>
                                        <ajaxToolkit:AccordionPane ID="ofertas" runat="server">
                                            <Header>
                                                <div style="background-image: url(img/flecha.png); background-position: right; margin-right: 8px">
                                                    <span>Ofertas</span>
                                                </div>
                                            </Header>
                                            <Content>
                                                <asp:ListView ID="lvContactItems" runat="server" DataSourceID="odsContactItems">
                                                    <LayoutTemplate>
                                                        <ul>
                                                            <li id="itemPlaceholder" runat="server" />
                                                        </ul>
                                                    </LayoutTemplate>
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("url")%>'>
                                                        <li title='<%# Eval("Name")%>'>
                                                            <%# Eval("Name") %></li>
                                                        </asp:HyperLink>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                            </Content>
                                        </ajaxToolkit:AccordionPane>
                                    </Panes>
                                </ajaxToolkit:Accordion>




                                </div></div><div id="bottom" class="bottom_divfondo "><div class="esquina_inf_izq">
                                <img src="img_divfondo/btm_left.png" alt="Esquina inferior izquierda" /></div><div class="esquina_inf_med">
                                </div><div class="esquina_inf_der"><img src="img_divfondo/btm_right.png" alt="Esquina inferior derecha"  />
                                </div></div></div>


                            <div id="lado_derecho">



                             <div id="Div12" class="top_divfondo"><div class="esquina_sup_izq"><img src="img_divfondo/top_left.png" alt="Esquina superior izquierda"  />
                            </div><div class="esquina_sup_med"></div><div class="esquina_sup_der"><img src="img_divfondo/top_right.png" alt="Esquina superior derecha" />
                            </div></div><div id="Div22" class="content_imagenes"><div id="Div32" class="boxcontrol_resultados">





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
                                    <PagerStyle HorizontalAlign="Center" ForeColor="#2C2C2C" BackColor="#4382AB" Mode="NumericPages"
                                        Position="TopAndBottom" Font-Bold="True" Font-Italic="False" Font-Overline="False"
                                        Font-Size="16px" Font-Strikeout="False" Font-Underline="False"></PagerStyle>
                                </asp:DataGrid>





                                </div></div><div id="Div4" class="bottom_divfondo "><div class="esquina_inf_izq">
                                <img src="img_divfondo/btm_left.png" alt="Esquina inferior izquierda" /></div><div class="esquina_inf_med">
                                </div><div class="esquina_inf_der"><img src="img_divfondo/btm_right.png" alt="Esquina inferior derecha"  />
                                </div></div></div>



                            
                   
                </div>
           
</asp:Content>
