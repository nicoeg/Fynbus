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

            // Making tabs for companies
            MakeTabs();

            // Showing firms for first company
            ShowFirms(1);
        }

        private void ShowFirms(int company) {
            ObservableCollection<ModelLayer.Models.Firm> firms = new ObservableCollection<ModelLayer.Models.Firm>(_controller.GetFirmsFromCompany(company));
            Firms.DataContext = firms;
        }

        private void AddCompany(int id, string name) {
            Button button = new Button() { Content = name, Name = "id" + id };
            button.Click += new RoutedEventHandler(this.Tab_Click);
            _companyButtons.Add(button);
        }

        private void Tab_Click(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
            int company = int.Parse(button.Name.Replace("id", ""));

            ShowFirms(company);
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

        private void MakeButtons() {
            foreach (KeyValuePair<int, string> company in _controller.GetAllCompanies()) {
                AddCompany(company.Key, company.Value);
            }
        }

        private void ShowOffers_Click(object sender, RoutedEventArgs e) {
            Button cmd = (Button)sender;

            if (cmd.DataContext is ModelLayer.Models.Firm) {
                ModelLayer.Models.Firm firm = (ModelLayer.Models.Firm)cmd.DataContext;
                Firms.SelectedItem = firm;
                MessageBox.Show("Tlf: " + firm.Telephone);
            }
        }
    }
}