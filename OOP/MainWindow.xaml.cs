using OOP.Models;
using OOP.Result;
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

            List<BaseResult<string>> results = new List<BaseResult<string>>();

            //BaseResult<string> result = new BaseResult<string>(); //Gaat niet, klasse is abstract
            DbResult db = new DbResult();
            db.IsSucces = false;
            db.RowsAffected = 1;

            ApiResult<BankAccount> api = new ApiResult<BankAccount>();
            api.IsSucces = true;
            api.StatusCode = 200;


            foreach (BaseResult<string> result in results)
            {
                Debug.WriteLine(result.IsSucces);
                Debug.WriteLine(result.StatusCode); // kan niet, zit niet in base klasse
                Debug.WriteLine(result.RowsAffected); // kan niet, zit niet in base klasse

                // kan error geven als result een dbResult is
                Debug.WriteLine((result as ApiResult<string>).StatusCode); 

                if (result is ApiResult<string>)
                {
                    Debug.WriteLine((result as ApiResult<string>).StatusCode);
                }
            }

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