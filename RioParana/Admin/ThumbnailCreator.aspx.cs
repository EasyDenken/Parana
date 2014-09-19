using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Drawing;

public partial class ThumbnailCreator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string imgPath;
        if (Request.QueryString["ImageId"] != null)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ImageId"].ToString()))
            {
                imgPath = Request.QueryString["ImageId"].ToString();
                if (!string.IsNullOrEmpty(imgPath))
                {

                    
                    bool grande;
                    try 
                    { 
                        if (Request.QueryString["img"].ToString() != null)
                            grande = true;
                        else 
                            grande = false;
                    }
                    catch 
                    { 
                        grande = false;
                    }
                    if (grande)
                    {
                        string aux = "";
                        aux = imgPath.Substring(0, imgPath.IndexOf("_thumb"));
                        aux = aux + imgPath.Substring(imgPath.IndexOf("_thumb") + 6, 4);
                        byte[] imgByte = GetImageByteArr(new Bitmap(aux));
                        Context.Response.ContentType = "image/gif";
                        Context.Response.BinaryWrite(imgByte);
                    }
                    else
                    {
                        byte[] imgByte = GetImageByteArr(new Bitmap(imgPath));
                        MemoryStream memoryStream = new MemoryStream();
                        memoryStream.Write(imgByte, 0, imgByte.Length);
                        System.Drawing.Image imagen = System.Drawing.Image.FromStream(memoryStream);
                        Response.ContentType = "image/Jpeg";
                        ImageResize ir = new ImageResize();
                        ir.File = imagen;
                        ir.Height = imagen.Size.Height;
                        ir.Width = imagen.Size.Width;
                        ir.GetThumbnail().Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
            }
        }
    }
    private static byte[] GetImageByteArr(System.Drawing.Image img)
    {
        byte[] ImgByte;
        using (MemoryStream stream = new MemoryStream())
        {
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            ImgByte = stream.ToArray();
        }
        return ImgByte;
    }
}
