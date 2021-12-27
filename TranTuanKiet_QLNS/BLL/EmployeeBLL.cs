using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranTuanKiet_QLNS.DAO;
using TranTuanKiet_QLNS.DTO;

namespace TranTuanKiet_QLNS.BLL
{
   public class EmployeeBLL
    {
        EmployeeDAO dal = new EmployeeDAO();
        public List<EmployeeDTO> ReadCusTomer()
        {
            List<EmployeeDTO> lstCus = dal.ReadEmployee();
            return lstCus;
        }
        public void NewCustomer(EmployeeDTO cus)
        {
            dal.NewEmployee(cus);
        }
        public void DeleteCustomer(EmployeeDTO cus)
        {
            dal.DeleteEmployee(cus);
        }
        public void EditCustomer(EmployeeDTO cus)
        {
            dal.EditEmployee(cus);
        }
    }
}
