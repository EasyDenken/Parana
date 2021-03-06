﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Configuration;
using System.IO;
using System.Text;
using System.Security;

namespace RioParana
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContacto_Click(object sender, EventArgs e)
        {
            ProcessRequest(HttpUtility.HtmlEncode(txtNombre.Text), HttpUtility.HtmlEncode(txtEmpresa.Text), HttpUtility.HtmlEncode(txtEmail.Text), HttpUtility.HtmlEncode(txtTelefono.Text), HttpUtility.HtmlEncode(txtCiudad.Text), HttpUtility.HtmlEncode(txtPais.Text), HttpUtility.HtmlEncode(txtConsulta.Text), "CONTACTO");
        }

        private void ProcessRequest(string Nombre, string Empresa, string Email, string Telefono, string Ciudad, string Pais, string Consulta, string subject)
        {
            if (Page.IsValid)
            {               

                var mail = new System.Net.Mail.SmtpClient();
                mail.EnableSsl = false;


                var mailMessage = new MailMessage();
                //bool CanEmail = false;

                using (var mailBodyStream = new StreamReader(Server.MapPath(ConfigurationManager.AppSettings["TEMPATES-PATH-CONTACTO"])))
                {
                    StringBuilder body = new StringBuilder(mailBodyStream.ReadToEnd());
                    body.Replace("[NOMBRE]", SecurityElement.Escape(Nombre));
                    body.Replace("[EMPRESA]", SecurityElement.Escape(Empresa));
                    body.Replace("[EMAIL]", SecurityElement.Escape(Email));
                    body.Replace("[TELEFONO]", SecurityElement.Escape(Telefono));
                    body.Replace("[CIUDAD]", SecurityElement.Escape(Ciudad));
                    body.Replace("[PAIS]", SecurityElement.Escape(Pais));
                    body.Replace("[CONSULTA]", SecurityElement.Escape(Consulta));
                    mailMessage.To.Clear();
                    mailMessage.To.Add(new MailAddress(ConfigurationManager.AppSettings["MAILTO"]));
                    mailMessage.Body = body.ToString();
                    mailMessage.Subject = "Rio Parana: " + SecurityElement.Escape(subject);
                    mailMessage.From = new MailAddress("info@rioparanainmuebles.com.ar");
                    mailMessage.ReplyTo = new MailAddress(Email);
                    
                    mail.Send(mailMessage);

                    clear(txtCiudad);
                    clear(txtConsulta);
                    clear(txtEmail);
                    clear(txtEmpresa);
                    clear(txtNombre);
                    clear(txtPais);
                    clear(txtTelefono);
                }
            }
        }

        private void clear(TextBox txt)
        {
            txt.Text = "";
        }
    }
}