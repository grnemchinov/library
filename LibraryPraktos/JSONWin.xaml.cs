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
using System.Windows.Shapes;

namespace LibraryPraktos
{
    /// <summary>
    /// Логика взаимодействия для JSONWin.xaml
    /// </summary>
    public partial class JSONWin : Window
    {
        public JSONWin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int result;
            if (int.TryParse(NumOf.Text, out result)){
                List<BasicClass> bases = new List<BasicClass>();
                List<string> Names = new List<string>()
                {
                    "Danya", "Vasya", "Grisha", "Dima", "Maks", "Vladimir", "Ilya", "Konstantin"
                };
                for (int i = 0; i < result; i++)
                {
                    Random random = new Random();
                    BasicClass newuser = new BasicClass(Names[random.Next(0, Names.Count-1)], random.Next(18, 70), random.Next(25000, 50000));
                    bases.Add(newuser);
                }
                JsonSerializer.JsonEnjoyer.saveInfo("D:\\info.json", bases);
            }
            else
            {
                MessageBox.Show("Вы не ввели число!");
            }
        }

        private void GetData_Click(object sender, RoutedEventArgs e)
        {
            List<BasicClass> basicClasses = JsonSerializer.JsonEnjoyer.getInfo<List<BasicClass>>("D:\\info.json");
            List<string> datas = new List<string>();
            foreach (BasicClass basicClass in basicClasses)
            {
                datas.Add($"Name: {basicClass.Name}, Age: {basicClass.Age}, Salary: {basicClass.Salary}");
            }
            Data.ItemsSource = null;
            Data.ItemsSource = datas;
        }
    }
}
