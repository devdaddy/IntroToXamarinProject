using System;
using System.Collections.Generic;

namespace MotorMeans.ViewModels
{
    public class PaintModel : BaseViewModel
    {
        public PaintModel()
        {
            Paints = new List<Paint>();
            Paints.Add(new Paint() { ColorCode = "#014025", ColorName = "British Racing Green" });
            Paints.Add(new Paint() { ColorCode = "#F6ED00", ColorName = "Fly Yellow" });
            Paints.Add(new Paint() { ColorCode = "#49A1F1", ColorName = "Grabber Blue" });
            Paints.Add(new Paint() { ColorCode = "#008A78", ColorName = "Grabber Green" });
            Paints.Add(new Paint() { ColorCode = "#E9602D", ColorName = "Hugger Orange" });
            Paints.Add(new Paint() { ColorCode = "#4BB417", ColorName = "Kelly Green" });
            Paints.Add(new Paint() { ColorCode = "#F4539A", ColorName = "Panther Pink" });
            Paints.Add(new Paint() { ColorCode = "#463E7A", ColorName = "Plum Crazy" });
            Paints.Add(new Paint() { ColorCode = "#DA2524", ColorName = "Rossa Corsa" });
            Paints.Add(new Paint() { ColorCode = "#FFED4D", ColorName = "Top Banana" });
        }

        public List<Paint> Paints { get; private set; }

        private string colorCode = "";
        public string ColorCode
        {
            get
            {
                return colorCode;
            }
            set
            {
                if (colorCode != value)
                {
                    colorCode = value;
                    OnPropertyChanged(nameof(ColorCode));
                }
            }
        }

        private string colorName = "";
        public string ColorName
        {
            get
            {
                return colorName;
            }
            set
            {
                if (colorName != value)
                {
                    colorName = value;
                    OnPropertyChanged(nameof(ColorName));
                }
            }
        }
    }


    public class Paint
    {
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
    }
}
