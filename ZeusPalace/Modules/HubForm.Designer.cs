using System.Threading;

namespace ZeusPalace.Modules
{
    partial class HubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HubForm));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelHub = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPoolOrHorse = new System.Windows.Forms.Panel();
            this.labelPoolOrHorse = new System.Windows.Forms.Label();
            this.pictureBoxPoolOrHorse = new System.Windows.Forms.PictureBox();
            this.panelDevices = new System.Windows.Forms.Panel();
            this.labelDevices = new System.Windows.Forms.Label();
            this.pictureBoxDevices = new System.Windows.Forms.PictureBox();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.labelOrders = new System.Windows.Forms.Label();
            this.pictureBoxOrders = new System.Windows.Forms.PictureBox();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.panelLogin.SuspendLayout();
            this.panelHub.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPoolOrHorse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoolOrHorse)).BeginInit();
            this.panelDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevices)).BeginInit();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Location = new System.Drawing.Point(438, 244);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(404, 172);
            this.panelLogin.TabIndex = 1;
            this.panelLogin.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(194, 98);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(96, 30);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Σύνδεση";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(194, 58);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(185, 25);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(194, 17);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(185, 25);
            this.textBoxUsername.TabIndex = 6;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.labelPassword.Location = new System.Drawing.Point(78, 56);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 22);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Κωδικός";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.labelUsername.Location = new System.Drawing.Point(26, 16);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(130, 22);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Όνομα χρήστη";
            // 
            // panelHub
            // 
            this.panelHub.BackgroundImage = global::ZeusPalace.Properties.Resources.background_home;
            this.panelHub.Controls.Add(this.tableLayoutPanel1);
            this.panelHub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHub.Location = new System.Drawing.Point(0, 0);
            this.panelHub.Name = "panelHub";
            this.panelHub.Size = new System.Drawing.Size(1280, 660);
            this.panelHub.TabIndex = 2;
            this.panelHub.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelPoolOrHorse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDevices, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelOrders, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 660);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelPoolOrHorse
            // 
            this.panelPoolOrHorse.Controls.Add(this.labelPoolOrHorse);
            this.panelPoolOrHorse.Controls.Add(this.pictureBoxPoolOrHorse);
            this.panelPoolOrHorse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPoolOrHorse.Location = new System.Drawing.Point(643, 3);
            this.panelPoolOrHorse.Name = "panelPoolOrHorse";
            this.panelPoolOrHorse.Size = new System.Drawing.Size(634, 324);
            this.panelPoolOrHorse.TabIndex = 4;
            // 
            // labelPoolOrHorse
            // 
            this.labelPoolOrHorse.AutoSize = true;
            this.labelPoolOrHorse.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoolOrHorse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelPoolOrHorse.Location = new System.Drawing.Point(282, 291);
            this.labelPoolOrHorse.Name = "labelPoolOrHorse";
            this.labelPoolOrHorse.Size = new System.Drawing.Size(71, 22);
            this.labelPoolOrHorse.TabIndex = 4;
            this.labelPoolOrHorse.Text = "ΠΙΣΙΝΑ";
            // 
            // pictureBoxPoolOrHorse
            // 
            this.pictureBoxPoolOrHorse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPoolOrHorse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPoolOrHorse.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPoolOrHorse.Image")));
            this.pictureBoxPoolOrHorse.Location = new System.Drawing.Point(113, 46);
            this.pictureBoxPoolOrHorse.Name = "pictureBoxPoolOrHorse";
            this.pictureBoxPoolOrHorse.Size = new System.Drawing.Size(408, 233);
            this.pictureBoxPoolOrHorse.TabIndex = 1;
            this.pictureBoxPoolOrHorse.TabStop = false;
            this.pictureBoxPoolOrHorse.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBoxPoolOrHorse.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // panelDevices
            // 
            this.panelDevices.Controls.Add(this.labelDevices);
            this.panelDevices.Controls.Add(this.pictureBoxDevices);
            this.panelDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDevices.Location = new System.Drawing.Point(3, 3);
            this.panelDevices.Name = "panelDevices";
            this.panelDevices.Size = new System.Drawing.Size(634, 324);
            this.panelDevices.TabIndex = 3;
            // 
            // labelDevices
            // 
            this.labelDevices.AutoSize = true;
            this.labelDevices.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelDevices.Location = new System.Drawing.Point(199, 291);
            this.labelDevices.Name = "labelDevices";
            this.labelDevices.Size = new System.Drawing.Size(237, 22);
            this.labelDevices.TabIndex = 4;
            this.labelDevices.Text = "ΣΥΣΚΕΥΕΣ ΚΑΤΑΛΥΜΑΤΟΣ";
            // 
            // pictureBoxDevices
            // 
            this.pictureBoxDevices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDevices.Image = global::ZeusPalace.Properties.Resources.background_loading;
            this.pictureBoxDevices.Location = new System.Drawing.Point(113, 46);
            this.pictureBoxDevices.Name = "pictureBoxDevices";
            this.pictureBoxDevices.Size = new System.Drawing.Size(408, 233);
            this.pictureBoxDevices.TabIndex = 1;
            this.pictureBoxDevices.TabStop = false;
            this.pictureBoxDevices.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBoxDevices.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // panelOrders
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelOrders, 2);
            this.panelOrders.Controls.Add(this.labelOrders);
            this.panelOrders.Controls.Add(this.pictureBoxOrders);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(3, 333);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(1274, 324);
            this.panelOrders.TabIndex = 5;
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelOrders.Location = new System.Drawing.Point(581, 291);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(113, 22);
            this.labelOrders.TabIndex = 5;
            this.labelOrders.Text = "ΕΣΤΙΑΤΟΡΙΟ";
            // 
            // pictureBoxOrders
            // 
            this.pictureBoxOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOrders.Image = global::ZeusPalace.Properties.Resources.orders_button;
            this.pictureBoxOrders.Location = new System.Drawing.Point(433, 46);
            this.pictureBoxOrders.Name = "pictureBoxOrders";
            this.pictureBoxOrders.Size = new System.Drawing.Size(408, 233);
            this.pictureBoxOrders.TabIndex = 1;
            this.pictureBoxOrders.TabStop = false;
            this.pictureBoxOrders.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBoxOrders.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 2000;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // HubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::ZeusPalace.Properties.Resources.background_loading;
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Controls.Add(this.panelHub);
            this.Controls.Add(this.panelLogin);
            this.Name = "HubForm";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelHub.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelPoolOrHorse.ResumeLayout(false);
            this.panelPoolOrHorse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoolOrHorse)).EndInit();
            this.panelDevices.ResumeLayout(false);
            this.panelDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevices)).EndInit();
            this.panelOrders.ResumeLayout(false);
            this.panelOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelHub;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelPoolOrHorse;
        private System.Windows.Forms.Panel panelDevices;
        internal System.Windows.Forms.PictureBox pictureBoxOrders;
        internal System.Windows.Forms.PictureBox pictureBoxPoolOrHorse;
        internal System.Windows.Forms.PictureBox pictureBoxDevices;
        private System.Windows.Forms.Label labelDevices;
        private System.Windows.Forms.Label labelPoolOrHorse;
        private System.Windows.Forms.Label labelOrders;
        internal System.Windows.Forms.Timer timerLoading;
        internal System.Windows.Forms.Panel panelOrders;
    }
}
