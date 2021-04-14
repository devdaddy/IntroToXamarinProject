using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MotorMeans
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        async void GoToMakes(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MakesPage());
        }

        async void GoToModels(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ModelsPage());
        }

        async void GoToColors(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaintsPage());
        }

        async void GoToMotors(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MotorsPage());
        }
    }
}
