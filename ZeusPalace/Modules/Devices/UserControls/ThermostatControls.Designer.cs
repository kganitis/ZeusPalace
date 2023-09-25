namespace ZeusPalace.Modules.Devices.UserControls
{
    partial class ThermostatControls
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
            this.btn_decr_temp = new System.Windows.Forms.Button();
            this.temperature_label = new System.Windows.Forms.Label();
            this.thermostat_label = new System.Windows.Forms.Label();
            this.btn_icr_temp = new System.Windows.Forms.Button();
            this.celsius_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.35739F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.64261F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.btn_decr_temp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.thermostat_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_icr_temp, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.celsius_label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.temperature_label, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 43);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn_decr_temp
            // 
            this.btn_decr_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_decr_temp.Location = new System.Drawing.Point(130, 3);
            this.btn_decr_temp.Name = "btn_decr_temp";
            this.btn_decr_temp.Size = new System.Drawing.Size(93, 37);
            this.btn_decr_temp.TabIndex = 3;
            this.btn_decr_temp.Text = "-";
            this.btn_decr_temp.UseVisualStyleBackColor = true;
            // 
            // temperature_label
            // 
            this.temperature_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.temperature_label.Location = new System.Drawing.Point(229, 0);
            this.temperature_label.Name = "temperature_label";
            this.temperature_label.Size = new System.Drawing.Size(73, 43);
            this.temperature_label.TabIndex = 1;
            this.temperature_label.Text = "22,0";
            this.temperature_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thermostat_label
            // 
            this.thermostat_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.thermostat_label.Location = new System.Drawing.Point(3, 0);
            this.thermostat_label.Name = "thermostat_label";
            this.thermostat_label.Size = new System.Drawing.Size(121, 43);
            this.thermostat_label.TabIndex = 0;
            this.thermostat_label.Text = "Θερμοστάτης";
            this.thermostat_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_icr_temp
            // 
            this.btn_icr_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_icr_temp.Location = new System.Drawing.Point(425, 3);
            this.btn_icr_temp.Name = "btn_icr_temp";
            this.btn_icr_temp.Size = new System.Drawing.Size(105, 37);
            this.btn_icr_temp.TabIndex = 2;
            this.btn_icr_temp.Text = "+";
            this.btn_icr_temp.UseVisualStyleBackColor = true;
            this.btn_icr_temp.Click += new System.EventHandler(this.btn_icr_temp_Click);
            // 
            // celsius_label
            // 
            this.celsius_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.celsius_label.Location = new System.Drawing.Point(337, 0);
            this.celsius_label.Name = "celsius_label";
            this.celsius_label.Size = new System.Drawing.Size(73, 40);
            this.celsius_label.TabIndex = 4;
            this.celsius_label.Text = "C";
            this.celsius_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThermostatControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Label temperature_label;
        private System.Windows.Forms.Label thermostat_label;
        private System.Windows.Forms.Button btn_icr_temp;
        private System.Windows.Forms.Label celsius_label;
    }
}
