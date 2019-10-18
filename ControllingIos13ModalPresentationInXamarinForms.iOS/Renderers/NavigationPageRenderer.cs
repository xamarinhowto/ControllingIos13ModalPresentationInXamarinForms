using System;
using ControllingIos13ModalPresentationInXamarinForms.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(NavigationPageRenderer))]
namespace ControllingIos13ModalPresentationInXamarinForms.iOS.Renderers
{
    public class NavigationPageRenderer : NavigationRenderer
    {
        public override void WillMoveToParentViewController(UIViewController parent)
        {
            try
            {
                if (parent != null)
                {
                    if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0) )
                    {
                        // Obviously in a real application this would be more sophisticated or concrete here, but for
                        // the purposes of this demo we're just doing a quick n dirty check to illustrate things
                        parent.ModalPresentationStyle = App.UseIos13FullScreenModal ? UIModalPresentationStyle.FullScreen : UIModalPresentationStyle.Automatic;
                    }
                }

                base.WillMoveToParentViewController(parent);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}
