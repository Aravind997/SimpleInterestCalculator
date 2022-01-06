using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleInterest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleInterestCalculator : ContentPage
        
    {
        
        public SimpleInterestCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Clicked(object sender, EventArgs e)
        {
            float p = float.Parse(TextBox_PrincipleAmount.Text);
            float n = float.Parse(TextBox_NumberofYears.Text);
            float r = float.Parse(TextBox_RateofInterest.Text);
            float s = ((p * n * r) /100);
            TextBox_InterestAmount.Text = s.ToString();
            float t = (s + p);
            TextBox_TotalAmount.Text = t.ToString();
            
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            TextBox_PrincipleAmount.Text = "0";
            TextBox_NumberofYears.Text = "0";
            TextBox_RateofInterest.Text = "0";
            TextBox_InterestAmount.Text = "0";
            TextBox_TotalAmount.Text = "0";
        }
    }
}
