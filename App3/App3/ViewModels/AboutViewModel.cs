using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App3.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Inicio";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://webchat.botframework.com/embed/botdeapp-bot/gemini?b=botdeapp-bot&s=E3qLHxJSymI.xAq5AacZUisbEj9Mt6YZO8OFpHc99w29mHfOXyDgsz0&username=You"));
        }

        public ICommand OpenWebCommand { get; }
    }
}