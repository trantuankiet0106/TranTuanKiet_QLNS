﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranTuanKiet_QLNS.DTO
{
   public class DepartmentDTO
    { 
        public string ID { get; set; }
        public string NAME { get; set; }
        public List<EmployeeDTO> departments { get; set; }
    }
}
