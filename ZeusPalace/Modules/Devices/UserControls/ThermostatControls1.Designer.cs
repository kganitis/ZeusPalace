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
            this.btn_icr_temp = new System.Windows.Forms.Button();
            this.temperature_label = new System.Windows.Forms.Label();
            this.btn_decr_temp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.88555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.01501F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.82739F));
            this.tableLayoutPanel1.Controls.Add(this.thermostat_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_icr_temp, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_decr_temp, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.temperature_label, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 43);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // thermostat_label
            // 
            this.thermostat_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.thermostat_label.Location = new System.Drawing.Point(3, 0);
            this.thermostat_label.Name = "thermostat_label";
            this.thermostat_label.Size = new System.Drawing.Size(183, 43);
            this.thermostat_label.TabIndex = 0;
            this.thermostat_label.Text = "Θερμοκρασία ";
            this.thermostat_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_icr_temp
            // 
            this.btn_icr_temp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_icr_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_icr_temp.Location = new System.Drawing.Point(419, 3);
            this.btn_icr_temp.Name = "btn_icr_temp";
            this.btn_icr_temp.Size = new System.Drawing.Size(99, 37);
            this.btn_icr_temp.TabIndex = 7;
            this.btn_icr_temp.Text = "+";
            this.btn_icr_temp.UseVisualStyleBackColor = true;
            this.btn_icr_temp.Click += new System.EventHandler(this.btn_icr_temp_Click);
            // 
            // temperature_label
            // 
            this.temperature_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.temperature_label.Location = new System.Drawing.Point(192, 0);
            this.temperature_label.Name = "temperature_label";
            this.temperature_label.Size = new System.Drawing.Size(83, 43);
            this.temperature_label.TabIndex = 6;
            this.temperature_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_decr_temp
            // 
            this.btn_decr_temp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_decr_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_decr_temp.Location = new System.Drawing.Point(289, 3);
            this.btn_decr_temp.Name = "btn_decr_temp";
            this.btn_decr_temp.Size = new System.Drawing.Size(104, 37);
            this.btn_decr_temp.TabIndex = 3;
            this.btn_decr_temp.Text = "-";
            this.btn_decr_temp.UseVisualStyleBackColor = true;
            this.btn_decr_temp.Click += new System.EventHandler(this.btn_decr_temp_Click);
            // 
            // ThermostatControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThermostatControls";
            this.Size = new System.Drawing.Size(533, 43);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_decr_temp;
        private System.Windows.Forms.Label thermostat_label;
        private System.Windows.Forms.Button btn_icr_temp;
        private System.Windows.Forms.Label temperature_label;
    }
}
