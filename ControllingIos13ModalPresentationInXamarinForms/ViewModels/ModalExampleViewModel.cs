using System.Windows.Input;
using ControllingIos13ModalPresentationInXamarinForms.Views;
using Xamarin.Forms;

namespace ControllingIos13ModalPresentationInXamarinForms.ViewModels
{
    public class ModalExampleViewModel : BaseViewModel
    {
        public bool UseIos13FullScreenModal { get; set; }

        public ICommand DefaultCommand
        {
            get
            {
                return new Command(() =>
               {
                   Device.BeginInvokeOnMainThread(async () =>
                   {
                        // Obviously in a real application this would be more sophisticated or concrete here, but for
                        // the purposes of this demo we're just doing a quick n dirty to illustrate things
                        App.UseIos13FullScreenModal = UseIos13FullScreenModal;
                       await Navigation.PushModalAsync(new NavigationPage(new ModalDisplayPage()));
                   });
               });
            }
        }

        public ModalExampleViewModel()
        {
            Title = "iOS 13 Full Screen Modal";
        }
    }
}
