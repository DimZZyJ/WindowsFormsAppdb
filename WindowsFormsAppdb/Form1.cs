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
    
    
        
    
    public partial class Form1 : Form
    {
        public void GetMeCitizen()//метод для получения списка граждан
        {
            
            using (police_dbContext db = new police_dbContext())
            {
                
                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.Citizen.FromSqlRaw("select * from citizen").ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }

        public void GetMeEmployee()//метод для получения списка Работников
        {

            using (police_dbContext db = new police_dbContext())
            {

                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.Employee.FromSqlRaw("select * from employee").ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }

        public void GetMeFine()//метод для получения списка Штрафов
        {

            using (police_dbContext db = new police_dbContext())
            {

                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.Fine.FromSqlRaw("select * from fine").ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }

        public void GetMeInsurance()//метод для получения списка страховок
        {

            using (police_dbContext db = new police_dbContext())
            {

                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.Insurance.FromSqlRaw("select * from insurance").ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }

        public void GetMeLicense()//метод для получения списка прав
        {

            using (police_dbContext db = new police_dbContext())
            {

                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.License.FromSqlRaw("select * from license").ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }

        public void GetMeTechPasport()//метод для получения списка тех паспортов
        {

            using (police_dbContext db = new police_dbContext())
            {

                if (db.Citizen.Count() == 0)
                {
                    MessageBox.Show("Таблица пуста");
                }
                else
                {
                    var ctz = db.TechPasport.FromSqlRaw("select * from tech_pasport").ToList();
                    dataGridView1.DataSource = ctz;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n=comboBox1.Text;
            switch (n)
            {
                case "":
                    MessageBox.Show("не выбрана таблица");
                    break;
                case "Citizen":
                    GetMeCitizen();
                    break;
                case "Employee":
                    GetMeEmployee();
                    break;
                case "Fine":
                    GetMeFine();
                    break;
                case "Insurance":
                    GetMeInsurance();
                    break;
                case "License":
                    GetMeLicense();
                    break;
                case "TechPasport":
                    GetMeTechPasport();
                    break;

            }
            
                

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using (var db = new police_dbContext())
            {
                string choice = comboBox1.Text;
                switch (choice)
                {
                    case "":
                        MessageBox.Show("не выбрана таблица");
                        break;
                    case "Citizen":
                        try
                        {
                            var delete = db.Citizen.Single(a => a.CitizenId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                            db.Citizen.Remove(delete);
                            db.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("От этого зависят значения других таблиц");
                        }
                        break;
                    case "Employee":
                        try
                        {
                            var delete = db.Employee.Single(a => a.EmpId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                            db.Employee.Remove(delete);
                            db.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("От этого зависят значения других таблиц");
                        }
                        break;
                    case "Fine":
                        try
                        {
                            var delete = db.Fine.Single(a => a.VialatorId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                            db.Fine.Remove(delete);
                            db.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("От этого зависят значения других таблиц");
                        }
                        break;
                    case "Insurance":
                        try
                        {
                            var delete = db.Insurance.Single(a => a.InsuranceSerialnumber == dataGridView1.CurrentRow.Cells[1].Value.ToString());
                            db.Insurance.Remove(delete);
                            db.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("От этого зависят значения других таблиц");
                        }
                        break;
                    case "License":
                        try
                        {
                            var delete = db.License.Single(a => a.LicenseId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                            db.License.Remove(delete);
                            db.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("От этого зависят значения других таблиц");
                        }
                        break;
                    case "TechPasport":
                        try
                        {
                            var delete = db.TechPasport.Single(a => a.TechPassId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                            db.TechPasport.Remove(delete);
                            db.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("От этого зависят значения других таблиц");
                        }
                        break;
                }
            }
                
        }//удаление
    }
}
