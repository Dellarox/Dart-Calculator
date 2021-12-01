using System;
using System.Windows.Forms;

namespace DartCalculator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOnePlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            OnePlayer onePlayer = new OnePlayer();
            onePlayer.ShowDialog();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonTwoPlayers_Click(object sender, EventArgs e)
        {
            this.Hide();
            TwoPlayers twoPlayers = new TwoPlayers();
            twoPlayers.ShowDialog();
        }
    }
}
