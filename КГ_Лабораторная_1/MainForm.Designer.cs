namespace КГ_Лабораторная_1
{
    partial class MainForm
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
            this.pb_spatiald = new System.Windows.Forms.PictureBox();
            this.pb_complexd = new System.Windows.Forms.PictureBox();
            this.trackBarZ = new КГ_Лабораторная_1.ScrollBar();
            this.trackBarY = new КГ_Лабораторная_1.ScrollBar();
            this.trackBarX = new КГ_Лабораторная_1.ScrollBar();
            this.trackBarG = new КГ_Лабораторная_1.ScrollBar();
            this.trackBarB = new КГ_Лабораторная_1.ScrollBar();
            this.trackBarA = new КГ_Лабораторная_1.ScrollBar();
            this.bt_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_spatiald)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_complexd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_spatiald
            // 
            this.pb_spatiald.BackColor = System.Drawing.Color.White;
            this.pb_spatiald.Location = new System.Drawing.Point(44, 19);
            this.pb_spatiald.Margin = new System.Windows.Forms.Padding(4);
            this.pb_spatiald.Name = "pb_spatiald";
            this.pb_spatiald.Size = new System.Drawing.Size(441, 381);
            this.pb_spatiald.TabIndex = 0;
            this.pb_spatiald.TabStop = false;
            this.pb_spatiald.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_spatiald_Paint);
            // 
            // pb_complexd
            // 
            this.pb_complexd.BackColor = System.Drawing.Color.White;
            this.pb_complexd.Location = new System.Drawing.Point(605, 19);
            this.pb_complexd.Margin = new System.Windows.Forms.Padding(4);
            this.pb_complexd.Name = "pb_complexd";
            this.pb_complexd.Size = new System.Drawing.Size(441, 381);
            this.pb_complexd.TabIndex = 4;
            this.pb_complexd.TabStop = false;
            this.pb_complexd.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_complexd_Paint);
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(70, 619);
            this.trackBarZ.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarZ.Maximum = 60;
            this.trackBarZ.Minimum = -60;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(363, 53);
            this.trackBarZ.TabIndex = 3;
            this.trackBarZ.Value = 50;
            this.trackBarZ.ValueChanged += new System.EventHandler(this.XYZControl_ValueChanged);
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(70, 521);
            this.trackBarY.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarY.Maximum = 60;
            this.trackBarY.Minimum = -60;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(363, 53);
            this.trackBarY.TabIndex = 2;
            this.trackBarY.Value = 50;
            this.trackBarY.ValueChanged += new System.EventHandler(this.XYZControl_ValueChanged);
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(70, 423);
            this.trackBarX.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarX.Maximum = 60;
            this.trackBarX.Minimum = -60;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(363, 53);
            this.trackBarX.TabIndex = 1;
            this.trackBarX.Value = 50;
            this.trackBarX.ValueChanged += new System.EventHandler(this.XYZControl_ValueChanged);
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(642, 619);
            this.trackBarG.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarG.Maximum = 360;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(363, 53);
            this.trackBarG.TabIndex = 7;
            this.trackBarG.Value = 270;
            this.trackBarG.ValueChanged += new System.EventHandler(this.AngleControl_ValueChanged);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(642, 521);
            this.trackBarB.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarB.Maximum = 360;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(363, 53);
            this.trackBarB.TabIndex = 6;
            this.trackBarB.Value = 135;
            this.trackBarB.ValueChanged += new System.EventHandler(this.AngleControl_ValueChanged);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(642, 423);
            this.trackBarA.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarA.Maximum = 360;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(363, 53);
            this.trackBarA.TabIndex = 5;
            this.trackBarA.ValueChanged += new System.EventHandler(this.AngleControl_ValueChanged);
            // 
            // bt_exit
            // 
            this.bt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exit.Location = new System.Drawing.Point(1035, 688);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(85, 32);
            this.bt_exit.TabIndex = 8;
            this.bt_exit.Text = "Выход";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(235, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(235, 500);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(235, 591);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(797, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alpha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(806, 500);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Beta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(787, 589);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gamma:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 736);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.trackBarG);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.pb_complexd);
            this.Controls.Add(this.trackBarZ);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.pb_spatiald);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа по Компьютерной Графики №1 \"Точка в 3D\". Касымов Максим МО-21" +
    "1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_spatiald)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_complexd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_spatiald;
        private КГ_Лабораторная_1.ScrollBar trackBarX;
        private КГ_Лабораторная_1.ScrollBar trackBarY;
        private КГ_Лабораторная_1.ScrollBar trackBarZ;
        private System.Windows.Forms.PictureBox pb_complexd;
        private ScrollBar trackBarG;
        private ScrollBar trackBarB;
        private ScrollBar trackBarA;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

