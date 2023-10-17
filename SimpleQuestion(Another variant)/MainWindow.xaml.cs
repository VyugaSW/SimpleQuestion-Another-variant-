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

namespace SimpleQuestion_Another_variant_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static string Answer = "YES OF COURSE YOU ARE!";

        public MainWindow()
        {
            InitializeComponent();
        }

        private Button ButtonRandomMove(Button button)
        {
            Random rand = new Random();
            button.Margin = new Thickness(rand.Next(400), rand.Next(400), rand.Next(80), rand.Next(80));
            return button;
        }

        private void ButtonYes_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonYes.Content.ToString() == "YES")
                AnswerTextBlock.Text = Answer;
        }

        private void ButtonNo_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonNo.Content.ToString() == "YES")
                AnswerTextBlock.Text = Answer;
        }

        private void ButtonYes_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ButtonYes.Content.ToString() == "NO")
            {
                ButtonYes.Content = "YES";
                ButtonNo.Content = "NO";

                ButtonYes = ButtonRandomMove(ButtonYes);
            }
        }

        private void ButtonNo_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ButtonNo.Content.ToString() == "NO")
            {
                ButtonYes.Content = "NO";
                ButtonNo.Content = "YES";

                ButtonNo = ButtonRandomMove(ButtonNo);
            }
        }
    }
}
