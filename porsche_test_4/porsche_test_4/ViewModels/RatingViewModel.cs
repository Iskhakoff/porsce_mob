using Java.IO;
using Newtonsoft.Json;
using porsche_test_4.Models;
using porsche_test_4.Services;
using porsche_test_4.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace porsche_test_4.ViewModels
{
    public class RatingViewModel : ContentView
    {
        public ObservableCollection<RatingModel> Ratings { get; set; } = new ObservableCollection<RatingModel>();
        //{
        //    new RatingModel
        //    {
        //        FullTitle = "БорисХофф",
        //        Rat = "9.1",


        //    },
        //};

        public async Task RatingAsync()
        {
            var dataService = DataService.GetInstance();
            var rating = await dataService.RatingAsync();
            //var ratings = JsonConvert.DeserializeObject<List<RatingModel>>(rating);

            foreach (var rat in rating)
            {
                
            }
        }

        private Page _page;

        public ICommand OpenProfile { get; set; }

        public ICommand OpenLog { get; set; }

        public RatingViewModel(Page page)
        {
            _page = page;
            OpenProfile = new Command(async () => {
                await _page.Navigation.PushAsync(new SettingsPage());
                });
            OpenLog = new Command(WayOut);
        }

        private void WayOut()
        {
            var app = (App)Application.Current;
            app.MainPage = new NavigationPage(new LoginPage());
        }
    }
    
}
