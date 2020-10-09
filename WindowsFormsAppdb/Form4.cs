using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppdb.Models;
using Exel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsAppdb
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (var db = new police_dbContext())
            {
                
                double avgamount = (double)db.Fine.Average(a => a.Ammount);
                var fines = db.Fine.Where(a=>a.Ammount>avgamount).ToList();
                dataGridView1.DataSource = fines;
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exel.Application exApp = new Exel.Application();
            exApp.Workbooks.Add();
            Exel.Worksheet wsh = (Exel.Worksheet)exApp.ActiveSheet;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    exApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }



            exApp.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
