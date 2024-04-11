namespace _0001
{
    partial class FormPreviewDialog
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
            this.PNL_MAIN = new System.Windows.Forms.Panel();
            this.BTN_DESKTOP = new System.Windows.Forms.Button();
            this.BTN_UP = new System.Windows.Forms.Button();
            this.treeViewDirectories = new System.Windows.Forms.TreeView();
            this.TXT_STATUS = new System.Windows.Forms.TextBox();
            this.LST_IMAGES = new System.Windows.Forms.ListBox();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.PNL_BUTTONS = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.PNL_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.PNL_BUTTONS.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_MAIN
            // 
            this.PNL_MAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PNL_MAIN.Controls.Add(this.BTN_DESKTOP);
            this.PNL_MAIN.Controls.Add(this.BTN_UP);
            this.PNL_MAIN.Controls.Add(this.treeViewDirectories);
            this.PNL_MAIN.Controls.Add(this.TXT_STATUS);
            this.PNL_MAIN.Controls.Add(this.LST_IMAGES);
            this.PNL_MAIN.Controls.Add(this.PCT_CANVAS);
            this.PNL_MAIN.Controls.Add(this.PNL_BUTTONS);
            this.PNL_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_MAIN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNL_MAIN.ForeColor = System.Drawing.Color.Silver;
            this.PNL_MAIN.Location = new System.Drawing.Point(0, 0);
            this.PNL_MAIN.Name = "PNL_MAIN";
            this.PNL_MAIN.Size = new System.Drawing.Size(748, 630);
            this.PNL_MAIN.TabIndex = 0;
            // 
            // BTN_DESKTOP
            // 
            this.BTN_DESKTOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DESKTOP.FlatAppearance.BorderSize = 0;
            this.BTN_DESKTOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DESKTOP.Location = new System.Drawing.Point(12, 47);
            this.BTN_DESKTOP.Name = "BTN_DESKTOP";
            this.BTN_DESKTOP.Size = new System.Drawing.Size(88, 27);
            this.BTN_DESKTOP.TabIndex = 8;
            this.BTN_DESKTOP.Text = "DESKTOP";
            this.BTN_DESKTOP.UseVisualStyleBackColor = false;
            this.BTN_DESKTOP.Click += new System.EventHandler(this.BTN_DESKTOP_Click);
            // 
            // BTN_UP
            // 
            this.BTN_UP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_UP.FlatAppearance.BorderSize = 0;
            this.BTN_UP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UP.Location = new System.Drawing.Point(106, 47);
            this.BTN_UP.Name = "BTN_UP";
            this.BTN_UP.Size = new System.Drawing.Size(75, 27);
            this.BTN_UP.TabIndex = 7;
            this.BTN_UP.Text = "UP";
            this.BTN_UP.UseVisualStyleBackColor = false;
            this.BTN_UP.Click += new System.EventHandler(this.BTN_UP_Click);
            // 
            // treeViewDirectories
            // 
            this.treeViewDirectories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.treeViewDirectories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewDirectories.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewDirectories.ForeColor = System.Drawing.Color.Silver;
            this.treeViewDirectories.Location = new System.Drawing.Point(12, 80);
            this.treeViewDirectories.Name = "treeViewDirectories";
            this.treeViewDirectories.Size = new System.Drawing.Size(350, 247);
            this.treeViewDirectories.TabIndex = 6;
            this.treeViewDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDirectories_AfterSelect);
            // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_STATUS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_STATUS.ForeColor = System.Drawing.Color.Silver;
            this.TXT_STATUS.Location = new System.Drawing.Point(12, 22);
            this.TXT_STATUS.Name = "TXT_STATUS";
            this.TXT_STATUS.Size = new System.Drawing.Size(724, 19);
            this.TXT_STATUS.TabIndex = 1;
            // 
            // LST_IMAGES
            // 
            this.LST_IMAGES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LST_IMAGES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LST_IMAGES.ForeColor = System.Drawing.Color.Silver;
            this.LST_IMAGES.FormattingEnabled = true;
            this.LST_IMAGES.ItemHeight = 19;
            this.LST_IMAGES.Location = new System.Drawing.Point(368, 80);
            this.LST_IMAGES.Name = "LST_IMAGES";
            this.LST_IMAGES.Size = new System.Drawing.Size(368, 247);
            this.LST_IMAGES.TabIndex = 4;
            this.LST_IMAGES.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            this.LST_IMAGES.DoubleClick += new System.EventHandler(this.LST_IMAGES_DoubleClick);
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(12, 333);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(724, 246);
            this.PCT_CANVAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCT_CANVAS.TabIndex = 3;
            this.PCT_CANVAS.TabStop = false;
            // 
            // PNL_BUTTONS
            // 
            this.PNL_BUTTONS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.PNL_BUTTONS.Controls.Add(this.btn_cancel);
            this.PNL_BUTTONS.Controls.Add(this.btn_Open);
            this.PNL_BUTTONS.Location = new System.Drawing.Point(12, 585);
            this.PNL_BUTTONS.Name = "PNL_BUTTONS";
            this.PNL_BUTTONS.Size = new System.Drawing.Size(724, 33);
            this.PNL_BUTTONS.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(611, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 27);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Open.FlatAppearance.BorderSize = 0;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.Location = new System.Drawing.Point(29, 3);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 27);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "LOAD";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FormPreviewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 630);
            this.Controls.Add(this.PNL_MAIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPreviewDialog";
            this.Text = "FormPreviewDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPreviewDialog_FormClosing);
            this.PNL_MAIN.ResumeLayout(false);
            this.PNL_MAIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.PNL_BUTTONS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_MAIN;
        private System.Windows.Forms.ListBox LST_IMAGES;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Panel PNL_BUTTONS;
        private System.Windows.Forms.TreeView treeViewDirectories;
        private System.Windows.Forms.TextBox TXT_STATUS;
        private System.Windows.Forms.Button BTN_UP;
        private System.Windows.Forms.Button BTN_DESKTOP;
    }
}