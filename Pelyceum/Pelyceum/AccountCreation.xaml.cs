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

namespace Pelyceum
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AccountCreation : Page
    {
        public Student CurrentProfile;

        public AccountCreation()
        {
            this.InitializeComponent();

            this.CurrentProfile = new Student("Stu Dent", 18, "O'Dea");
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ContentDialog()
            {
                Content = namebox.Text,
                ///how do with others???
                PrimaryButtonText = "Close"
            };

            this.CurrentProfile.name = namebox.Text;
            this.CurrentProfile.SetAge(int.Parse(agebox.Text));
            //int.parse, take string, convert to number, try parse
            this.CurrentProfile.highschool = schoolbox.Text;

            await dialog.ShowAsync();
        }
    }
}

