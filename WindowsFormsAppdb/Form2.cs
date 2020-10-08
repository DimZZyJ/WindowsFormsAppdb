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
    public partial class Form2 : Form
    {
        //МЕТОДЫ
        public void CreateCitizen()
        {
            var CitizenIdcl = new DataGridViewTextBoxColumn();
            var CitizenFiocl = new DataGridViewTextBoxColumn();
            CitizenIdcl.HeaderText = "CitizenId";
            CitizenFiocl.HeaderText = "CitizenFio";
            dataGridView1.Columns.Add(CitizenIdcl);
            dataGridView1.Columns.Add(CitizenFiocl);
            
        }

        public void CreateEmployee()
        {
            var emp_id = new DataGridViewTextBoxColumn();
            emp_id.HeaderText = "emp_id";
            var emp_fio= new DataGridViewTextBoxColumn();
            emp_fio.HeaderText = "emp_fio";
            var work_date = new DataGridViewTextBoxColumn();
            work_date.HeaderText = "work_date";
            var work_status = new DataGridViewTextBoxColumn();
            work_status.HeaderText = "work_status";
            var leave_date = new DataGridViewTextBoxColumn();
            leave_date.HeaderText = "leave_date";
            var position = new DataGridViewTextBoxColumn();
            position.HeaderText = "position";
            dataGridView1.Columns.Add(emp_id);
            dataGridView1.Columns.Add(emp_fio);
            dataGridView1.Columns.Add(work_date);
            dataGridView1.Columns.Add(work_status);
            dataGridView1.Columns.Add(leave_date);
            dataGridView1.Columns.Add(position);
        }

        public void CreateFine()
        {
            var v_id = new DataGridViewTextBoxColumn();
            v_id.HeaderText = "vialator_id";
            var amount = new DataGridViewTextBoxColumn();
            amount.HeaderText = "amount";
            var vtpid = new DataGridViewTextBoxColumn();
            vtpid.HeaderText = "vialator_tech_pasport_id";
            var koap12 = new DataGridViewTextBoxColumn();
            koap12.HeaderText = "koap12";
            var vialationdate = new DataGridViewTextBoxColumn();
            vialationdate.HeaderText = "vialation_date";
            var vp = new DataGridViewTextBoxColumn();
            vp.HeaderText = "vialation_place";
            dataGridView1.Columns.Add(v_id);
            dataGridView1.Columns.Add(amount);
            dataGridView1.Columns.Add(vtpid);
            dataGridView1.Columns.Add(koap12);
            dataGridView1.Columns.Add(vialationdate);
            dataGridView1.Columns.Add(vp);
        }

        public void CreateInsurance()
        {

            var itp_id = new DataGridViewTextBoxColumn();
            itp_id.HeaderText = "insurance_tech_pasport_id";
            var isn = new DataGridViewTextBoxColumn();
            isn.HeaderText = "insurance_serial_number";
            var ifrom  = new DataGridViewTextBoxColumn();
            ifrom.HeaderText = "insurance_from";
            var ibefore = new DataGridViewTextBoxColumn();
            ibefore.HeaderText = "insurance_before";
            var icid = new DataGridViewTextBoxColumn();
            icid.HeaderText = "insurance_civilian_id";
            dataGridView1.Columns.Add(itp_id);
            dataGridView1.Columns.Add(isn);
            dataGridView1.Columns.Add(ifrom);
            dataGridView1.Columns.Add(ibefore);
            dataGridView1.Columns.Add(icid);
        }

        public void CreateLicense()
        {
            var l_id = new DataGridViewTextBoxColumn();
            l_id.HeaderText = "License_id";
            var ownerid = new DataGridViewTextBoxColumn();
            ownerid.HeaderText = "owner_id";
            var lfrom = new DataGridViewTextBoxColumn();
            lfrom.HeaderText = "from_data";
            var lbefore = new DataGridViewTextBoxColumn();
            lbefore.HeaderText = "before_data";
            dataGridView1.Columns.Add(l_id);
            dataGridView1.Columns.Add(ownerid);
            dataGridView1.Columns.Add(lfrom);
            dataGridView1.Columns.Add(lbefore);
        }

        public void CreateTechPasport()
        {
            var itp_id = new DataGridViewTextBoxColumn();
            itp_id.HeaderText = "tech_pass_id";
            var isn = new DataGridViewTextBoxColumn();
            isn.HeaderText = "civ_tech_passport_id";
            var ifrom = new DataGridViewTextBoxColumn();
            ifrom.HeaderText = "color";
            var ibefore = new DataGridViewTextBoxColumn();
            ibefore.HeaderText = "car_model";
            var icid = new DataGridViewTextBoxColumn();
            icid.HeaderText = "vin";
            dataGridView1.Columns.Add(itp_id);
            dataGridView1.Columns.Add(isn);
            dataGridView1.Columns.Add(ifrom);
            dataGridView1.Columns.Add(ibefore);
            dataGridView1.Columns.Add(icid);
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            string n = comboBox1.Text;
            switch (n)
            {
                case "":
                    MessageBox.Show("не выбрана таблица");
                    break;
                case "Citizen":
                    CreateCitizen();
                    break;
                case "Employee":
                    CreateEmployee();
                    break;
                case "Fine":
                    CreateFine();
                    break;
                case "Insurance":
                    CreateInsurance();
                    break;
                case "License":
                    CreateLicense();
                    break;
                case "TechPasport":
                    CreateTechPasport();
                    break;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (var db = new police_dbContext())
            {
                
            }

        }

        private void button1_Click(object sender, EventArgs e)//подтверждение
        {
            using (var db = new police_dbContext())
            {
                string n = comboBox1.Text;
                switch (n)
                {
                    case "":
                        MessageBox.Show("не выбрана таблица");
                        break;
                    case "Citizen":
                        int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        string fio = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        db.Citizen.Add(new Citizen { CitizenId = id, CitizenFio = fio });
                        db.SaveChanges();
                        break;
                    case "Employee":
                        int empid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        string empfio=dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        string workdate = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        string workstatus = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        //string leavedate = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        int empposition = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                        db.Employee.Add(new Employee {EmpId=empid,EmpFio=empfio,WorkDate=DateTime.Parse(workdate),WorkStatus=workstatus,LeaveDate=null,EmpPosition=empposition });
                        db.SaveChanges();
                        break;
                    case "Fine":
                        
                        int vid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        int amount = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                        int vtpid = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                        int koap = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        string vdate = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        string vplace = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                        db.Fine.Add(new Fine {VialatorId=vid,Ammount=amount,VialatorTechPasportId=vtpid,Koap12=koap,VialationDate=DateTime.Parse(vdate),VialationPlace=vplace });
                        db.SaveChanges();
                        break;
                    case "Insurance":
                        int itpid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        string isn = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        string ifrom = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        string ibefore = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        int icid = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        db.Insurance.Add(new Insurance { InsuranceTechPasportId=itpid,InsuranceSerialnumber=isn,InsuranceFrom=DateTime.Parse(ifrom),InsuranceBefore=DateTime.Parse(ibefore),InsuranceCivilianId=icid});
                        db.SaveChanges();
                        break;
                    case "License":
                        int lid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        int oid = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                        string fdata = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        string bdata = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        db.License.Add(new Models.License { LicenseId = lid, OwnerId = oid, FromData = DateTime.Parse(fdata), BeforeData = DateTime.Parse(bdata) });
                        db.SaveChanges();
                        break;
                    case "TechPasport":
                        int tpid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        int ctpid = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                        string color = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        string model = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        string vin = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        db.TechPasport.Add(new TechPasport {TechPassId=tpid,CivTechPassportId=ctpid,Color=color,CarModel=model,Vin=vin });
                        db.SaveChanges();
                        break;

                }
            }
            
            Form2 form2 = new Form2();
            form2.Close();
        }
    }
}
