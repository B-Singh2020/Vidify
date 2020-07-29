using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidify.Models;
using Vidify.Dtos;

namespace Vidify.App_Start
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}