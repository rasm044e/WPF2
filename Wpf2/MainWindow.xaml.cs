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

namespace Wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;

        public MainWindow()
        {
            controller = Controller.GetInstance();
            InitializeComponent();
            
        }

        private void textBoxFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxAge_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxPhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonNew_Click(object sender, RoutedEventArgs e)
        {
            
            controller.AddPerson(textBoxFirstName.Text, textBoxLastName.Text, textBoxAge.Text, textBoxPhoneNumber.Text);
            labelIndexCounter.Content = controller.PersonIndex;
            labelPersonCounter.Content = controller.PersonCount;
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAge.Text = "";
            textBoxPhoneNumber.Text = "";
           
            
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();
            labelIndexCounter.Content = controller.PersonIndex;
            labelPersonCounter.Content = controller.PersonCount;
            if (controller.CurrentPerson != null)
            {
                textBoxFirstName.Text = controller.CurrentPerson.FirstName;
                textBoxLastName.Text = controller.CurrentPerson.LastName;
                textBoxAge.Text = Convert.ToString(controller.CurrentPerson.Age);
                textBoxPhoneNumber.Text = controller.CurrentPerson.PhoneNumber;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxAge.Text = "";
                textBoxPhoneNumber.Text = "";
            }
        }

        private void buttonUp_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            labelIndexCounter.Content = controller.PersonIndex;
            if (controller.CurrentPerson != null)
            {
                textBoxFirstName.Text = controller.CurrentPerson.FirstName;
                textBoxLastName.Text = controller.CurrentPerson.LastName;
                textBoxAge.Text = Convert.ToString(controller.CurrentPerson.Age);
                textBoxPhoneNumber.Text = controller.CurrentPerson.PhoneNumber;
            }
        }

        private void buttonDown_Click(object sender, RoutedEventArgs e)
        {
            controller.PreviousPerson();
            labelIndexCounter.Content = controller.PersonIndex;
            if (controller.CurrentPerson != null)
            {
                textBoxFirstName.Text = controller.CurrentPerson.FirstName;
                textBoxLastName.Text = controller.CurrentPerson.LastName;
                textBoxAge.Text = Convert.ToString(controller.CurrentPerson.Age);
                textBoxPhoneNumber.Text = controller.CurrentPerson.PhoneNumber;
            }
        }
    }
}
