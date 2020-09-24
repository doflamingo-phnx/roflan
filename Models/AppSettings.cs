using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotapp.azurewebsites.net:433/{0}";
        public static string Name { get; set; } = "mingo_bot";
        public static string Key { get; set; } = "1182414567:AAFTVg1bJcErTzf3BaY0zXSuOhZYfpf0Ns8";
    }
}