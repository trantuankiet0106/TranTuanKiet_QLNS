﻿using System;
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
        public string GT { get; set; }
        public string NOISINH { get; set; }
        public DepartmentDTO KV { get;  set; }
        public string IDDEPART
        {
            get { return KV.NAME; }
        }

    }
}

