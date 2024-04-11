namespace _0001
{
    partial class MAIN
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PNL_MAIN = new System.Windows.Forms.Panel();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.PNL_LEFT = new System.Windows.Forms.Panel();
            this.Histograma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCT_THUMBNAIL = new System.Windows.Forms.PictureBox();
            this.PNL_RIGHT = new System.Windows.Forms.Panel();
            this.pictureBoxH = new System.Windows.Forms.PictureBox();
            this.BTN_SEPIA = new System.Windows.Forms.Button();
            this.BTN_GRAY = new System.Windows.Forms.Button();
            this.BTN_INVERT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PNL_BOTTOM = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.PNL_HEAD = new System.Windows.Forms.Panel();
            this.BTN_RELOAD = new System.Windows.Forms.Button();
            this.BTN_EXE = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PNL_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.PNL_LEFT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_THUMBNAIL)).BeginInit();
            this.PNL_RIGHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH)).BeginInit();
            this.PNL_BOTTOM.SuspendLayout();
            this.PNL_HEAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_MAIN
            // 
            this.PNL_MAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PNL_MAIN.Controls.Add(this.PCT_CANVAS);
            this.PNL_MAIN.Controls.Add(this.PNL_LEFT);
            this.PNL_MAIN.Controls.Add(this.PNL_RIGHT);
            this.PNL_MAIN.Controls.Add(this.PNL_BOTTOM);
            this.PNL_MAIN.Controls.Add(this.PNL_HEAD);
            this.PNL_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_MAIN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNL_MAIN.ForeColor = System.Drawing.Color.Silver;
            this.PNL_MAIN.Location = new System.Drawing.Point(0, 0);
            this.PNL_MAIN.Name = "PNL_MAIN";
            this.PNL_MAIN.Size = new System.Drawing.Size(1219, 565);
            this.PNL_MAIN.TabIndex = 0;
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(277, 56);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(668, 425);
            this.PCT_CANVAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCT_CANVAS.TabIndex = 4;
            this.PCT_CANVAS.TabStop = false;
            // 
            // PNL_LEFT
            // 
            this.PNL_LEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PNL_LEFT.Controls.Add(this.Histograma);
            this.PNL_LEFT.Controls.Add(this.button1);
            this.PNL_LEFT.Controls.Add(this.panel4);
            this.PNL_LEFT.Controls.Add(this.panel1);
            this.PNL_LEFT.Controls.Add(this.PCT_THUMBNAIL);
            this.PNL_LEFT.Dock = System.Windows.Forms.DockStyle.Left;
            this.PNL_LEFT.Location = new System.Drawing.Point(0, 50);
            this.PNL_LEFT.Name = "PNL_LEFT";
            this.PNL_LEFT.Size = new System.Drawing.Size(250, 465);
            this.PNL_LEFT.TabIndex = 3;
            // 
            // Histograma
            // 
            this.Histograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Histograma.FlatAppearance.BorderSize = 0;
            this.Histograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Histograma.Location = new System.Drawing.Point(25, 148);
            this.Histograma.Name = "Histograma";
            this.Histograma.Size = new System.Drawing.Size(96, 27);
            this.Histograma.TabIndex = 10;
            this.Histograma.Text = "Histogram";
            this.Histograma.UseVisualStyleBackColor = false;
            this.Histograma.Click += new System.EventHandler(this.Histograma_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(25, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "SQUARES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 445);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 20);
            this.panel4.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 20);
            this.panel1.TabIndex = 6;
            // 
            // PCT_THUMBNAIL
            // 
            this.PCT_THUMBNAIL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_THUMBNAIL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PCT_THUMBNAIL.Location = new System.Drawing.Point(8, 350);
            this.PCT_THUMBNAIL.Name = "PCT_THUMBNAIL";
            this.PCT_THUMBNAIL.Size = new System.Drawing.Size(238, 89);
            this.PCT_THUMBNAIL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCT_THUMBNAIL.TabIndex = 5;
            this.PCT_THUMBNAIL.TabStop = false;
            // 
            // PNL_RIGHT
            // 
            this.PNL_RIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PNL_RIGHT.Controls.Add(this.button3);
            this.PNL_RIGHT.Controls.Add(this.button4);
            this.PNL_RIGHT.Controls.Add(this.button2);
            this.PNL_RIGHT.Controls.Add(this.pictureBoxH);
            this.PNL_RIGHT.Controls.Add(this.BTN_SEPIA);
            this.PNL_RIGHT.Controls.Add(this.BTN_GRAY);
            this.PNL_RIGHT.Controls.Add(this.BTN_INVERT);
            this.PNL_RIGHT.Controls.Add(this.panel3);
            this.PNL_RIGHT.Controls.Add(this.panel2);
            this.PNL_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.PNL_RIGHT.Location = new System.Drawing.Point(969, 50);
            this.PNL_RIGHT.Name = "PNL_RIGHT";
            this.PNL_RIGHT.Size = new System.Drawing.Size(250, 465);
            this.PNL_RIGHT.TabIndex = 2;
            // 
            // pictureBoxH
            // 
            this.pictureBoxH.BackColor = System.Drawing.Color.OldLace;
            this.pictureBoxH.Location = new System.Drawing.Point(-17, 270);
            this.pictureBoxH.Name = "pictureBoxH";
            this.pictureBoxH.Size = new System.Drawing.Size(255, 150);
            this.pictureBoxH.TabIndex = 11;
            this.pictureBoxH.TabStop = false;
            this.pictureBoxH.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BTN_SEPIA
            // 
            this.BTN_SEPIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_SEPIA.FlatAppearance.BorderSize = 0;
            this.BTN_SEPIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEPIA.Location = new System.Drawing.Point(7, 115);
            this.BTN_SEPIA.Name = "BTN_SEPIA";
            this.BTN_SEPIA.Size = new System.Drawing.Size(78, 27);
            this.BTN_SEPIA.TabIndex = 10;
            this.BTN_SEPIA.Text = "SEPIA";
            this.BTN_SEPIA.UseVisualStyleBackColor = false;
            this.BTN_SEPIA.Click += new System.EventHandler(this.BTN_SEPIA_Click);
            // 
            // BTN_GRAY
            // 
            this.BTN_GRAY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_GRAY.FlatAppearance.BorderSize = 0;
            this.BTN_GRAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GRAY.Location = new System.Drawing.Point(7, 82);
            this.BTN_GRAY.Name = "BTN_GRAY";
            this.BTN_GRAY.Size = new System.Drawing.Size(78, 27);
            this.BTN_GRAY.TabIndex = 9;
            this.BTN_GRAY.Text = "G";
            this.BTN_GRAY.UseVisualStyleBackColor = false;
            this.BTN_GRAY.Click += new System.EventHandler(this.BTN_GRAY_Click);
            // 
            // BTN_INVERT
            // 
            this.BTN_INVERT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_INVERT.FlatAppearance.BorderSize = 0;
            this.BTN_INVERT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_INVERT.Location = new System.Drawing.Point(7, 49);
            this.BTN_INVERT.Name = "BTN_INVERT";
            this.BTN_INVERT.Size = new System.Drawing.Size(78, 27);
            this.BTN_INVERT.TabIndex = 1;
            this.BTN_INVERT.Text = "-i";
            this.BTN_INVERT.UseVisualStyleBackColor = false;
            this.BTN_INVERT.Click += new System.EventHandler(this.BTN_INVERT_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 20);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 20);
            this.panel2.TabIndex = 7;
            // 
            // PNL_BOTTOM
            // 
            this.PNL_BOTTOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PNL_BOTTOM.Controls.Add(this.textBox1);
            this.PNL_BOTTOM.Controls.Add(this.BTN_SAVE);
            this.PNL_BOTTOM.Controls.Add(this.LBL_STATUS);
            this.PNL_BOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_BOTTOM.Location = new System.Drawing.Point(0, 515);
            this.PNL_BOTTOM.Name = "PNL_BOTTOM";
            this.PNL_BOTTOM.Size = new System.Drawing.Size(1219, 50);
            this.PNL_BOTTOM.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(421, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 19);
            this.textBox1.TabIndex = 3;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_SAVE.FlatAppearance.BorderSize = 0;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Location = new System.Drawing.Point(381, 11);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(138, 27);
            this.BTN_SAVE.TabIndex = 2;
            this.BTN_SAVE.Text = "SAVE";
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_STATUS.Location = new System.Drawing.Point(0, 31);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(1219, 19);
            this.LBL_STATUS.TabIndex = 0;
            this.LBL_STATUS.Text = "WELCOME";
            // 
            // PNL_HEAD
            // 
            this.PNL_HEAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PNL_HEAD.Controls.Add(this.BTN_RELOAD);
            this.PNL_HEAD.Controls.Add(this.BTN_EXE);
            this.PNL_HEAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_HEAD.Location = new System.Drawing.Point(0, 0);
            this.PNL_HEAD.Name = "PNL_HEAD";
            this.PNL_HEAD.Size = new System.Drawing.Size(1219, 50);
            this.PNL_HEAD.TabIndex = 0;
            this.PNL_HEAD.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_HEAD_Paint);
            // 
            // BTN_RELOAD
            // 
            this.BTN_RELOAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_RELOAD.FlatAppearance.BorderSize = 0;
            this.BTN_RELOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RELOAD.Location = new System.Drawing.Point(186, 12);
            this.BTN_RELOAD.Name = "BTN_RELOAD";
            this.BTN_RELOAD.Size = new System.Drawing.Size(72, 27);
            this.BTN_RELOAD.TabIndex = 1;
            this.BTN_RELOAD.Text = "RE";
            this.BTN_RELOAD.UseVisualStyleBackColor = false;
            this.BTN_RELOAD.Click += new System.EventHandler(this.BTN_RELOAD_Click);
            // 
            // BTN_EXE
            // 
            this.BTN_EXE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_EXE.FlatAppearance.BorderSize = 0;
            this.BTN_EXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE.Location = new System.Drawing.Point(9, 12);
            this.BTN_EXE.Name = "BTN_EXE";
            this.BTN_EXE.Size = new System.Drawing.Size(138, 27);
            this.BTN_EXE.TabIndex = 0;
            this.BTN_EXE.Text = "LOAD";
            this.BTN_EXE.UseVisualStyleBackColor = false;
            this.BTN_EXE.Click += new System.EventHandler(this.BTN_EXE_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "brillo +";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(107, 158);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "brillo -";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 211);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 32);
            this.button3.TabIndex = 14;
            this.button3.Text = "Contrast";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 565);
            this.Controls.Add(this.PNL_MAIN);
            this.Name = "MAIN";
            this.Text = "IMG PLAYGROUND";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PNL_MAIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.PNL_LEFT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_THUMBNAIL)).EndInit();
            this.PNL_RIGHT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH)).EndInit();
            this.PNL_BOTTOM.ResumeLayout(false);
            this.PNL_BOTTOM.PerformLayout();
            this.PNL_HEAD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_MAIN;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Panel PNL_LEFT;
        private System.Windows.Forms.Panel PNL_RIGHT;
        private System.Windows.Forms.Panel PNL_BOTTOM;
        private System.Windows.Forms.Panel PNL_HEAD;
        private System.Windows.Forms.Button BTN_EXE;
        private System.Windows.Forms.PictureBox PCT_THUMBNAIL;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_INVERT;
        private System.Windows.Forms.Button BTN_SEPIA;
        private System.Windows.Forms.Button BTN_GRAY;
        private System.Windows.Forms.Button BTN_RELOAD;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxH;
        private System.Windows.Forms.Button Histograma;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}

