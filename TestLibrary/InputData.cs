using System;
using System.Collections.Generic;
using System.Text;

namespace SDKLibrary
{
    public class InputData
    {
       public System.Drawing.Color Color { get; set; } = System.Drawing.Color.Red;
        public List<System.Drawing.PointF> Points { get; set; } = new List<System.Drawing.PointF>();

    }
}
