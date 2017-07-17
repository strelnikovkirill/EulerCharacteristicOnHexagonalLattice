namespace EulerCharacteristicOnHexagonalLattice
{
    partial class Form2
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
            this.PreviousSet_Button = new System.Windows.Forms.Button();
            this.NextSet_Button = new System.Windows.Forms.Button();
            this.ToFirstSet_Button = new System.Windows.Forms.Button();
            this.ToLastSet_Button = new System.Windows.Forms.Button();
            this.ShowInfo_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PreviousSet_Button
            // 
            this.PreviousSet_Button.Location = new System.Drawing.Point(25, 98);
            this.PreviousSet_Button.Name = "PreviousSet_Button";
            this.PreviousSet_Button.Size = new System.Drawing.Size(135, 56);
            this.PreviousSet_Button.TabIndex = 0;
            this.PreviousSet_Button.Text = "PREVIOUS";
            this.PreviousSet_Button.UseVisualStyleBackColor = true;
            this.PreviousSet_Button.Click += new System.EventHandler(this.PreviousSet_Button_Click);
            // 
            // NextSet_Button
            // 
            this.NextSet_Button.Location = new System.Drawing.Point(184, 98);
            this.NextSet_Button.Name = "NextSet_Button";
            this.NextSet_Button.Size = new System.Drawing.Size(135, 56);
            this.NextSet_Button.TabIndex = 1;
            this.NextSet_Button.Text = "NEXT";
            this.NextSet_Button.UseVisualStyleBackColor = true;
            this.NextSet_Button.Click += new System.EventHandler(this.NextSet_Button_Click);
            // 
            // ToFirstSet_Button
            // 
            this.ToFirstSet_Button.Location = new System.Drawing.Point(25, 24);
            this.ToFirstSet_Button.Name = "ToFirstSet_Button";
            this.ToFirstSet_Button.Size = new System.Drawing.Size(135, 56);
            this.ToFirstSet_Button.TabIndex = 2;
            this.ToFirstSet_Button.Text = "TO FIRST";
            this.ToFirstSet_Button.UseVisualStyleBackColor = true;
            this.ToFirstSet_Button.Click += new System.EventHandler(this.ToFirstSet_Button_Click);
            // 
            // ToLastSet_Button
            // 
            this.ToLastSet_Button.Location = new System.Drawing.Point(184, 24);
            this.ToLastSet_Button.Name = "ToLastSet_Button";
            this.ToLastSet_Button.Size = new System.Drawing.Size(135, 56);
            this.ToLastSet_Button.TabIndex = 3;
            this.ToLastSet_Button.Text = "TO LAST";
            this.ToLastSet_Button.UseVisualStyleBackColor = true;
            this.ToLastSet_Button.Click += new System.EventHandler(this.ToLastSet_Button_Click);
            // 
            // ShowInfo_Button
            // 
            this.ShowInfo_Button.Location = new System.Drawing.Point(25, 171);
            this.ShowInfo_Button.Name = "ShowInfo_Button";
            this.ShowInfo_Button.Size = new System.Drawing.Size(294, 30);
            this.ShowInfo_Button.TabIndex = 4;
            this.ShowInfo_Button.Text = "SHOW INFO";
            this.ShowInfo_Button.UseVisualStyleBackColor = true;
            this.ShowInfo_Button.Click += new System.EventHandler(this.ShowInfo_Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 218);
            this.Controls.Add(this.ShowInfo_Button);
            this.Controls.Add(this.ToLastSet_Button);
            this.Controls.Add(this.ToFirstSet_Button);
            this.Controls.Add(this.NextSet_Button);
            this.Controls.Add(this.PreviousSet_Button);
            this.MaximumSize = new System.Drawing.Size(365, 265);
            this.MinimumSize = new System.Drawing.Size(365, 265);
            this.Name = "Form2";
            this.Text = "Navigation Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PreviousSet_Button;
        private System.Windows.Forms.Button NextSet_Button;
        private System.Windows.Forms.Button ToFirstSet_Button;
        private System.Windows.Forms.Button ToLastSet_Button;
        private System.Windows.Forms.Button ShowInfo_Button;
    }
}