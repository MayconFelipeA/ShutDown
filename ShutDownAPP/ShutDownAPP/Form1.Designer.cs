namespace ShutDownAPP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_closed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.options = new System.Windows.Forms.Label();
            this.segund = new System.Windows.Forms.Label();
            this.minut = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.horas = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.stopShutdown = new System.Windows.Forms.Button();
            this.startShutdown = new System.Windows.Forms.Button();
            this.bt_mini = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_closed
            // 
            this.bt_closed.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bt_closed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bt_closed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_closed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_closed.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bt_closed.FlatAppearance.BorderSize = 0;
            this.bt_closed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bt_closed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_closed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_closed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_closed.ForeColor = System.Drawing.Color.White;
            this.bt_closed.ImageKey = "(nenhum/a)";
            this.bt_closed.Location = new System.Drawing.Point(420, 7);
            this.bt_closed.Name = "bt_closed";
            this.bt_closed.Size = new System.Drawing.Size(25, 23);
            this.bt_closed.TabIndex = 0;
            this.bt_closed.Text = "X";
            this.bt_closed.UseVisualStyleBackColor = false;
            this.bt_closed.Click += new System.EventHandler(this.bt_closed_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.options);
            this.panel1.Controls.Add(this.segund);
            this.panel1.Controls.Add(this.minut);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.horas);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(11, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 370);
            this.panel1.TabIndex = 1;
            // 
            // options
            // 
            this.options.AutoSize = true;
            this.options.BackColor = System.Drawing.Color.Transparent;
            this.options.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.ForeColor = System.Drawing.Color.Silver;
            this.options.Location = new System.Drawing.Point(45, 214);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(83, 24);
            this.options.TabIndex = 14;
            this.options.Text = "Opções";
            // 
            // segund
            // 
            this.segund.AutoSize = true;
            this.segund.BackColor = System.Drawing.Color.Transparent;
            this.segund.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segund.ForeColor = System.Drawing.Color.Silver;
            this.segund.Location = new System.Drawing.Point(294, 52);
            this.segund.Name = "segund";
            this.segund.Size = new System.Drawing.Size(105, 24);
            this.segund.TabIndex = 13;
            this.segund.Text = "Segundos";
            // 
            // minut
            // 
            this.minut.AutoSize = true;
            this.minut.BackColor = System.Drawing.Color.Transparent;
            this.minut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minut.ForeColor = System.Drawing.Color.Silver;
            this.minut.Location = new System.Drawing.Point(181, 52);
            this.minut.Name = "minut";
            this.minut.Size = new System.Drawing.Size(83, 24);
            this.minut.TabIndex = 13;
            this.minut.Text = "Minutos";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown3.Location = new System.Drawing.Point(298, 88);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(68, 49);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.Tag = "";
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.ThousandsSeparator = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown2.Location = new System.Drawing.Point(185, 88);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 49);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.Tag = "";
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.ThousandsSeparator = true;
            // 
            // horas
            // 
            this.horas.AutoSize = true;
            this.horas.BackColor = System.Drawing.Color.Transparent;
            this.horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas.ForeColor = System.Drawing.Color.Silver;
            this.horas.Location = new System.Drawing.Point(40, 52);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(65, 24);
            this.horas.TabIndex = 13;
            this.horas.Text = "Horas";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.CausesValidation = false;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown1.Location = new System.Drawing.Point(44, 88);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            595,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(94, 49);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Tag = "";
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(15, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 113);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton2.Location = new System.Drawing.Point(16, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Reiniciar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton3.Location = new System.Drawing.Point(16, 84);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "Logoff";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton1.Location = new System.Drawing.Point(16, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Desligar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(14, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Programa simples para desligar o computador.";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.stopShutdown);
            this.flowLayoutPanel1.Controls.Add(this.startShutdown);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(226, 312);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(189, 42);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // stopShutdown
            // 
            this.stopShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopShutdown.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.stopShutdown.FlatAppearance.BorderSize = 0;
            this.stopShutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.stopShutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stopShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopShutdown.ForeColor = System.Drawing.Color.White;
            this.stopShutdown.Location = new System.Drawing.Point(3, 3);
            this.stopShutdown.Name = "stopShutdown";
            this.stopShutdown.Size = new System.Drawing.Size(83, 35);
            this.stopShutdown.TabIndex = 2;
            this.stopShutdown.Text = "Cancelar";
            this.stopShutdown.UseVisualStyleBackColor = true;
            this.stopShutdown.Click += new System.EventHandler(this.stopShutdown_Click);
            // 
            // startShutdown
            // 
            this.startShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startShutdown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startShutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.startShutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startShutdown.ForeColor = System.Drawing.Color.White;
            this.startShutdown.Location = new System.Drawing.Point(92, 3);
            this.startShutdown.Name = "startShutdown";
            this.startShutdown.Size = new System.Drawing.Size(92, 35);
            this.startShutdown.TabIndex = 2;
            this.startShutdown.Text = "Pronto";
            this.startShutdown.UseVisualStyleBackColor = true;
            this.startShutdown.Click += new System.EventHandler(this.startShutdown_Click);
            // 
            // bt_mini
            // 
            this.bt_mini.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bt_mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bt_mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mini.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bt_mini.FlatAppearance.BorderSize = 0;
            this.bt_mini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bt_mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mini.ForeColor = System.Drawing.Color.White;
            this.bt_mini.ImageKey = "(nenhum/a)";
            this.bt_mini.Location = new System.Drawing.Point(393, 7);
            this.bt_mini.Name = "bt_mini";
            this.bt_mini.Size = new System.Drawing.Size(25, 23);
            this.bt_mini.TabIndex = 0;
            this.bt_mini.Text = "_";
            this.bt_mini.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_mini.UseVisualStyleBackColor = false;
            this.bt_mini.Click += new System.EventHandler(this.bt_mini_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(45, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "ShutDown Computer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Criado por Maycon Felipe - (2018 - 2020)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(456, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_mini);
            this.Controls.Add(this.bt_closed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desligar o PC";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_closed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_mini;
        private System.Windows.Forms.Button startShutdown;
        private System.Windows.Forms.Button stopShutdown;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label horas;
        private System.Windows.Forms.Label minut;
        protected System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label segund;
        protected System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label options;
    }
}

