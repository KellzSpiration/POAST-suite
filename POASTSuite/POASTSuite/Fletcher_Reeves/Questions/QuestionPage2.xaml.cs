﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.Fletcher_Reeves.Questions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage2 : ContentPage
    {
        string username;
        FletcherReeves question2;
        public QuestionPage2(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            question2 = new FletcherReeves(-2, 4, 3, 2, -1.5, 1, 2.5, 1);
            functionDisplay.Text = question2.soln.writeFunction();
            xValue.Text = question2.soln.x[0, 0].ToString();
            yValue.Text = question2.soln.x[1, 0].ToString();
            this.username = username;
        }

        async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationPage(question2, username));
        }
    }
}