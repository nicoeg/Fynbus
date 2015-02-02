using Fynbus.Models;
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

namespace Fynbus {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        List<Button> _companies;
        ObservableCollection<Firm> firms;
        public MainWindow() {
            InitializeComponent();
            _companies = new List<Button>();
            
            AddCompany("Fynbus");
            AddCompany("Sydtrafik");
            AddCompany("Midttrafik");

            MakeTabs();

            firms = new ObservableCollection<Firm>() {
                new Firm(24343543, "Vognmanden.com", 3343534),
                new Firm(2324434, "Vognmand Harding Poulsen", 43435),
                new Firm(434535, "Erik Nielsen & Søn transport", 3432)
            };
            Firms.DataContext = firms;
        }

        private void AddCompany(string name) {
            _companies.Add(new Button() { Content = name });
        }
        private void MakeTabs() {
            double width = 336 / _companies.Count;
            foreach (Button button in _companies) {
                button.Width = width;
                Tabs.Children.Add(button);
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
