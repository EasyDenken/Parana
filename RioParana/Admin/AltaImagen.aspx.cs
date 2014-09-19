using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;

namespace RioParana.Admin
{
    public partial class AltaImagen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IdInmueble"] == null || Session["IdInmueble"].ToString() == "")
                Response.Redirect("Propiedades.aspx");
        }
        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            if (revImagenJPG.IsValid)
            {

                if (DropDownListImage.SelectedValue.ToString() != "NumeroDeImagen")
                {
                    //Path to store uploaded files on server - make sure your paths are unique

                    //string Id = Session["IdInmueble"].ToString();

                    string filePath = "~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + DropDownListImage.SelectedValue.ToString();
                    string thumbPath = "~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + DropDownListImage.SelectedValue.ToString() + "_thumb";

                    // Check that there is a file
                    if (fileUploader.PostedFile != null)
                    {
                        // Check file size (mustn’t be 0)
                        HttpPostedFile myFile = fileUploader.PostedFile;
                        int nFileLen = myFile.ContentLength;
                        if ((nFileLen > 0) && (System.IO.Path.GetExtension(myFile.FileName).ToLower() == ".jpg"))
                        {
                            // Read file into a data stream
                            byte[] myData = new Byte[nFileLen];
                            myFile.InputStream.Read(myData, 0, nFileLen);
                            myFile.InputStream.Dispose();

                            // Save the stream to disk as temporary file. make sure the path is unique!
                            System.IO.FileStream newFile
                                    = new System.IO.FileStream(Server.MapPath(filePath + "_temp.jpg"),
                                                               System.IO.FileMode.Create);
                            newFile.Write(myData, 0, myData.Length);

                            // run ALL the image optimisations you want here..... make sure your paths are unique
                            // you can use these booleans later if you need the results for your own labels or so.
                            // dont call the function after the file has been closed.
                            bool success = ResizeImageAndUpload(newFile, thumbPath, 199, 260);
                            success = ResizeImageAndUpload(newFile, filePath, 768, 1024);

                            // tidy up and delete the temp file.
                            newFile.Close();
                            System.IO.File.Delete(Server.MapPath(filePath + "_temp.jpg"));
                        }

                        Image1.ImageUrl = "~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + DropDownListImage.SelectedValue.ToString() + "_thumb.jpg";

                        Image1.Visible = true;

                        lblImagen.Visible = true;

                        btnEliminarImagen.Visible = true;
                    }
                }
            }
        }

        public bool ResizeImageAndUpload(System.IO.FileStream newFile, string folderPathAndFilenameNoExtension, double maxHeight, double maxWidth)
        {

            try
            {

                // Declare variable for the conversion
                float ratio;

                // Create variable to hold the image
                System.Drawing.Image thisImage = System.Drawing.Image.FromStream(newFile);

                // Get height and width of current image
                int width = (int)thisImage.Width;
                int height = (int)thisImage.Height;

                // Ratio and conversion for new size
                if (width > maxWidth)
                {
                    ratio = (float)width / (float)maxWidth;
                    width = (int)(width / ratio);
                    height = (int)(height / ratio);
                }

                // Ratio and conversion for new size
                if (height > maxHeight)
                {
                    ratio = (float)height / (float)maxHeight;
                    height = (int)(height / ratio);
                    width = (int)(width / ratio);
                }

                // Create "blank" image for drawing new image
                Bitmap outImage = new Bitmap(width, height);
                Graphics outGraphics = Graphics.FromImage(outImage);
                SolidBrush sb = new SolidBrush(System.Drawing.Color.White);


                // Fill "blank" with new sized image
                outGraphics.FillRectangle(sb, 0, 0, outImage.Width, outImage.Height);
                outGraphics.DrawImage(thisImage, 0, 0, outImage.Width, outImage.Height);
                sb.Dispose();
                outGraphics.Dispose();
                thisImage.Dispose();

                // Save new image as jpg
                outImage.Save(Server.MapPath(folderPathAndFilenameNoExtension + ".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                outImage.Dispose();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        protected void DropDownListImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean strFoto;
            string strRutaFoto = Server.MapPath("~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + DropDownListImage.SelectedValue.ToString() + "_thumb.jpg");
            strFoto = (System.IO.File.Exists(strRutaFoto));
            if (strFoto)
            {
                Image1.ImageUrl = "~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + DropDownListImage.SelectedValue.ToString() + "_thumb.jpg";
                Image1.Visible = true;
                lblImagen.Visible = true;
                btnEliminarImagen.Visible = true;
            }
            else
            {
                Image1.Visible = false;
                lblImagen.Visible = false;
                btnEliminarImagen.Visible = false;
            }
        }
        protected void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.Delete(Server.MapPath("~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + DropDownListImage.SelectedValue.ToString() + ".jpg"));
                System.IO.File.Delete(Server.MapPath("~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + DropDownListImage.SelectedValue.ToString() + "_thumb.jpg"));
                Image1.Visible = false;
                lblImagen.Visible = false;
                btnEliminarImagen.Visible = false;

            }
            catch
            {
            }

        }

        private bool checkFileType(string fileName)
        {
            string fileExt = Path.GetExtension(fileUploader.FileName);

            switch (fileExt.ToLower())
            {
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }

        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("FichaPropiedad.Aspx");
            }
            catch { }
        }
    }
}