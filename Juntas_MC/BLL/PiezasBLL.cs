using Juntas_MC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juntas_MC.BLL
{
    class PiezasBLL
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string CodigoProveedor { get; set; }
        public decimal Precio { get; set; }
        public int PiezaTipo { get; set; }
        public int Material { get; set; }
        public string Detalles { get; set; }
        public string Imagen { get; set; }
        public int Estado { get; set; }
        [NotMapped]
        public Image Picture
        {
            get
            {
                if (!string.IsNullOrEmpty(Imagen))
                {
                    if (File.Exists(Imagen))
                    {
                        Image im = Image.FromFile(Imagen);
                        Image newImage = ScaleImage(im, 100, 100);

                        return newImage;

                        //return Image.FromFile(Imagen);
                    }
                }
                Image im2 = Resources.image2;
                Image standartImage = ScaleImage(im2, 100, 100);
                return standartImage;
            }
        }
        public decimal PrecioDeVenta { get; set; }

        private static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }
        public string Observaciones { get; set; }
    }
}
