using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ControllingIos13ModalPresentationInXamarinForms.ViewModels
{
    public class ModalDisplayViewModel : BaseViewModel
    {
        public ICommand CloseCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await Navigation.PopModalAsync();
                });
            }
        }

        public ImageSource Image
        {
            get
            {
                return ImageSource.FromUri(new Uri($"https://picsum.photos/200?{Guid.NewGuid().ToString()}"));
            }
        }

        public ModalDisplayViewModel()
        {
            Title = "Modal Page";
        }
    }
}