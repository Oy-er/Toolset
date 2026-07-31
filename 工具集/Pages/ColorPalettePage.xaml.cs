using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Windows.UI;

namespace 工具集.Pages
{
    public sealed partial class ColorPalettePage : Page
    {
        public ColorPalettePage()
        {
            InitializeComponent();
            ColorPicker.ColorChanged += ColorPicker_ColorChanged;
            UpdateHex(ColorPicker.Color);
        }

        private void ColorPicker_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {
            Color c = args.NewColor;
            Preview.Background = new SolidColorBrush(c);
            UpdateHex(c);
        }

        private void UpdateHex(Color c)
        {
            HexText.Text = $"#{c.R:X2}{c.G:X2}{c.B:X2}  (A={c.A})";
        }
    }
}
