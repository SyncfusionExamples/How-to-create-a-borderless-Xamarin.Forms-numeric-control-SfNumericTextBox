using Android.Graphics.Drawables;
using Borderless_TextBox;
using Borderless_TextBox.Droid;
using Syncfusion.SfNumericTextBox.XForms.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomNumericTextBox), typeof(CustomNumericTextBoxRenderer))]
namespace Borderless_TextBox.Droid
{
    public class CustomNumericTextBoxRenderer : SfNumericTextBoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = null;
            }
        }
    }
}