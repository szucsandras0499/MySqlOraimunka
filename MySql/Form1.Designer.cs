namespace MySql
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
            this.HozzaadButton = new System.Windows.Forms.Button();
            this.nevtextBox = new System.Windows.Forms.TextBox();
            this.fajtaTextBox = new System.Windows.Forms.TextBox();
            this.orokbefogad_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.torles = new System.Windows.Forms.Button();
            this.Modositas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HozzaadButton
            // 
            this.HozzaadButton.Location = new System.Drawing.Point(41, 100);
            this.HozzaadButton.Name = "HozzaadButton";
            this.HozzaadButton.Size = new System.Drawing.Size(75, 23);
            this.HozzaadButton.TabIndex = 0;
            this.HozzaadButton.Text = "Hozzaad";
            this.HozzaadButton.UseVisualStyleBackColor = true;
            this.HozzaadButton.Click += new System.EventHandler(this.HozzaadButton_Click);
            // 
            // nevtextBox
            // 
            this.nevtextBox.Location = new System.Drawing.Point(25, 55);
            this.nevtextBox.Name = "nevtextBox";
            this.nevtextBox.Size = new System.Drawing.Size(100, 20);
            this.nevtextBox.TabIndex = 1;
            // 
            // fajtaTextBox
            // 
            this.fajtaTextBox.Location = new System.Drawing.Point(163, 55);
            this.fajtaTextBox.Name = "fajtaTextBox";
            this.fajtaTextBox.Size = new System.Drawing.Size(100, 20);
            this.fajtaTextBox.TabIndex = 2;
            // 
            // orokbefogad_dateTimePicker
            // 
            this.orokbefogad_dateTimePicker.Location = new System.Drawing.Point(291, 55);
            this.orokbefogad_dateTimePicker.Name = "orokbefogad_dateTimePicker";
            this.orokbefogad_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orokbefogad_dateTimePicker.TabIndex = 3;
            // 
            // torles
            // 
            this.torles.Location = new System.Drawing.Point(163, 113);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(75, 23);
            this.torles.TabIndex = 4;
            this.torles.Text = "torles";
            this.torles.UseVisualStyleBackColor = true;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // Modositas
            // 
            this.Modositas.Location = new System.Drawing.Point(400, 166);
            this.Modositas.Name = "Modositas";
            this.Modositas.Size = new System.Drawing.Size(75, 23);
            this.Modositas.TabIndex = 5;
            this.Modositas.Text = "Modositas";
            this.Modositas.UseVisualStyleBackColor = true;
            this.Modositas.Click += new System.EventHandler(this.Modositas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 584);
            this.Controls.Add(this.Modositas);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.orokbefogad_dateTimePicker);
            this.Controls.Add(this.fajtaTextBox);
            this.Controls.Add(this.nevtextBox);
            this.Controls.Add(this.HozzaadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HozzaadButton;
        private System.Windows.Forms.TextBox nevtextBox;
        private System.Windows.Forms.TextBox fajtaTextBox;
        private System.Windows.Forms.DateTimePicker orokbefogad_dateTimePicker;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Button Modositas;
    }
}

