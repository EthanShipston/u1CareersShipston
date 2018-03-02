using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U1CareersShipston
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBasicInfo_Click(object sender, RoutedEventArgs e)
        {
            lblMainLabel.Content = "Brock University:" + Environment.NewLine + " Bsc Honours: Computer Science";
            txtInformation.Text = "--OUAC Code: BG" + System.Environment.NewLine + "--# of Students in University: 17,877" + System.Environment.NewLine + "--Competitive: No" + System.Environment.NewLine + "--Location: St. Catharines, Ontario." + System.Environment.NewLine + "--Residential cost: Minimum 9,020, Maximum 12,790";
        }

        private void btnEducation_Click(object sender, RoutedEventArgs e)
        {
            lblMainLabel.Content = "Education Requirements";
            txtInformation.Text = "--Prerequisites Required: -English (ENG4U)" + System.Environment.NewLine + "-Advanced Functions (MHF4U) (min.70%) or Calculus and Vectors (MCV4U) (min.70%)" + System.Environment.NewLine + "Recommended Courses: -Computer and Information Sciences (ICS4U)";
        }

        private void btncourses_Click(object sender, RoutedEventArgs e)
        {
            lblMainLabel.Content = "Courses";
            txtInformation.Text = "";
            btnFirstYearCourses.Visibility = Visibility.Visible;
            btnMoreCourses.Visibility = Visibility.Visible;
        }

        private void btnCareer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFirstYearCourses_Click(object sender, RoutedEventArgs e)
        {
            lblMainLabel.Content = "First Year Courses";
            txtInformation.Text = "";
        }

        private void btnMoreCourses_Click(object sender, RoutedEventArgs e)
        {
            lblMainLabel.Content = "Post First Year";
            txtInformation.Text = "";
        }
    }
}
