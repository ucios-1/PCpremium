namespace PCpremiumFB
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.slider = new System.Windows.Forms.Panel();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.bttnClosed = new System.Windows.Forms.Button();
            this.bttnOpened = new System.Windows.Forms.Button();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnReload = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.bttnGo = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewReal = new System.Windows.Forms.DataGridView();
            this.dataGridViewDone = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            this.slider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDone)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panelLeft.Controls.Add(this.slider);
            this.panelLeft.Controls.Add(this.bttnSearch);
            this.panelLeft.Controls.Add(this.bttnClosed);
            this.panelLeft.Controls.Add(this.bttnOpened);
            this.panelLeft.Controls.Add(this.pbMenu);
            this.panelLeft.Controls.Add(this.txt1);
            this.panelLeft.Controls.Add(this.txt3);
            this.panelLeft.Controls.Add(this.txt2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(70, 758);
            this.panelLeft.TabIndex = 3;
            // 
            // slider
            // 
            this.slider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.slider.Controls.Add(this.txt4);
            this.slider.Location = new System.Drawing.Point(60, 48);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(10, 60);
            this.slider.TabIndex = 1;
            this.slider.Visible = false;
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.txt4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21F);
            this.txt4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt4.Location = new System.Drawing.Point(22, 14);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(174, 33);
            this.txt4.TabIndex = 5;
            this.txt4.Visible = false;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackgroundImage = global::PCpremiumFB.Properties.Resources.search2;
            this.bttnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSearch.Location = new System.Drawing.Point(5, 301);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(60, 60);
            this.bttnSearch.TabIndex = 2;
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // bttnClosed
            // 
            this.bttnClosed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.bttnClosed.BackgroundImage = global::PCpremiumFB.Properties.Resources.list__2_;
            this.bttnClosed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClosed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.bttnClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnClosed.Location = new System.Drawing.Point(3, 218);
            this.bttnClosed.Name = "bttnClosed";
            this.bttnClosed.Size = new System.Drawing.Size(60, 60);
            this.bttnClosed.TabIndex = 1;
            this.bttnClosed.UseVisualStyleBackColor = false;
            this.bttnClosed.Click += new System.EventHandler(this.bttnClosed_Click);
            // 
            // bttnOpened
            // 
            this.bttnOpened.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.bttnOpened.BackgroundImage = global::PCpremiumFB.Properties.Resources.listTODO;
            this.bttnOpened.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnOpened.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnOpened.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.bttnOpened.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnOpened.Location = new System.Drawing.Point(4, 133);
            this.bttnOpened.Name = "bttnOpened";
            this.bttnOpened.Size = new System.Drawing.Size(60, 60);
            this.bttnOpened.TabIndex = 1;
            this.bttnOpened.UseVisualStyleBackColor = false;
            this.bttnOpened.Click += new System.EventHandler(this.bttnOpened_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMenu.BackgroundImage")));
            this.pbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMenu.InitialImage")));
            this.pbMenu.Location = new System.Drawing.Point(12, 48);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(45, 45);
            this.pbMenu.TabIndex = 4;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21F);
            this.txt1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt1.Location = new System.Drawing.Point(82, 147);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(174, 33);
            this.txt1.TabIndex = 5;
            this.txt1.Text = "Otwarte";
            this.txt1.Visible = false;
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21F);
            this.txt3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt3.Location = new System.Drawing.Point(82, 315);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(174, 33);
            this.txt3.TabIndex = 5;
            this.txt3.Text = "Szukaj";
            this.txt3.Visible = false;
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21F);
            this.txt2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt2.Location = new System.Drawing.Point(82, 232);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(174, 33);
            this.txt2.TabIndex = 5;
            this.txt2.Text = "Zamknięte";
            this.txt2.Visible = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.bttnReload);
            this.panelTop.Controls.Add(this.bttnAdd);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(70, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1281, 73);
            this.panelTop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::PCpremiumFB.Properties.Resources.logoWhite;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1197, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bttnReload
            // 
            this.bttnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.bttnReload.BackgroundImage = global::PCpremiumFB.Properties.Resources.reload;
            this.bttnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.bttnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnReload.Location = new System.Drawing.Point(2, 0);
            this.bttnReload.Name = "bttnReload";
            this.bttnReload.Size = new System.Drawing.Size(53, 73);
            this.bttnReload.TabIndex = 1;
            this.bttnReload.UseVisualStyleBackColor = false;
            this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.bttnAdd.BackgroundImage = global::PCpremiumFB.Properties.Resources.plus;
            this.bttnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdd.Font = new System.Drawing.Font("Myriad Web Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttnAdd.Location = new System.Drawing.Point(58, 0);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(62, 73);
            this.bttnAdd.TabIndex = 0;
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PCpremiumFB.Properties.Resources.test;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dataGridViewSearch);
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Controls.Add(this.dataGridViewReal);
            this.panel1.Controls.Add(this.dataGridViewDone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(70, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 685);
            this.panel1.TabIndex = 5;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSearch.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.Size = new System.Drawing.Size(1281, 622);
            this.dataGridViewSearch.TabIndex = 1;
            this.dataGridViewSearch.Visible = false;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.panel3);
            this.panelSearch.Controls.Add(this.panel2);
            this.panelSearch.Controls.Add(this.cbSearch);
            this.panelSearch.Controls.Add(this.bttnGo);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1281, 63);
            this.panelSearch.TabIndex = 4;
            this.panelSearch.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panel3.Location = new System.Drawing.Point(15, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 2);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panel2.Location = new System.Drawing.Point(233, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 2);
            this.panel2.TabIndex = 3;
            // 
            // cbSearch
            // 
            this.cbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSearch.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F);
            this.cbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Name",
            "Date"});
            this.cbSearch.Location = new System.Drawing.Point(15, 14);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(208, 35);
            this.cbSearch.TabIndex = 2;
            // 
            // bttnGo
            // 
            this.bttnGo.BackgroundImage = global::PCpremiumFB.Properties.Resources.forward_fast;
            this.bttnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnGo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bttnGo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.bttnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGo.Location = new System.Drawing.Point(529, 4);
            this.bttnGo.Name = "bttnGo";
            this.bttnGo.Size = new System.Drawing.Size(55, 55);
            this.bttnGo.TabIndex = 1;
            this.bttnGo.UseVisualStyleBackColor = true;
            this.bttnGo.Click += new System.EventHandler(this.bttnGo_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.txtSearch.Location = new System.Drawing.Point(233, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(286, 33);
            this.txtSearch.TabIndex = 0;
            // 
            // dataGridViewReal
            // 
            this.dataGridViewReal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewReal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReal.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReal.Name = "dataGridViewReal";
            this.dataGridViewReal.Size = new System.Drawing.Size(1281, 685);
            this.dataGridViewReal.TabIndex = 0;
            this.dataGridViewReal.Visible = false;
            this.dataGridViewReal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewReal_MouseDoubleClick);
            // 
            // dataGridViewDone
            // 
            this.dataGridViewDone.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDone.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDone.Name = "dataGridViewDone";
            this.dataGridViewDone.Size = new System.Drawing.Size(1281, 685);
            this.dataGridViewDone.TabIndex = 0;
            this.dataGridViewDone.Visible = false;
            this.dataGridViewDone.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewDone_MouseDoubleClick);
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1351, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Premium";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.slider.ResumeLayout(false);
            this.slider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnReload;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel slider;
        private System.Windows.Forms.Button bttnOpened;
        private System.Windows.Forms.Button bttnClosed;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.DataGridView dataGridViewReal;
        private System.Windows.Forms.DataGridView dataGridViewDone;
        private System.Windows.Forms.Button bttnGo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
    }
}

