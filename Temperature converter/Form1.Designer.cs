namespace Temperature_converter
{
    partial class Form1
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.TemperatureTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Imie:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(12, 41);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Nazwisko:";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(12, 68);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(90, 13);
            this.TemperatureLabel.TabIndex = 2;
            this.TemperatureLabel.Text = "Temperatura (C°):";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(48, 13);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.FirstNameTextBox.TabIndex = 3;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(74, 38);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(227, 20);
            this.LastNameTextBox.TabIndex = 4;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // TemperatureTextBox
            // 
            this.TemperatureTextBox.Location = new System.Drawing.Point(99, 64);
            this.TemperatureTextBox.Name = "TemperatureTextBox";
            this.TemperatureTextBox.Size = new System.Drawing.Size(203, 20);
            this.TemperatureTextBox.TabIndex = 5;
            this.TemperatureTextBox.TextChanged += new System.EventHandler(this.TemperatureTextBox_TextChanged);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 114);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(35, 13);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 240);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.TemperatureTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox TemperatureTextBox;
        private System.Windows.Forms.Label ResultLabel;
    }
}

