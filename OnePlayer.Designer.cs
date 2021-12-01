
namespace DartCalculator
{
    partial class OnePlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnePlayer));
            this.labelPoints = new System.Windows.Forms.Label();
            this.textBoxFirstThrow = new System.Windows.Forms.TextBox();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.textBoxSecondThrow = new System.Windows.Forms.TextBox();
            this.textBoxThirdThrow = new System.Windows.Forms.TextBox();
            this.buttonBackToMainWindow = new System.Windows.Forms.Button();
            this.label1stThrow = new System.Windows.Forms.Label();
            this.label2ndThrow = new System.Windows.Forms.Label();
            this.label3rdThrow = new System.Windows.Forms.Label();
            this.labelBestEnding = new System.Windows.Forms.Label();
            this.labelBestEndingFirst = new System.Windows.Forms.Label();
            this.labelBestEndingSecond = new System.Windows.Forms.Label();
            this.labelBestEndingThird = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoints.Location = new System.Drawing.Point(12, 9);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(59, 31);
            this.labelPoints.TabIndex = 0;
            this.labelPoints.Text = "501";
            // 
            // textBoxFirstThrow
            // 
            this.textBoxFirstThrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFirstThrow.Location = new System.Drawing.Point(12, 62);
            this.textBoxFirstThrow.Name = "textBoxFirstThrow";
            this.textBoxFirstThrow.Size = new System.Drawing.Size(53, 26);
            this.textBoxFirstThrow.TabIndex = 1;
            this.textBoxFirstThrow.Text = "0";
            this.textBoxFirstThrow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstThrow_KeyPress);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSubtract.Location = new System.Drawing.Point(12, 104);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(103, 42);
            this.buttonSubtract.TabIndex = 2;
            this.buttonSubtract.Text = "Subtract";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // textBoxSecondThrow
            // 
            this.textBoxSecondThrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSecondThrow.Location = new System.Drawing.Point(71, 62);
            this.textBoxSecondThrow.Name = "textBoxSecondThrow";
            this.textBoxSecondThrow.Size = new System.Drawing.Size(53, 26);
            this.textBoxSecondThrow.TabIndex = 3;
            this.textBoxSecondThrow.Text = "0";
            this.textBoxSecondThrow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSecondThrow_KeyPress);
            // 
            // textBoxThirdThrow
            // 
            this.textBoxThirdThrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxThirdThrow.Location = new System.Drawing.Point(130, 62);
            this.textBoxThirdThrow.Name = "textBoxThirdThrow";
            this.textBoxThirdThrow.Size = new System.Drawing.Size(53, 26);
            this.textBoxThirdThrow.TabIndex = 4;
            this.textBoxThirdThrow.Text = "0";
            this.textBoxThirdThrow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxThirdThrow_KeyPress);
            // 
            // buttonBackToMainWindow
            // 
            this.buttonBackToMainWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackToMainWindow.Location = new System.Drawing.Point(130, 106);
            this.buttonBackToMainWindow.Name = "buttonBackToMainWindow";
            this.buttonBackToMainWindow.Size = new System.Drawing.Size(123, 42);
            this.buttonBackToMainWindow.TabIndex = 5;
            this.buttonBackToMainWindow.Text = "Change number of players";
            this.buttonBackToMainWindow.UseVisualStyleBackColor = true;
            this.buttonBackToMainWindow.Click += new System.EventHandler(this.buttonBackToMainWindow_Click);
            // 
            // label1stThrow
            // 
            this.label1stThrow.AutoSize = true;
            this.label1stThrow.Location = new System.Drawing.Point(9, 46);
            this.label1stThrow.Name = "label1stThrow";
            this.label1stThrow.Size = new System.Drawing.Size(40, 13);
            this.label1stThrow.TabIndex = 6;
            this.label1stThrow.Text = "Throw:";
            // 
            // label2ndThrow
            // 
            this.label2ndThrow.AutoSize = true;
            this.label2ndThrow.Location = new System.Drawing.Point(68, 46);
            this.label2ndThrow.Name = "label2ndThrow";
            this.label2ndThrow.Size = new System.Drawing.Size(40, 13);
            this.label2ndThrow.TabIndex = 7;
            this.label2ndThrow.Text = "Throw:";
            // 
            // label3rdThrow
            // 
            this.label3rdThrow.AutoSize = true;
            this.label3rdThrow.Location = new System.Drawing.Point(127, 46);
            this.label3rdThrow.Name = "label3rdThrow";
            this.label3rdThrow.Size = new System.Drawing.Size(40, 13);
            this.label3rdThrow.TabIndex = 8;
            this.label3rdThrow.Text = "Throw:";
            // 
            // labelBestEnding
            // 
            this.labelBestEnding.AutoSize = true;
            this.labelBestEnding.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBestEnding.Location = new System.Drawing.Point(214, 9);
            this.labelBestEnding.Name = "labelBestEnding";
            this.labelBestEnding.Size = new System.Drawing.Size(225, 31);
            this.labelBestEnding.TabIndex = 9;
            this.labelBestEnding.Text = "Best ending path:";
            // 
            // labelBestEndingFirst
            // 
            this.labelBestEndingFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBestEndingFirst.Location = new System.Drawing.Point(229, 62);
            this.labelBestEndingFirst.Name = "labelBestEndingFirst";
            this.labelBestEndingFirst.Size = new System.Drawing.Size(56, 26);
            this.labelBestEndingFirst.TabIndex = 10;
            // 
            // labelBestEndingSecond
            // 
            this.labelBestEndingSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBestEndingSecond.Location = new System.Drawing.Point(291, 62);
            this.labelBestEndingSecond.Name = "labelBestEndingSecond";
            this.labelBestEndingSecond.Size = new System.Drawing.Size(56, 26);
            this.labelBestEndingSecond.TabIndex = 11;
            // 
            // labelBestEndingThird
            // 
            this.labelBestEndingThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBestEndingThird.Location = new System.Drawing.Point(353, 62);
            this.labelBestEndingThird.Name = "labelBestEndingThird";
            this.labelBestEndingThird.Size = new System.Drawing.Size(56, 26);
            this.labelBestEndingThird.TabIndex = 12;
            // 
            // OnePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 160);
            this.Controls.Add(this.labelBestEndingThird);
            this.Controls.Add(this.labelBestEndingSecond);
            this.Controls.Add(this.labelBestEndingFirst);
            this.Controls.Add(this.labelBestEnding);
            this.Controls.Add(this.label3rdThrow);
            this.Controls.Add(this.label2ndThrow);
            this.Controls.Add(this.label1stThrow);
            this.Controls.Add(this.buttonBackToMainWindow);
            this.Controls.Add(this.textBoxThirdThrow);
            this.Controls.Add(this.textBoxSecondThrow);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.textBoxFirstThrow);
            this.Controls.Add(this.labelPoints);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OnePlayer";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnePlayer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.TextBox textBoxFirstThrow;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.TextBox textBoxSecondThrow;
        private System.Windows.Forms.TextBox textBoxThirdThrow;
        private System.Windows.Forms.Button buttonBackToMainWindow;
        private System.Windows.Forms.Label label1stThrow;
        private System.Windows.Forms.Label label2ndThrow;
        private System.Windows.Forms.Label label3rdThrow;
        private System.Windows.Forms.Label labelBestEnding;
        private System.Windows.Forms.Label labelBestEndingFirst;
        private System.Windows.Forms.Label labelBestEndingSecond;
        private System.Windows.Forms.Label labelBestEndingThird;
    }
}