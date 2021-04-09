using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace FrameExo2
{
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        bool OnTimerTick()
        {
            _timePicker.Time = DateTime.Now.TimeOfDay;
            scroller.Date = DateTime.Now;
            return true;
        }
    }
    
}
