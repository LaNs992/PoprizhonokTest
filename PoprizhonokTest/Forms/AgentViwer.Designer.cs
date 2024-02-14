namespace PoprizhonokTest.Forms
{
    partial class AgentViwer
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.CountLbl = new System.Windows.Forms.Label();
            this.Numberlbl = new System.Windows.Forms.Label();
            this.Favoritlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PoprizhonokTest.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(25, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(209, 18);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(47, 15);
            this.TypeLbl.TabIndex = 1;
            this.TypeLbl.Text = "TypeLbl";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(293, 18);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(55, 15);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "NameLbl";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(1728, 447);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(38, 15);
            this.Count.TabIndex = 3;
            this.Count.Text = "label1";
            // 
            // CountLbl
            // 
            this.CountLbl.AutoSize = true;
            this.CountLbl.Location = new System.Drawing.Point(218, 55);
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(56, 15);
            this.CountLbl.TabIndex = 4;
            this.CountLbl.Text = "CountLbl";
            // 
            // Numberlbl
            // 
            this.Numberlbl.AutoSize = true;
            this.Numberlbl.Location = new System.Drawing.Point(218, 86);
            this.Numberlbl.Name = "Numberlbl";
            this.Numberlbl.Size = new System.Drawing.Size(64, 15);
            this.Numberlbl.TabIndex = 5;
            this.Numberlbl.Text = "Numberlbl";
            // 
            // Favoritlbl
            // 
            this.Favoritlbl.AutoSize = true;
            this.Favoritlbl.Location = new System.Drawing.Point(218, 116);
            this.Favoritlbl.Name = "Favoritlbl";
            this.Favoritlbl.Size = new System.Drawing.Size(56, 15);
            this.Favoritlbl.TabIndex = 6;
            this.Favoritlbl.Text = "Favoritlbl";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(592, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AgentViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Favoritlbl);
            this.Controls.Add(this.Numberlbl);
            this.Controls.Add(this.CountLbl);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AgentViwer";
            this.Size = new System.Drawing.Size(703, 182);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label TypeLbl;
        private Label NameLbl;
        private Label Count;
        private Label CountLbl;
        private Label Numberlbl;
        private Label Favoritlbl;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Button button2;
    }
}
