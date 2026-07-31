using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about project templates, see: http://aka.ms/winui-project-info.

namespace 工具集
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Hide the default system title bar.
            ExtendsContentIntoTitleBar = true;
            // Replace system title bar with the WinUI TitleBar.
            SetTitleBar(AppTitleBar);

            // 默认选中“最大公因数”并导航到对应页面
            NavView.SelectedItem = NavView.MenuItems[0];
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem is NavigationViewItem item && item.Tag is string tag)
            {
                Type? pageType = tag switch
                {
                    "GCD" => typeof(Pages.GCDPage),
                    "ColorPalette" => typeof(Pages.ColorPalettePage),
                    "Settings" => typeof(Pages.SettingsPage),
                    "About" => typeof(Pages.AboutPage),
                    _ => null
                };

                if (pageType is not null)
                {
                    ContentFrame.Navigate(pageType, null, args.RecommendedNavigationTransitionInfo);
                }
            }
        }
    }
}
