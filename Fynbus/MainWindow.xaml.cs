using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using ControllerLayer;

namespace ModelLayer {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        ControllerLayer.Controller _controller;

        List<Button> _companyButtons;
        public MainWindow() {

            InitializeComponent();

            _controller = new Controller();

            MakeTabs();

            /*firms = new ObservableCollection<Firm>() {
                new Firm(24343543, "Vognmanden.com", 3343534),
                new Firm(2324434, "Vognmand Harding Poulsen", 43435),
                new Firm(434535, "Erik Nielsen & Søn transport", 3432)
            };
            Firms.DataContext = firms;*/
        }

        private void AddCompany(string name) {
            _companyButtons.Add(new Button() { Content = name });
        }
        private void MakeTabs() {
            _companyButtons = new List<Button>();

            MakeButtons();

            double width = Tabs.Width / _companyButtons.Count;

            foreach (Button button in _companyButtons) {
                button.Width = width;
                Tabs.Children.Add(button);
            }
        }

        private void MakeButtons()
        {
            foreach (string companyName in _controller.GetAllCompanyNames())
            {
                AddCompany(companyName);
            }
        }

        private void ShowOffers_Click(object sender, RoutedEventArgs e) {
            Button cmd = (Button)sender;
            if (cmd.DataContext is Firm) {
             
                Firm firm = (Firm)cmd.DataContext;
                Firms.SelectedItem = firm;
                //MessageBox.Show("Tlf: " + firm.Telephone);
                // fris er bøs
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            
        }
    }
}
