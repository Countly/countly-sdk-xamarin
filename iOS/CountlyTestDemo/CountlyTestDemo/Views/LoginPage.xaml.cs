using System;
using System.Collections.Generic;

using Xamarin.Forms;
using CountlySdk;
namespace CountlyTestDemo
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
		public delegate void Action(nuint obj);

		public void Handle_Clicked(object sender, System.EventArgs e)
		{
            DisplayAlert("","Hello","ok");
		}

    }
}
