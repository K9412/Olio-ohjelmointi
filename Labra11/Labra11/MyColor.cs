using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Drawing;

namespace Labra11
{
    class MyColor : INotifyPropertyChanged
    {
        private int red, green, blue;

        public int Red
        {
            get
            {
                return red;
            }
            set
            {
                if (red != value)
                {
                    red = value;
                    RaisePropertyChanged("Red");
                }
            }
        }
        public int Green
        {
            get
            {
                return green;
            }
            set
            {
                if (green != value)
                {
                    green = value;
                    RaisePropertyChanged("Green");
                }
            }
        }
        public int Blue
        {
            get
            {
                return blue;
            }
            set
            {
                if (blue != value)
                {
                    blue = value;
                    RaisePropertyChanged("Blue");
                }
            }
        }
        public string Hex
        {
            get
            {
                string hex = "#";
                hex += red.ToString("X2");
                hex += green.ToString("X2");
                hex += blue.ToString("X2");
                return hex;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
