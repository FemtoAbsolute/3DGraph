
namespace _3DGraph
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.FunctionTextbox = new System.Windows.Forms.TextBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.FirstTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.ValuesOfFunction = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DeltaYNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.DeltaXNumeric = new System.Windows.Forms.NumericUpDown();
            this.YMaxNumeric = new System.Windows.Forms.NumericUpDown();
            this.XMaxNumeric = new System.Windows.Forms.NumericUpDown();
            this.YMinNumeric = new System.Windows.Forms.NumericUpDown();
            this.XMinNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondTab = new System.Windows.Forms.TabPage();
            this.DocumentTabs = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.DragControl = new _3DGraph.DragControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CollapseButton = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.FirstTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValuesOfFunction)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaYNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaXNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YMaxNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XMaxNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YMinNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XMinNumeric)).BeginInit();
            this.DocumentTabs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CalculateButton.Location = new System.Drawing.Point(165, 151);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(482, 34);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // FunctionTextbox
            // 
            this.FunctionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionTextbox.Location = new System.Drawing.Point(116, 34);
            this.FunctionTextbox.Name = "FunctionTextbox";
            this.FunctionTextbox.Size = new System.Drawing.Size(633, 31);
            this.FunctionTextbox.TabIndex = 0;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.FirstTab);
            this.Tabs.Controls.Add(this.SecondTab);
            this.Tabs.Controls.Add(this.DocumentTabs);
            this.Tabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tabs.Location = new System.Drawing.Point(0, 33);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.ShowToolTips = true;
            this.Tabs.Size = new System.Drawing.Size(842, 548);
            this.Tabs.TabIndex = 70;
            // 
            // FirstTab
            // 
            this.FirstTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.FirstTab.Controls.Add(this.label10);
            this.FirstTab.Controls.Add(this.ValuesOfFunction);
            this.FirstTab.Controls.Add(this.groupBox1);
            this.FirstTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FirstTab.Location = new System.Drawing.Point(4, 29);
            this.FirstTab.Name = "FirstTab";
            this.FirstTab.Padding = new System.Windows.Forms.Padding(3);
            this.FirstTab.Size = new System.Drawing.Size(834, 515);
            this.FirstTab.TabIndex = 1;
            this.FirstTab.Text = "Ввод функции и таблица значений";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(28, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Y\\X";
            this.label10.Visible = false;
            // 
            // ValuesOfFunction
            // 
            this.ValuesOfFunction.AllowUserToAddRows = false;
            this.ValuesOfFunction.AllowUserToDeleteRows = false;
            this.ValuesOfFunction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.ValuesOfFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ValuesOfFunction.Location = new System.Drawing.Point(8, 203);
            this.ValuesOfFunction.Name = "ValuesOfFunction";
            this.ValuesOfFunction.ReadOnly = true;
            this.ValuesOfFunction.RowHeadersWidth = 80;
            this.ValuesOfFunction.RowTemplate.ReadOnly = true;
            this.ValuesOfFunction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ValuesOfFunction.ShowCellToolTips = false;
            this.ValuesOfFunction.ShowEditingIcon = false;
            this.ValuesOfFunction.Size = new System.Drawing.Size(820, 304);
            this.ValuesOfFunction.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CalculateButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DeltaYNumeric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DeltaXNumeric);
            this.groupBox1.Controls.Add(this.YMaxNumeric);
            this.groupBox1.Controls.Add(this.XMaxNumeric);
            this.groupBox1.Controls.Add(this.YMinNumeric);
            this.groupBox1.Controls.Add(this.XMinNumeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FunctionTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 191);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод функции и ограничений, накладываемых на аргументы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(607, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Шаг ΔY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(303, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y(Max):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y(Min):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(605, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Шаг ΔX";
            // 
            // DeltaYNumeric
            // 
            this.DeltaYNumeric.DecimalPlaces = 2;
            this.DeltaYNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeltaYNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.DeltaYNumeric.Location = new System.Drawing.Point(690, 110);
            this.DeltaYNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DeltaYNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.DeltaYNumeric.Name = "DeltaYNumeric";
            this.DeltaYNumeric.Size = new System.Drawing.Size(120, 31);
            this.DeltaYNumeric.TabIndex = 4;
            this.DeltaYNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(301, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "X(Max):";
            // 
            // DeltaXNumeric
            // 
            this.DeltaXNumeric.DecimalPlaces = 2;
            this.DeltaXNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeltaXNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.DeltaXNumeric.Location = new System.Drawing.Point(690, 73);
            this.DeltaXNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DeltaXNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.DeltaXNumeric.Name = "DeltaXNumeric";
            this.DeltaXNumeric.Size = new System.Drawing.Size(120, 31);
            this.DeltaXNumeric.TabIndex = 4;
            this.DeltaXNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // YMaxNumeric
            // 
            this.YMaxNumeric.DecimalPlaces = 4;
            this.YMaxNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YMaxNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.YMaxNumeric.Location = new System.Drawing.Point(384, 107);
            this.YMaxNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.YMaxNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.YMaxNumeric.Name = "YMaxNumeric";
            this.YMaxNumeric.Size = new System.Drawing.Size(120, 31);
            this.YMaxNumeric.TabIndex = 4;
            this.YMaxNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // XMaxNumeric
            // 
            this.XMaxNumeric.DecimalPlaces = 4;
            this.XMaxNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XMaxNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.XMaxNumeric.Location = new System.Drawing.Point(384, 70);
            this.XMaxNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.XMaxNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.XMaxNumeric.Name = "XMaxNumeric";
            this.XMaxNumeric.Size = new System.Drawing.Size(120, 31);
            this.XMaxNumeric.TabIndex = 4;
            this.XMaxNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // YMinNumeric
            // 
            this.YMinNumeric.DecimalPlaces = 4;
            this.YMinNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YMinNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.YMinNumeric.Location = new System.Drawing.Point(84, 107);
            this.YMinNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.YMinNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.YMinNumeric.Name = "YMinNumeric";
            this.YMinNumeric.Size = new System.Drawing.Size(120, 31);
            this.YMinNumeric.TabIndex = 4;
            // 
            // XMinNumeric
            // 
            this.XMinNumeric.DecimalPlaces = 4;
            this.XMinNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XMinNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.XMinNumeric.Location = new System.Drawing.Point(84, 70);
            this.XMinNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.XMinNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.XMinNumeric.Name = "XMinNumeric";
            this.XMinNumeric.Size = new System.Drawing.Size(120, 31);
            this.XMinNumeric.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "X(Min):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Z = f(X,Y) =";
            // 
            // SecondTab
            // 
            this.SecondTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.SecondTab.Location = new System.Drawing.Point(4, 29);
            this.SecondTab.Name = "SecondTab";
            this.SecondTab.Padding = new System.Windows.Forms.Padding(3);
            this.SecondTab.Size = new System.Drawing.Size(834, 515);
            this.SecondTab.TabIndex = 0;
            this.SecondTab.Text = "3D-график";
            // 
            // DocumentTabs
            // 
            this.DocumentTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.DocumentTabs.Controls.Add(this.label9);
            this.DocumentTabs.Location = new System.Drawing.Point(4, 29);
            this.DocumentTabs.Name = "DocumentTabs";
            this.DocumentTabs.Padding = new System.Windows.Forms.Padding(3);
            this.DocumentTabs.Size = new System.Drawing.Size(834, 515);
            this.DocumentTabs.TabIndex = 2;
            this.DocumentTabs.Text = "Документация";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(6, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(820, 497);
            this.label9.TabIndex = 0;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragControl
            // 
            this.DragControl.selectControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CollapseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 33);
            this.panel1.TabIndex = 68;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.CloseButton.BackgroundImage = global::_3DGraph.Properties.Resources.exit;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(810, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 25);
            this.CloseButton.TabIndex = 62;
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Добро пожаловать";
            // 
            // CollapseButton
            // 
            this.CollapseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.CollapseButton.BackgroundImage = global::_3DGraph.Properties.Resources.collapse;
            this.CollapseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CollapseButton.FlatAppearance.BorderSize = 0;
            this.CollapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollapseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CollapseButton.Location = new System.Drawing.Point(775, 4);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(29, 25);
            this.CollapseButton.TabIndex = 63;
            this.CollapseButton.UseVisualStyleBackColor = false;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 581);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.FirstTab.ResumeLayout(false);
            this.FirstTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValuesOfFunction)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaYNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaXNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YMaxNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XMaxNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YMinNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XMinNumeric)).EndInit();
            this.DocumentTabs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox FunctionTextbox;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage FirstTab;
        private System.Windows.Forms.TabPage SecondTab;
        private DragControl DragControl;
        private System.Windows.Forms.DataGridView ValuesOfFunction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown DeltaYNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DeltaXNumeric;
        private System.Windows.Forms.NumericUpDown YMaxNumeric;
        private System.Windows.Forms.NumericUpDown XMaxNumeric;
        private System.Windows.Forms.NumericUpDown YMinNumeric;
        private System.Windows.Forms.NumericUpDown XMinNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage DocumentTabs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CollapseButton;
        private System.Windows.Forms.Label label10;
    }
}

