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
    public sealed partial class AccountChoice : Page
    {
        public AccountChoice()
        {
            this.InitializeComponent();
        }

        public static string proftype;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            proftype = filebox.Text;
            if (proftype.Equals("Student"))
            {
                this.Frame.Navigate(typeof(StudentCreation));
            }
            else if (proftype.Equals("Counselor"))
            {
                this.Frame.Navigate(typeof(CounselorCreation));
            }
            else if (proftype.Equals("Representative"))
            {
                this.Frame.Navigate(typeof(RepCreation));
            }
            else if (proftype.Equals("Alumnus"))
            {
                this.Frame.Navigate(typeof(AlumCreation));
            }
        }
    }
}
