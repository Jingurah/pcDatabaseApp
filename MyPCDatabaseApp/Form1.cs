using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPCDatabaseApp
{
    public partial class Form1 : Form
    {
        
        PCs101 model = new PCs101();
        public Form1()
        {
            InitializeComponent();
            PopulateDataGridView();
        }
        void Clear()
        {
            txtManufacturer.Text = txtModel.Text = txtSsdHdd.Text = txtRAM.Text = txtPrice.Text = "";
            SaveButton.Text = "Save";
            DeleteButton.Enabled = false;
            model.PCID = 0;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {          
            model.MANUFACTURER = txtManufacturer.Text.Trim();
            model.MODEL = txtModel.Text.Trim();
            model.SSD_HDD = txtSsdHdd.Text.Trim();
            model.RAM = Convert.ToInt32(txtRAM.Text.Trim());
            model.PRICE = Convert.ToInt32(txtPrice.Text.Trim());
            

            try
            {
                using (COMPUTERSEntities db = new COMPUTERSEntities())
                {
                    if (model.PCID == 0)//Insert
                    {
                        db.PCs101.Add(model);
                    }
                    else
                    {
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                Clear();
                 PopulateDataGridView();
                MessageBox.Show("Saved successfully");
            }
            catch
            {
                MessageBox.Show("Failed to save Data");
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
        }
        void PopulateDataGridView()
        {
            dataGridViewPCs101.AutoGenerateColumns = false;
            using(COMPUTERSEntities db = new COMPUTERSEntities())
            {
                dataGridViewPCs101.DataSource = db.PCs101.ToList<PCs101>();
            }
        }

        private void dataGridViewPCs101_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridViewPCs101.CurrentRow.Index != -1)
            {
                model.PCID = Convert.ToInt32(dataGridViewPCs101.CurrentRow.Cells["PCID"].Value);
                using (COMPUTERSEntities db = new COMPUTERSEntities())
                {
                   model = db.PCs101.Where(x => x.PCID == model.PCID).FirstOrDefault();

                    txtManufacturer.Text = model.MANUFACTURER;
                    txtModel.Text = model.MODEL;
                    txtSsdHdd.Text = model.SSD_HDD;
                    txtRAM.Text = model.RAM.ToString();
                    txtPrice.Text = model.PRICE.ToString();
                }
                SaveButton.Text = "Update";
                DeleteButton.Enabled = true;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete ROW ?","CRUD Operation", MessageBoxButtons.YesNo)==DialogResult.Yes)
            using(COMPUTERSEntities db = new COMPUTERSEntities())
            {
                    var enrty = db.Entry(model);
                    if(enrty.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.PCs101.Attach(model);
                    }
                    db.PCs101.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Data deleted successfully");

            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var fileInfo = new FileInfo(saveFileDialog.FileName);
                        using (var package = new ExcelPackage(fileInfo))
                        {
                            ExcelWorksheet excelWorksheet = package.Workbook.Worksheets.Add("PCs");
                            excelWorksheet.Cells.LoadFromCollection<PCs101>(dataGridViewPCs101.DataSource as List<PCs101>, true);
                            package.Save();
                            PopulateDataGridView();
                        }
                        MessageBox.Show("File successfully exported. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
