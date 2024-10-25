namespace CalculatorApp
{
    partial class CalculatorMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorMain));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Font = new System.Drawing.Font("Gadugi", 17F);
            this.txtDisplay.ForeColor = System.Drawing.Color.Black;
            this.txtDisplay.Location = new System.Drawing.Point(0, 82);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(363, 36);
            this.txtDisplay.TabIndex = 15;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(324, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calculator";
            // 
            // txtresult
            // 
            this.txtresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.txtresult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtresult.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtresult.Enabled = false;
            this.txtresult.Font = new System.Drawing.Font("Gadugi", 20F, System.Drawing.FontStyle.Bold);
            this.txtresult.ForeColor = System.Drawing.Color.Black;
            this.txtresult.Location = new System.Drawing.Point(0, 118);
            this.txtresult.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(363, 45);
            this.txtresult.TabIndex = 16;
            this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 41);
            this.panel2.TabIndex = 13;
            // 
            // lbHistory
            // 
            this.lbHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(186)))), ((int)(((byte)(208)))));
            this.lbHistory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(11, 13);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.ScrollAlwaysVisible = true;
            this.lbHistory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbHistory.Size = new System.Drawing.Size(339, 355);
            this.lbHistory.TabIndex = 22;
            this.lbHistory.Visible = false;
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(0, 0);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(39, 41);
            this.btnHistory.TabIndex = 9;
            this.btnHistory.TabStop = false;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.panel3.Controls.Add(this.btnHistory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 41);
            this.panel3.TabIndex = 14;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.btn7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btn7.Location = new System.Drawing.Point(11, 84);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(82, 69);
            this.btn7.TabIndex = 1;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumValue_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.btn8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btn8.Location = new System.Drawing.Point(95, 84);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(82, 69);
            this.btn8.TabIndex = 2;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumValue_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.btn9.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btn9.Location = new System.Drawing.Point(179, 84);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(82, 69);
            this.btn9.TabIndex = 3;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumValue_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(11, 13);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 69);
            this.btnClear.TabIndex = 4;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.btn4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btn4.Location = new System.Drawing.Point(11, 155);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(82, 69);
            this.btn4.TabIndex = 5;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumValue_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.btn5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btn5.Location = new System.Drawing.Point(95, 155);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(82, 69);
            this.btn5.TabIndex = 6;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumValue_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.btn6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btn6.Location = new System.Drawing.Point(179, 155);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(82, 69);
            this.btn6.TabIndex = 7;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumValue_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(263, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 69);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.OperatorValue_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.btn1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btn1.Location = new System.Drawing.Point(11, 226);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(82, 69);
            this.btn1.TabIndex = 9;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumValue_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.btn2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btn2.Location = new System.Drawing.Point(95, 226);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(82, 69);
            this.btn2.TabIndex = 10;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumValue_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.btn3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btn3.Location = new System.Drawing.Point(179, 226);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(82, 69);
            this.btn3.TabIndex = 11;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumValue_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnSubtract.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnSubtract.ForeColor = System.Drawing.Color.White;
            this.btnSubtract.Location = new System.Drawing.Point(263, 84);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(82, 69);
            this.btnSubtract.TabIndex = 12;
            this.btnSubtract.TabStop = false;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.OperatorValue_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.btn0.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btn0.Location = new System.Drawing.Point(11, 297);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(166, 69);
            this.btn0.TabIndex = 13;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumValue_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btnDot.Location = new System.Drawing.Point(178, 297);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(83, 69);
            this.btnDot.TabIndex = 14;
            this.btnDot.TabStop = false;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.NumValue_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnEquals.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.White;
            this.btnEquals.Location = new System.Drawing.Point(263, 297);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(82, 69);
            this.btnEquals.TabIndex = 1;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(263, 155);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(82, 69);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.OperatorValue_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(263, 226);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(82, 69);
            this.btnDivide.TabIndex = 17;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.OperatorValue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 18;
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnBackspace.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.ForeColor = System.Drawing.Color.Transparent;
            this.btnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackspace.Image")));
            this.btnBackspace.Location = new System.Drawing.Point(95, 13);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(82, 69);
            this.btnBackspace.TabIndex = 19;
            this.btnBackspace.TabStop = false;
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.BackSpace_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnPercent.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.ForeColor = System.Drawing.Color.White;
            this.btnPercent.Location = new System.Drawing.Point(179, 13);
            this.btnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(82, 69);
            this.btnPercent.TabIndex = 20;
            this.btnPercent.TabStop = false;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.lbHistory);
            this.panel1.Controls.Add(this.btnPercent);
            this.panel1.Controls.Add(this.btnBackspace);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDivide);
            this.panel1.Controls.Add(this.btnMultiply);
            this.panel1.Controls.Add(this.btnEquals);
            this.panel1.Controls.Add(this.btnDot);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btnSubtract);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 380);
            this.panel1.TabIndex = 12;
            // 
            // CalculatorMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(363, 546);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Panel panel1;
    }
}

