using System;
using System.Windows.Forms;

namespace DartCalculator
{
    public partial class TwoPlayers : Form
    {
        public TwoPlayers()
        {
            InitializeComponent();
            textBoxSecondPlayerFirstThrow.Enabled = false;
            textBoxSecondPlayerSecondThrow.Enabled = false;
            textBoxSecondPlayerThirdThrow.Enabled = false;
            buttonSecondPlayerSubtract.Enabled = false;
        }
        
        private void buttonBackToMainWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }
        private void TwoPlayers_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonFirstPlayerSubtract_Click(object sender, EventArgs e)
        {
            int actualNumber;
            int subtract;

            labelFirstPlayerBestEndingFirst.Text = "";
            labelFirstPlayerBestEndingSecond.Text = "";
            labelFirstPlayerBestEndingThird.Text = "";

            if (((int.Parse(textBoxFirstPlayerFirstThrow.Text) >= 0 && int.Parse(textBoxFirstPlayerFirstThrow.Text) <= 20))
                || ((int.Parse(textBoxFirstPlayerFirstThrow.Text) >= 0 && int.Parse(textBoxFirstPlayerFirstThrow.Text) <= 40) && int.Parse(textBoxFirstPlayerFirstThrow.Text) % 2 == 0)
                || ((int.Parse(textBoxFirstPlayerFirstThrow.Text) >= 0 && int.Parse(textBoxFirstPlayerFirstThrow.Text) <= 60) && int.Parse(textBoxFirstPlayerFirstThrow.Text) % 3 == 0)
                || (int.Parse(textBoxFirstPlayerFirstThrow.Text) == 25) // wrong value in first throw
                || ((int.Parse(textBoxFirstPlayerSecondThrow.Text) >= 0 && int.Parse(textBoxFirstPlayerSecondThrow.Text) <= 20))
                || ((int.Parse(textBoxFirstPlayerSecondThrow.Text) >= 0 && int.Parse(textBoxFirstPlayerSecondThrow.Text) <= 40) && int.Parse(textBoxFirstPlayerSecondThrow.Text) % 2 == 0)
                || ((int.Parse(textBoxFirstPlayerSecondThrow.Text) >= 0 && int.Parse(textBoxFirstPlayerSecondThrow.Text) <= 60) && int.Parse(textBoxFirstPlayerSecondThrow.Text) % 3 == 0)
                || (int.Parse(textBoxFirstPlayerSecondThrow.Text) == 25) // wrong value in second throw
                || ((int.Parse(textBoxFirstPlayerThirdThrow.Text) >= 0 && int.Parse(textBoxFirstPlayerThirdThrow.Text) <= 20))
                || ((int.Parse(textBoxFirstPlayerThirdThrow.Text) >= 0 && int.Parse(textBoxFirstPlayerThirdThrow.Text) <= 40) && int.Parse(textBoxFirstPlayerThirdThrow.Text) % 2 == 0)
                || ((int.Parse(textBoxFirstPlayerThirdThrow.Text) >= 0 && int.Parse(textBoxFirstPlayerThirdThrow.Text) <= 60) && int.Parse(textBoxFirstPlayerThirdThrow.Text) % 3 == 0)
                || (int.Parse(textBoxFirstPlayerThirdThrow.Text) == 25)) // wrong value in third throw
            {
                if (labelFirstPlayerPoints.Text == "2" && (textBoxFirstPlayerFirstThrow.Text == "1" || textBoxFirstPlayerSecondThrow.Text == "1" || textBoxFirstPlayerThirdThrow.Text == "1"))
                {
                    MessageBox.Show("BUST");
                } // if left 2 points and 1 was thrown:
                else
                {
                    if (string.IsNullOrWhiteSpace(textBoxFirstPlayerFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxFirstPlayerSecondThrow.Text) && string.IsNullOrWhiteSpace(textBoxFirstPlayerThirdThrow.Text))
                    {
                        MessageBox.Show("All boxes are empty!");
                    } // all empty
                    else if (string.IsNullOrWhiteSpace(textBoxFirstPlayerSecondThrow.Text) && string.IsNullOrWhiteSpace(textBoxFirstPlayerThirdThrow.Text))
                    {
                        actualNumber = int.Parse(labelFirstPlayerPoints.Text);
                        subtract = int.Parse(textBoxFirstPlayerFirstThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelFirstPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // second and third empty
                    else if (string.IsNullOrWhiteSpace(textBoxFirstPlayerFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxFirstPlayerThirdThrow.Text))
                    {
                        actualNumber = int.Parse(labelFirstPlayerPoints.Text);
                        subtract = int.Parse(textBoxFirstPlayerSecondThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelFirstPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // first and third empty
                    else if (string.IsNullOrWhiteSpace(textBoxFirstPlayerFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxFirstPlayerSecondThrow.Text))
                    {
                        actualNumber = int.Parse(labelFirstPlayerPoints.Text);
                        subtract = int.Parse(textBoxFirstPlayerThirdThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelFirstPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // second and first empty
                    else if (string.IsNullOrWhiteSpace(textBoxFirstPlayerFirstThrow.Text))
                    {
                        actualNumber = int.Parse(labelFirstPlayerPoints.Text);
                        subtract = int.Parse(textBoxFirstPlayerThirdThrow.Text) + int.Parse(textBoxFirstPlayerSecondThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelFirstPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // only first empty
                    else if (string.IsNullOrWhiteSpace(textBoxFirstPlayerSecondThrow.Text))
                    {
                        actualNumber = int.Parse(labelFirstPlayerPoints.Text);
                        subtract = int.Parse(textBoxFirstPlayerThirdThrow.Text) + int.Parse(textBoxFirstPlayerFirstThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelFirstPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // only second empty
                    else if (string.IsNullOrWhiteSpace(textBoxFirstPlayerThirdThrow.Text))
                    {
                        actualNumber = int.Parse(labelFirstPlayerPoints.Text);
                        subtract = int.Parse(textBoxFirstPlayerSecondThrow.Text) + int.Parse(textBoxFirstPlayerFirstThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelFirstPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // only third empty
                    else
                    {
                        actualNumber = int.Parse(labelFirstPlayerPoints.Text);
                        subtract = int.Parse(textBoxFirstPlayerFirstThrow.Text) + int.Parse(textBoxFirstPlayerSecondThrow.Text) + int.Parse(textBoxFirstPlayerThirdThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelFirstPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // all throws are good
                }

                if (labelFirstPlayerPoints.Text == "0")
                {
                    MessageBox.Show("You've done it!\nNow You'll be move to Main Window.");
                    this.Hide();
                    MainWindow mw = new MainWindow();
                    mw.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong value!");
            }

            switch (labelFirstPlayerPoints.Text)
            {
                case "170":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T20";
                    labelFirstPlayerBestEndingThird.Text = "BULL";
                    break;
                case "167":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T19";
                    labelFirstPlayerBestEndingThird.Text = "BULL";
                    break;
                case "164":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T18";
                    labelFirstPlayerBestEndingThird.Text = "BULL";
                    break;
                case "161":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T17";
                    labelFirstPlayerBestEndingThird.Text = "BULL";
                    break;
                case "160":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T20";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "158":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T20";
                    labelFirstPlayerBestEndingThird.Text = "D19";
                    break;
                case "157":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T19";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "156":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T20";
                    labelFirstPlayerBestEndingThird.Text = "D18";
                    break;
                case "155":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T19";
                    labelFirstPlayerBestEndingThird.Text = "D19";
                    break;
                case "154":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T18";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "153":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T19";
                    labelFirstPlayerBestEndingThird.Text = "D18";
                    break;
                case "152":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T20";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "151":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T17";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "150":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T18";
                    labelFirstPlayerBestEndingThird.Text = "D18";
                    break;
                case "149":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T19";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "148":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T16";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "147":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T17";
                    labelFirstPlayerBestEndingThird.Text = "D18";
                    break;
                case "146":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T18";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "145":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T15";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "144":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T20";
                    labelFirstPlayerBestEndingThird.Text = "D12";
                    break;
                case "143":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T17";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "142":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T14";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "141":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T19";
                    labelFirstPlayerBestEndingThird.Text = "D12";
                    break;
                case "140":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T16";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "139":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "T14";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "138":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T18";
                    labelFirstPlayerBestEndingThird.Text = "D12";
                    break;
                case "137":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "T16";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "136":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T20";
                    labelFirstPlayerBestEndingThird.Text = "D8";
                    break;
                case "135":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T17";
                    labelFirstPlayerBestEndingThird.Text = "D12";
                    break;
                case "134":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T14";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "133":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T19";
                    labelFirstPlayerBestEndingThird.Text = "D8";
                    break;
                case "132":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T16";
                    labelFirstPlayerBestEndingThird.Text = "D12";
                    break;
                case "131":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T13";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "130":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T20";
                    labelFirstPlayerBestEndingThird.Text = "D5";
                    break;
                case "129":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "T16";
                    labelFirstPlayerBestEndingThird.Text = "D12";
                    break;
                case "128":
                    labelFirstPlayerBestEndingFirst.Text = "T18";
                    labelFirstPlayerBestEndingSecond.Text = "T14";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "127":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T17";
                    labelFirstPlayerBestEndingThird.Text = "D8";
                    break;
                case "126":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "T19";
                    labelFirstPlayerBestEndingThird.Text = "D6";
                    break;
                case "125":
                    labelFirstPlayerBestEndingFirst.Text = "25";
                    labelFirstPlayerBestEndingSecond.Text = "T20";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "124":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "T16";
                    labelFirstPlayerBestEndingThird.Text = "D8";
                    break;
                case "123":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "T16";
                    labelFirstPlayerBestEndingThird.Text = "D9";
                    break;
                case "122":
                    labelFirstPlayerBestEndingFirst.Text = "T18";
                    labelFirstPlayerBestEndingSecond.Text = "T20";
                    labelFirstPlayerBestEndingThird.Text = "D4";
                    break;
                case "121":
                    labelFirstPlayerBestEndingFirst.Text = "T17";
                    labelFirstPlayerBestEndingSecond.Text = "T10";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "120":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "20";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "119":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "T10";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "118":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "18";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "117":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "17";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "116":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "16";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "115":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "15";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "114":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "14";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "113":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "13";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "112":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "12";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "111":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "19";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "110":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "18";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "109":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "20";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "108":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "16";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "107":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "18";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "106":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "14";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "105":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "16";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "104":
                    labelFirstPlayerBestEndingFirst.Text = "T18";
                    labelFirstPlayerBestEndingSecond.Text = "18";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "103":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "3";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "102":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "10";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "101":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "1";
                    labelFirstPlayerBestEndingThird.Text = "D20";
                    break;
                case "100":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "99":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "10";
                    labelFirstPlayerBestEndingThird.Text = "D16";
                    break;
                case "98":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "D19";
                    break;
                case "97":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "96":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "D18";
                    break;
                case "95":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "D19";
                    break;
                case "94":
                    labelFirstPlayerBestEndingFirst.Text = "T18";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "93":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "D18";
                    break;
                case "92":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "D16";
                    break;
                case "91":
                    labelFirstPlayerBestEndingFirst.Text = "T17";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "90":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "D15";
                    break;
                case "89":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "D16";
                    break;
                case "88":
                    labelFirstPlayerBestEndingFirst.Text = "T16";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "87":
                    labelFirstPlayerBestEndingFirst.Text = "T17";
                    labelFirstPlayerBestEndingSecond.Text = "D18";
                    break;
                case "86":
                    labelFirstPlayerBestEndingFirst.Text = "T18";
                    labelFirstPlayerBestEndingSecond.Text = "D16";
                    break;
                case "85":
                    labelFirstPlayerBestEndingFirst.Text = "T15";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "84":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "D12";
                    break;
                case "83":
                    labelFirstPlayerBestEndingFirst.Text = "T17";
                    labelFirstPlayerBestEndingSecond.Text = "D16";
                    break;
                case "82":
                    labelFirstPlayerBestEndingFirst.Text = "T14";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "81":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "D12";
                    break;
                case "80":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "D10";
                    break;
                case "79":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "D11";
                    break;
                case "78":
                    labelFirstPlayerBestEndingFirst.Text = "T18";
                    labelFirstPlayerBestEndingSecond.Text = "D12";
                    break;
                case "77":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "D10";
                    break;
                case "76":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "D8";
                    break;
                case "75":
                    labelFirstPlayerBestEndingFirst.Text = "T17";
                    labelFirstPlayerBestEndingSecond.Text = "D12";
                    break;
                case "74":
                    labelFirstPlayerBestEndingFirst.Text = "T14";
                    labelFirstPlayerBestEndingSecond.Text = "D16";
                    break;
                case "73":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "D8";
                    break;
                case "72":
                    labelFirstPlayerBestEndingFirst.Text = "T16";
                    labelFirstPlayerBestEndingSecond.Text = "D12";
                    break;
                case "71":
                    labelFirstPlayerBestEndingFirst.Text = "T13";
                    labelFirstPlayerBestEndingSecond.Text = "D16";
                    break;
                case "70":
                    labelFirstPlayerBestEndingFirst.Text = "T10";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "69":
                    labelFirstPlayerBestEndingFirst.Text = "T15";
                    labelFirstPlayerBestEndingSecond.Text = "D12";
                    break;
                case "68":
                    labelFirstPlayerBestEndingFirst.Text = "T20";
                    labelFirstPlayerBestEndingSecond.Text = "D4";
                    break;
                case "67":
                    labelFirstPlayerBestEndingFirst.Text = "T17";
                    labelFirstPlayerBestEndingSecond.Text = "D8";
                    break;
                case "66":
                    labelFirstPlayerBestEndingFirst.Text = "T10";
                    labelFirstPlayerBestEndingSecond.Text = "D18";
                    break;
                case "65":
                    labelFirstPlayerBestEndingFirst.Text = "T19";
                    labelFirstPlayerBestEndingSecond.Text = "D4";
                    break;
                case "64":
                    labelFirstPlayerBestEndingFirst.Text = "T16";
                    labelFirstPlayerBestEndingSecond.Text = "D8";
                    break;
                case "63":
                    labelFirstPlayerBestEndingFirst.Text = "T13";
                    labelFirstPlayerBestEndingSecond.Text = "D12";
                    break;
                case "62":
                    labelFirstPlayerBestEndingFirst.Text = "T10";
                    labelFirstPlayerBestEndingSecond.Text = "D16";
                    break;
                case "61":
                    labelFirstPlayerBestEndingFirst.Text = "T15";
                    labelFirstPlayerBestEndingSecond.Text = "D8";
                    break;
                case "60":
                    labelFirstPlayerBestEndingFirst.Text = "20";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "59":
                    labelFirstPlayerBestEndingFirst.Text = "19";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "58":
                    labelFirstPlayerBestEndingFirst.Text = "18";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "57":
                    labelFirstPlayerBestEndingFirst.Text = "17";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "56":
                    labelFirstPlayerBestEndingFirst.Text = "16";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "55":
                    labelFirstPlayerBestEndingFirst.Text = "15";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "54":
                    labelFirstPlayerBestEndingFirst.Text = "14";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "53":
                    labelFirstPlayerBestEndingFirst.Text = "13";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "52":
                    labelFirstPlayerBestEndingFirst.Text = "12";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "51":
                    labelFirstPlayerBestEndingFirst.Text = "11";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "50":
                    labelFirstPlayerBestEndingFirst.Text = "10";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "49":
                    labelFirstPlayerBestEndingFirst.Text = "9";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "48":
                    labelFirstPlayerBestEndingFirst.Text = "8";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "47":
                    labelFirstPlayerBestEndingFirst.Text = "7";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "46":
                    labelFirstPlayerBestEndingFirst.Text = "6";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "45":
                    labelFirstPlayerBestEndingFirst.Text = "5";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "44":
                    labelFirstPlayerBestEndingFirst.Text = "4";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "43":
                    labelFirstPlayerBestEndingFirst.Text = "3";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "42":
                    labelFirstPlayerBestEndingFirst.Text = "2";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "41":
                    labelFirstPlayerBestEndingFirst.Text = "1";
                    labelFirstPlayerBestEndingSecond.Text = "D20";
                    break;
                case "40":
                    labelFirstPlayerBestEndingFirst.Text = "D20";
                    break;
                case "39":
                    labelFirstPlayerBestEndingFirst.Text = "7";
                    labelFirstPlayerBestEndingSecond.Text = "D16";
                    break;
                case "38":
                    labelFirstPlayerBestEndingFirst.Text = "D19";
                    break;
                case "37":
                    labelFirstPlayerBestEndingFirst.Text = "5";
                    labelFirstPlayerBestEndingSecond.Text = "D16";
                    break;
                case "36":
                    labelFirstPlayerBestEndingFirst.Text = "D18";
                    break;
                case "35":
                    labelFirstPlayerBestEndingFirst.Text = "3";
                    labelFirstPlayerBestEndingSecond.Text = "D16";
                    break;
                case "34":
                    labelFirstPlayerBestEndingFirst.Text = "D17";
                    break;
                case "33":
                    labelFirstPlayerBestEndingFirst.Text = "1";
                    labelFirstPlayerBestEndingSecond.Text = "D16";
                    break;
                case "32":
                    labelFirstPlayerBestEndingFirst.Text = "D16";
                    break;
                case "31":
                    labelFirstPlayerBestEndingFirst.Text = "9";
                    labelFirstPlayerBestEndingSecond.Text = "D12";
                    break;
                case "30":
                    labelFirstPlayerBestEndingFirst.Text = "D15";
                    break;
                case "29":
                    labelFirstPlayerBestEndingFirst.Text = "7";
                    labelFirstPlayerBestEndingSecond.Text = "D12";
                    break;
                case "28":
                    labelFirstPlayerBestEndingFirst.Text = "D14";
                    break;
                case "27":
                    labelFirstPlayerBestEndingFirst.Text = "5";
                    labelFirstPlayerBestEndingSecond.Text = "D12";
                    break;
                case "26":
                    labelFirstPlayerBestEndingFirst.Text = "D13";
                    break;
                case "25":
                    labelFirstPlayerBestEndingFirst.Text = "3";
                    labelFirstPlayerBestEndingSecond.Text = "D12";
                    break;
                case "24":
                    labelFirstPlayerBestEndingFirst.Text = "D12";
                    break;
                case "23":
                    labelFirstPlayerBestEndingFirst.Text = "3";
                    labelFirstPlayerBestEndingSecond.Text = "D10";
                    break;
                case "22":
                    labelFirstPlayerBestEndingFirst.Text = "D11";
                    break;
                case "21":
                    labelFirstPlayerBestEndingFirst.Text = "1";
                    labelFirstPlayerBestEndingSecond.Text = "D10";
                    break;
                case "20":
                    labelFirstPlayerBestEndingFirst.Text = "D10";
                    break;
                case "19":
                    labelFirstPlayerBestEndingFirst.Text = "3";
                    labelFirstPlayerBestEndingSecond.Text = "D8";
                    break;
                case "18":
                    labelFirstPlayerBestEndingFirst.Text = "D9";
                    break;
                case "17":
                    labelFirstPlayerBestEndingFirst.Text = "1";
                    labelFirstPlayerBestEndingSecond.Text = "D8";
                    break;
                case "16":
                    labelFirstPlayerBestEndingFirst.Text = "D8";
                    break;
                case "15":
                    labelFirstPlayerBestEndingFirst.Text = "5";
                    labelFirstPlayerBestEndingSecond.Text = "D5";
                    break;
                case "14":
                    labelFirstPlayerBestEndingFirst.Text = "D7";
                    break;
                case "13":
                    labelFirstPlayerBestEndingFirst.Text = "3";
                    labelFirstPlayerBestEndingSecond.Text = "D5";
                    break;
                case "12":
                    labelFirstPlayerBestEndingFirst.Text = "D6";
                    break;
                case "11":
                    labelFirstPlayerBestEndingFirst.Text = "1";
                    labelFirstPlayerBestEndingSecond.Text = "D5";
                    break;
                case "10":
                    labelFirstPlayerBestEndingFirst.Text = "D5";
                    break;
                case "9":
                    labelFirstPlayerBestEndingFirst.Text = "1";
                    labelFirstPlayerBestEndingSecond.Text = "D4";
                    break;
                case "8":
                    labelFirstPlayerBestEndingFirst.Text = "D4";
                    break;
                case "7":
                    labelFirstPlayerBestEndingFirst.Text = "1";
                    labelFirstPlayerBestEndingSecond.Text = "D3";
                    break;
                case "6":
                    labelFirstPlayerBestEndingFirst.Text = "D3";
                    break;
                case "5":
                    labelFirstPlayerBestEndingFirst.Text = "1";
                    labelFirstPlayerBestEndingSecond.Text = "D2";
                    break;
                case "4":
                    labelFirstPlayerBestEndingFirst.Text = "D2";
                    break;
                case "3":
                    labelFirstPlayerBestEndingFirst.Text = "1";
                    labelFirstPlayerBestEndingSecond.Text = "D1";
                    break;
                case "2":
                    labelFirstPlayerBestEndingFirst.Text = "D1";
                    break;
            } // switch that shows the best ending

            textBoxFirstPlayerFirstThrow.Text = "0";
            textBoxFirstPlayerSecondThrow.Text = "0";
            textBoxFirstPlayerThirdThrow.Text = "0";

            textBoxFirstPlayerFirstThrow.Enabled = false;
            textBoxFirstPlayerSecondThrow.Enabled = false;
            textBoxFirstPlayerThirdThrow.Enabled = false;
            buttonFirstPlayerSubtract.Enabled = false;

            textBoxSecondPlayerFirstThrow.Enabled = true;
            textBoxSecondPlayerSecondThrow.Enabled = true;
            textBoxSecondPlayerThirdThrow.Enabled = true;
            buttonSecondPlayerSubtract.Enabled = true;
        }

        private void buttonSecondPlayerSubtract_Click(object sender, EventArgs e)
        {
            int actualNumber;
            int subtract;

            labelSecondPlayerBestEndingFirst.Text = "";
            labelSecondPlayerBestEndingSecond.Text = "";
            labelSecondPlayerBestEndingThird.Text = "";

            if (((int.Parse(textBoxSecondPlayerFirstThrow.Text) >= 0 && int.Parse(textBoxSecondPlayerFirstThrow.Text) <= 20))
                || ((int.Parse(textBoxSecondPlayerFirstThrow.Text) >= 0 && int.Parse(textBoxSecondPlayerFirstThrow.Text) <= 40) && int.Parse(textBoxSecondPlayerFirstThrow.Text) % 2 == 0)
                || ((int.Parse(textBoxSecondPlayerFirstThrow.Text) >= 0 && int.Parse(textBoxSecondPlayerFirstThrow.Text) <= 60) && int.Parse(textBoxSecondPlayerFirstThrow.Text) % 3 == 0)
                || (int.Parse(textBoxSecondPlayerFirstThrow.Text) == 25) // wrong value in first throw
                || ((int.Parse(textBoxSecondPlayerSecondThrow.Text) >= 0 && int.Parse(textBoxSecondPlayerSecondThrow.Text) <= 20))
                || ((int.Parse(textBoxSecondPlayerSecondThrow.Text) >= 0 && int.Parse(textBoxSecondPlayerSecondThrow.Text) <= 40) && int.Parse(textBoxSecondPlayerSecondThrow.Text) % 2 == 0)
                || ((int.Parse(textBoxSecondPlayerSecondThrow.Text) >= 0 && int.Parse(textBoxSecondPlayerSecondThrow.Text) <= 60) && int.Parse(textBoxSecondPlayerSecondThrow.Text) % 3 == 0)
                || (int.Parse(textBoxSecondPlayerSecondThrow.Text) == 25) // wrong value in second throw
                || ((int.Parse(textBoxSecondPlayerThirdThrow.Text) >= 0 && int.Parse(textBoxSecondPlayerThirdThrow.Text) <= 20))
                || ((int.Parse(textBoxSecondPlayerThirdThrow.Text) >= 0 && int.Parse(textBoxSecondPlayerThirdThrow.Text) <= 40) && int.Parse(textBoxSecondPlayerThirdThrow.Text) % 2 == 0)
                || ((int.Parse(textBoxSecondPlayerThirdThrow.Text) >= 0 && int.Parse(textBoxSecondPlayerThirdThrow.Text) <= 60) && int.Parse(textBoxSecondPlayerThirdThrow.Text) % 3 == 0)
                || (int.Parse(textBoxSecondPlayerThirdThrow.Text) == 25)) // wrong value in third throw
            {
                if (labelSecondPlayerPoints.Text == "2" && (textBoxSecondPlayerFirstThrow.Text == "1" || textBoxSecondPlayerSecondThrow.Text == "1" || textBoxSecondPlayerThirdThrow.Text == "1"))
                {
                    MessageBox.Show("BUST");
                } // if left 2 points and 1 was thrown:
                else
                {
                    if (string.IsNullOrWhiteSpace(textBoxSecondPlayerFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxSecondPlayerSecondThrow.Text) && string.IsNullOrWhiteSpace(textBoxSecondPlayerThirdThrow.Text))
                    {
                        MessageBox.Show("All boxes are empty!");
                    } // all empty
                    else if (string.IsNullOrWhiteSpace(textBoxSecondPlayerSecondThrow.Text) && string.IsNullOrWhiteSpace(textBoxSecondPlayerThirdThrow.Text))
                    {
                        actualNumber = int.Parse(labelSecondPlayerPoints.Text);
                        subtract = int.Parse(textBoxSecondPlayerFirstThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelSecondPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // second and third empty
                    else if (string.IsNullOrWhiteSpace(textBoxSecondPlayerFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxSecondPlayerThirdThrow.Text))
                    {
                        actualNumber = int.Parse(labelSecondPlayerPoints.Text);
                        subtract = int.Parse(textBoxSecondPlayerSecondThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelSecondPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // first and third empty
                    else if (string.IsNullOrWhiteSpace(textBoxSecondPlayerFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxSecondPlayerSecondThrow.Text))
                    {
                        actualNumber = int.Parse(labelSecondPlayerPoints.Text);
                        subtract = int.Parse(textBoxSecondPlayerThirdThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelSecondPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // second and first empty
                    else if (string.IsNullOrWhiteSpace(textBoxSecondPlayerFirstThrow.Text))
                    {
                        actualNumber = int.Parse(labelSecondPlayerPoints.Text);
                        subtract = int.Parse(textBoxSecondPlayerThirdThrow.Text) + int.Parse(textBoxSecondPlayerSecondThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelSecondPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // only first empty
                    else if (string.IsNullOrWhiteSpace(textBoxSecondPlayerSecondThrow.Text))
                    {
                        actualNumber = int.Parse(labelSecondPlayerPoints.Text);
                        subtract = int.Parse(textBoxSecondPlayerThirdThrow.Text) + int.Parse(textBoxSecondPlayerFirstThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelSecondPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // only second empty
                    else if (string.IsNullOrWhiteSpace(textBoxSecondPlayerThirdThrow.Text))
                    {
                        actualNumber = int.Parse(labelSecondPlayerPoints.Text);
                        subtract = int.Parse(textBoxSecondPlayerSecondThrow.Text) + int.Parse(textBoxSecondPlayerFirstThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelSecondPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // only third empty
                    else
                    {
                        actualNumber = int.Parse(labelSecondPlayerPoints.Text);
                        subtract = int.Parse(textBoxSecondPlayerFirstThrow.Text) + int.Parse(textBoxSecondPlayerSecondThrow.Text) + int.Parse(textBoxSecondPlayerThirdThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelSecondPlayerPoints.Text = actualNumber.ToString();
                        }
                    } // all throws are good
                }

                if (labelSecondPlayerPoints.Text == "0")
                {
                    MessageBox.Show("You've done it!\nNow You'll be move to Main Window.");
                    this.Hide();
                    MainWindow mw = new MainWindow();
                    mw.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong value!");
            }

            switch (labelSecondPlayerPoints.Text)
            {
                case "170":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T20";
                    labelSecondPlayerBestEndingThird.Text = "BULL";
                    break;
                case "167":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T19";
                    labelSecondPlayerBestEndingThird.Text = "BULL";
                    break;
                case "164":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T18";
                    labelSecondPlayerBestEndingThird.Text = "BULL";
                    break;
                case "161":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T17";
                    labelSecondPlayerBestEndingThird.Text = "BULL";
                    break;
                case "160":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T20";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "158":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T20";
                    labelSecondPlayerBestEndingThird.Text = "D19";
                    break;
                case "157":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T19";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "156":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T20";
                    labelSecondPlayerBestEndingThird.Text = "D18";
                    break;
                case "155":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T19";
                    labelSecondPlayerBestEndingThird.Text = "D19";
                    break;
                case "154":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T18";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "153":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T19";
                    labelSecondPlayerBestEndingThird.Text = "D18";
                    break;
                case "152":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T20";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "151":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T17";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "150":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T18";
                    labelSecondPlayerBestEndingThird.Text = "D18";
                    break;
                case "149":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T19";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "148":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T16";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "147":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T17";
                    labelSecondPlayerBestEndingThird.Text = "D18";
                    break;
                case "146":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T18";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "145":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T15";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "144":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T20";
                    labelSecondPlayerBestEndingThird.Text = "D12";
                    break;
                case "143":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T17";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "142":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T14";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "141":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T19";
                    labelSecondPlayerBestEndingThird.Text = "D12";
                    break;
                case "140":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T16";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "139":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "T14";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "138":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T18";
                    labelSecondPlayerBestEndingThird.Text = "D12";
                    break;
                case "137":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "T16";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "136":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T20";
                    labelSecondPlayerBestEndingThird.Text = "D8";
                    break;
                case "135":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T17";
                    labelSecondPlayerBestEndingThird.Text = "D12";
                    break;
                case "134":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T14";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "133":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T19";
                    labelSecondPlayerBestEndingThird.Text = "D8";
                    break;
                case "132":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T16";
                    labelSecondPlayerBestEndingThird.Text = "D12";
                    break;
                case "131":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T13";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "130":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T20";
                    labelSecondPlayerBestEndingThird.Text = "D5";
                    break;
                case "129":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "T16";
                    labelSecondPlayerBestEndingThird.Text = "D12";
                    break;
                case "128":
                    labelSecondPlayerBestEndingFirst.Text = "T18";
                    labelSecondPlayerBestEndingSecond.Text = "T14";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "127":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T17";
                    labelSecondPlayerBestEndingThird.Text = "D8";
                    break;
                case "126":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "T19";
                    labelSecondPlayerBestEndingThird.Text = "D6";
                    break;
                case "125":
                    labelSecondPlayerBestEndingFirst.Text = "25";
                    labelSecondPlayerBestEndingSecond.Text = "T20";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "124":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "T16";
                    labelSecondPlayerBestEndingThird.Text = "D8";
                    break;
                case "123":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "T16";
                    labelSecondPlayerBestEndingThird.Text = "D9";
                    break;
                case "122":
                    labelSecondPlayerBestEndingFirst.Text = "T18";
                    labelSecondPlayerBestEndingSecond.Text = "T20";
                    labelSecondPlayerBestEndingThird.Text = "D4";
                    break;
                case "121":
                    labelSecondPlayerBestEndingFirst.Text = "T17";
                    labelSecondPlayerBestEndingSecond.Text = "T10";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "120":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "20";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "119":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "T10";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "118":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "18";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "117":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "17";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "116":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "16";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "115":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "15";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "114":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "14";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "113":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "13";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "112":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "12";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "111":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "19";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "110":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "18";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "109":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "20";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "108":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "16";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "107":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "18";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "106":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "14";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "105":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "16";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "104":
                    labelSecondPlayerBestEndingFirst.Text = "T18";
                    labelSecondPlayerBestEndingSecond.Text = "18";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "103":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "3";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "102":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "10";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "101":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "1";
                    labelSecondPlayerBestEndingThird.Text = "D20";
                    break;
                case "100":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "99":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "10";
                    labelSecondPlayerBestEndingThird.Text = "D16";
                    break;
                case "98":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "D19";
                    break;
                case "97":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "96":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "D18";
                    break;
                case "95":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "D19";
                    break;
                case "94":
                    labelSecondPlayerBestEndingFirst.Text = "T18";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "93":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "D18";
                    break;
                case "92":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "D16";
                    break;
                case "91":
                    labelSecondPlayerBestEndingFirst.Text = "T17";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "90":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "D15";
                    break;
                case "89":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "D16";
                    break;
                case "88":
                    labelSecondPlayerBestEndingFirst.Text = "T16";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "87":
                    labelSecondPlayerBestEndingFirst.Text = "T17";
                    labelSecondPlayerBestEndingSecond.Text = "D18";
                    break;
                case "86":
                    labelSecondPlayerBestEndingFirst.Text = "T18";
                    labelSecondPlayerBestEndingSecond.Text = "D16";
                    break;
                case "85":
                    labelSecondPlayerBestEndingFirst.Text = "T15";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "84":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "D12";
                    break;
                case "83":
                    labelSecondPlayerBestEndingFirst.Text = "T17";
                    labelSecondPlayerBestEndingSecond.Text = "D16";
                    break;
                case "82":
                    labelSecondPlayerBestEndingFirst.Text = "T14";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "81":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "D12";
                    break;
                case "80":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "D10";
                    break;
                case "79":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "D11";
                    break;
                case "78":
                    labelSecondPlayerBestEndingFirst.Text = "T18";
                    labelSecondPlayerBestEndingSecond.Text = "D12";
                    break;
                case "77":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "D10";
                    break;
                case "76":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "D8";
                    break;
                case "75":
                    labelSecondPlayerBestEndingFirst.Text = "T17";
                    labelSecondPlayerBestEndingSecond.Text = "D12";
                    break;
                case "74":
                    labelSecondPlayerBestEndingFirst.Text = "T14";
                    labelSecondPlayerBestEndingSecond.Text = "D16";
                    break;
                case "73":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "D8";
                    break;
                case "72":
                    labelSecondPlayerBestEndingFirst.Text = "T16";
                    labelSecondPlayerBestEndingSecond.Text = "D12";
                    break;
                case "71":
                    labelSecondPlayerBestEndingFirst.Text = "T13";
                    labelSecondPlayerBestEndingSecond.Text = "D16";
                    break;
                case "70":
                    labelSecondPlayerBestEndingFirst.Text = "T10";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "69":
                    labelSecondPlayerBestEndingFirst.Text = "T15";
                    labelSecondPlayerBestEndingSecond.Text = "D12";
                    break;
                case "68":
                    labelSecondPlayerBestEndingFirst.Text = "T20";
                    labelSecondPlayerBestEndingSecond.Text = "D4";
                    break;
                case "67":
                    labelSecondPlayerBestEndingFirst.Text = "T17";
                    labelSecondPlayerBestEndingSecond.Text = "D8";
                    break;
                case "66":
                    labelSecondPlayerBestEndingFirst.Text = "T10";
                    labelSecondPlayerBestEndingSecond.Text = "D18";
                    break;
                case "65":
                    labelSecondPlayerBestEndingFirst.Text = "T19";
                    labelSecondPlayerBestEndingSecond.Text = "D4";
                    break;
                case "64":
                    labelSecondPlayerBestEndingFirst.Text = "T16";
                    labelSecondPlayerBestEndingSecond.Text = "D8";
                    break;
                case "63":
                    labelSecondPlayerBestEndingFirst.Text = "T13";
                    labelSecondPlayerBestEndingSecond.Text = "D12";
                    break;
                case "62":
                    labelSecondPlayerBestEndingFirst.Text = "T10";
                    labelSecondPlayerBestEndingSecond.Text = "D16";
                    break;
                case "61":
                    labelSecondPlayerBestEndingFirst.Text = "T15";
                    labelSecondPlayerBestEndingSecond.Text = "D8";
                    break;
                case "60":
                    labelSecondPlayerBestEndingFirst.Text = "20";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "59":
                    labelSecondPlayerBestEndingFirst.Text = "19";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "58":
                    labelSecondPlayerBestEndingFirst.Text = "18";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "57":
                    labelSecondPlayerBestEndingFirst.Text = "17";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "56":
                    labelSecondPlayerBestEndingFirst.Text = "16";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "55":
                    labelSecondPlayerBestEndingFirst.Text = "15";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "54":
                    labelSecondPlayerBestEndingFirst.Text = "14";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "53":
                    labelSecondPlayerBestEndingFirst.Text = "13";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "52":
                    labelSecondPlayerBestEndingFirst.Text = "12";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "51":
                    labelSecondPlayerBestEndingFirst.Text = "11";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "50":
                    labelSecondPlayerBestEndingFirst.Text = "10";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "49":
                    labelSecondPlayerBestEndingFirst.Text = "9";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "48":
                    labelSecondPlayerBestEndingFirst.Text = "8";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "47":
                    labelSecondPlayerBestEndingFirst.Text = "7";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "46":
                    labelSecondPlayerBestEndingFirst.Text = "6";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "45":
                    labelSecondPlayerBestEndingFirst.Text = "5";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "44":
                    labelSecondPlayerBestEndingFirst.Text = "4";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "43":
                    labelSecondPlayerBestEndingFirst.Text = "3";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "42":
                    labelSecondPlayerBestEndingFirst.Text = "2";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "41":
                    labelSecondPlayerBestEndingFirst.Text = "1";
                    labelSecondPlayerBestEndingSecond.Text = "D20";
                    break;
                case "40":
                    labelSecondPlayerBestEndingFirst.Text = "D20";
                    break;
                case "39":
                    labelSecondPlayerBestEndingFirst.Text = "7";
                    labelSecondPlayerBestEndingSecond.Text = "D16";
                    break;
                case "38":
                    labelSecondPlayerBestEndingFirst.Text = "D19";
                    break;
                case "37":
                    labelSecondPlayerBestEndingFirst.Text = "5";
                    labelSecondPlayerBestEndingSecond.Text = "D16";
                    break;
                case "36":
                    labelSecondPlayerBestEndingFirst.Text = "D18";
                    break;
                case "35":
                    labelSecondPlayerBestEndingFirst.Text = "3";
                    labelSecondPlayerBestEndingSecond.Text = "D16";
                    break;
                case "34":
                    labelSecondPlayerBestEndingFirst.Text = "D17";
                    break;
                case "33":
                    labelSecondPlayerBestEndingFirst.Text = "1";
                    labelSecondPlayerBestEndingSecond.Text = "D16";
                    break;
                case "32":
                    labelSecondPlayerBestEndingFirst.Text = "D16";
                    break;
                case "31":
                    labelSecondPlayerBestEndingFirst.Text = "9";
                    labelSecondPlayerBestEndingSecond.Text = "D12";
                    break;
                case "30":
                    labelSecondPlayerBestEndingFirst.Text = "D15";
                    break;
                case "29":
                    labelSecondPlayerBestEndingFirst.Text = "7";
                    labelSecondPlayerBestEndingSecond.Text = "D12";
                    break;
                case "28":
                    labelSecondPlayerBestEndingFirst.Text = "D14";
                    break;
                case "27":
                    labelSecondPlayerBestEndingFirst.Text = "5";
                    labelSecondPlayerBestEndingSecond.Text = "D12";
                    break;
                case "26":
                    labelSecondPlayerBestEndingFirst.Text = "D13";
                    break;
                case "25":
                    labelSecondPlayerBestEndingFirst.Text = "3";
                    labelSecondPlayerBestEndingSecond.Text = "D12";
                    break;
                case "24":
                    labelSecondPlayerBestEndingFirst.Text = "D12";
                    break;
                case "23":
                    labelSecondPlayerBestEndingFirst.Text = "3";
                    labelSecondPlayerBestEndingSecond.Text = "D10";
                    break;
                case "22":
                    labelSecondPlayerBestEndingFirst.Text = "D11";
                    break;
                case "21":
                    labelSecondPlayerBestEndingFirst.Text = "1";
                    labelSecondPlayerBestEndingSecond.Text = "D10";
                    break;
                case "20":
                    labelSecondPlayerBestEndingFirst.Text = "D10";
                    break;
                case "19":
                    labelSecondPlayerBestEndingFirst.Text = "3";
                    labelSecondPlayerBestEndingSecond.Text = "D8";
                    break;
                case "18":
                    labelSecondPlayerBestEndingFirst.Text = "D9";
                    break;
                case "17":
                    labelSecondPlayerBestEndingFirst.Text = "1";
                    labelSecondPlayerBestEndingSecond.Text = "D8";
                    break;
                case "16":
                    labelSecondPlayerBestEndingFirst.Text = "D8";
                    break;
                case "15":
                    labelSecondPlayerBestEndingFirst.Text = "5";
                    labelSecondPlayerBestEndingSecond.Text = "D5";
                    break;
                case "14":
                    labelSecondPlayerBestEndingFirst.Text = "D7";
                    break;
                case "13":
                    labelSecondPlayerBestEndingFirst.Text = "3";
                    labelSecondPlayerBestEndingSecond.Text = "D5";
                    break;
                case "12":
                    labelSecondPlayerBestEndingFirst.Text = "D6";
                    break;
                case "11":
                    labelSecondPlayerBestEndingFirst.Text = "1";
                    labelSecondPlayerBestEndingSecond.Text = "D5";
                    break;
                case "10":
                    labelSecondPlayerBestEndingFirst.Text = "D5";
                    break;
                case "9":
                    labelSecondPlayerBestEndingFirst.Text = "1";
                    labelSecondPlayerBestEndingSecond.Text = "D4";
                    break;
                case "8":
                    labelSecondPlayerBestEndingFirst.Text = "D4";
                    break;
                case "7":
                    labelSecondPlayerBestEndingFirst.Text = "1";
                    labelSecondPlayerBestEndingSecond.Text = "D3";
                    break;
                case "6":
                    labelSecondPlayerBestEndingFirst.Text = "D3";
                    break;
                case "5":
                    labelSecondPlayerBestEndingFirst.Text = "1";
                    labelSecondPlayerBestEndingSecond.Text = "D2";
                    break;
                case "4":
                    labelSecondPlayerBestEndingFirst.Text = "D2";
                    break;
                case "3":
                    labelSecondPlayerBestEndingFirst.Text = "1";
                    labelSecondPlayerBestEndingSecond.Text = "D1";
                    break;
                case "2":
                    labelSecondPlayerBestEndingFirst.Text = "D1";
                    break;
            } // switch that shows the best ending

            textBoxSecondPlayerFirstThrow.Text = "0";
            textBoxSecondPlayerSecondThrow.Text = "0";
            textBoxSecondPlayerThirdThrow.Text = "0";

            textBoxFirstPlayerFirstThrow.Enabled = true;
            textBoxFirstPlayerSecondThrow.Enabled = true;
            textBoxFirstPlayerThirdThrow.Enabled = true;
            buttonFirstPlayerSubtract.Enabled = true;

            textBoxSecondPlayerFirstThrow.Enabled = false;
            textBoxSecondPlayerSecondThrow.Enabled = false;
            textBoxSecondPlayerThirdThrow.Enabled = false;
            buttonSecondPlayerSubtract.Enabled = false;
        }
    }
}
