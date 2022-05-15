using AutoMapper;
using Model;
using ModelRes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonHelper
{
    public class MyProfile : Profile
    {
        public MyProfile()
        {
            CreateMap<blog, Blog>();
        }
    }
}
