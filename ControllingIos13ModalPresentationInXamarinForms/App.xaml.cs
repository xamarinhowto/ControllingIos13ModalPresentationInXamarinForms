using ControllingIos13ModalPresentationInXamarinForms.Views;
using Xamarin.Forms;

namespace ControllingIos13ModalPresentationInXamarinForms
{
    public partial class App : Application
    {
        public static bool UseIos13FullScreenModal { get; set; }
        
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
