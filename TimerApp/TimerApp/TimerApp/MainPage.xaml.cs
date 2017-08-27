using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // fire a periodic event to update the date and time for every second.
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }
        private bool OnTimerTick()
        {
            DateTime dt = DateTime.Now;
            TimeLabel.Text = dt.ToString("T");
            DateLabel.Text = dt.ToString("D");
            return true;
        }
    }
}
