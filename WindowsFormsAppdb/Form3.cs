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

namespace WindowsFormsAppdb
{
    public partial class Form3 : Form
    {
        public void GetMeCopyCitizen()//метод для получения списка граждан
        {

            using (var db = new police_dbContext())
            {

                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.CopyCitizen.ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }

        public void GetMeCopyEmployee()
        {
            using (var db = new police_dbContext())
            {

                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.CopyEmployee.ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }

        public void GetMeCopyFine()
        {
            using (var db = new police_dbContext())
            {

                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.CopyFine.ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }

        public void GetMeCopyInsurance()
        {
            using (var db = new police_dbContext())
            {

                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.CopyInsurance.ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }

        public void GetMeCopyLicense()
        {
            using (var db = new police_dbContext())
            {

                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.CopyLicense.ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }

        public void GetMeCopyTechPasport()
        {
            using (var db = new police_dbContext())
            {

                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.CopyTechPasport.ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBox1.Text;
            switch (n)
            {
                case "":
                    MessageBox.Show("не выбрана таблица");
                    break;
                case "Citizen":
                    GetMeCopyCitizen();
                    break;
                case "Employee":
                    GetMeCopyEmployee();
                    break;
                case "Fine":
                    GetMeCopyFine();
                    break;
                case "Insurance":
                    GetMeCopyInsurance();
                    break;
                case "License":
                    GetMeCopyLicense();
                    break;
                case "TechPasport":
                    GetMeCopyTechPasport();
                    break;

            }
        }
    }
}
