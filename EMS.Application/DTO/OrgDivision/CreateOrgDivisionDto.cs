using EMS.Application.DTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.DTO.OrgDivision
{
    public class CreateOrgDivisionDto : BaseDto, IOrgDivisionDto
    {
        public string Name { get; set; }
        public int? Status { get; set; }
    }
}
