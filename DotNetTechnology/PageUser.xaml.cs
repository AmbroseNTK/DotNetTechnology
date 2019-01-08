using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DotNetTechnology
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageUser : Page
    {
        public PageUser()
        {
            this.InitializeComponent();
            btExit.Click += BtExit_Click;
            btBack.Click += BtBack_Click;
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void BtExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            try
            {
                User user = e.Parameter as User;
                if (user.Username == user.Password)
                {
                    tbHello.Text = "Hello " + user.Username;
                }
                else
                {
                    tbHello.Text = "Invalid username or password";
                }
            }
            catch { }
        }
    }
}
