
namespace _3DGraph
{
    partial class Chart3DForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart3DForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CollapseButton = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ScatterCheck = new System.Windows.Forms.CheckBox();
            this.GridChecked = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FontTrackbar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ZScaleBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ZoomBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ZLabelsBar = new System.Windows.Forms.TrackBar();
            this.YLabelsValue = new System.Windows.Forms.TrackBar();
            this.XLabelsValue = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CorRadio = new System.Windows.Forms.RadioButton();
            this.InterpolatedRadio = new System.Windows.Forms.RadioButton();
            this.ResetButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CloseSettings = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.OpenPanel = new System.Windows.Forms.Panel();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontTrackbar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZScaleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZLabelsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YLabelsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XLabelsValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.OpenPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(845, 33);
            this.panel1.TabIndex = 69;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Image = global::_3DGraph.Properties.Resources.collapse;
            this.CloseButton.Location = new System.Drawing.Point(787, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 33);
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
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Поверхность функции";
            // 
            // CollapseButton
            // 
            this.CollapseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.CollapseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CollapseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CollapseButton.FlatAppearance.BorderSize = 0;
            this.CollapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollapseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CollapseButton.Image = global::_3DGraph.Properties.Resources.exit;
            this.CollapseButton.Location = new System.Drawing.Point(816, 0);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(29, 33);
            this.CollapseButton.TabIndex = 63;
            this.CollapseButton.UseVisualStyleBackColor = false;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.AutoScroll = true;
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.SettingsPanel.Controls.Add(this.groupBox5);
            this.SettingsPanel.Controls.Add(this.groupBox4);
            this.SettingsPanel.Controls.Add(this.groupBox3);
            this.SettingsPanel.Controls.Add(this.groupBox2);
            this.SettingsPanel.Controls.Add(this.groupBox1);
            this.SettingsPanel.Controls.Add(this.ResetButton);
            this.SettingsPanel.Controls.Add(this.panel3);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 33);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(305, 919);
            this.SettingsPanel.TabIndex = 70;
            this.SettingsPanel.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox4);
            this.groupBox5.Controls.Add(this.pictureBox3);
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(0, 733);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(254, 199);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Вид";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::_3DGraph.Properties.Resources.cube;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBox4.Location = new System.Drawing.Point(111, 103);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.Orto3DClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::_3DGraph.Properties.Resources.zaxis;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.pictureBox3.Location = new System.Drawing.Point(85, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 97);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.ZAxisOrtoClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::_3DGraph.Properties.Resources.yaxis;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.pictureBox2.Location = new System.Drawing.Point(138, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 97);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.YAxisOrtoClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_3DGraph.Properties.Resources.xaxis;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.pictureBox1.Location = new System.Drawing.Point(33, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.XAxisOrtoClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ScatterCheck);
            this.groupBox4.Controls.Add(this.GridChecked);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.FontTrackbar);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(0, 545);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 188);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Отображение";
            // 
            // ScatterCheck
            // 
            this.ScatterCheck.AutoSize = true;
            this.ScatterCheck.Location = new System.Drawing.Point(13, 137);
            this.ScatterCheck.Name = "ScatterCheck";
            this.ScatterCheck.Size = new System.Drawing.Size(211, 28);
            this.ScatterCheck.TabIndex = 10;
            this.ScatterCheck.Text = "Отображение точек";
            this.ScatterCheck.UseVisualStyleBackColor = true;
            this.ScatterCheck.CheckedChanged += new System.EventHandler(this.ScatterCheckedChanged);
            // 
            // GridChecked
            // 
            this.GridChecked.AutoSize = true;
            this.GridChecked.Location = new System.Drawing.Point(13, 91);
            this.GridChecked.Name = "GridChecked";
            this.GridChecked.Size = new System.Drawing.Size(211, 28);
            this.GridChecked.TabIndex = 10;
            this.GridChecked.Text = "Отображение сетки";
            this.GridChecked.UseVisualStyleBackColor = true;
            this.GridChecked.CheckedChanged += new System.EventHandler(this.GridCheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Размер шрифта";
            // 
            // FontTrackbar
            // 
            this.FontTrackbar.LargeChange = 1;
            this.FontTrackbar.Location = new System.Drawing.Point(8, 53);
            this.FontTrackbar.Maximum = 30;
            this.FontTrackbar.Minimum = 1;
            this.FontTrackbar.Name = "FontTrackbar";
            this.FontTrackbar.Size = new System.Drawing.Size(222, 45);
            this.FontTrackbar.TabIndex = 9;
            this.FontTrackbar.TickFrequency = 0;
            this.FontTrackbar.Value = 30;
            this.FontTrackbar.Scroll += new System.EventHandler(this.FontTrackScroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ZScaleBar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ZoomBar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(0, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 184);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Масштабирование";
            // 
            // ZScaleBar
            // 
            this.ZScaleBar.LargeChange = 1;
            this.ZScaleBar.Location = new System.Drawing.Point(13, 135);
            this.ZScaleBar.Maximum = 10000;
            this.ZScaleBar.Name = "ZScaleBar";
            this.ZScaleBar.Size = new System.Drawing.Size(222, 45);
            this.ZScaleBar.TabIndex = 4;
            this.ZScaleBar.TickFrequency = 0;
            this.ZScaleBar.Value = 350;
            this.ZScaleBar.Scroll += new System.EventHandler(this.ZScaleScroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Масштабирование";
            // 
            // ZoomBar
            // 
            this.ZoomBar.Location = new System.Drawing.Point(13, 59);
            this.ZoomBar.Maximum = 350;
            this.ZoomBar.Name = "ZoomBar";
            this.ZoomBar.Size = new System.Drawing.Size(222, 45);
            this.ZoomBar.TabIndex = 1;
            this.ZoomBar.TickFrequency = 0;
            this.ZoomBar.Value = 350;
            this.ZoomBar.Scroll += new System.EventHandler(this.ScrollEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Масштабирование Z";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ZLabelsBar);
            this.groupBox2.Controls.Add(this.YLabelsValue);
            this.groupBox2.Controls.Add(this.XLabelsValue);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(0, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 256);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Деления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Количество делений X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество делений Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(10, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Количество делений Y";
            // 
            // ZLabelsBar
            // 
            this.ZLabelsBar.LargeChange = 1;
            this.ZLabelsBar.Location = new System.Drawing.Point(9, 204);
            this.ZLabelsBar.Maximum = 2;
            this.ZLabelsBar.Minimum = 2;
            this.ZLabelsBar.Name = "ZLabelsBar";
            this.ZLabelsBar.Size = new System.Drawing.Size(222, 45);
            this.ZLabelsBar.TabIndex = 7;
            this.ZLabelsBar.TickFrequency = 0;
            this.ZLabelsBar.Value = 2;
            this.ZLabelsBar.Scroll += new System.EventHandler(this.ZLabelsScroll);
            // 
            // YLabelsValue
            // 
            this.YLabelsValue.LargeChange = 1;
            this.YLabelsValue.Location = new System.Drawing.Point(10, 128);
            this.YLabelsValue.Maximum = 2;
            this.YLabelsValue.Minimum = 2;
            this.YLabelsValue.Name = "YLabelsValue";
            this.YLabelsValue.Size = new System.Drawing.Size(222, 45);
            this.YLabelsValue.TabIndex = 7;
            this.YLabelsValue.TickFrequency = 0;
            this.YLabelsValue.Value = 2;
            this.YLabelsValue.Scroll += new System.EventHandler(this.YLabelsScroll);
            // 
            // XLabelsValue
            // 
            this.XLabelsValue.LargeChange = 1;
            this.XLabelsValue.Location = new System.Drawing.Point(10, 52);
            this.XLabelsValue.Maximum = 2;
            this.XLabelsValue.Minimum = 2;
            this.XLabelsValue.Name = "XLabelsValue";
            this.XLabelsValue.Size = new System.Drawing.Size(222, 45);
            this.XLabelsValue.TabIndex = 7;
            this.XLabelsValue.TickFrequency = 0;
            this.XLabelsValue.Value = 2;
            this.XLabelsValue.Scroll += new System.EventHandler(this.ZLabelsScroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CorRadio);
            this.groupBox1.Controls.Add(this.InterpolatedRadio);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 105);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стиль окраса";
            // 
            // CorRadio
            // 
            this.CorRadio.AutoSize = true;
            this.CorRadio.Location = new System.Drawing.Point(7, 63);
            this.CorRadio.Name = "CorRadio";
            this.CorRadio.Size = new System.Drawing.Size(94, 28);
            this.CorRadio.TabIndex = 0;
            this.CorRadio.TabStop = true;
            this.CorRadio.Text = "Грубый";
            this.CorRadio.UseVisualStyleBackColor = true;
            this.CorRadio.CheckedChanged += new System.EventHandler(this.RadioCheckedChanged);
            // 
            // InterpolatedRadio
            // 
            this.InterpolatedRadio.AutoSize = true;
            this.InterpolatedRadio.Checked = true;
            this.InterpolatedRadio.Location = new System.Drawing.Point(7, 29);
            this.InterpolatedRadio.Name = "InterpolatedRadio";
            this.InterpolatedRadio.Size = new System.Drawing.Size(216, 28);
            this.InterpolatedRadio.TabIndex = 0;
            this.InterpolatedRadio.TabStop = true;
            this.InterpolatedRadio.Text = "Интерполированный";
            this.InterpolatedRadio.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(0, 932);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(254, 52);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Сброс настроек";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CloseSettings);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(254, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 984);
            this.panel3.TabIndex = 2;
            // 
            // CloseSettings
            // 
            this.CloseSettings.BackgroundImage = global::_3DGraph.Properties.Resources.Close;
            this.CloseSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseSettings.Location = new System.Drawing.Point(0, 0);
            this.CloseSettings.Name = "CloseSettings";
            this.CloseSettings.Size = new System.Drawing.Size(34, 984);
            this.CloseSettings.TabIndex = 0;
            this.CloseSettings.UseVisualStyleBackColor = true;
            this.CloseSettings.Click += new System.EventHandler(this.CloseSettings_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(0, 952);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(845, 28);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Visible = false;
            this.buttonSettings.Click += new System.EventHandler(this.button2_Click);
            // 
            // OpenPanel
            // 
            this.OpenPanel.Controls.Add(this.OpenButton);
            this.OpenPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenPanel.Location = new System.Drawing.Point(305, 33);
            this.OpenPanel.Name = "OpenPanel";
            this.OpenPanel.Size = new System.Drawing.Size(36, 919);
            this.OpenPanel.TabIndex = 71;
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.OpenButton.BackgroundImage = global::_3DGraph.Properties.Resources.Open;
            this.OpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Location = new System.Drawing.Point(0, 0);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(36, 919);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Chart3DForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 980);
            this.Controls.Add(this.OpenPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chart3DForm";
            this.Text = "График поверхности";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Chart3DForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontTrackbar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZScaleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZLabelsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YLabelsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XLabelsValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.OpenPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CollapseButton;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.TrackBar ZoomBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CloseSettings;
        private System.Windows.Forms.Panel OpenPanel;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TrackBar ZScaleBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TrackBar ZLabelsBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.TrackBar FontTrackbar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CorRadio;
        private System.Windows.Forms.RadioButton InterpolatedRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar YLabelsValue;
        private System.Windows.Forms.TrackBar XLabelsValue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox GridChecked;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ScatterCheck;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}