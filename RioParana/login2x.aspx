<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login2.aspx.cs" Inherits="login._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    

    <link rel="stylesheet" href="Styles/login.css" type="text/css" media="screen"/>

   
</head>
<body>


<form id="form-login" runat="server" method="post">
   

        <div style="width:415px; display:block; text-align:left; float:none">
            <div class="block indent-bot3">
                <div class="indent">
                                        <h3>Administración</h3>
                                        
                                            <fieldset>
                                                <label><span></span>Usuario<br>
                                                
                                                <asp:TextBox ID="txtUsuario" runat="server" name="txtUsuario" class="input"/>
                                                
                                                </label>
                                                 <label><span></span>Contraseña<br>
                                                
                                                 <asp:TextBox ID="txtPassword" name="txtPassword" runat="server" TextMode="Password" class="input" />
                                                 </label>
                                                
                                                
                                                <div class="buttons wrapper">
                                                    <div class="fleft padding"><input type="checkbox" name="option" value="v1" class="checkbox"/><span>Recordarme</span></div>
                                                   
                                                   
                                                    <asp:Button ID="btnAcceder" runat="server" Text="INGRESAR" onclick="btnAcceder_Click" class="btn" />
                                              
                                                </div>
                                                <a href="#">Pedir contrase&ntilde;a</a>
                                                <div class="mensaje_estado_ingreso">
                                                    <asp:Label ID="lblMensaje" runat="server" Text="Mensaje de estado"></asp:Label>
                                                </div>
                                            </fieldset>                   
                                       
            </div>
            </div>
        </div>
            
                        
   </form>                     
                  
</body>
</html>
