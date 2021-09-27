using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM02PH02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btsm_Clicked(object sender, EventArgs e)
        {
            var n1 = Convert.ToDecimal(txtn1.Text);
            var n2 = Convert.ToDecimal(txtn2.Text);

            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(n1 + n2)));

            /*
             await DisplayAlert("Result.Suma", Convert.ToDecimal(n1 + n2) , "OK"); 
            */
        }

        private async void btrst_Clicked(object sender, EventArgs e)
        {
            var n1 = Convert.ToDecimal(txtn1.Text);
            var n2 = Convert.ToDecimal(txtn2.Text);
            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(n1 - n2)));
            //await DisplayAlert("Result.Resta", Convert.ToString(n1 - n2), "OK");
        }

        private async void btmlt_Clicked(object sender, EventArgs e)
        {
            var n1 = Convert.ToDecimal(txtn1.Text);
            var n2 = Convert.ToDecimal(txtn2.Text);
            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(n1 * n2)));
            //await DisplayAlert("Result.Multiplicacion", Convert.ToString(n1 * n2), "OK");
        }

        private async void btndiv_Clicked(object sender, EventArgs e)
        {
            var n1 = Convert.ToDecimal(txtn1.Text);
            var n2 = Convert.ToDecimal(txtn2.Text);
            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(n1 / n2)));
            //await DisplayAlert("Result.Multiplicacion", Convert.ToString(n1 * n2), "OK");
        }
    }
}
