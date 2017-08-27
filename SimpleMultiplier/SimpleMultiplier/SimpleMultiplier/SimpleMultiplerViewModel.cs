using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SimpleMultiplier.Annotations;

namespace SimpleMultiplier
{
    class SimpleMultiplerViewModel : INotifyPropertyChanged
    {
        private double multiplicand, multiplier, product;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Multiplicand
        {
            get
            {
                return multiplicand;
            }
            set
            {
                if (multiplicand != value)
                {
                    multiplicand = value;
                    OnPropertyChanged("Multiplicand");
                    UpdateProduct();
                }
            }
        }

        public double Multiplier
        {
            get { return multiplier; }
            set
            {
                if (multiplier != value)
                {
                    multiplier = value;
                    OnPropertyChanged("Multiplier");
                    UpdateProduct();
                }
            }
        }


        public double Product
        {
            get { return product; }
            protected set
            {
                product = value;
                OnPropertyChanged("Product");
            }
        }

        void UpdateProduct()
        {
            Product = Multiplicand * Multiplier;
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
