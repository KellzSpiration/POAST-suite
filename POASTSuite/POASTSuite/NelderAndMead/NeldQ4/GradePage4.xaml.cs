﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.NelderAndMead.NeldQ4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GradePage4 : ContentPage
    {
        private double score;
        public GradePage4(double T2)
        {
            InitializeComponent();
            score = T2;
        }

        private void BtnNxt4_Clicked(object sender, EventArgs e)
        {
            if (score == 100)
            {
                quote.Text = "EXCELLENT!";
            }
            else if (score > 70 && score <= 99)
            {
                quote.Text = "VERY GOOD";
            }
            else if (score < 70 && score >= 50)
            {
                quote.Text = "GOOD";
            }
            else
            {
                quote.Text = "YOU CAN DO BETTER!";
            }

            Score.Text = score + "%".ToString();
          
        }

        private async void BtnSolution_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SolutionPage4());
        }

        private async void SelectionPage4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new WelcomePage(greeting));
        }
    }
}