using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace porsche_test_4.ViewModels
{
    public class SettingsViewModel : ContentView
    {
        public string ImageUser { get; set; } = "http://telegraf.com.ua/files/2016/11/cat.jpg";

        public string FullNameUser { get; set; } = "Исхаков Дмитрий Витальевич";
        public string StatusUser { get; set; } = "Генеральный директор";
    }
}
