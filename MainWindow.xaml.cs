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
            btnFirstYearCourses.Visibility = Visibility.Hidden;
            btnMoreCourses.Visibility = Visibility.Hidden;
            btnCourseCont.Visibility = Visibility.Hidden;
            btnCourseCont2.Visibility = Visibility.Hidden;
            btnCourseCont3.Visibility = Visibility.Hidden;
        }

        private void btnEducation_Click(object sender, RoutedEventArgs e)
        {
            lblMainLabel.Content = "Education Requirements";
            txtInformation.Text = "--Prerequisites Required: -English (ENG4U)" + System.Environment.NewLine + "-Advanced Functions (MHF4U) (min.70%) or Calculus and Vectors (MCV4U) (min.70%)" + System.Environment.NewLine + "Recommended Courses: -Computer and Information Sciences (ICS4U)";
            btnFirstYearCourses.Visibility = Visibility.Hidden;
            btnMoreCourses.Visibility = Visibility.Hidden;
            btnCourseCont.Visibility = Visibility.Hidden;
            btnCourseCont2.Visibility = Visibility.Hidden;
            btnCourseCont3.Visibility = Visibility.Hidden;
        }

        private void btncourses_Click(object sender, RoutedEventArgs e)
        {
            lblMainLabel.Content = "Courses";
            txtInformation.Text = "";
            btnFirstYearCourses.Visibility = Visibility.Visible;
            btnMoreCourses.Visibility = Visibility.Visible; 
            btnCourseCont.Visibility = Visibility.Hidden;
            btnCourseCont2.Visibility = Visibility.Hidden;
            btnCourseCont3.Visibility = Visibility.Hidden;

        }

        private void btnCareer_Click(object sender, RoutedEventArgs e)
        {
            lblMainLabel.Content = "Career Paths";
            txtInformation.Text = "List of Career Possibilities" + System.Environment.NewLine +
                "Programmer or systems analyst" + System.Environment.NewLine +
                "Computer graphics developer" + System.Environment.NewLine +
                "Database or network administrator" + System.Environment.NewLine +
                "IT project manager or corporate trainer" + System.Environment.NewLine +
                "Web designer / Internet specialist";
            btnFirstYearCourses.Visibility = Visibility.Hidden;
            btnMoreCourses.Visibility = Visibility.Hidden;
            btnCourseCont.Visibility = Visibility.Hidden;
            btnCourseCont2.Visibility = Visibility.Hidden;
            btnCourseCont3.Visibility = Visibility.Hidden;
        }

        private void btnFirstYearCourses_Click(object sender, RoutedEventArgs e)
        {
            lblMainLabel.Content = "First Year Courses";
            txtInformation.Text = "APCO 1P00 Intro to Media Computation" + System.Environment.NewLine +
                "APCO 1P01 Fluency with Technology" + System.Environment.NewLine +
                "APCO 1P50 Integrity and Literacy in the Information Age" + System.Environment.NewLine +
                "APCO 1P93 Applied Programming"; 
            btnFirstYearCourses.Visibility = Visibility.Hidden;
            btnMoreCourses.Visibility = Visibility.Hidden;
            btnCourseCont.Visibility = Visibility.Visible;
        }

        private void btnMoreCourses_Click(object sender, RoutedEventArgs e)
        {
            lblMainLabel.Content = "General Course Info";
            txtInformation.Text = "Including internships and CO-OPs, there are a total of 64 courses available." + System.Environment.NewLine +
                "The Brock Computer Science Program is a four year program.";
            btnFirstYearCourses.Visibility = Visibility.Hidden;
            btnMoreCourses.Visibility = Visibility.Hidden;
        }

        private void btnCourseCont_Click(object sender, RoutedEventArgs e)
        {
            lblMainLabel.Content = "First Year Courses";
            txtInformation.Text = "COSC 1P02 Introduction to Computer Science" + System.Environment.NewLine +
                "COSC 1P03 Data Structures and Abstraction" + System.Environment.NewLine +
                "COSC 1P50 Integrity and Literacy in the Information Age" + System.Environment.NewLine;
            btnCourseCont.Visibility = Visibility.Hidden;
            btnCourseCont2.Visibility = Visibility.Visible;
        }

        private void btnCourseCont2_Click(object sender, RoutedEventArgs e)
        {
            txtInformation.Text = "MATH 1P01 Calculus I" + System.Environment.NewLine +
                "MATH 1P02 Calculus II" + System.Environment.NewLine +
                "MATH 1P05 Applied Calculus I" + System.Environment.NewLine +
                "MATH 1P06 Applied Calculus II" + System.Environment.NewLine +
                "MATH 1P66 Mathematics for Computer Science I" + System.Environment.NewLine +
                "MATH 1P67 Mathematics for Computer Science II";
            btnCourseCont2.Visibility = Visibility.Hidden;
            btnCourseCont3.Visibility = Visibility.Visible;
        }

        private void btnCourseCont3_Click(object sender, RoutedEventArgs e)
        {
            txtInformation.Text = "MATH 1P97 Differential and Integral Methods" + System.Environment.NewLine +
                "MATH 1P98 Basic Statistical Methods";
            btnCourseCont3.Visibility = Visibility.Hidden;
        }
    }
}
