using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Flower
    {
        public string Name { set; get; }
        public string Color { set; get; }
        public string ImagePath { set; get; }
        public string GrowingArea { set; get; }
        public string Description { set; get; }

        public Flower(string _name, string _color, string _imagePath, string _growingArea, string _description)
        {
            Name = _name;//
            Color = _color;
            ImagePath = _imagePath;
            GrowingArea = _growingArea;
            Description = _description;
        }
    }


    
}
