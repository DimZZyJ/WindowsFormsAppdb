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
    }
}
