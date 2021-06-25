
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ZoomBar = new System.Windows.Forms.TrackBar();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CloseSettings = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CollapseButton = new System.Windows.Forms.Button();
            this.OpenPanel = new System.Windows.Forms.Panel();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ZScaleBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ZLabelsBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).BeginInit();
            this.panel3.SuspendLayout();
            this.OpenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZScaleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZLabelsBar)).BeginInit();
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
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.SettingsPanel.Controls.Add(this.ZLabelsBar);
            this.SettingsPanel.Controls.Add(this.label4);
            this.SettingsPanel.Controls.Add(this.ResetButton);
            this.SettingsPanel.Controls.Add(this.ZScaleBar);
            this.SettingsPanel.Controls.Add(this.label3);
            this.SettingsPanel.Controls.Add(this.panel3);
            this.SettingsPanel.Controls.Add(this.buttonSettings);
            this.SettingsPanel.Controls.Add(this.ZoomBar);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 33);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(312, 802);
            this.SettingsPanel.TabIndex = 70;
            this.SettingsPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Масштабирование";
            // 
            // ZoomBar
            // 
            this.ZoomBar.Location = new System.Drawing.Point(13, 41);
            this.ZoomBar.Maximum = 350;
            this.ZoomBar.Name = "ZoomBar";
            this.ZoomBar.Size = new System.Drawing.Size(222, 45);
            this.ZoomBar.TabIndex = 1;
            this.ZoomBar.TickFrequency = 0;
            this.ZoomBar.Value = 350;
            this.ZoomBar.Scroll += new System.EventHandler(this.ScrollEvent);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(26, 426);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(182, 65);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CloseSettings);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(253, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 802);
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
            this.CloseSettings.Size = new System.Drawing.Size(59, 802);
            this.CloseSettings.TabIndex = 0;
            this.CloseSettings.UseVisualStyleBackColor = true;
            this.CloseSettings.Click += new System.EventHandler(this.CloseSettings_Click);
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
            // OpenPanel
            // 
            this.OpenPanel.Controls.Add(this.OpenButton);
            this.OpenPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenPanel.Location = new System.Drawing.Point(312, 33);
            this.OpenPanel.Name = "OpenPanel";
            this.OpenPanel.Size = new System.Drawing.Size(61, 802);
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
            this.OpenButton.Size = new System.Drawing.Size(61, 802);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ZScaleBar
            // 
            this.ZScaleBar.LargeChange = 1;
            this.ZScaleBar.Location = new System.Drawing.Point(13, 117);
            this.ZScaleBar.Maximum = 10000;
            this.ZScaleBar.Name = "ZScaleBar";
            this.ZScaleBar.Size = new System.Drawing.Size(222, 45);
            this.ZScaleBar.TabIndex = 4;
            this.ZScaleBar.TickFrequency = 0;
            this.ZScaleBar.Value = 350;
            this.ZScaleBar.Scroll += new System.EventHandler(this.ZScaleScroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Масштабирование Z";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(12, 755);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(223, 35);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Сброс настроек";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ZLabelsBar
            // 
            this.ZLabelsBar.LargeChange = 1;
            this.ZLabelsBar.Location = new System.Drawing.Point(13, 193);
            this.ZLabelsBar.Maximum = 2;
            this.ZLabelsBar.Minimum = 2;
            this.ZLabelsBar.Name = "ZLabelsBar";
            this.ZLabelsBar.Size = new System.Drawing.Size(222, 45);
            this.ZLabelsBar.TabIndex = 7;
            this.ZLabelsBar.TickFrequency = 0;
            this.ZLabelsBar.Value = 2;
            this.ZLabelsBar.Scroll += new System.EventHandler(this.ZLabelsScroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество делений Z";
            // 
            // Chart3DForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 835);
            this.Controls.Add(this.OpenPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chart3DForm";
            this.Text = "Chart3DForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Chart3DForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.OpenPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ZScaleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZLabelsBar)).EndInit();
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
    }
}