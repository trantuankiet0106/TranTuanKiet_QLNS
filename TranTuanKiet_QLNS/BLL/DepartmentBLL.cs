using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranTuanKiet_QLNS.DAO;
using TranTuanKiet_QLNS.DTO;

namespace TranTuanKiet_QLNS.BLL
{
    public class DepartmentBLL
    {
        DepartmentDAO dal = new DepartmentDAO();
        public List<DepartmentDTO> ReadAreaList()
        {
            List<DepartmentDTO> lstArea = dal.ReadAreaList();
            return lstArea;
        }
    }
}
