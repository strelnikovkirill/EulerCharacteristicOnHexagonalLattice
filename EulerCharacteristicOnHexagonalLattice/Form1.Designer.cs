namespace EulerCharacteristicOnHexagonalLattice
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eulerCharacteristic_Label = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.x0_Label = new System.Windows.Forms.Label();
            this.x1_Label = new System.Windows.Forms.Label();
            this.x2_Label = new System.Windows.Forms.Label();
            this.x3_Label = new System.Windows.Forms.Label();
            this.x4_Label = new System.Windows.Forms.Label();
            this.x5_Label = new System.Windows.Forms.Label();
            this.x6_Label = new System.Windows.Forms.Label();
            this.x7_Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.x15_Label = new System.Windows.Forms.Label();
            this.x14_Label = new System.Windows.Forms.Label();
            this.x13_Label = new System.Windows.Forms.Label();
            this.x12_Label = new System.Windows.Forms.Label();
            this.x11_Label = new System.Windows.Forms.Label();
            this.x10_Label = new System.Windows.Forms.Label();
            this.x9_Label = new System.Windows.Forms.Label();
            this.x8_Label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(709, 633);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(736, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 634);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hexagonal Lattice (8 x 8)";
            // 
            // calculate_Button
            // 
            this.calculate_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculate_Button.Location = new System.Drawing.Point(104, 576);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(231, 41);
            this.calculate_Button.TabIndex = 2;
            this.calculate_Button.Text = "CALCULATE";
            this.calculate_Button.UseVisualStyleBackColor = false;
            this.calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-15, 20);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "X_0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(94, 20);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(51, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "X_1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(151, 20);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(51, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "X_2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(208, 20);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(51, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "X_3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(265, 20);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(51, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "X_4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(322, 20);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(51, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "X_5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(379, 20);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(51, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "X_6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(436, 20);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(51, 30);
            this.label9.TabIndex = 7;
            this.label9.Text = "X_7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(-15, 13);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(28, 5, 5, 5);
            this.label10.Size = new System.Drawing.Size(74, 30);
            this.label10.TabIndex = 8;
            this.label10.Text = "X_8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(62, 13);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5);
            this.label11.Size = new System.Drawing.Size(51, 30);
            this.label11.TabIndex = 9;
            this.label11.Text = "X_9";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(118, 13);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5);
            this.label12.Size = new System.Drawing.Size(61, 30);
            this.label12.TabIndex = 10;
            this.label12.Text = "X_10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(186, 13);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(5);
            this.label13.Size = new System.Drawing.Size(61, 30);
            this.label13.TabIndex = 11;
            this.label13.Text = "X_11";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(252, 13);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(5);
            this.label14.Size = new System.Drawing.Size(61, 30);
            this.label14.TabIndex = 12;
            this.label14.Text = "X_12";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(320, 13);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(5);
            this.label15.Size = new System.Drawing.Size(61, 30);
            this.label15.TabIndex = 13;
            this.label15.Text = "X_13";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(382, 13);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(5);
            this.label16.Size = new System.Drawing.Size(61, 30);
            this.label16.TabIndex = 14;
            this.label16.Text = "X_14";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(447, 13);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(5);
            this.label17.Size = new System.Drawing.Size(61, 30);
            this.label17.TabIndex = 15;
            this.label17.Text = "X_15";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.eulerCharacteristic_Label);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(104, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 100);
            this.panel2.TabIndex = 5;
            // 
            // eulerCharacteristic_Label
            // 
            this.eulerCharacteristic_Label.AutoSize = true;
            this.eulerCharacteristic_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eulerCharacteristic_Label.Location = new System.Drawing.Point(350, 38);
            this.eulerCharacteristic_Label.Name = "eulerCharacteristic_Label";
            this.eulerCharacteristic_Label.Size = new System.Drawing.Size(19, 20);
            this.eulerCharacteristic_Label.TabIndex = 1;
            this.eulerCharacteristic_Label.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(111, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(270, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "X = X_4 - X_9 + X_10 - X_11 =";
            // 
            // x0_Label
            // 
            this.x0_Label.AutoSize = true;
            this.x0_Label.Cursor = System.Windows.Forms.Cursors.Default;
            this.x0_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x0_Label.Location = new System.Drawing.Point(44, 58);
            this.x0_Label.Name = "x0_Label";
            this.x0_Label.Size = new System.Drawing.Size(19, 20);
            this.x0_Label.TabIndex = 1;
            this.x0_Label.Text = "0";
            // 
            // x1_Label
            // 
            this.x1_Label.AutoSize = true;
            this.x1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1_Label.Location = new System.Drawing.Point(110, 58);
            this.x1_Label.Name = "x1_Label";
            this.x1_Label.Size = new System.Drawing.Size(19, 20);
            this.x1_Label.TabIndex = 8;
            this.x1_Label.Text = "0";
            // 
            // x2_Label
            // 
            this.x2_Label.AutoSize = true;
            this.x2_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x2_Label.Location = new System.Drawing.Point(168, 58);
            this.x2_Label.Name = "x2_Label";
            this.x2_Label.Size = new System.Drawing.Size(19, 20);
            this.x2_Label.TabIndex = 9;
            this.x2_Label.Text = "0";
            // 
            // x3_Label
            // 
            this.x3_Label.AutoSize = true;
            this.x3_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x3_Label.Location = new System.Drawing.Point(226, 58);
            this.x3_Label.Name = "x3_Label";
            this.x3_Label.Size = new System.Drawing.Size(19, 20);
            this.x3_Label.TabIndex = 10;
            this.x3_Label.Text = "0";
            // 
            // x4_Label
            // 
            this.x4_Label.AutoSize = true;
            this.x4_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x4_Label.Location = new System.Drawing.Point(282, 58);
            this.x4_Label.Name = "x4_Label";
            this.x4_Label.Size = new System.Drawing.Size(19, 20);
            this.x4_Label.TabIndex = 11;
            this.x4_Label.Text = "0";
            // 
            // x5_Label
            // 
            this.x5_Label.AutoSize = true;
            this.x5_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x5_Label.Location = new System.Drawing.Point(338, 58);
            this.x5_Label.Name = "x5_Label";
            this.x5_Label.Size = new System.Drawing.Size(19, 20);
            this.x5_Label.TabIndex = 12;
            this.x5_Label.Text = "0";
            // 
            // x6_Label
            // 
            this.x6_Label.AutoSize = true;
            this.x6_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x6_Label.Location = new System.Drawing.Point(396, 58);
            this.x6_Label.Name = "x6_Label";
            this.x6_Label.Size = new System.Drawing.Size(19, 20);
            this.x6_Label.TabIndex = 13;
            this.x6_Label.Text = "0";
            // 
            // x7_Label
            // 
            this.x7_Label.AutoSize = true;
            this.x7_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x7_Label.Location = new System.Drawing.Point(452, 58);
            this.x7_Label.Name = "x7_Label";
            this.x7_Label.Size = new System.Drawing.Size(19, 20);
            this.x7_Label.TabIndex = 14;
            this.x7_Label.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.x7_Label);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.x6_Label);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.x5_Label);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.x4_Label);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.x3_Label);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.x2_Label);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.x1_Label);
            this.panel3.Controls.Add(this.x0_Label);
            this.panel3.Location = new System.Drawing.Point(104, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 100);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.x15_Label);
            this.panel4.Controls.Add(this.x14_Label);
            this.panel4.Controls.Add(this.x13_Label);
            this.panel4.Controls.Add(this.x12_Label);
            this.panel4.Controls.Add(this.x11_Label);
            this.panel4.Controls.Add(this.x10_Label);
            this.panel4.Controls.Add(this.x9_Label);
            this.panel4.Controls.Add(this.x8_Label);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(104, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 100);
            this.panel4.TabIndex = 7;
            // 
            // x15_Label
            // 
            this.x15_Label.AutoSize = true;
            this.x15_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x15_Label.Location = new System.Drawing.Point(462, 55);
            this.x15_Label.Name = "x15_Label";
            this.x15_Label.Size = new System.Drawing.Size(19, 20);
            this.x15_Label.TabIndex = 22;
            this.x15_Label.Text = "0";
            // 
            // x14_Label
            // 
            this.x14_Label.AutoSize = true;
            this.x14_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x14_Label.Location = new System.Drawing.Point(400, 55);
            this.x14_Label.Name = "x14_Label";
            this.x14_Label.Size = new System.Drawing.Size(19, 20);
            this.x14_Label.TabIndex = 21;
            this.x14_Label.Text = "0";
            // 
            // x13_Label
            // 
            this.x13_Label.AutoSize = true;
            this.x13_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x13_Label.Location = new System.Drawing.Point(340, 55);
            this.x13_Label.Name = "x13_Label";
            this.x13_Label.Size = new System.Drawing.Size(19, 20);
            this.x13_Label.TabIndex = 20;
            this.x13_Label.Text = "0";
            // 
            // x12_Label
            // 
            this.x12_Label.AutoSize = true;
            this.x12_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x12_Label.Location = new System.Drawing.Point(268, 55);
            this.x12_Label.Name = "x12_Label";
            this.x12_Label.Size = new System.Drawing.Size(19, 20);
            this.x12_Label.TabIndex = 19;
            this.x12_Label.Text = "0";
            // 
            // x11_Label
            // 
            this.x11_Label.AutoSize = true;
            this.x11_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x11_Label.Location = new System.Drawing.Point(200, 55);
            this.x11_Label.Name = "x11_Label";
            this.x11_Label.Size = new System.Drawing.Size(19, 20);
            this.x11_Label.TabIndex = 18;
            this.x11_Label.Text = "0";
            // 
            // x10_Label
            // 
            this.x10_Label.AutoSize = true;
            this.x10_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x10_Label.Location = new System.Drawing.Point(136, 55);
            this.x10_Label.Name = "x10_Label";
            this.x10_Label.Size = new System.Drawing.Size(19, 20);
            this.x10_Label.TabIndex = 17;
            this.x10_Label.Text = "0";
            // 
            // x9_Label
            // 
            this.x9_Label.AutoSize = true;
            this.x9_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x9_Label.Location = new System.Drawing.Point(75, 55);
            this.x9_Label.Name = "x9_Label";
            this.x9_Label.Size = new System.Drawing.Size(19, 20);
            this.x9_Label.TabIndex = 16;
            this.x9_Label.Text = "0";
            // 
            // x8_Label
            // 
            this.x8_Label.AutoSize = true;
            this.x8_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x8_Label.Location = new System.Drawing.Point(21, 55);
            this.x8_Label.Name = "x8_Label";
            this.x8_Label.Size = new System.Drawing.Size(19, 20);
            this.x8_Label.TabIndex = 15;
            this.x8_Label.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1458, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.newToolStripMenuItem.Text = "Show Set";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowSetToolStripMenuItem_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(391, 576);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(231, 41);
            this.Clear_Button.TabIndex = 10;
            this.Clear_Button.Text = "CLEAR";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1458, 679);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1476, 726);
            this.Name = "Form1";
            this.Text = "Euler Characteristic On Hexagonal Lattice";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label x0_Label;
        private System.Windows.Forms.Label x1_Label;
        private System.Windows.Forms.Label x2_Label;
        private System.Windows.Forms.Label x3_Label;
        private System.Windows.Forms.Label x4_Label;
        private System.Windows.Forms.Label x5_Label;
        private System.Windows.Forms.Label x6_Label;
        private System.Windows.Forms.Label x7_Label;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label x15_Label;
        private System.Windows.Forms.Label x14_Label;
        private System.Windows.Forms.Label x13_Label;
        private System.Windows.Forms.Label x12_Label;
        private System.Windows.Forms.Label x11_Label;
        private System.Windows.Forms.Label x10_Label;
        private System.Windows.Forms.Label x9_Label;
        private System.Windows.Forms.Label x8_Label;
        private System.Windows.Forms.Label eulerCharacteristic_Label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button Clear_Button;
    }
}

