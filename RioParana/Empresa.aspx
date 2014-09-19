<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="False" CodeBehind="Empresa.aspx.cs" Inherits="RioParana.Empresa" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:content ID="HeaderContent" runat="server" 
    ContentPlaceHolderID="HeadContent">
    <link href="Styles/bordes_esquinas.css" rel="stylesheet" type="text/css" />
<link href="Styles/contacto.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style2
        {
            font-size: 10pt;
        }
    .style3
    {
        font-family: Calibri;
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




     
               <div style="min-height:300px; padding-top:10px; color:Black;" ><b><font size="3">Nuestas Oficinas:</font></b><br />
                   San Lorenzo 1998<br />
                   S2000ARZ Rosario<br />
                   <br />
                   <b><font size="3">Tel:</font></b><br />
                   0341 - 4499107
                   <br />
                   5680381/2<br />
                   <br />
                   Zona Centro<br />
                   <br />
                   <br />
                   <br />
                   <br />
                   <br />
                   <span class="style2">
                   <br />
                   <br />
                   </span></div>


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
              
              
              
              
              
               <div class="contacto">
 <h1>Empresa</h1> 
				<form action="" method="post" enctype="multipart/form-data" name="contacto" id="contacto"> 
					<input name="funcion" type="hidden" id="funcion" value="contacto" /> 
					<div id="update_container"><span class="Apple-style-span" 
                            style="border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; font-size: medium;">
                        <span class="Apple-style-span" 
                            style="border-collapse: collapse; color: rgb(80, 0, 80); font-family: arial, sans-serif; font-size: 13px;">
                        <p class="MsoNormal" 
                            style="margin-top: 6pt; margin-right: 0cm; margin-bottom: 6pt; margin-left: 0cm;">
                            <span><span class="style3" lang="ES" style="font-size: 11pt;">Quienes somos, qué 
                            hacemos y cómo trabajamos.</span></span></p>
                        <p class="MsoNormal" 
                            style="margin-top: 6pt; margin-right: 0cm; margin-bottom: 6pt; margin-left: 0cm;">
                            <span style="margin-left: 80px"><span class="style3" lang="ES" 
                                style="font-size: 11pt;"><span class="Apple-converted-space">&nbsp;</span>Somos 
                            una empresa rosarina con más de 25 años de trayectoria en la Venta de Inmuebles 
                            y la Administración de Locaciones y Consorcios.</span></span></p>
                        <p class="MsoNormal" 
                            style="margin-top: 6pt; margin-right: 0cm; margin-bottom: 6pt; margin-left: 0cm;">
                            <span><span class="style3" lang="ES" style="font-size: 11pt;">Contamos con un 
                            equipo de profesionales multidisciplinarios, dinámicos y formados especialmente 
                            en cada área.</span></span></p>
                        <p class="MsoNormal" 
                            style="margin-top: 6pt; margin-right: 0cm; margin-bottom: 6pt; margin-left: 0cm;">
                            <span><span class="style3" lang="ES" style="font-size: 11pt;">El eje estratégico 
                            de nuestra actividad es la satisfacción de nuestros clientes.</span></span></p>
                        <p class="MsoNormal" 
                            style="margin-top: 6pt; margin-right: 0cm; margin-bottom: 6pt; margin-left: 0cm;">
                            <span><span class="style3" lang="ES" style="font-size: 11pt;">Poseemos una 
                            estructura operativa y tecnológica, actualizada permanentemente, conforme a la 
                            demanda del mercado inmobiliario actual.<br />
                            </span></span></p>
                        </span></span>
					 <div style="text-align:center">
				    <img src="images/fondo_parana_menu_empresa_1.png" width="650" height="467" alt=""/>
                    <img src="images/fondo_parana_menu_empresa_2.png" width="650" height="467" alt=""/>
                    <img src="images/fondo_parana_menu_empresa_3.png" width="650" height="467" alt=""/>
                    <img src="images/fondo_parana_menu_empresa_4.png" width="650" height="467" alt=""/>
                    </div>
                    
                    
                    </div> 
					<div class="sep_gral"></div> 
				</form> 
					<div class="sep_gral"></div> 
				
				
					 

</div>
    

         
              

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