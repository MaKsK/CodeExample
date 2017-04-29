namespace КГ_Лабораторная_1
{
    partial class ScrollBar
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.minValue = new System.Windows.Forms.Label();
            this.curentValue = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.Label();
            this.ziroValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // minValue
            // 
            this.minValue.AutoSize = true;
            this.minValue.Location = new System.Drawing.Point(0, 0);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(100, 23);
            this.minValue.TabIndex = 0;
            this.minValue.Text = "label1";
            // 
            // curentValue
            // 
            this.curentValue.AutoSize = true;
            this.curentValue.BackColor = System.Drawing.Color.White;
            this.curentValue.Location = new System.Drawing.Point(0, 0);
            this.curentValue.Name = "curentValue";
            this.curentValue.Size = new System.Drawing.Size(100, 23);
            this.curentValue.TabIndex = 0;
            this.curentValue.Text = "label2";
            // 
            // maxValue
            // 
            this.maxValue.AutoSize = true;
            this.maxValue.Location = new System.Drawing.Point(0, 0);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(100, 23);
            this.maxValue.TabIndex = 0;
            this.maxValue.Text = "label3";
            // 
            // ziroValue
            // 
            this.ziroValue.AutoSize = true;
            this.ziroValue.Location = new System.Drawing.Point(0, 0);
            this.ziroValue.Name = "ziroValue";
            this.ziroValue.Size = new System.Drawing.Size(100, 23);
            this.ziroValue.TabIndex = 0;
            this.ziroValue.Text = "0";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label minValue;
        private System.Windows.Forms.Label curentValue;
        private System.Windows.Forms.Label maxValue;
        private System.Windows.Forms.Label ziroValue;
    }
}
