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

            if (string.IsNullOrWhiteSpace(textBoxFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxSecondThrow.Text) && string.IsNullOrWhiteSpace(textBoxThirdThrow.Text))
            {
                MessageBox.Show("All boxes are empty!");
            } // wszystkie puste
            else if (string.IsNullOrWhiteSpace(textBoxSecondThrow.Text) && string.IsNullOrWhiteSpace(textBoxThirdThrow.Text)) 
            {
                actualNumber = int.Parse(labelPoints.Text);
                subtract = int.Parse(textBoxFirstThrow.Text);

                if (subtract > actualNumber)
                {
                    MessageBox.Show("FURA!");
                }
                else
                {
                    actualNumber -= subtract;
                    labelPoints.Text = actualNumber.ToString();
                }
            } // drugi trzeci pusty
            else if (string.IsNullOrWhiteSpace(textBoxFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxThirdThrow.Text))
            {
                actualNumber = int.Parse(labelPoints.Text);
                subtract = int.Parse(textBoxSecondThrow.Text);

                if (subtract > actualNumber)
                {
                    MessageBox.Show("FURA!");
                }
                else
                {
                    actualNumber -= subtract;
                    labelPoints.Text = actualNumber.ToString();
                }
            } // pierwszy trzeci pusty
            else if (string.IsNullOrWhiteSpace(textBoxFirstThrow.Text) && string.IsNullOrWhiteSpace(textBoxSecondThrow.Text))
            {
                actualNumber = int.Parse(labelPoints.Text);
                subtract = int.Parse(textBoxThirdThrow.Text);

                if (subtract > actualNumber)
                {
                    MessageBox.Show("FURA!");
                }
                else
                {
                    actualNumber -= subtract;
                    labelPoints.Text = actualNumber.ToString();
                }
            } // drugi pierwszy pusty
            else if (string.IsNullOrWhiteSpace(textBoxFirstThrow.Text)) 
            {
                actualNumber = int.Parse(labelPoints.Text);
                subtract = int.Parse(textBoxThirdThrow.Text) + int.Parse(textBoxSecondThrow.Text);

                if (subtract > actualNumber)
                {
                    MessageBox.Show("FURA!");
                }
                else
                {
                    actualNumber -= subtract;
                    labelPoints.Text = actualNumber.ToString();
                }
            } // tylko pierwszy pusty
            else if (string.IsNullOrWhiteSpace(textBoxSecondThrow.Text))
            {
                actualNumber = int.Parse(labelPoints.Text);
                subtract = int.Parse(textBoxThirdThrow.Text) + int.Parse(textBoxFirstThrow.Text);

                if (subtract > actualNumber)
                {
                    MessageBox.Show("FURA!");
                }
                else
                {
                    actualNumber -= subtract;
                    labelPoints.Text = actualNumber.ToString();
                }
            } // tylko drugi pusty
            else if (string.IsNullOrWhiteSpace(textBoxThirdThrow.Text))
            {
                actualNumber = int.Parse(labelPoints.Text);
                subtract = int.Parse(textBoxSecondThrow.Text) + int.Parse(textBoxFirstThrow.Text);

                if (subtract > actualNumber)
                {
                    MessageBox.Show("FURA!");
                }
                else
                {
                    actualNumber -= subtract;
                    labelPoints.Text = actualNumber.ToString();
                }
            } // tylko trzeci pusty
            else
            {
                actualNumber = int.Parse(labelPoints.Text);
                subtract = int.Parse(textBoxFirstThrow.Text) + int.Parse(textBoxSecondThrow.Text) + int.Parse(textBoxThirdThrow.Text);

                if (subtract > actualNumber)
                {
                    MessageBox.Show("FURA!");
                }
                else
                {
                    actualNumber -= subtract;
                    labelPoints.Text = actualNumber.ToString();
                }
            } // żaden niepusty
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
    }
}
