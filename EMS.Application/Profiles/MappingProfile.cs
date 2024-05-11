using AutoMapper;
using EMS.Application.DTO.OrgDivision;
using EMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region OrgDivision
            CreateMap<OrgDivision, CreateOrgDivisionDto>().ReverseMap();
            CreateMap<OrgDivision, UpdateOrgDivisionDto>().ReverseMap();
            #endregion


        }
    }
}
