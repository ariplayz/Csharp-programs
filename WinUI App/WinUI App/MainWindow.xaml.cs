using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Windowing; // Import this
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI_App
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private List<MainWindow?> allWindows;

        public MainWindow(List<MainWindow?> allWindows)
        {
            this.InitializeComponent();
            ShowImage1();
            this.allWindows = allWindows;
        }

        public void ShowImage1()
        {
            Image1.Source = new BitmapImage(new Uri("https://th.bing.com/th/id/R.1b12fd543c84f4b6232c2360d0ef8a1e?rik=OkTfmva8HExGiA&pid=ImgRaw&r=0"));
            Image1.Visibility = Visibility.Visible;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow(this.allWindows);
            secondWindow.Activate();
        }
    }
}