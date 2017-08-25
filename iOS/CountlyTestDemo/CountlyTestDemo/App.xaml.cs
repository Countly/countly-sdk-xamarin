using System.Collections.Generic;

using Xamarin.Forms;

namespace CountlyTestDemo
{
    public partial class App : Application
    {
      

      
        public App()
        {
            InitializeComponent();

           

            SetMainPage();
        }

        public static void SetMainPage()
        {
           
                Current.MainPage = new NavigationPage(new LoginPage())
                {
                    BarBackgroundColor = (Color)Current.Resources["Primary"],
                    BarTextColor = Color.White
                };

           
        }


    }
}
