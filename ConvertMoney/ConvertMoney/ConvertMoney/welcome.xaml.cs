using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConvertMoney
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class welcome : ContentPage
    {
        public welcome()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            // await Task.Delay(TimeSpan.FromSeconds(1));
            // await welcome.RelScaleTo(0.3, 250);
            await w.RelScaleTo(0.3, 150);
            await w.ScaleTo(1, 150);
            await e.RelScaleTo(0.3, 150);
            await e.ScaleTo(1, 150);
            await l.RelScaleTo(0.3, 150);
            await l.ScaleTo(1, 150);
            await c.RelScaleTo(0.3, 150);
            await c.ScaleTo(1, 150);
            await o.RelScaleTo(0.3, 150);
            await o.ScaleTo(1, 150);
            await m.RelScaleTo(0.3, 150);
            await m.ScaleTo(1, 150);
            await e2.RelScaleTo(0.3, 150);
            await e2.ScaleTo(1, 150);


            await Task.Delay(TimeSpan.FromSeconds(0.6));
            await pic.ScaleTo(0.40, 250);
            await pic.RelRotateTo(360, 500);
            //await Task.Delay(TimeSpan.FromSeconds(0.5));
            await pic.RelScaleTo(0.6, 750);
            await Navigation.PushAsync(new MainPage());
            this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
            await this.Navigation.PopAsync();
        }
    }
}