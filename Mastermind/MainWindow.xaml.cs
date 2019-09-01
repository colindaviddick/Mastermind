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

        int[] buttonColours = new int[4];

        //int buttonColours[0] = 1;
        //int buttonColours[1] = 1;
        //int buttonColours[2] = 1;
        //int buttonColours[3] = 1;

        int b1guesscolour = 1;
        int b2guesscolour = 2;
        int b3guesscolour = 3;
        int b4guesscolour = 4;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (buttonColours[0] < 4)
            {
                buttonColours[0]++;
            }
            else buttonColours[0] = 1;

            switch (buttonColours[0])
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
            if (buttonColours[1] < 4)
            {
                buttonColours[1]++;
            }
            else buttonColours[1] = 1;

            switch (buttonColours[1])
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
            if (buttonColours[2] < 4)
            {
                buttonColours[2]++;
            }
            else buttonColours[2] = 1;

            switch (buttonColours[2])
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
            if (buttonColours[3] < 4)
            {
                buttonColours[3]++;
            }
            else buttonColours[3] = 1;

            switch (buttonColours[3])
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

            if ((buttonColours[0] == b1guesscolour) && (buttonColours[1] == b2guesscolour) && (buttonColours[2] == b3guesscolour) && (buttonColours[3] == b4guesscolour))
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

                if (buttonColours[0] == 1 || buttonColours[1] == 1 || buttonColours[2] == 1 || buttonColours[3] == 1)
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

                if (buttonColours[0] == 2 || buttonColours[1] == 2 || buttonColours[2] == 2 || buttonColours[3] == 2)
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
                if (buttonColours[0] == 3 || buttonColours[1] == 3 || buttonColours[2] == 3 || buttonColours[3] == 3)
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
                if (buttonColours[0] == 4 || buttonColours[1] == 4 || buttonColours[2] == 4 || buttonColours[3] == 4)
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

                if(buttonColours[0] == b1guesscolour)
                {
                    posHintNo++;
                }
                if (buttonColours[1] == b2guesscolour)
                {
                    posHintNo++;
                }
                if (buttonColours[2] == b3guesscolour)
                {
                    posHintNo++;
                }
                if (buttonColours[3] == b4guesscolour)
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
            AnswerPanel.Visibility = Visibility.Collapsed;
            StartPanel.Visibility = Visibility.Collapsed;

            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;

            buttonColours[0] = 1;
            buttonColours[1] = 1;
            buttonColours[2] = 1;
            buttonColours[3] = 1;

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


        //private void HighScoreSaveButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (HighScoreName.Text == "" || HighScoreName.Text == null)
        //    {
        //        NoNameWarning.Visibility = Visibility.Visible;
        //    }

        //    else
        //    {
        //        HighScoreSaveRoutine();
        //    }
        //}

        //private void HighScoreSaveRoutine()
        //{
        //    if (clicks < Properties.Settings.Default.Score1)
        //    {
        //        Properties.Settings.Default.Name5 = Properties.Settings.Default.Name4;
        //        Properties.Settings.Default.Score5 = Properties.Settings.Default.Score4;
        //        Properties.Settings.Default.Name4 = Properties.Settings.Default.Name3;
        //        Properties.Settings.Default.Score4 = Properties.Settings.Default.Score3;
        //        Properties.Settings.Default.Name3 = Properties.Settings.Default.Name2;
        //        Properties.Settings.Default.Score3 = Properties.Settings.Default.Score2;
        //        Properties.Settings.Default.Name2 = Properties.Settings.Default.Name1;
        //        Properties.Settings.Default.Score2 = Properties.Settings.Default.Score1;
        //        Properties.Settings.Default.Name1 = HighScoreName.Text;
        //        Properties.Settings.Default.Score1 = clicks;
        //        Properties.Settings.Default.Save();
        //    }
        //    else if (clicks < Properties.Settings.Default.Score2)
        //    {
        //        Properties.Settings.Default.Name5 = Properties.Settings.Default.Name4;
        //        Properties.Settings.Default.Score5 = Properties.Settings.Default.Score4;
        //        Properties.Settings.Default.Name4 = Properties.Settings.Default.Name3;
        //        Properties.Settings.Default.Score4 = Properties.Settings.Default.Score3;
        //        Properties.Settings.Default.Name3 = Properties.Settings.Default.Name2;
        //        Properties.Settings.Default.Score3 = Properties.Settings.Default.Score2;
        //        Properties.Settings.Default.Name2 = HighScoreName.Text;
        //        Properties.Settings.Default.Score2 = clicks;
        //        Properties.Settings.Default.Save();
        //    }
        //    else if (clicks < Properties.Settings.Default.Score3)
        //    {
        //        Properties.Settings.Default.Name5 = Properties.Settings.Default.Name4;
        //        Properties.Settings.Default.Score5 = Properties.Settings.Default.Score4;
        //        Properties.Settings.Default.Name4 = Properties.Settings.Default.Name3;
        //        Properties.Settings.Default.Score4 = Properties.Settings.Default.Score3;
        //        Properties.Settings.Default.Name3 = HighScoreName.Text;
        //        Properties.Settings.Default.Score3 = clicks;
        //        Properties.Settings.Default.Save();
        //    }
        //    else if (clicks < Properties.Settings.Default.Score4)
        //    {
        //        Properties.Settings.Default.Name5 = Properties.Settings.Default.Name4;
        //        Properties.Settings.Default.Score5 = Properties.Settings.Default.Score4;
        //        Properties.Settings.Default.Name4 = HighScoreName.Text;
        //        Properties.Settings.Default.Score4 = clicks;
        //        Properties.Settings.Default.Save();
        //    }
        //    else
        //    {
        //        Properties.Settings.Default.Name5 = HighScoreName.Text;
        //        Properties.Settings.Default.Score5 = clicks;
        //        Properties.Settings.Default.Save();
        //    }

        //    UpdateClicks();
        //    Properties.Settings.Default.Save();
        //    NoNameWarning.Visibility = Visibility.Hidden;
        //    HighScorePanel.Visibility = Visibility.Collapsed;
        //}


    }

}
