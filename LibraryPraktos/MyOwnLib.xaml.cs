using BaseLogicCalculator;
using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для MyOwnLib.xaml
    /// </summary>
    public partial class MyOwnLib : Window
    {

        List<Button> BUTTONS = new List<Button>();
        public MyOwnLib()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if((e.OriginalSource as Button).Name == "ButtonEq")
            {
                if(Class1.Eval(Field.Content.ToString()) != "error")
                {
                    Field.Content = Class1.Eval(Field.Content.ToString());
                }
                else
                {
                    MessageBox.Show("Cant process it!");
                }
            }
            else if((e.OriginalSource as Button).Name == "ButtonC")
            {
                Field.Content = "";
            }
            else
            {
                Field.Content += (e.OriginalSource as Button).Content.ToString();
            }
        }
    }
}
