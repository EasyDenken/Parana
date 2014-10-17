<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FichaPropiedad.aspx.cs" Inherits="RioParana.FichaPropiedad" %>

<%@ Register Assembly="Artem.GoogleMap" Namespace="Artem.Web.UI.Controls" TagPrefix="cc2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<link href="Styles/bordes_esquinas.css" rel="stylesheet" type="text/css" />
<link href="Styles/contacto.css" rel="stylesheet" type="text/css" />
 <style type="text/css">
        /* ajax modal dialog styles */.modalBackground
        {
            background-color: Black;
            filter: alpha(opacity=50);
            opacity: 0.5;
        }
        .modalBox
        {
            background-color: #252525;
            border-width: 1px;
            border-style: solid;
            border-color: #CCCCCC;
            padding: 3px;
        }
        .modalBox caption
        {
            background-image: url(images/window_titlebg.gif);
            background-repeat: repeat-x;
        }
        /* tweb modal dialog styles */.modalPanelTitle td
        {
            padding: 3px;
            font-weight: bold;
            font-size: 0.9em;
            background-image: url(images/window_titlebg.gif);
            cursor: pointer;
            color: black;
            font-family: Verdana;
            width: 100%;
            height: 30px;
            background-color: #6f90dc;
        }
        .modalPanel
        {
            z-index: 500;
            width: 500px;
            border: solid 1px #275473;
            position: absolute;
            border-collapse: collapse;
            background-color: #f0faff;
        }
        .modalPanel td
        {
            vertical-align: top;
        }
        .titleIcon
        {
            padding-right: 2px;
        }
        .modalBackground
        {
            background-color: #252525;
            filter: alpha(opacity=90);
            opacity: 0.9;
        }
        .modalPopup
        {
            background-color: #ffffdd;
            padding-right: 2px;
            padding-left: 2px;
            border-width: 1px;
            border-style: solid;
            border-color: Gray;
            font-family: @Arial Unicode MS;
            font-size: 15px;
        }
        h1
        {
            margin: 0;
            font-size: 26px;
        }
        h1 em
        {
            font-size: 60%;
        }
        hr
        {
            border: none;
            height: 1px;
            line-height: 1px;
            background: #CCC;
            margin-bottom: 0px;
            padding: 0;
        }
        p
        {
            margin: 0;
            padding: 0px 0;
        }
        a
        {
            outline: none;
            margin-right: 0px;
        }
        a img
        {
            border: 1px solid #000000;
            padding: 0px;
            margin: 6px 2px 0px 0px;
        }
        #contenedorfotos
        {
            width: 282px;
            border: 0px;
            height: 585px;
            overflow: auto;
        }
    </style>
    
   <script type="text/javascript" src="images/fancybox/jquery.min.js"></script>

        <link rel="stylesheet" type="text/css" href="images/fancybox/jquery.fancybox-1.2.5.css"
            media="screen" />

        <script type="text/javascript" src="images/fancybox/jquery.fancybox-1.2.5.pack.js"></script>

        <script type="text/javascript">
            $(document).ready(function () {

                $("a.zoom1").fancybox({
                    'overlayOpacity': 0.6,
                    'zoomSpeedIn': 500,
                    'zoomSpeedOut': 350,
                    'overlayColor': '#000'
                });
            });
        </script>
            
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script language="JavaScript" type="text/javascript">
    function pantallacompleta(pagina) {
        var opciones = ("toolbar=no,location=no, directories=no, status=no, menubar=no ,scrollbars=no, resizable=NO, Titlebar=no, Toolbar=no , fullscreen=no, width=685, height=1000, scrollbars=NO");
        window.open(pagina, "", opciones);
    }
    </script>

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










    
    <div align="center">

        <script type="text/javascript">
            AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '710', 'height', '50', 'src', 'secciones?textoweb= -  Ficha Propiedad - ', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'wmode', 'transparent', 'movie', 'secciones?textoweb= -  Ficha Propiedad - '); //end AC code
        </script>

        <noscript>
            <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0"
                width="710" height="50">
                <param name="movie" value="secciones.swf?textoweb= -  Ficha Propiedad - " />
                <param name="quality" value="high" />
                <param name="wmode" value="transparent" />
                <embed src="secciones.swf?textoweb= -  Ficha Propiedad - " width="710" height="50"
                    quality="high" pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"
                    type="application/x-shockwave-flash" wmode="transparent"></embed>
            </object>
        </noscript>
    </div>
    <div>
        <a href="javascript:history.go(-1)">Volver</a>
        <input type="button" value="Imprimir Ficha" 
            onclick="javascript:pantallacompleta('Imprimir.aspx')" 
            style="position:relative; z-index: 3; top: 5px; margin-left:150px" />
    </div>

    <script id="grid" type="text/javascript">

        function On(GridView) {
            if (GridView != null) {
                GridView.originalBgColor = GridView.style.backgroundColor;
                GridView.style.backgroundColor = "#D1E7FF";
                GridView.style.cursor = "hand";
            }
        }

        function Off(GridView) {
            if (GridView != null) {
                GridView.style.backgroundColor = GridView.originalBgColor;
            }
        }

    </script>

   
    <div align="center">

     

        <table cellpadding="0" cellspacing="0" border="0" align="center" width="700px">
            <tr>
                <td>
                    <div align="center" id="contenedorfotos">
                        <asp:updatepanel ID="upImagenes" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="grdImageViewer" runat="server" AutoGenerateColumns="False" CellPadding="0"
                                    AllowPaging="True" PageSize="10" OnPageIndexChanging="grdImageViewer_PageIndexChanging"
                                    GridLines="None" OnRowDataBound="grdImageViewer_RowDataBound" DataKeyNames="grdImage"
                                    Style="margin-right: 0px; margin-top: 0px; margin-bottom: 0px" EditIndex="0"
                                    HorizontalAlign="Center" SelectedIndex="0" ShowHeader="False">
                                    <PagerSettings Mode="NumericFirstLast" />
                                    <RowStyle HorizontalAlign="Center" />
                                    <Columns>
                                        <asp:TemplateField ShowHeader="False">
                                            <ItemTemplate>
                                                <a class="zoom1" rel="group" href='<%#Eval("grdImage1")%>'>
                                                    <img src='<%#Eval("grdImage")%>' alt="Imagen Propiedad" />
                                            </ItemTemplate>
                                            <HeaderStyle Height="0px" Wrap="False" />
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:updatepanel>
                    </div>
                </td>
                <td align="right" valign="top" width="450px">
                    <asp:updatepanel runat="server" ID="upDetail">
                        <ContentTemplate>
                            <asp:DetailsView ID="DetailsView1" runat="server" CellPadding="1" ForeColor="#333333"
                                GridLines="None" AutoGenerateRows="False" DataKeyNames="IdInmueble" OnItemCommand="DetailsView1_ItemCommand"
                                CaptionAlign="Right" Style="margin-left: 0px" Width="565px" 
                                CellSpacing="1" HorizontalAlign="Left">
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
                                <RowStyle BackColor="#EFF3FB" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <FieldHeaderStyle BackColor="#DEE8F5" width="200px" Font-Bold="True" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <AlternatingRowStyle BackColor="White" />
                                <Fields>

                                    <asp:TemplateField HeaderText="Dirección:" HeaderStyle-HorizontalAlign="Right">
                                        <ItemTemplate>
                                            <div align="left" style="width: 120px">
                                                <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Calle") + " " + DataBinder.Eval(Container.DataItem,"Numero") %>'
                                                    ID="Linkbutton1" Width="150px" />
                                            </div>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Right" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Descripción:" HeaderStyle-HorizontalAlign="Right">
                                        <ItemTemplate>
                                                                                     
                                                    <%#DataBinder.Eval(Container.DataItem, "Observaciones")%>
                                              

                                        </ItemTemplate>
                                        <FooterStyle HorizontalAlign="Left" />
                                        <HeaderStyle HorizontalAlign="Right" />
                                    </asp:TemplateField>
                                </Fields>
                            </asp:DetailsView>
                        </ContentTemplate>
                    </asp:updatepanel>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;
                    
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 114px" align="center">
                    <asp:panel ID="Panel1" runat="server">
                        <cc2:GoogleMap BorderStyle="Solid" BorderWidth="1" EnableDoubleClickZoom="true" EnableScrollWheelZoom="true"
                            EnableGoogleBar="true" ID="GoogleMap1" runat="server" Latitude="42.1229" Longitude="24.7879"
                            Zoom="15" Width="850px" Height="400px" Key="ABQIAAAAyTqlc98ec-AroHRpV-k7tRSYLG6fDlhVEk874HydvxxZhp9wgBTxJRxIYzG9pcz3SrjRaPONc678ag">
                        </cc2:GoogleMap>
                    </asp:panel>
                </td>
            </tr>
            <tr>
                <td>&nbsp;
                    
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:panel ID="Panel3" runat="server" Visible="false">
                        <div align="center">
                            <asp:DropDownList ID="ddlOpciones" runat="server">
                                <asp:ListItem>Seleccione una opción</asp:ListItem>
                                <asp:ListItem>Editar Propiedad</asp:ListItem>
                                <asp:ListItem>Editar Imagenes</asp:ListItem>
                                <asp:ListItem>Eliminar Propiedad</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Button ID="btnOpciones" runat="server" OnClick="btnOpcion_Click" Text="Aceptar" />
                        </div>
                    </asp:panel>
                </td>
            </tr>
        </table>
 
 
 
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


</asp:content>
