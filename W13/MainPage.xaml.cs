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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace W13
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Customer> ListCustomer = new ObservableCollection<Customer>();
        public MainPage()
        {
            this.InitializeComponent();
            ListCustomer.Add(new Customer() { Name = "Nam" });
            ListCustomer.Add(new Customer() { Name = "Dat" });
            ListCustomer.Add(new Customer() { Name = "Dau Dau" });
            lvCustomer.SelectionChanged += LvCustomer_SelectionChanged;
            sliderFontSize.ValueChanged += SliderFontSize_ValueChanged;
            btSelectColor.Click += BtSelectColor_Click;
        }

        private void BtSelectColor_Click(object sender, RoutedEventArgs e)
        {
            tbName.Foreground = new SolidColorBrush(picker.Color);
        }

        private void SliderFontSize_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            tbName.FontSize = sliderFontSize.Value;
        }

        private void LvCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = lvCustomer.SelectedIndex;
            tbName.Text = ListCustomer[selectedIndex].Name;
        }

        private void LvCustomer_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            //tbName.Text = (lvCustomer.SelectedItem as TextBlock).Text;

        }
    }
}
