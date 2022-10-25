
namespace MyPCDatabaseApp
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSsdHdd = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.dataGridViewPCs101 = new System.Windows.Forms.DataGridView();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RAM = new System.Windows.Forms.Label();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.PCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANUFACTURER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCMODEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSDorHDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPCs101)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(154, 311);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(51, 42);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(696, 359);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 33);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(229, 311);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(47, 42);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANUFACTURER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MODEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SSD or HDD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRICE";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(154, 34);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(205, 20);
            this.txtManufacturer.TabIndex = 8;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(154, 88);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(205, 20);
            this.txtModel.TabIndex = 9;
            // 
            // txtSsdHdd
            // 
            this.txtSsdHdd.Location = new System.Drawing.Point(154, 144);
            this.txtSsdHdd.Name = "txtSsdHdd";
            this.txtSsdHdd.Size = new System.Drawing.Size(205, 20);
            this.txtSsdHdd.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(154, 243);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(205, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(696, 408);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 30);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dataGridViewPCs101
            // 
            this.dataGridViewPCs101.AllowUserToDeleteRows = false;
            this.dataGridViewPCs101.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPCs101.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPCs101.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PCID,
            this.MANUFACTURER,
            this.PCMODEL,
            this.SSDorHDD,
            this.PCRAM,
            this.PCPRICE});
            this.dataGridViewPCs101.Location = new System.Drawing.Point(377, 35);
            this.dataGridViewPCs101.Name = "dataGridViewPCs101";
            this.dataGridViewPCs101.ReadOnly = true;
            this.dataGridViewPCs101.Size = new System.Drawing.Size(547, 318);
            this.dataGridViewPCs101.TabIndex = 14;
            this.dataGridViewPCs101.DoubleClick += new System.EventHandler(this.dataGridViewPCs101_DoubleClick);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(301, 311);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(58, 42);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RAM
            // 
            this.RAM.AutoSize = true;
            this.RAM.Location = new System.Drawing.Point(57, 196);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(31, 13);
            this.RAM.TabIndex = 16;
            this.RAM.Text = "RAM";
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(154, 193);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(205, 20);
            this.txtRAM.TabIndex = 17;
            // 
            // PCID
            // 
            this.PCID.DataPropertyName = "PCID";
            this.PCID.HeaderText = "PCID";
            this.PCID.Name = "PCID";
            this.PCID.ReadOnly = true;
            this.PCID.Visible = false;
            // 
            // MANUFACTURER
            // 
            this.MANUFACTURER.DataPropertyName = "MANUFACTURER";
            this.MANUFACTURER.HeaderText = "MANUFACTURER";
            this.MANUFACTURER.Name = "MANUFACTURER";
            this.MANUFACTURER.ReadOnly = true;
            // 
            // PCMODEL
            // 
            this.PCMODEL.DataPropertyName = "MODEL";
            this.PCMODEL.HeaderText = "MODEL";
            this.PCMODEL.Name = "PCMODEL";
            this.PCMODEL.ReadOnly = true;
            // 
            // SSDorHDD
            // 
            this.SSDorHDD.DataPropertyName = "SSD_HDD";
            this.SSDorHDD.HeaderText = "SSD or HDD";
            this.SSDorHDD.Name = "SSDorHDD";
            this.SSDorHDD.ReadOnly = true;
            // 
            // PCRAM
            // 
            this.PCRAM.DataPropertyName = "RAM";
            this.PCRAM.HeaderText = "RAM";
            this.PCRAM.Name = "PCRAM";
            this.PCRAM.ReadOnly = true;
            // 
            // PCPRICE
            // 
            this.PCPRICE.DataPropertyName = "PRICE";
            this.PCPRICE.HeaderText = "PRICE";
            this.PCPRICE.Name = "PCPRICE";
            this.PCPRICE.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.dataGridViewPCs101);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtSsdHdd);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.SaveButton);
            this.Name = "Form1";
            this.Text = "PC DATABASE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPCs101)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtSsdHdd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dataGridViewPCs101;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label RAM;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANUFACTURER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCMODEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSDorHDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCPRICE;
    }
}

