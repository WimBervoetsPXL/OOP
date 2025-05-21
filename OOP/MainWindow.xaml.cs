using OOP.Models;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<BankAccount> accounts = new List<BankAccount>();

            for (int i = 0; i < 50; i++) 
            {
                if(i % 2 == 0)
                {
                    accounts.Add(new Zichtrekening());
                }
                else
                {
                    accounts.Add(new Spaarrekening());
                }
            }

            foreach (BankAccount account in accounts) 
            {
                if(account is Spaarrekening)
                {
                    Debug.WriteLine(account.CalculateInterest());
                }
            }
                  
        }
    }
}