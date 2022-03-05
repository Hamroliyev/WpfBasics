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

namespace WpfBasics
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is : {DescriptionText.Text}");
        }

        private void ReserButton_Click(object sender, RoutedEventArgs e)
        {
            CheckBoxAssambley.IsChecked = CheckBoxDrill.IsChecked = CheckBoxFold.IsChecked = CheckBoxLaser.IsChecked = CheckBoxLathe.IsChecked =
                CheckBoxPlasma.IsChecked = CheckBoxPurchase.IsChecked = CheckBoxRoll.IsChecked = CheckBoxSaw.IsChecked = CheckBoxWeld.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            LengthText.Text += ((CheckBox)sender).Content.ToString();
        }
        private void FinishDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NoteText ==null)
            {
                return;
            }
            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;

            NoteText.Text = value.Content.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropDown_SelectionChanged(this.FinishDropDown, null);
        }

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            MassText.Text = SupplierNameText.Text;
        }
    }
}
