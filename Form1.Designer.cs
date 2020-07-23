namespace Hangman_Practical
{
    partial class Hangman
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
            this.Word = new System.Windows.Forms.TextBox();
            this.letterCheck = new System.Windows.Forms.TextBox();
            this.btnLetterCheck = new System.Windows.Forms.Button();
            this.lblAttemptNumber = new System.Windows.Forms.Label();
            this.lblUsedLetter = new System.Windows.Forms.Label();
            this.textUsedLetters = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Word
            // 
            this.Word.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(98, 25);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(517, 45);
            this.Word.TabIndex = 0;
            // 
            // letterCheck
            // 
            this.letterCheck.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.letterCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterCheck.Location = new System.Drawing.Point(205, 99);
            this.letterCheck.Name = "letterCheck";
            this.letterCheck.Size = new System.Drawing.Size(46, 41);
            this.letterCheck.TabIndex = 1;
            // 
            // btnLetterCheck
            // 
            this.btnLetterCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetterCheck.Location = new System.Drawing.Point(42, 99);
            this.btnLetterCheck.Name = "btnLetterCheck";
            this.btnLetterCheck.Size = new System.Drawing.Size(131, 107);
            this.btnLetterCheck.TabIndex = 2;
            this.btnLetterCheck.Text = "Check for Letter";
            this.btnLetterCheck.UseVisualStyleBackColor = true;
            this.btnLetterCheck.Click += new System.EventHandler(this.btnLetterCheck_Click);
            // 
            // lblAttemptNumber
            // 
            this.lblAttemptNumber.AutoSize = true;
            this.lblAttemptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttemptNumber.Location = new System.Drawing.Point(252, 158);
            this.lblAttemptNumber.Name = "lblAttemptNumber";
            this.lblAttemptNumber.Size = new System.Drawing.Size(310, 36);
            this.lblAttemptNumber.TabIndex = 3;
            this.lblAttemptNumber.Text = "Number of Attempts: 0";
            // 
            // lblUsedLetter
            // 
            this.lblUsedLetter.AutoSize = true;
            this.lblUsedLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedLetter.Location = new System.Drawing.Point(36, 239);
            this.lblUsedLetter.Name = "lblUsedLetter";
            this.lblUsedLetter.Size = new System.Drawing.Size(183, 36);
            this.lblUsedLetter.TabIndex = 4;
            this.lblUsedLetter.Text = "Used Letters";
            // 
            // textUsedLetters
            // 
            this.textUsedLetters.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textUsedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsedLetters.Location = new System.Drawing.Point(42, 312);
            this.textUsedLetters.Name = "textUsedLetters";
            this.textUsedLetters.Size = new System.Drawing.Size(573, 38);
            this.textUsedLetters.TabIndex = 5;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(42, 399);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(245, 75);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "Start New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveUp.Location = new System.Drawing.Point(362, 399);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(253, 75);
            this.btnGiveUp.TabIndex = 7;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.Red;
            this.winnerLabel.Location = new System.Drawing.Point(284, 99);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(0, 46);
            this.winnerLabel.TabIndex = 8;
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(696, 522);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.textUsedLetters);
            this.Controls.Add(this.lblUsedLetter);
            this.Controls.Add(this.lblAttemptNumber);
            this.Controls.Add(this.btnLetterCheck);
            this.Controls.Add(this.letterCheck);
            this.Controls.Add(this.Word);
            this.Name = "Hangman";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.TextBox letterCheck;
        private System.Windows.Forms.Button btnLetterCheck;
        private System.Windows.Forms.Label lblAttemptNumber;
        private System.Windows.Forms.Label lblUsedLetter;
        private System.Windows.Forms.TextBox textUsedLetters;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Label winnerLabel;
    }
}

