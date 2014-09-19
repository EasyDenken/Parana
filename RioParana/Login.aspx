<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="RioParana.Login" MasterPageFile="~/Site.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<link href="Styles/bordes_esquinas.css" rel="stylesheet" type="text/css" />
<link href="Styles/contacto.css" rel="stylesheet" type="text/css" />
 <link rel="stylesheet" href="Styles/login.css" type="text/css" media="screen"/>

</asp:Content>


<asp:Content ContentPlaceHolderID="MainContent" ID="idcontent" runat="server">
    <asp:UpdatePanel runat="server" ID="upLogin">
        <ContentTemplate>
        


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

   

   

<form id="form-login" method="post">
   

        <div style="width:415px; display:block; text-align:left; float:none">
            <div class="block indent-bot3">
                <div class="indent">
                                        <h3>Administración</h3>
                                        
                                            <fieldset>
                                                <label style="font-size:12px;font-family:Arial, Helvetica, sans-serif;"><span></span>Usuario :<br>
                                                
                                                <asp:TextBox ID="txtUsuario" runat="server" name="txtUsuario" class="input"/>
                                                
                                                </label><br>
                                                 <label style="font-size:12px;font-family:Arial, Helvetica, sans-serif;"><span></span>Contraseña :<br>
                                                
                                                 <asp:TextBox ID="txtPassword" name="txtPassword" runat="server" TextMode="Password" class="input" />
                                                 </label>
                                                
                                                
                                                <div class="buttons wrapper">
                                                    <div class="fleft padding">
                                                    <input type="checkbox" name="option" value="v1" class="checkbox"/>
                                                    <span style="font-size:12px;font-family:Arial, Helvetica, sans-serif;">Recordarme</span>
                                                    </div>
                                                   
                                                   
                                               <!--     <asp:Button ID="btnAcceder" runat="server" Text="INGRESAR" onclick="btnAcceder_Click" class="btn" BackColor="#FE0045" BorderColor="#CCFFFF" CssClass="btn" ForeColor="White" Font-Bold="True" /> -->
                                                      <a class="btn" onserverclick="btnAcceder_Click" runat="server">INGRESAR</a>
                                               
                                               
                                                </div>
                                                <a class="pedir_contra">Pedir contrase&ntilde;a</a>
                                                <div class="mensaje_estado_ingreso">
                                                    <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Red" Font-Bold="True" Class="mensaje_estad"></asp:Label>
                                                </div>
                                            </fieldset>                   
                                       
            </div>
            </div>
        </div>
            
                        
   </form> 
  
  
  
  
  
  
  
                      
   
            </div>
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
    
    
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
