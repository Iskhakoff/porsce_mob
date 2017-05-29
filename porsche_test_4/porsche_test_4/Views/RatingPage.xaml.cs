using porsche_test_4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace porsche_test_4.Views
{
    public partial class RatingPage : ContentPage
    {
        private readonly RatingViewModel _viewModel;

        public RatingPage()
        {
            InitializeComponent();
            _viewModel = new RatingViewModel(this);
            BindingContext = _viewModel;
        }
        //public void picker_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    header.Text = "Регион: " + picker.Items[picker.SelectedIndex];
        //}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.RatingAsync();
        }
    }

}
