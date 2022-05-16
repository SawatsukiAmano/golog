﻿using AutoMapper;
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
            CreateMap<blog, Blog>()
                .ForMember(dest => dest.BlogId, opt => opt.MapFrom(src => src.blog_id))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.user_name))
                .ForMember(dest => dest.BlogName, opt => opt.MapFrom(src => src.blog_name))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.category))
                .ForMember(dest => dest.CreateTime, opt => opt.MapFrom(src => src.create_time))
                .ForMember(dest => dest.LatestTime, opt => opt.MapFrom(src => src.lagtest_time))
                .ForMember(dest => dest.CurrEditTxt, opt => opt.MapFrom(src => src.curr_edit_txt))
                .ForMember(dest => dest.ViewTxt, opt => opt.MapFrom(src => src.view_txt)).ReverseMap();


        }
    }
}
