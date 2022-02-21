using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiplomProject1
{
    public partial class MainPage : ContentPage
    {
        bool loaded = false;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            BtnEntry.Clicked += BtnEntry_Clicked;
            //base.OnAppearing();
            //if (loaded == false)
            //{
            //    DisplayStack();
            //    loaded = true;
            //}
        }
        //protected internal void DisplayStack()
        //{
        //    NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        //    stackLabel.Text = "";
        //    foreach (Page p in navPage.Navigation.NavigationStack)
        //    {
        //        stackLabel.Text += p.Title + "\n";
        //    }
        //}

        private async void BtnEntry_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        //protected override void OnAppearing()
        //{
        //    StackLayout layout1 = new StackLayout();

        //    Entry дщп = new Entry()
        //    {
        //        Placeholder = "Логин"

        //    };

        //    Entry pass = new Entry()
        //    {
        //        Placeholder = "Пароль",
        //        IsPassword = true

        //    };

        //    layout1.Children.Add(pass);
        //    Content = layout1;
        //}
    }
}
