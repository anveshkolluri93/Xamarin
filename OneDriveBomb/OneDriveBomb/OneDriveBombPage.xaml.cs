using System;
using Xamarin.Forms;

namespace OneDriveBomb
{
    //Is like the main class
    public partial class OneDriveBombPage : ContentPage
    {
        //Assigning bomb to a random button in the four buttons
        static string bomb = new Random().Next(1, 5).ToString();
        static int scores = 0;

        public OneDriveBombPage() {
            InitializeComponent();
        }

        async void ButtonClicked(object sender, EventArgs e){
            Button button = sender as Button;

            if(button.Text == bomb){
                await DisplayAlert("!!BOOM!! You are burn't.", "Game Over", "Retry");
                bomb = new Random().Next(1, 5).ToString();
                scores = 0;
            }
            else{
                scores += 1;
                await DisplayAlert("Bomb Diffused", "Score = " + scores, "Continue");
                bomb = new Random().Next(1, 5).ToString();
            }
        }
    }
}
