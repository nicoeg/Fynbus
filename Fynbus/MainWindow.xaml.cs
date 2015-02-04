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

<<<<<<< HEAD
            // Showing firms for first company
            ShowFirms(1);
        }

        private void ShowFirms(int company) {
            ObservableCollection<ModelLayer.Models.Firm> firms = new ObservableCollection<ModelLayer.Models.Firm>(_controller.GetFirmsFromCompany(company));
=======
            // Kan laves i controlleren
            ObservableCollection<ModelLayer.Models.Firm> firms = new ObservableCollection<ModelLayer.Models.Firm>(_controller.GetFirmsFromCompany(1));
            /*foreach (ModelLayer.Models.Firm firm in _controller.GetFirmsFromCompany(1)) {
                firms.Add(firm);
            }
            firms = new ObservableCollection<Firm>() {
                new Firm(24343543, "Vognmanden.com", 3343534),
                new Firm(2324434, "Vognmand Harding Poulsen", 43435),
                new Firm(434535, "Erik Nielsen & Søn transport", 3432)
            };*/
>>>>>>> origin/master
            Firms.DataContext = firms;
        }

        private void AddCompany(int id, string name) {
<<<<<<< HEAD
            Button button = new Button() { Content = name, Name="id"+id };
=======
            Button button = new Button() { Name= "id"+id, Content = name };
>>>>>>> origin/master
            button.Click += new RoutedEventHandler(this.Tab_Click);
            _companyButtons.Add(button);
        }

        private void Tab_Click(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
<<<<<<< HEAD
            int company = int.Parse(button.Name.Replace("id", ""));

            ShowFirms(company);
=======
            MessageBox.Show((string)button.Name);
>>>>>>> origin/master
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
<<<<<<< HEAD
            foreach (KeyValuePair<int, string> company in _controller.GetAllCompanies())
            {
                AddCompany(company.Key, company.Value);
=======
            foreach (KeyValuePair<int, string> kvp in _controller.GetAllCompanies())
            {
                AddCompany(kvp.Key, kvp.Value);
>>>>>>> origin/master
            }
        }

        private void ShowOffers_Click(object sender, RoutedEventArgs e) {
            Button cmd = (Button)sender;

            // Skal fixe så den er i controller
            if (cmd.DataContext is ModelLayer.Models.Firm) {
                ModelLayer.Models.Firm firm = (ModelLayer.Models.Firm)cmd.DataContext;
                Firms.SelectedItem = firm;
                MessageBox.Show("Tlf: " + firm.Telephone);
            }
        }
    }
}
