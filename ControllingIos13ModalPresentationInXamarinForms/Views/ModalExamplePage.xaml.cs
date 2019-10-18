using System.ComponentModel;
using ControllingIos13ModalPresentationInXamarinForms.ViewModels;
using Xamarin.Forms;

namespace ControllingIos13ModalPresentationInXamarinForms.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ModalExamplePage : ContentPage
    {
        ModalExampleViewModel viewModel;

        public ModalExamplePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ModalExampleViewModel()
            {
                // Quick and dirty Navigation for purposes of example, real world would be more sophisticated
                Navigation = Navigation,
            };
        }

    }
}