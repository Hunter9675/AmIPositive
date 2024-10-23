namespace AmIPositive
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
            this.ponAnddb7Button = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.ponInput = new System.Windows.Forms.TextBox();
            this.inputTitle = new System.Windows.Forms.Label();
            this.ponOutput = new System.Windows.Forms.Label();
            this.db7Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ponAnddb7Button
            // 
            this.ponAnddb7Button.Location = new System.Drawing.Point(62, 153);
            this.ponAnddb7Button.Name = "ponAnddb7Button";
            this.ponAnddb7Button.Size = new System.Drawing.Size(161, 63);
            this.ponAnddb7Button.TabIndex = 0;
            this.ponAnddb7Button.Text = "Activate";
            this.ponAnddb7Button.UseVisualStyleBackColor = true;
            this.ponAnddb7Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(463, 40);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Type a number, press the button and see if you\'re positive or not!\r\n\r\n";
            // 
            // ponInput
            // 
            this.ponInput.Location = new System.Drawing.Point(85, 52);
            this.ponInput.Name = "ponInput";
            this.ponInput.Size = new System.Drawing.Size(191, 20);
            this.ponInput.TabIndex = 2;
            // 
            // inputTitle
            // 
            this.inputTitle.AutoSize = true;
            this.inputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTitle.Location = new System.Drawing.Point(24, 52);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(50, 20);
            this.inputTitle.TabIndex = 3;
            this.inputTitle.Text = "Input:";
            // 
            // ponOutput
            // 
            this.ponOutput.AutoSize = true;
            this.ponOutput.Location = new System.Drawing.Point(298, 101);
            this.ponOutput.Name = "ponOutput";
            this.ponOutput.Size = new System.Drawing.Size(0, 13);
            this.ponOutput.TabIndex = 4;
            // 
            // db7Output
            // 
            this.db7Output.AutoSize = true;
            this.db7Output.Location = new System.Drawing.Point(298, 178);
            this.db7Output.Name = "db7Output";
            this.db7Output.Size = new System.Drawing.Size(0, 13);
            this.db7Output.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 271);
            this.Controls.Add(this.db7Output);
            this.Controls.Add(this.ponOutput);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.ponInput);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.ponAnddb7Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ponAnddb7Button;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox ponInput;
        private System.Windows.Forms.Label inputTitle;
        private System.Windows.Forms.Label ponOutput;
        private System.Windows.Forms.Label db7Output;
    }
}

