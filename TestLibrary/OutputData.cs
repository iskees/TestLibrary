using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Text;

namespace SDKLibrary
{
    public class OutputData
    {
        public OutputData(InputData inputData)
        {
            Image = new System.Drawing.Bitmap(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + System.IO.Path.DirectorySeparatorChar  +"А113СУ01 0d39032a-c665-4734-8380-bee4e45aee94.jpg");
            DateTime = DateTime.Now;
            Graphics g = Graphics.FromImage(Image);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawString(DateTime.ToLongTimeString(), new Font("Tahoma",20),inputData.Color==Color.Red?  Brushes.Red:Brushes.White, new PointF(100,100));
            foreach (var point in inputData.Points)
                g.DrawRectangle(Pens.Red, new Rectangle(Convert.ToInt32(point.X * 600), Convert.ToInt32(point.Y * 600), 10, 10));
            g.Flush();

        }
        public System.Drawing.Bitmap Image { get; set; }
        public DateTime DateTime { get; set; }
    }
}
