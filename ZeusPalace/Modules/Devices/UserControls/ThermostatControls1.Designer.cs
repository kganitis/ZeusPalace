namespace ZeusPalace.Modules.Devices.UserControls
{
    partial class ThermostatControls1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.thermostat_label = new System.Windows.Forms.Label();
            this.btn_decr_temp = new System.Windows.Forms.Button();
            this.temperature_label = new System.Windows.Forms.Label();
            this.TempBox = new System.Windows.Forms.PictureBox();
            this.btn_icr_temp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.32494F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.26144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.93464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.thermostat_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_decr_temp, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.temperature_label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TempBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_icr_temp, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 39);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // thermostat_label
            // 
            this.thermostat_label.BackColor = System.Drawing.Color.Transparent;
            this.thermostat_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thermostat_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.thermostat_label.ForeColor = System.Drawing.Color.Black;
            this.thermostat_label.Location = new System.Drawing.Point(3, 0);
            this.thermostat_label.Name = "thermostat_label";
            this.thermostat_label.Size = new System.Drawing.Size(136, 39);
            this.thermostat_label.TabIndex = 0;
            this.thermostat_label.Text = "Θερμοκρασία ";
            this.thermostat_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_decr_temp
            // 
            this.btn_decr_temp.BackColor = System.Drawing.Color.Transparent;
            this.btn_decr_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_decr_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_decr_temp.Location = new System.Drawing.Point(264, 3);
            this.btn_decr_temp.Name = "btn_decr_temp";
            this.btn_decr_temp.Size = new System.Drawing.Size(59, 33);
            this.btn_decr_temp.TabIndex = 3;
            this.btn_decr_temp.Text = "-";
            this.btn_decr_temp.UseVisualStyleBackColor = false;
            this.btn_decr_temp.Click += new System.EventHandler(this.btn_decr_temp_Click);
            // 
            // temperature_label
            // 
            this.temperature_label.BackColor = System.Drawing.Color.Transparent;
            this.temperature_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperature_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.temperature_label.ForeColor = System.Drawing.Color.Snow;
            this.temperature_label.Location = new System.Drawing.Point(198, 0);
            this.temperature_label.Name = "temperature_label";
            this.temperature_label.Size = new System.Drawing.Size(60, 39);
            this.temperature_label.TabIndex = 6;
            this.temperature_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TempBox
            // 
            this.TempBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TempBox.BackColor = System.Drawing.Color.Transparent;
            this.TempBox.BackgroundImage = global::ZeusPalace.Properties.Resources.thermometer_png_icon_1;
            this.TempBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TempBox.Location = new System.Drawing.Point(145, 3);
            this.TempBox.Name = "TempBox";
            this.TempBox.Size = new System.Drawing.Size(47, 33);
            this.TempBox.TabIndex = 8;
            this.TempBox.TabStop = false;
            // 
            // btn_icr_temp
            // 
            this.btn_icr_temp.BackColor = System.Drawing.Color.Transparent;
            this.btn_icr_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_icr_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_icr_temp.Location = new System.Drawing.Point(329, 3);
            this.btn_icr_temp.Name = "btn_icr_temp";
            this.btn_icr_temp.Size = new System.Drawing.Size(56, 33);
            this.btn_icr_temp.TabIndex = 7;
            this.btn_icr_temp.Text = "+";
            this.btn_icr_temp.UseVisualStyleBackColor = false;
            this.btn_icr_temp.Click += new System.EventHandler(this.btn_icr_temp_Click);
            // 
            // ThermostatControls1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThermostatControls1";
            this.Size = new System.Drawing.Size(487, 84);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TempBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_decr_temp;
        private System.Windows.Forms.Label thermostat_label;
        private System.Windows.Forms.Button btn_icr_temp;
        private System.Windows.Forms.Label temperature_label;
        private System.Windows.Forms.PictureBox TempBox;
    }
}
