using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HslSliders.Annotations;
using Xamarin.Forms;

namespace HslSliders
{
    class ColorViewModel : INotifyPropertyChanged
    {
        Color color;
        public event PropertyChangedEventHandler PropertyChanged;


        public double Red
        {
            set
            {
                if (Round(color.R) != value)
                {
                    Color = Color.FromRgba(value, color.G, color.B, color.A);
                }
            }
            get { return Round(color.R); }
        }
        public double Green
        {
            set
            {
                if (Round(color.G) != value)
                    Color = Color.FromRgba(color.R, value, color.B, color.A);
            }
            get
            {
                return Round(color.G);
            }
        }

        public double Blue
        {
            set
            {
                if (Round(color.B) != value)
                    Color = Color.FromRgba(color.R, color.G, value, color.A);
            }
            get { return Round(color.B); }
        }
        public double Alpha
        {
            set
            {
                if (Round(color.A) != value)
                {
                    Color = Color.FromRgba(color.R, color.G, color.B, value);
                }
            }
            get
            {
                return Round(color.A);
            }
        }
        public double Hue
        {
            set
            {
                if (Round(color.Hue) != value)
                    Color = Color.FromHsla(value, color.Saturation, color.Luminosity, color.A);
            }
            get
            {
                return Round(color.Hue);
            }
        }

        public double Saturation
        {
            set
            {
                if (Round(color.Saturation) != value)
                    Color = Color.FromHsla(color.Hue, value, color.Luminosity, color.A);
            }
            get
            {
                return Round(color.Saturation);
            }
        }


        public double Luminosity
        {
            set
            {
                if (Round(color.Luminosity) != value)
                    Color = Color.FromHsla(color.Hue, color.Saturation, value, color.A);
            }
            get
            {
                return Round(color.Luminosity);
            }
        }


        public Color Color
        {
            set
            {
                Color oldColor = color;
                if (color != value)
                {
                    color = value;
                    OnPropertyChanged("Color");
                }
                if (color.R != oldColor.R)
                {
                    OnPropertyChanged("Red");
                }
                if (color.G != oldColor.G)
                {
                    OnPropertyChanged("Green");
                }
                if (color.B != oldColor.B)
                {
                    OnPropertyChanged("Blue");
                }
                if (color.Hue != oldColor.Hue)
                {
                    OnPropertyChanged("Hue");
                }
                if (color.A != oldColor.A)
                {
                    OnPropertyChanged("Alpha");
                }
                if (color.Luminosity != oldColor.Luminosity)
                {
                    OnPropertyChanged("Luminosity");
                }
                if (color.Saturation != oldColor.Saturation)
                {
                    OnPropertyChanged("Saturation");
                }
            }
            get { return color; }
        }

        double Round(double value)
        {
            var result = 0.0;
            //return Device.OnPlatform(value, Math.Round(value, 3), value);
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    result = value;
                    break;
                case Device.Android:
                    result = Math.Round(value, 3);
                    break;
                case Device.WinPhone:
                    result = value;
                    break;

            }
            return result;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
