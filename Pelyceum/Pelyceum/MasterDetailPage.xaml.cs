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

namespace Pelyceum
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MasterDetailPage : Page
    {
        private const string DefaultNamespace = "Pelyceum";

        public MasterDetailPage()
        {
            this.InitializeComponent();

            this.navigationView.SelectedItem = this.navigationView.MenuItems.OfType<NavigationViewItem>().First();
            this.navigationView.IsBackEnabled = false;
        }

        private void SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var selectedItem = (NavigationViewItem)args.SelectedItem;
            var tag = (string)selectedItem.Tag;
            var typeName = $"{DefaultNamespace}.{tag}";
            var pageType = Type.GetType(typeName);

            this.contentFrame.Navigate(pageType);
            this.navigationView.IsBackEnabled = true;
        }

        private void BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (!this.contentFrame.CanGoBack)
            {
                return;
            }

            this.contentFrame.GoBack();
            this.navigationView.IsBackEnabled = this.contentFrame.BackStackDepth > 0;
        }

    }
}
