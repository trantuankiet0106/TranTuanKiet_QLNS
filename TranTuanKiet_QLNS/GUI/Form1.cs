using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranTuanKiet_QLNS.BLL;
using TranTuanKiet_QLNS.DAO;
using TranTuanKiet_QLNS.DTO;

namespace TranTuanKiet_QLNS.GUI
{
    public partial class Form1 : Form
    {
        EmployeeBLL cusBAL = new EmployeeBLL();
        DepartmentBLL areaBAL = new DepartmentBLL();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<EmployeeDTO> lstCus = cusBAL.ReadCusTomer();
            foreach (EmployeeDTO cus in lstCus)
            {
                dataGridView1.Rows.Add(cus.IDME, cus.NAME_EM, cus.BIRTH.Date.ToString(), cus.GT, cus.NOISINH, cus.IDDEPART);
            }
            List<DepartmentDTO> lstArea = areaBAL.ReadAreaList();
            foreach (DepartmentDTO areas in lstArea)
            {
                CBNAME.Items.Add(areas);
                CBNAME.DisplayMember = "NAME";

            }
        }
        private void ROW(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;


            if (idx >= 0)
            {
                TBID.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
                TBNAME.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
                DTNGAYSINH.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
                if (dataGridView1.Rows[idx].Cells[3].Value.ToString().Length < 3)
                {
                    CHECK.Checked =false ;
                }
                else
                {
                    CHECK.Checked = true;
                }
                //TBGT.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
                TBNS.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
                CBNAME.Text = dataGridView1.Rows[idx].Cells[5].Value.ToString();

            }
        }

        private void THEM_Click(object sender, EventArgs e)

        {
            if ((TBID.Text == "") || (TBNAME.Text == "") || TBNS.Text == "")
            {
                MessageBox.Show("Hãy Điền đủ thông tin !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
               EmployeeDTO cus = new EmployeeDTO();
                cus.IDME = TBID.Text;
                cus.NAME_EM = TBNAME.Text;
                cus.BIRTH = DTNGAYSINH.Value;
                if (CHECK.Checked)
                {
                    cus.GT = "NAM";
                }
                else
                {
                    cus.GT = "NU";
                }
                //cus.GT = TBGT.Text;
                cus.NOISINH = TBNS.Text;
                cus.KV = (DepartmentDTO)CBNAME.SelectedItem;
                cusBAL.NewCustomer(cus);
                dataGridView1.Rows.Add(cus.IDME, cus.NAME_EM, cus.BIRTH, cus.GT, cus.NOISINH, cus.KV.NAME);
            }
        }

    
        private void XOA_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa thành viên này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
               
              
                EmployeeDTO cus = new EmployeeDTO();
                cus.IDME = TBID.Text;
                cusBAL.DeleteCustomer(cus);

                DataGridViewRow row = dataGridView1.CurrentRow;
                int idx = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(idx);


            }
        }

        private void SUA_Click(object sender, EventArgs e)
        {

           
            DataGridViewRow row = dataGridView1.CurrentRow;
            EmployeeDTO cus = new EmployeeDTO();
            cus.IDME = TBID.Text;
            cus.NAME_EM = TBNAME.Text;
            cus.BIRTH = DTNGAYSINH.Value;
            cus.GT = TBGT.Text;
            cus.NOISINH = TBNS.Text;
            cus.KV = (DepartmentDTO)CBNAME.SelectedItem;
            cusBAL.EditCustomer(cus);

            row.Cells[0].Value = cus.IDME;
            row.Cells[1].Value = cus.NAME_EM;
            row.Cells[2].Value = cus.BIRTH;
            row.Cells[3].Value = cus.GT;
            row.Cells[4].Value = cus.NOISINH;
            row.Cells[5].Value = cus.IDDEPART;

        }
        private void THOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
