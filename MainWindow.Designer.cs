
namespace DartCalculator
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.labelHowMuchPlayers = new System.Windows.Forms.Label();
            this.buttonOnePlayer = new System.Windows.Forms.Button();
            this.buttonTwoPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHowMuchPlayers
            // 
            this.labelHowMuchPlayers.AutoSize = true;
            this.labelHowMuchPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHowMuchPlayers.Location = new System.Drawing.Point(67, 31);
            this.labelHowMuchPlayers.Name = "labelHowMuchPlayers";
            this.labelHowMuchPlayers.Size = new System.Drawing.Size(147, 20);
            this.labelHowMuchPlayers.TabIndex = 2;
            this.labelHowMuchPlayers.Text = "How much players?";
            this.labelHowMuchPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOnePlayer
            // 
            this.buttonOnePlayer.Location = new System.Drawing.Point(12, 105);
            this.buttonOnePlayer.Name = "buttonOnePlayer";
            this.buttonOnePlayer.Size = new System.Drawing.Size(98, 49);
            this.buttonOnePlayer.TabIndex = 3;
            this.buttonOnePlayer.Text = "1 PLAYERS";
            this.buttonOnePlayer.UseVisualStyleBackColor = true;
            this.buttonOnePlayer.Click += new System.EventHandler(this.buttonOnePlayer_Click);
            // 
            // buttonTwoPlayers
            // 
            this.buttonTwoPlayers.Location = new System.Drawing.Point(173, 105);
            this.buttonTwoPlayers.Name = "buttonTwoPlayers";
            this.buttonTwoPlayers.Size = new System.Drawing.Size(98, 49);
            this.buttonTwoPlayers.TabIndex = 4;
            this.buttonTwoPlayers.Text = "2 PLAYERS";
            this.buttonTwoPlayers.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 175);
            this.Controls.Add(this.buttonTwoPlayers);
            this.Controls.Add(this.buttonOnePlayer);
            this.Controls.Add(this.labelHowMuchPlayers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Dart Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHowMuchPlayers;
        private System.Windows.Forms.Button buttonOnePlayer;
        private System.Windows.Forms.Button buttonTwoPlayers;
    }
}

