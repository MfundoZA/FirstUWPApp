using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using FirstUWPApp.domainclasses;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FirstUWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Customer customer;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string cellphoneNumber = txtCellphoneNumber.Text;
            App.SubscriptionTier substriptionTier;

            customer = new Customer(name, cellphoneNumber);
            App.customers.Add(customer);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // this.DataContext = customer;

            lstCustomers.ItemsSource = App.customers;

        }
    }
}
