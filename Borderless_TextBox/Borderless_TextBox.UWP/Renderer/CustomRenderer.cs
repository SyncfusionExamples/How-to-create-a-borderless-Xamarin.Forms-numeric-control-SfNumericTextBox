using Borderless_TextBox;
using Borderless_TextBox.UWP;
using Syncfusion.SfNumericTextBox.XForms;
using Syncfusion.SfNumericTextBox.XForms.UWP;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomNumericTextBox), typeof(CustomNumericTextBoxRenderer))]
namespace Borderless_TextBox.UWP
{
    class CustomNumericTextBoxRenderer : SfNumericTextBoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SfNumericTextBox> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
            }
        }
    }
}