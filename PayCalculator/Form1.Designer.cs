namespace PayCalculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoursLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.hoursInput = new System.Windows.Forms.TextBox();
            this.rateInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalInput = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(86, 64);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(52, 20);
            this.hoursLabel.TabIndex = 0;
            this.hoursLabel.Text = "Hours";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(64, 111);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(74, 20);
            this.rateLabel.TabIndex = 1;
            this.rateLabel.Text = "Pay Rate";
            // 
            // hoursInput
            // 
            this.hoursInput.Location = new System.Drawing.Point(144, 58);
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(100, 26);
            this.hoursInput.TabIndex = 2;
            // 
            // rateInput
            // 
            this.rateInput.Location = new System.Drawing.Point(144, 105);
            this.rateInput.Name = "rateInput";
            this.rateInput.Size = new System.Drawing.Size(100, 26);
            this.rateInput.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(112, 183);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(104, 35);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalInput
            // 
            this.subtotalInput.AutoSize = true;
            this.subtotalInput.Location = new System.Drawing.Point(46, 249);
            this.subtotalInput.Name = "subtotalInput";
            this.subtotalInput.Size = new System.Drawing.Size(69, 20);
            this.subtotalInput.TabIndex = 6;
            this.subtotalInput.Text = "Subtotal";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Location = new System.Drawing.Point(156, 249);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(21, 20);
            this.subtotalOutput.TabIndex = 7;
            this.subtotalOutput.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.subtotalInput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rateInput);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.hoursLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox hoursInput;
        private System.Windows.Forms.TextBox rateInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalInput;
        private System.Windows.Forms.Label subtotalOutput;
    }
}

