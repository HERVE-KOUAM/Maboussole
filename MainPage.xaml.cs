using System.Runtime.CompilerServices;

namespace Maboussole
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            DisplayAlert("La boussole", $" La nouvelle direction est {rotationLabel.Text} ", "ok");

        }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double rotation = ((Slider)sender).Value;
            rotationLabel.Text = rotation + "°";
            boussoleImg.RotateTo(rotation);
                
        
        }
        
    }

}
