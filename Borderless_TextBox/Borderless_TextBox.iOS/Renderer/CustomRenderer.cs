using Borderless_TextBox;
using Borderless_TextBox.iOS;
using Syncfusion.SfNumericTextBox.XForms;
using Syncfusion.SfNumericTextBox.XForms.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomNumericTextBox), typeof(CustomNumericTextBoxRenderer))]
namespace Borderless_TextBox.iOS
{
    class CustomNumericTextBoxRenderer : SfNumericTextBoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SfNumericTextBox> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
                Control.Layer.CornerRadius = 0f;
                Control.Layer.BorderColor = Color.Transparent.ToCGColor();
                Control.Layer.BorderWidth = 0;
            }
        }
    }
}