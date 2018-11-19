using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ButtonBMI.Clicked += ButtonBmiClickEvent;
            ButtonBMI2.Clicked += ButtonClickEvent2;
        }

        private void ButtonClickEvent2(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            float height = float.Parse(EntryHeight.Text);
            int weight = int.Parse(EntryWeight.Text);
            Navigation.PushModalAsync(new NavigationPage(new BmiResult
                (height,weight)));
        }

        private void ButtonBmiClickEvent(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            String a = EntryHeight.Text;
            String b = EntryWeight.Text;
            float height = float.Parse(a);
            int weight = int.Parse(b);

            LabelResult.Text = ""+weight/ (height * height);
            
        }
    }
}
