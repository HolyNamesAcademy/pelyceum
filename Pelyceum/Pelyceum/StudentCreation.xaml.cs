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
    public sealed partial class StudentCreation : Page
    {
        public Student CurrentProfile;

        public StudentCreation()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CurrentProfile = new Student();
            this.CurrentProfile.name = namebox.Text;
            this.CurrentProfile.SetAge(int.Parse(agebox.Text));
            this.CurrentProfile.highschool = schoolbox.Text;
            StoredProfile.CurrentProfile = this.CurrentProfile;
            this.Frame.Navigate(typeof(AccountDetailsPage)); 
        }

        //private void SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        //{
        //    var selectedItem = (NavigationViewItem)args.SelectedItem;
        //    var tag = (string)selectedItem.Tag;
        //    var typeName = $"{DefaultNamespace}.{tag}";
        //    var pageType = Type.GetType(typeName);
        //    if (tag.Equals("AccountDetails"))
        //    {
        //        if (StoredProfile.CurrentProfile == null)
        //        {
        //            pageType = typeof(AccountCreation);
        //        }
        //        else
        //        {
        //            pageType = typeof(AccountDetailsPage);
        //        }
        //        //go to display, pageType = typeof(*name of class*)
        //        //else
        //        //go to create, pageType = typeof(*name of class*)
        //    }
        //    //else ???


        //    this.contentFrame.Navigate(pageType);
        //    this.navigationView.IsBackEnabled = true;
        //}
    }
}

