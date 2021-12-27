using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranTuanKiet_QLNS.BLL;
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
                dataGridView1.Rows.Add(cus.IDME, cus.NAME_EM, cus.BIRTH,cus.gt,cus.NOISINH/*,cus.AreaName*/);
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
                TBNS.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
      
            }
        }
    }
}
