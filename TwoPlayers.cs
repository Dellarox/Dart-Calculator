using System;
using System.Windows.Forms;

namespace DartCalculator
{
    public partial class TwoPlayers : Form
    {
        public TwoPlayers()
        {
            InitializeComponent();
        }

        private void TwoPlayers_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
