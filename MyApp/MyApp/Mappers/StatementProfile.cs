using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyApp.Models;
using MyApp.DataModels;

namespace MyApp.Mappers
{
    public class StatementProfile : Profile
    {
        public StatementProfile()
        {
            CreateMap<StatementModel, Statement>();
            CreateMap<Statement, StatementModel>();

        }
    }
}
