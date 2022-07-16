using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace Impresoras.Config
{
    public class clsImagen
    {
        //Byte a Img
        public static MemoryStream byteToImg(byte [] array)
        {
            MemoryStream ms = new MemoryStream((byte[])array);
            return ms;
        }

        // Img a Byte
        public static byte [] imgToByte(Image imgIn)
        {
            MemoryStream ms = new MemoryStream();
            imgIn.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        
    }
}
