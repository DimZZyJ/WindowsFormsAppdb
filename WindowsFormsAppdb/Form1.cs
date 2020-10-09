using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        public void button1_Click(object sender, EventArgs e)//обновить
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

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//удаление
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
                
        }

        private void button3_Click(object sender, EventArgs e)//изменение
        {
            string n = comboBox1.Text;
            try
            {
                switch (n)
                {
                    case "":
                        MessageBox.Show("не выбрана таблица");
                        break;
                    case "Citizen":
                        EditCitizen();
                        break;
                    case "Employee":
                        EditEmployee();
                        break;
                    case "Fine":

                        break;
                    case "Insurance":
                        EditInsurance();

                        break;
                    case "License":
                        EditLicense();
                        break;
                    case "TechPasport":
                        EditTechPasport();
                        break;

                }
            }
            catch
            {
                MessageBox.Show("Невозможно изменить");
            }
            
            button1_Click(sender,e);
        }
        public void EditCitizen()//изменеие граждан
        {
            using (var db = new police_dbContext())
            {
                var edit = db.Citizen.Single(a => a.CitizenId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                edit.CitizenFio = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                db.SaveChanges();
            }
        }

        public void EditEmployee()//изменеие работников
        {
            using (var db = new police_dbContext())
            {
                var edit = db.Employee.Single(a => a.EmpId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                edit.EmpFio = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //edit.WorkDate = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                //edit.WorkStatus = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //edit.LeaveDate = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                edit.EmpPosition = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                db.SaveChanges();
            }
        }

        //public void EditFine()//изменеие штрафа
        //{
        //    using (var db = new police_dbContext())
        //    {
        //        var edit = db.Fine.Single(a => a.VialatorId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        //        edit.VialatorId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        //        edit.Ammount = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
        //        edit.VialatorId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        //        db.SaveChanges();
        //    }
        //}
        public void EditInsurance()//изменеие страховки
        {
            using (var db = new police_dbContext())
            {
                var edit = db.Insurance.Single(a => a.InsuranceSerialnumber == dataGridView1.CurrentRow.Cells[0].Value.ToString());
                edit.InsuranceFrom = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                edit.InsuranceBefore = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                db.SaveChanges();
            }
        }

        public void EditLicense()//изменеие прав
        {
            using (var db = new police_dbContext())
            {
                var edit = db.License.Single(a => a.LicenseId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                edit.FromData = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                edit.BeforeData= DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                db.SaveChanges();
            }
        }

        public void EditTechPasport()//изменеие тех паспорта
        {
            using (var db = new police_dbContext())
            {
                var edit = db.TechPasport.Single(a => a.TechPassId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                edit.Color = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                edit.CarModel = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                db.SaveChanges();
            }
        }

        private void button4_Click(object sender, EventArgs e)//создание
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            
        }
    }
}
