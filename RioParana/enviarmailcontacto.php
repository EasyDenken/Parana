<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Envio mail</title>


</head>

<body style="font-family: Arial, Helvetica, sans-serif; font-size: 12px" onLoad="redimenciona()">
<span style="text-align: center"></span>
<div style="text-align:center"></div>
</body>

<?php 


$nombre = $_POST['nombre'];
$empresa = $_POST['empresa'];
$email = $_POST['email'];
$telefono = $_POST['telefono'];
$ciudad = $_POST['ciudad'];
$pais = $_POST['pais'];
$consulta = $_POST['consulta'];


$nombreinmo = "Nombre inmobiliaria";
$emailresponder = "info@rioparanainmuebles.com.ar";

require_once("fzo.mail.php");
$mail = new SMTP("localhost","info@rioparanainmuebles.com.ar","inforioparana");
$de = $emailresponder;
//$a = $_POST['destinatario'];
$a = "buenosairesdance@gmail.com";

$cc = "";
$bcc = "";
$header2 = "From: ".$nombreinmo." <".$emailresponder."> \r\n";
$header2 .= "Reply-To: ".$emailresponder." \r\n";
$header2 .= "MIME-Version: 1.0 \r\n";
$header2 .= "subject: Envio Formulario contacto Rio Parana \r\n";
$header2 .= "Content-type: text/html; charset=UTF-8\n" . "\r\n";
//$email = $_POST['HiddenFieldMailUsuario'];
$message = "hola como andas!!!\n";


# -=-=-=- FINAL BOUNDARY 

$message .= "$mime_boundary\n\n"; 

# -=-=-=- SEND MAIL 

$error = $mail->smtp_send($de, $a, $header2, $message, $cc, $bcc);


?>