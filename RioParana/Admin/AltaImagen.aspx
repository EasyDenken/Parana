<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="AltaImagen.aspx.cs" Inherits="RioParana.Admin.AltaImagen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center">

        <script type="text/javascript">
            AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '710', 'height', '50', 'src', 'secciones?textoweb= -  Imágenes - ', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'wmode', 'transparent', 'movie', 'secciones?textoweb= -  Imágenes - '); //end AC code
        </script>

        <noscript>
            <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0"
                width="710" height="50">
                <param name="movie" value="secciones.swf?textoweb= -  Imágenes - " />
                <param name="quality" value="high" />
                <param name="wmode" value="transparent" />
                <embed src="secciones.swf?textoweb= -  Imágenes - " width="710" height="50" quality="high"
                    pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"
                    type="application/x-shockwave-flash" wmode="transparent"></embed>
            </object>
        </noscript>
    </div>
    <style type="text/css">
        .lbl
        {
            color: green;
            font-weight: bold;
        }
        .upperColumn
        {
            margin: auto;
            width: 600px;
            border-bottom: Solid 1px orange;
            background-color: white;
            padding: 10px;
            height: 36px;
        }
        .bottomColumn
        {
            margin: auto;
            width: 600px;
            background-color: white;
            padding: 10px;
        }
        .style1
        {
            width: 100%;
            height: 23px;
        }
        .style8
        {
            height: 65px;
        }
        .style9
        {
            width: 100%;
            height: 32px;
        }
        .style10
        {
            text-align: left;
        }
        .style11
        {
            width: 246px;
            text-align: right;
        }
        .style12
        {
            width: 247px;
        }
        .style13
        {
        }
    </style>

    <script language="javascript" type="text/javascript">

        var size = 2;
        var id = 0;

        function ProgressBar() {
            if (document.getElementById('<%=fileUploader.ClientID %>').value != "" && document.getElementById('<%=DropDownListImage.ClientID %>').value != "0") {
                document.getElementById('ctl00_ContentPlaceHolder1_divProgress').style.display = "block";
                document.getElementById("divUpload").style.display = "block";
                id = setInterval("progress()", 20);
                return true;
            }
            else {
                alert("Seleccione un número de imagen y una archivo con extensión JPG");
                return false;
            }

        }

        function progress() {
            size = size + 1;
            if (size > 299) {
                clearTimeout(id);
            }
            document.getElementById('ctl00_ContentPlaceHolder1_divProgress').style.width = size + "pt";
            document.getElementById("<%=lblPercentage.ClientID %>").firstChild.data = parseInt(size / 3) + "%";
        }
        

    </script>

    <table style="width: 100%">
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <div>
                    <table class="style1">
                        <tr>
                            <td class="style11">
                                <asp:Label ID="Label2" Text="Seleccionar número de imagen:" AssociatedControlID="fileUploader"
                                    runat="server" CssClass="lbl" />
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownListImage" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListImage_SelectedIndexChanged"
                                    Style="margin-bottom: 0px">
                                    <asp:ListItem Value="0">Elegir numero de Imagen</asp:ListItem>
                                    <asp:ListItem Value="01">Imagen 1 (predeterminada)</asp:ListItem>
                                    <asp:ListItem Value="02">Imagen 2</asp:ListItem>
                                    <asp:ListItem Value="03">Imagen 3</asp:ListItem>
                                    <asp:ListItem Value="04">Imagen 4</asp:ListItem>
                                    <asp:ListItem Value="05">Imagen 5</asp:ListItem>
                                    <asp:ListItem Value="06">Imagen 6</asp:ListItem>
                                    <asp:ListItem Value="07">Imagen 7</asp:ListItem>
                                    <asp:ListItem Value="08">Imagen 8</asp:ListItem>
                                    <asp:ListItem Value="09">Imagen 9</asp:ListItem>
                                    <asp:ListItem Value="10">Imagen 10</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                        <div align="center" __designer:mapid="47">
                                            <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" 
                                                onclick="btnFinalizar_Click" />
                                        </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style8">
                <div style="height: 143px; text-align: center;">
                    <table class="style1">
                        <tr>
                            <td class="style11">
                                <asp:Label ID="lblImageFile" Text="Cargar la imagen:" AssociatedControlID="fileUploader"
                                    runat="server" CssClass="lbl" />
                            </td>
                            <td style="text-align: left" class="style13" colspan="2">
                                <asp:FileUpload ID="fileUploader" runat="server" Width="242px" Style="margin-left: 0px" />
                            </td>
                        </tr>
                        <td class="style11">
                            <asp:RegularExpressionValidator ID="revImagenJPG" runat="server" ControlToValidate="fileUploader"
                                ErrorMessage="Solamente se permiten imágenes en formato .JPG" SetFocusOnError="True"
                                ValidationExpression="(.*\.([jJ][pP][gG]|[jJ][pP][eE][gG])$)" Display="Dynamic"></asp:RegularExpressionValidator>
                        </td>
                        <td style="text-align: left" class="style13">
                            <asp:Button ID="btnAddImage" runat="server" Text="Agregar Imagen" OnClientClick="return ProgressBar()"
                                OnClick="ButtonUpload_Click" />
                        </td>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <asp:Label ID="lblImagen" runat="server" ForeColor="Red" Text="*Si agrega una imagen esta reemplazará la que esta actualmente."
                                        Visible="False" Style="text-align: center"></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </table>
                    <br />
                    <div id="divUpload" style="display: none">
                        <div style="width: 300pt; text-align: center;">
                            Cargando imagen... (por favor espere)
                        </div>
                        <div style="width: 300pt; height: 20px; border: solid 1pt gray">
                            <div id="divProgress" runat="server" style="width: 1pt; height: 20px; background-color: orange;
                                display: none">
                            </div>
                        </div>
                        <div style="width: 300pt; text-align: center;">
                            <asp:Label ID="lblPercentage" runat="server" Text="Label"></asp:Label></div>
                        <br />
                        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text=""></asp:Label>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <table cellpadding="0" cellspacing="0" style="width: 100%; height: 3px;">
                                <tr>
                                    <td>
                                        <table class="style9">
                                            <tr>
                                                <td class="style12" style="text-align: center">
                                                    &nbsp;<asp:Image ID="Image1" runat="server" Visible="False" />
                                                </td>
                                                <td class="style10">
                                                    <asp:Button ID="btnEliminarImagen" runat="server" OnClick="btnEliminarImagen_Click"
                                                        Text="Eliminar Imagen" Visible="False" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="DropDownListImage" EventName="SelectedIndexChanged" />
                        </Triggers>
                    </asp:UpdatePanel>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
