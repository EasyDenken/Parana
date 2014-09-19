<%@ Page Language="C#" MasterPageFile="~/Site.master"AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="RioParana.Contacto" %>

<asp:content ID="HeaderContent" runat="server" 
    ContentPlaceHolderID="HeadContent">
<link href="Styles/bordes_esquinas.css" rel="stylesheet" type="text/css" />
<link href="Styles/contacto.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style2
        {
            font-size: 10pt;
        }
    </style>
</asp:content>
<asp:content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">


  <div id="contenido_menu_resultados">
        <asp:objectdatasource ID="odsCasas" runat="server" SelectMethod="FetchCasas" 
            TypeName="RioParana.ListaPropiedades" />
        <asp:objectdatasource ID="odsDepartamentos" runat="server" SelectMethod="FetchDepartamentos"
            TypeName="RioParana.ListaPropiedades" />
        <asp:objectdatasource ID="odsOtrosInmuebles" runat="server" SelectMethod="FetchOtrosInmuebles"
            TypeName="RioParana.ListaPropiedades" />
      
      
      
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
                 <p>&nbsp;</p>
                 <p>Hola como va</p>
                 <p>&nbsp;</p>
                 <p>asdasd</p>
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
        
    </div>
  




 </asp:content>   