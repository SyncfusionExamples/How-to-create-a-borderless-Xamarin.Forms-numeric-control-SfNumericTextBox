# How-to-create-a-borderless-Xamarin.Forms-numeric-control-SfNumericTextBox-

This article explains How to create a borderless Xamarin.Forms numeric control (SfNumericTextBox)

The SfNumericTextBox control is an advanced version of the Entry control that restricts input to numeric values.

If you want to get Borderless_NumeircTextBox, you can disable the border using custom renderer and the output will be like this

 ![Output image of Borderless_NumeircTextBox](Borderless_NumeircTextBox.png)
 
## Creating the above UI

You can achieve the above UI using the below code snippet

[C#]

```
public class CustomNumericTextBox: SfNumericTextBox
{

} 
```

[XAML]

```
<StackLayout>

<borderless_textbox:CustomNumericTextBox Value="123" HorizontalOptions="Center" VerticalOptions="Center" />

</StackLayout>
```

[CustomNumericTextBoxRenderer_Droid]

```
    protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox> e)
    {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = null;
            }
        }
    }

``` 

[CustomNumericTextBoxRenderer_iOS]

```
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
``` 

[CustomNumericTextBoxRenderer_UWP]

```
        protected override void OnElementChanged(ElementChangedEventArgs<SfNumericTextBox> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
            }
        }
```    

## See also

[How to set the text color, Background color, watermark color, border color in Xamarin Numeric Entry (SfNumericTextBox)](https://help.syncfusion.com/xamarin/numeric-entry/colors)

[How to set the maximum number of Decimal Digits in Xamarin Numeric Entry (SfNumericTextBox)](https://help.syncfusion.com/xamarin/numeric-entry/set-maximum-number-of-decimal-digits)

[How to set the range support in Xamarin Numeric Entry (SfNumericTextBox)](https://help.syncfusion.com/xamarin/numeric-entry/range-support)

[How to provide selection support in Xamarin Numeric Entry (SfNumericTextBox)](https://help.syncfusion.com/xamarin/numeric-entry/set-selectallonfocus)

[How to provide Return Type in Xamarin Numeric Entry (SfNumericTextBox)](https://help.syncfusion.com/xamarin/numeric-entry/return-type)


