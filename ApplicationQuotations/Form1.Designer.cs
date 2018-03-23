namespace ApplicationQuotations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DevelopmentLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.VATLabel = new System.Windows.Forms.Label();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.DevelopmentOptions = new System.Windows.Forms.ComboBox();
            this.VATAmount = new System.Windows.Forms.TextBox();
            this.SubTotal = new System.Windows.Forms.TextBox();
            this.PaymentDue = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButtton = new System.Windows.Forms.Button();
            this.HoursText = new System.Windows.Forms.TextBox();
            this.OptionError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DevelopmentLabel
            // 
            this.DevelopmentLabel.AutoSize = true;
            this.DevelopmentLabel.Location = new System.Drawing.Point(12, 48);
            this.DevelopmentLabel.Name = "DevelopmentLabel";
            this.DevelopmentLabel.Size = new System.Drawing.Size(93, 13);
            this.DevelopmentLabel.TabIndex = 0;
            this.DevelopmentLabel.Text = "Development Item";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(19, 82);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(35, 13);
            this.HoursLabel.TabIndex = 1;
            this.HoursLabel.Text = "Hours";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(12, 113);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(53, 13);
            this.SubTotalLabel.TabIndex = 2;
            this.SubTotalLabel.Text = "Sub Total";
            // 
            // VATLabel
            // 
            this.VATLabel.AutoSize = true;
            this.VATLabel.Location = new System.Drawing.Point(26, 145);
            this.VATLabel.Name = "VATLabel";
            this.VATLabel.Size = new System.Drawing.Size(28, 13);
            this.VATLabel.TabIndex = 3;
            this.VATLabel.Text = "VAT";
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Location = new System.Drawing.Point(6, 174);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(71, 13);
            this.PaymentLabel.TabIndex = 4;
            this.PaymentLabel.Text = "Payment Due";
            // 
            // DevelopmentOptions
            // 
            this.DevelopmentOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DevelopmentOptions.FormattingEnabled = true;
            this.DevelopmentOptions.Items.AddRange(new object[] {
            "Desktop Application",
            "Network",
            "Website",
            "Mobile Application"});
            this.DevelopmentOptions.Location = new System.Drawing.Point(111, 45);
            this.DevelopmentOptions.Name = "DevelopmentOptions";
            this.DevelopmentOptions.Size = new System.Drawing.Size(121, 21);
            this.DevelopmentOptions.TabIndex = 5;
            this.DevelopmentOptions.SelectedIndexChanged += new System.EventHandler(this.DevelopementOptions_SelectedIndexChanged);
            this.DevelopmentOptions.Click += new System.EventHandler(this.DevelopementOptions_Click);
            // 
            // VATAmount
            // 
            this.VATAmount.Location = new System.Drawing.Point(60, 142);
            this.VATAmount.Name = "VATAmount";
            this.VATAmount.ReadOnly = true;
            this.VATAmount.Size = new System.Drawing.Size(100, 20);
            this.VATAmount.TabIndex = 6;
            // 
            // SubTotal
            // 
            this.SubTotal.Location = new System.Drawing.Point(71, 110);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Size = new System.Drawing.Size(100, 20);
            this.SubTotal.TabIndex = 7;
            // 
            // PaymentDue
            // 
            this.PaymentDue.Location = new System.Drawing.Point(83, 171);
            this.PaymentDue.Name = "PaymentDue";
            this.PaymentDue.ReadOnly = true;
            this.PaymentDue.Size = new System.Drawing.Size(100, 20);
            this.PaymentDue.TabIndex = 8;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(266, 110);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 10;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(266, 139);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButtton
            // 
            this.ExitButtton.Location = new System.Drawing.Point(266, 168);
            this.ExitButtton.Name = "ExitButtton";
            this.ExitButtton.Size = new System.Drawing.Size(75, 23);
            this.ExitButtton.TabIndex = 12;
            this.ExitButtton.Text = "Exit";
            this.ExitButtton.UseVisualStyleBackColor = true;
            this.ExitButtton.Click += new System.EventHandler(this.ExitButtton_Click);
            // 
            // HoursText
            // 
            this.HoursText.Location = new System.Drawing.Point(60, 79);
            this.HoursText.Name = "HoursText";
            this.HoursText.ReadOnly = true;
            this.HoursText.Size = new System.Drawing.Size(100, 20);
            this.HoursText.TabIndex = 14;
            // 
            // OptionError
            // 
            this.OptionError.AutoSize = true;
            this.OptionError.ForeColor = System.Drawing.Color.Red;
            this.OptionError.Location = new System.Drawing.Point(193, 199);
            this.OptionError.Name = "OptionError";
            this.OptionError.Size = new System.Drawing.Size(182, 13);
            this.OptionError.TabIndex = 15;
            this.OptionError.Text = "Please choose a development option";
            this.OptionError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Software Development Quotes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OptionError);
            this.Controls.Add(this.HoursText);
            this.Controls.Add(this.ExitButtton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.PaymentDue);
            this.Controls.Add(this.SubTotal);
            this.Controls.Add(this.VATAmount);
            this.Controls.Add(this.DevelopmentOptions);
            this.Controls.Add(this.PaymentLabel);
            this.Controls.Add(this.VATLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.DevelopmentLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Software Development Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DevelopmentLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label VATLabel;
        private System.Windows.Forms.Label PaymentLabel;
        private System.Windows.Forms.ComboBox DevelopmentOptions;
        private System.Windows.Forms.TextBox VATAmount;
        private System.Windows.Forms.TextBox SubTotal;
        private System.Windows.Forms.TextBox PaymentDue;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButtton;
        private System.Windows.Forms.TextBox HoursText;
        private System.Windows.Forms.Label OptionError;
        private System.Windows.Forms.Label label1;
    }
}

