using System;
using System.Collections.Generic;
using ControllingIos13ModalPresentationInXamarinForms.ViewModels;
using Xamarin.Forms;

namespace ControllingIos13ModalPresentationInXamarinForms.Views
{
    public partial class ModalDisplayPage : ContentPage
    {
        ModalDisplayViewModel viewModel;

        public ModalDisplayPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ModalDisplayViewModel()
            {
                // Quick and dirty Navigation for purposes of example, real world would be more sophisticated
                Navigation = Navigation,
            };
        }
    }
}
