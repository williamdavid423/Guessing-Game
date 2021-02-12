namespace Guessing_Game
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.enterLabel = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(52, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(278, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Guessing Game";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.ForeColor = System.Drawing.Color.White;
            this.enterLabel.Location = new System.Drawing.Point(54, 170);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(276, 19);
            this.enterLabel.TabIndex = 1;
            this.enterLabel.Text = "Enter a Number Between 1 and 100";
            this.enterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(156, 227);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(59, 20);
            this.numberInput.TabIndex = 2;
            this.numberInput.TextChanged += new System.EventHandler(this.NumberInput_TextChanged);
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.Color.Black;
            this.guessButton.ForeColor = System.Drawing.Color.White;
            this.guessButton.Location = new System.Drawing.Point(129, 286);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(112, 47);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.DarkRed;
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputLabel.Location = new System.Drawing.Point(129, 372);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(35, 13);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

