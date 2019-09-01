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

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random r = new Random();
        int attempts = 0;
        int b1col = 1;
        int b2col = 1;
        int b3col = 1;
        int b4col = 1;

        int b1guesscolour = 1;
        int b2guesscolour = 2;
        int b3guesscolour = 3;
        int b4guesscolour = 4;

        private Button[] buttons = new Button[4];
        private Button[] guessbuttons = new Button[4];

        public MainWindow()
        {
            buttons[0] = b1;
            buttons[1] = b2;
            buttons[2] = b3;
            buttons[3] = b4;

            guessbuttons[0] = b1;
            guessbuttons[1] = b2;
            guessbuttons[2] = b3;
            guessbuttons[3] = b4;

            InitializeComponent();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (b1col < 4)
            {
                b1col++;
            }
            else b1col = 1;

            switch (b1col)
            {
                case 1:
                    b1.Background = Brushes.Red;
                    break;
                case 2:
                    b1.Background = Brushes.Yellow;
                    break;
                case 3:
                    b1.Background = Brushes.LawnGreen;
                    break;
                case 4:
                    b1.Background = Brushes.DeepSkyBlue;
                    break;
                default:
                    break;
            }
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (b2col < 4)
            {
                b2col++;
            }
            else b2col = 1;

            switch (b2col)
            {
                case 1:
                    b2.Background = Brushes.Red;
                    break;
                case 2:
                    b2.Background = Brushes.Yellow;
                    break;
                case 3:
                    b2.Background = Brushes.LawnGreen;
                    break;
                case 4:
                    b2.Background = Brushes.DeepSkyBlue;
                    break;
                default:
                    break;
            }
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (b3col < 4)
            {
                b3col++;
            }
            else b3col = 1;

            switch (b3col)
            {
                case 1:
                    b3.Background = Brushes.Red;
                    break;
                case 2:
                    b3.Background = Brushes.Yellow;
                    break;
                case 3:
                    b3.Background = Brushes.LawnGreen;
                    break;
                case 4:
                    b3.Background = Brushes.DeepSkyBlue;
                    break;
                default:
                    break;
            }
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (b4col < 4)
            {
                b4col++;
            }
            else b4col = 1;

            switch (b4col)
            {
                case 1:
                    b4.Background = Brushes.Red;
                    break;
                case 2:
                    b4.Background = Brushes.Yellow;
                    break;
                case 3:
                    b4.Background = Brushes.LawnGreen;
                    break;
                case 4:
                    b4.Background = Brushes.DeepSkyBlue;
                    break;
                default:
                    break;
            }
        }

        private void Guess_Click(object sender, RoutedEventArgs e)
        {
            attempts++;
            Attempts.Text = (attempts + " attempts");

            if ((b1col == b1guesscolour) && (b2col == b2guesscolour) && (b3col == b3guesscolour) && (b4col == b4guesscolour))
            {
                AnswerPanel.Visibility = Visibility.Visible;
                MessageBox.Show("You have won!");
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
                b4.IsEnabled = false;
            }
            else
            {
                int hintNo = 0;
                int posHintNo = 0;

                if (b1col == 1 || b2col == 1 || b3col == 1 || b4col == 1)
                {
                    if(b1guesscolour == 1)
                    {
                        hintNo++;
                    }
                    if(b2guesscolour == 1)
                    {
                        hintNo++;
                    }
                    if (b3guesscolour == 1)
                    {
                        hintNo++;
                    }
                    if(b4guesscolour == 1)
                    {
                        hintNo++;
                    }
                }

                if (b1col == 2 || b2col == 2 || b3col == 2 || b4col == 2)
                {
                    if (b1guesscolour == 2)
                    {
                        hintNo++;
                    }
                    if (b2guesscolour == 2)
                    {
                        hintNo++;
                    }
                    if (b3guesscolour == 2)
                    {
                        hintNo++;
                    }
                    if (b4guesscolour == 2)
                    {
                        hintNo++;
                    }

                }
                if (b1col == 3 || b2col == 3 || b3col == 3 || b4col == 3)
                {
                    if (b1guesscolour == 3)
                    {
                        hintNo++;
                    }
                    if (b2guesscolour == 3)
                    {
                        hintNo++;
                    }
                    if (b3guesscolour == 3)
                    {
                        hintNo++;
                    }
                    if (b4guesscolour == 3)
                    {
                        hintNo++;
                    }
                }
                if (b1col == 4 || b2col == 4 || b3col == 4 || b4col == 4)
                {
                    if (b1guesscolour == 4)
                    {
                        hintNo++;
                    }
                    if (b2guesscolour == 4)
                    {
                        hintNo++;
                    }
                    if (b3guesscolour == 4)
                    {
                        hintNo++;
                    }
                    if (b4guesscolour == 4)
                    {
                        hintNo++;
                    }
                }

                if(b1col == b1guesscolour)
                {
                    posHintNo++;
                }
                if (b2col == b2guesscolour)
                {
                    posHintNo++;
                }
                if (b3col == b3guesscolour)
                {
                    posHintNo++;
                }
                if (b4col == b4guesscolour)
                {
                    posHintNo++;
                }

                // This needs checked, something is off with the counting....

                HintColourTextField.Text = ("You have " + hintNo + " correct colours.");

                if(posHintNo == 0)
                {
                    HintPositionTextField.Text = ("None are in the correct position");
                }
                else
                {
                    HintPositionTextField.Text = (posHintNo + " are in the correct position.");
                }
            }
        }

        private void NewGameButtonClick(object sender, RoutedEventArgs e)
        {
            attempts = 0;
            //AnswerPanel.Visibility = Visibility.Collapsed;
            StartPanel.Visibility = Visibility.Collapsed;

            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;

            b1guesscolour = r.Next(1, 5);
            b2guesscolour = r.Next(1, 5);
            b3guesscolour = r.Next(1, 5);
            b4guesscolour = r.Next(1, 5);

            for (int i = 0; i < 4; i++)
            {
                switch (b1guesscolour)
                {
                    case 1:
                        b1guess.Background = Brushes.Red;
                        break;
                    case 2:
                        b1guess.Background = Brushes.Yellow;
                        break;
                    case 3:
                        b1guess.Background = Brushes.LawnGreen;
                        break;
                    case 4:
                        b1guess.Background = Brushes.DeepSkyBlue;
                        break;
                    default:
                        break;
                }

                switch (b2guesscolour)
                {
                    case 1:
                        b2guess.Background = Brushes.Red;
                        break;
                    case 2:
                        b2guess.Background = Brushes.Yellow;
                        break;
                    case 3:
                        b2guess.Background = Brushes.LawnGreen;
                        break;
                    case 4:
                        b2guess.Background = Brushes.DeepSkyBlue;
                        break;
                    default:
                        break;
                }
                switch (b3guesscolour)
                {
                    case 1:
                        b3guess.Background = Brushes.Red;
                        break;
                    case 2:
                        b3guess.Background = Brushes.Yellow;
                        break;
                    case 3:
                        b3guess.Background = Brushes.LawnGreen;
                        break;
                    case 4:
                        b3guess.Background = Brushes.DeepSkyBlue;
                        break;
                    default:
                        break;
                }
                switch (b4guesscolour)
                {
                    case 1:
                        b4guess.Background = Brushes.Red;
                        break;
                    case 2:
                        b4guess.Background = Brushes.Yellow;
                        break;
                    case 3:
                        b4guess.Background = Brushes.LawnGreen;
                        break;
                    case 4:
                        b4guess.Background = Brushes.DeepSkyBlue;
                        break;
                    default:
                        break;
                }


            }
        }
    }
}
