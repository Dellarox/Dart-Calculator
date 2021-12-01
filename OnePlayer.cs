using System;
using System.Windows.Forms;

namespace DartCalculator
{
    public partial class OnePlayer : Form
    {
        
        public OnePlayer()
        {
            InitializeComponent();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            int actualNumber;
            int subtract;

            labelBestEndingFirst.Text = "";
            labelBestEndingSecond.Text = "";
            labelBestEndingThird.Text = "";

            if ((((int.Parse(textBoxFirstThrow.Text) >= 0 && int.Parse(textBoxFirstThrow.Text) <= 20))
                || ((int.Parse(textBoxFirstThrow.Text) >= 0 && int.Parse(textBoxFirstThrow.Text) <= 40) && int.Parse(textBoxFirstThrow.Text) % 2 == 0)
                || ((int.Parse(textBoxFirstThrow.Text) >= 0 && int.Parse(textBoxFirstThrow.Text) <= 60) && int.Parse(textBoxFirstThrow.Text) % 3 == 0)
                || (int.Parse(textBoxFirstThrow.Text) == 25)) // wrong value in first throw
                && (((int.Parse(textBoxSecondThrow.Text) >= 0 && int.Parse(textBoxSecondThrow.Text) <= 20))
                || ((int.Parse(textBoxSecondThrow.Text) >= 0 && int.Parse(textBoxSecondThrow.Text) <= 40) && int.Parse(textBoxSecondThrow.Text) % 2 == 0)
                || ((int.Parse(textBoxSecondThrow.Text) >= 0 && int.Parse(textBoxSecondThrow.Text) <= 60) && int.Parse(textBoxSecondThrow.Text) % 3 == 0)
                || (int.Parse(textBoxSecondThrow.Text) == 25)) // wrong value in second throw
                && (((int.Parse(textBoxThirdThrow.Text) >= 0 && int.Parse(textBoxThirdThrow.Text) <= 20))
                || ((int.Parse(textBoxThirdThrow.Text) >= 0 && int.Parse(textBoxThirdThrow.Text) <= 40) && int.Parse(textBoxThirdThrow.Text) % 2 == 0)
                || ((int.Parse(textBoxThirdThrow.Text) >= 0 && int.Parse(textBoxThirdThrow.Text) <= 60) && int.Parse(textBoxThirdThrow.Text) % 3 == 0)
                || (int.Parse(textBoxThirdThrow.Text) == 25))) // wrong value in third throw
            {
                if (labelPoints.Text == "2" && (textBoxFirstThrow.Text == "1" || textBoxSecondThrow.Text == "1" || textBoxThirdThrow.Text == "1"))
                { 
                    MessageBox.Show("BUST");
                } // if left 2 points and 1 was thrown:
                else
                {
                    if (string.IsNullOrWhiteSpace(textBoxFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxSecondThrow.Text) && string.IsNullOrWhiteSpace(textBoxThirdThrow.Text))
                    {
                        MessageBox.Show("All boxes are empty!");
                    } // all empty
                    else if (string.IsNullOrWhiteSpace(textBoxSecondThrow.Text) && string.IsNullOrWhiteSpace(textBoxThirdThrow.Text))
                    {
                        actualNumber = int.Parse(labelPoints.Text);
                        subtract = int.Parse(textBoxFirstThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelPoints.Text = actualNumber.ToString();
                        }
                    } // second and third empty
                    else if (string.IsNullOrWhiteSpace(textBoxFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxThirdThrow.Text))
                    {
                        actualNumber = int.Parse(labelPoints.Text);
                        subtract = int.Parse(textBoxSecondThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelPoints.Text = actualNumber.ToString();
                        }
                    } // first and third empty
                    else if (string.IsNullOrWhiteSpace(textBoxFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxSecondThrow.Text))
                    {
                        actualNumber = int.Parse(labelPoints.Text);
                        subtract = int.Parse(textBoxThirdThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelPoints.Text = actualNumber.ToString();
                        }
                    } // second and first empty
                    else if (string.IsNullOrWhiteSpace(textBoxFirstThrow.Text))
                    {
                        actualNumber = int.Parse(labelPoints.Text);
                        subtract = int.Parse(textBoxThirdThrow.Text) + int.Parse(textBoxSecondThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelPoints.Text = actualNumber.ToString();
                        }
                    } // only first empty
                    else if (string.IsNullOrWhiteSpace(textBoxSecondThrow.Text))
                    {
                        actualNumber = int.Parse(labelPoints.Text);
                        subtract = int.Parse(textBoxThirdThrow.Text) + int.Parse(textBoxFirstThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelPoints.Text = actualNumber.ToString();
                        }
                    } // only second empty
                    else if (string.IsNullOrWhiteSpace(textBoxThirdThrow.Text))
                    {
                        actualNumber = int.Parse(labelPoints.Text);
                        subtract = int.Parse(textBoxSecondThrow.Text) + int.Parse(textBoxFirstThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelPoints.Text = actualNumber.ToString();
                        }
                    } // only third empty
                    else
                    {
                        actualNumber = int.Parse(labelPoints.Text);
                        subtract = int.Parse(textBoxFirstThrow.Text) + int.Parse(textBoxSecondThrow.Text) + int.Parse(textBoxThirdThrow.Text);

                        if (subtract > actualNumber)
                        {
                            MessageBox.Show("BUST!");
                        }
                        else
                        {
                            actualNumber -= subtract;
                            labelPoints.Text = actualNumber.ToString();
                        }
                    } // all throws are good
                }

                if (labelPoints.Text == "0")
                {
                    MessageBox.Show("You've done it!\nNow You'll be move to Main Window.");
                    this.Hide();
                    MainWindow mw = new MainWindow();
                    mw.ShowDialog();
                }
            }
            else {
                MessageBox.Show("Wrong value!");
            }

            switch (labelPoints.Text)
            {
                case "170":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T20";
                    labelBestEndingThird.Text = "BULL";
                    break;
                case "167":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T19";
                    labelBestEndingThird.Text = "BULL";
                    break;
                case "164":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T18";
                    labelBestEndingThird.Text = "BULL";
                    break;
                case "161":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T17";
                    labelBestEndingThird.Text = "BULL";
                    break;
                case "160":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T20";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "158":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T20";
                    labelBestEndingThird.Text = "D19";
                    break;
                case "157":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T19";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "156":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T20";
                    labelBestEndingThird.Text = "D18";
                    break;
                case "155":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T19";
                    labelBestEndingThird.Text = "D19";
                    break;
                case "154":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T18";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "153":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T19";
                    labelBestEndingThird.Text = "D18";
                    break;
                case "152":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T20";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "151":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T17";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "150":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T18";
                    labelBestEndingThird.Text = "D18";
                    break;
                case "149":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T19";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "148":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T16";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "147":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T17";
                    labelBestEndingThird.Text = "D18";
                    break;
                case "146":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T18";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "145":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T15";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "144":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T20";
                    labelBestEndingThird.Text = "D12";
                    break;
                case "143":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T17";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "142":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T14";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "141":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T19";
                    labelBestEndingThird.Text = "D12";
                    break;
                case "140":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T16";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "139":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "T14";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "138":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T18";
                    labelBestEndingThird.Text = "D12";
                    break;
                case "137":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "T16";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "136":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T20";
                    labelBestEndingThird.Text = "D8";
                    break;
                case "135":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T17";
                    labelBestEndingThird.Text = "D12";
                    break;
                case "134":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T14";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "133":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T19";
                    labelBestEndingThird.Text = "D8";
                    break;
                case "132":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T16";
                    labelBestEndingThird.Text = "D12";
                    break;
                case "131":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T13";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "130":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T20";
                    labelBestEndingThird.Text = "D5";
                    break;
                case "129":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "T16";
                    labelBestEndingThird.Text = "D12";
                    break;
                case "128":
                    labelBestEndingFirst.Text = "T18";
                    labelBestEndingSecond.Text = "T14";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "127":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T17";
                    labelBestEndingThird.Text = "D8";
                    break;
                case "126":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "T19";
                    labelBestEndingThird.Text = "D6";
                    break;
                case "125":
                    labelBestEndingFirst.Text = "25";
                    labelBestEndingSecond.Text = "T20";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "124":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "T16";
                    labelBestEndingThird.Text = "D8";
                    break;
                case "123":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "T16";
                    labelBestEndingThird.Text = "D9";
                    break;
                case "122":
                    labelBestEndingFirst.Text = "T18";
                    labelBestEndingSecond.Text = "T20";
                    labelBestEndingThird.Text = "D4";
                    break;
                case "121":
                    labelBestEndingFirst.Text = "T17";
                    labelBestEndingSecond.Text = "T10";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "120":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "20";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "119":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "T10";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "118":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "18";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "117":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "17";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "116":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "16";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "115":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "15";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "114":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "14";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "113":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "13";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "112":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "12";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "111":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "19";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "110":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "18";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "109":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "20";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "108":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "16";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "107":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "18";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "106":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "14";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "105":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "16";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "104":
                    labelBestEndingFirst.Text = "T18";
                    labelBestEndingSecond.Text = "18";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "103":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "3";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "102":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "10";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "101":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "1";
                    labelBestEndingThird.Text = "D20";
                    break;
                case "100":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "99":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "10";
                    labelBestEndingThird.Text = "D16";
                    break;
                case "98":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "D19";
                    break;
                case "97":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "96":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "D18";
                    break;
                case "95":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "D19";
                    break;
                case "94":
                    labelBestEndingFirst.Text = "T18";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "93":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "D18";
                    break;
                case "92":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "D16";
                    break;
                case "91":
                    labelBestEndingFirst.Text = "T17";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "90":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "D15";
                    break;
                case "89":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "D16";
                    break;
                case "88":
                    labelBestEndingFirst.Text = "T16";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "87":
                    labelBestEndingFirst.Text = "T17";
                    labelBestEndingSecond.Text = "D18";
                    break;
                case "86":
                    labelBestEndingFirst.Text = "T18";
                    labelBestEndingSecond.Text = "D16";
                    break;
                case "85":
                    labelBestEndingFirst.Text = "T15";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "84":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "D12";
                    break;
                case "83":
                    labelBestEndingFirst.Text = "T17";
                    labelBestEndingSecond.Text = "D16";
                    break;
                case "82":
                    labelBestEndingFirst.Text = "T14";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "81":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "D12";
                    break;
                case "80":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "D10";
                    break;
                case "79":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "D11";
                    break;
                case "78":
                    labelBestEndingFirst.Text = "T18";
                    labelBestEndingSecond.Text = "D12";
                    break;
                case "77":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "D10";
                    break;
                case "76":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "D8";
                    break;
                case "75":
                    labelBestEndingFirst.Text = "T17";
                    labelBestEndingSecond.Text = "D12";
                    break;
                case "74":
                    labelBestEndingFirst.Text = "T14";
                    labelBestEndingSecond.Text = "D16";
                    break;
                case "73":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "D8";
                    break;
                case "72":
                    labelBestEndingFirst.Text = "T16";
                    labelBestEndingSecond.Text = "D12";
                    break;
                case "71":
                    labelBestEndingFirst.Text = "T13";
                    labelBestEndingSecond.Text = "D16";
                    break;
                case "70":
                    labelBestEndingFirst.Text = "T10";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "69":
                    labelBestEndingFirst.Text = "T15";
                    labelBestEndingSecond.Text = "D12";
                    break;
                case "68":
                    labelBestEndingFirst.Text = "T20";
                    labelBestEndingSecond.Text = "D4";
                    break;
                case "67":
                    labelBestEndingFirst.Text = "T17";
                    labelBestEndingSecond.Text = "D8";
                    break;
                case "66":
                    labelBestEndingFirst.Text = "T10";
                    labelBestEndingSecond.Text = "D18";
                    break;
                case "65":
                    labelBestEndingFirst.Text = "T19";
                    labelBestEndingSecond.Text = "D4";
                    break;
                case "64":
                    labelBestEndingFirst.Text = "T16";
                    labelBestEndingSecond.Text = "D8";
                    break;
                case "63":
                    labelBestEndingFirst.Text = "T13";
                    labelBestEndingSecond.Text = "D12";
                    break;
                case "62":
                    labelBestEndingFirst.Text = "T10";
                    labelBestEndingSecond.Text = "D16";
                    break;
                case "61":
                    labelBestEndingFirst.Text = "T15";
                    labelBestEndingSecond.Text = "D8";
                    break;
                case "60":
                    labelBestEndingFirst.Text = "20";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "59":
                    labelBestEndingFirst.Text = "19";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "58":
                    labelBestEndingFirst.Text = "18";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "57":
                    labelBestEndingFirst.Text = "17";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "56":
                    labelBestEndingFirst.Text = "16";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "55":
                    labelBestEndingFirst.Text = "15";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "54":
                    labelBestEndingFirst.Text = "14";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "53":
                    labelBestEndingFirst.Text = "13";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "52":
                    labelBestEndingFirst.Text = "12";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "51":
                    labelBestEndingFirst.Text = "11";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "50":
                    labelBestEndingFirst.Text = "10";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "49":
                    labelBestEndingFirst.Text = "9";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "48":
                    labelBestEndingFirst.Text = "8";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "47":
                    labelBestEndingFirst.Text = "7";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "46":
                    labelBestEndingFirst.Text = "6";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "45":
                    labelBestEndingFirst.Text = "5";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "44":
                    labelBestEndingFirst.Text = "4";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "43":
                    labelBestEndingFirst.Text = "3";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "42":
                    labelBestEndingFirst.Text = "2";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "41":
                    labelBestEndingFirst.Text = "1";
                    labelBestEndingSecond.Text = "D20";
                    break;
                case "40":
                    labelBestEndingFirst.Text = "D20";
                    break;
                case "39":
                    labelBestEndingFirst.Text = "7";
                    labelBestEndingSecond.Text = "D16";
                    break;
                case "38":
                    labelBestEndingFirst.Text = "D19";
                    break;
                case "37":
                    labelBestEndingFirst.Text = "5";
                    labelBestEndingSecond.Text = "D16";
                    break;
                case "36":
                    labelBestEndingFirst.Text = "D18";
                    break;
                case "35":
                    labelBestEndingFirst.Text = "3";
                    labelBestEndingSecond.Text = "D16";
                    break;
                case "34":
                    labelBestEndingFirst.Text = "D17";
                    break;
                case "33":
                    labelBestEndingFirst.Text = "1";
                    labelBestEndingSecond.Text = "D16";
                    break;
                case "32":
                    labelBestEndingFirst.Text = "D16";
                    break;
                case "31":
                    labelBestEndingFirst.Text = "9";
                    labelBestEndingSecond.Text = "D12";
                    break;
                case "30":
                    labelBestEndingFirst.Text = "D15";
                    break;
                case "29":
                    labelBestEndingFirst.Text = "7";
                    labelBestEndingSecond.Text = "D12";
                    break;
                case "28":
                    labelBestEndingFirst.Text = "D14";
                    break;
                case "27":
                    labelBestEndingFirst.Text = "5";
                    labelBestEndingSecond.Text = "D12";
                    break;
                case "26":
                    labelBestEndingFirst.Text = "D13";
                    break;
                case "25":
                    labelBestEndingFirst.Text = "3";
                    labelBestEndingSecond.Text = "D12";
                    break;
                case "24":
                    labelBestEndingFirst.Text = "D12";
                    break;
                case "23":
                    labelBestEndingFirst.Text = "3";
                    labelBestEndingSecond.Text = "D10";
                    break;
                case "22":
                    labelBestEndingFirst.Text = "D11";
                    break;
                case "21":
                    labelBestEndingFirst.Text = "1";
                    labelBestEndingSecond.Text = "D10";
                    break;
                case "20":
                    labelBestEndingFirst.Text = "D10";
                    break;
                case "19":
                    labelBestEndingFirst.Text = "3";
                    labelBestEndingSecond.Text = "D8";
                    break;
                case "18":
                    labelBestEndingFirst.Text = "D9";
                    break;
                case "17":
                    labelBestEndingFirst.Text = "1";
                    labelBestEndingSecond.Text = "D8";
                    break;
                case "16":
                    labelBestEndingFirst.Text = "D8";
                    break;
                case "15":
                    labelBestEndingFirst.Text = "5";
                    labelBestEndingSecond.Text = "D5";
                    break;
                case "14":
                    labelBestEndingFirst.Text = "D7";
                    break;
                case "13":
                    labelBestEndingFirst.Text = "3";
                    labelBestEndingSecond.Text = "D5";
                    break;
                case "12":
                    labelBestEndingFirst.Text = "D6";
                    break;
                case "11":
                    labelBestEndingFirst.Text = "1";
                    labelBestEndingSecond.Text = "D5";
                    break;
                case "10":
                    labelBestEndingFirst.Text = "D5";
                    break;
                case "9":
                    labelBestEndingFirst.Text = "1";
                    labelBestEndingSecond.Text = "D4";
                    break;
                case "8":
                    labelBestEndingFirst.Text = "D4";
                    break;
                case "7":
                    labelBestEndingFirst.Text = "1";
                    labelBestEndingSecond.Text = "D3";
                    break;
                case "6":
                    labelBestEndingFirst.Text = "D3";
                    break;
                case "5":
                    labelBestEndingFirst.Text = "1";
                    labelBestEndingSecond.Text = "D2";
                    break;
                case "4":
                    labelBestEndingFirst.Text = "D2";
                    break;
                case "3":
                    labelBestEndingFirst.Text = "1";
                    labelBestEndingSecond.Text = "D1";
                    break;
                case "2":
                    labelBestEndingFirst.Text = "D1";
                    break;
            } // switch that shows the best ending

            textBoxFirstThrow.Text = "0";
            textBoxSecondThrow.Text = "0";
            textBoxThirdThrow.Text = "0";
        }

        private void buttonBackToMainWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }

        private void OnePlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBoxFirstThrow_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBoxSecondThrow_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBoxThirdThrow_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
