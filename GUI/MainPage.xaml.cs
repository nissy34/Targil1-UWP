using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using BE;
using BL;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        IBl bl;
        public MainPage()
        {
            this.InitializeComponent();
            bl = Factory_Bl.GetInstance_List();
            GridView.ItemsSource =new ObservableCollection<Flower>(bl.GetAllFLowersByName(null));
        }

        private void TextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            GridView.ItemsSource = new ObservableCollection<Flower>(bl.GetAllFLowersByName((sender as TextBox).Text));
        }

   

        private void UIElement_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
    }
}
