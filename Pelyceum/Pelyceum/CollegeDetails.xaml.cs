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
    public sealed partial class CollegeDetails : Page
    {
        public College firstCollege;

        public CollegeDetails()
        {
            this.InitializeComponent();

            this.firstCollege = new College("Fornell's Univeristy", 360000)
            {
                loc = "Virginia",
                phone = "617-845-9204",
                avtuit = 560000,
                mail = "admissions@fornellu.com",
                site = "www.fornellU.org",
                comapp = false
            };
        }
    }
}
