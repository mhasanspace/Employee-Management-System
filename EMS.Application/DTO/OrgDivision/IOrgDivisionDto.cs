﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.DTO.OrgDivision
{
    public interface IOrgDivisionDto
    {
        public string Name { get; set; }
        public int? Status { get; set; }
    }
}
