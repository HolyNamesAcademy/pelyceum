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
    public sealed partial class CollegesPage : Page
    {
        public List<College> Colleges {get; set; }
        public CollegesPage()
        {
            this.InitializeComponent();

            this.Colleges = new List<College>();
            this.Colleges.Add(new College("Harvard University", "Cambridge, Massachusetts"));
            this.Colleges.Add(new College("Washington State University", "Pullman, Washington"));
            this.Colleges.Add(new College("University of Washington", "Seattle, Washington"));
            this.Colleges.Add(new College("Lehigh University", "Bethlehem, Pennsylvania"));
            this.Colleges.Add(new College("Purdue University" , "West Lafayette, Indiana"));
            this.Colleges.Add(new College("University of Rochester" , "Rochester, New York"));
            this.Colleges.Add(new College("Elon University", "Elon, North Carolina"));
            this.Colleges.Add(new College("Wake Forest University", "Winston-Salem, North Carolina"));
            this.Colleges.Add(new College("Santa Clara University", "Santa Clara California"));
            this.Colleges.Add(new College("Loyola Marymount University" , "Los Angeles, California"));
            this.Colleges.Add(new College("College of the Holy Cross", "Worcester, Massachusetts"));
            this.Colleges.Add(new College("Boston College" , "Chestnut Hill, Massachusetts"));
            this.Colleges.Add(new College("University of Richmond", "Richmond, Virginia"));
            this.Colleges.Add(new College("Villanova University", "Villanova, Pennsylvania"));
            this.Colleges.Add(new College("University of Notre Dame", "South Bend, Indiana"));
            this.Colleges.Add(new College("University of Michigan", "An"));
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            College ClickedCollege = (College)e.ClickedItem;
            this.Frame.Navigate(typeof(CollegeDetails));

        }

        private void SearchButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
