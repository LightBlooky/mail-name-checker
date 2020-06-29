namespace mail_name_checker
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
            this.tb = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.grib = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(30, 212);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(201, 20);
            this.tb.TabIndex = 0;
            this.tb.TabStop = false;
            this.tb.Enter += new System.EventHandler(this.tb_Enter);
            this.tb.Leave += new System.EventHandler(this.tb_Leave);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.add_btn.Location = new System.Drawing.Point(68, 258);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(109, 42);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // grib
            // 
            this.grib.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grib.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm});
            this.grib.Location = new System.Drawing.Point(310, 43);
            this.grib.Name = "grib";
            this.grib.Size = new System.Drawing.Size(240, 328);
            this.grib.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::mail_name_checker.Properties.Resources.emlog;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(30, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 164);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Clm
            // 
            this.Clm.HeaderText = "e-mail\'s";
            this.Clm.Name = "Clm";
            this.Clm.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grib);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.tb);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.grib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView grib;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm;
    }
}

