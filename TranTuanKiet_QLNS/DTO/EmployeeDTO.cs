using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranTuanKiet_QLNS.DTO
{
   public class EmployeeDTO
    {
        public string IDME { get; set; }
        public string NAME_EM { get; set; }
        public DateTime BIRTH { get; set; }
        public int gt { get; set; }
        public string NOISINH { get; set; }
        public DepartmentDTO department { get; set; }
        public string IDDEPART
        {
            get { return department.NAME; }
        }


    }
}

