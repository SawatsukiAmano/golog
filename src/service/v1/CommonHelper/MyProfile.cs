namespace CommonHelper
{
    /// <summary>
    /// AutoMapper 配置
    /// </summary>
    public class MyProfile : Profile
    {
        public MyProfile()
        {
            #region User

            #endregion

            #region Blog
            //CreateMap<add_blog, Blog>()
            //    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.user_name))
            //    .ForMember(dest => dest.BlogName, opt => opt.MapFrom(src => src.blog_name))
            //    .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.category))
            //    .ForMember(dest => dest.CreateTime, opt => opt.MapFrom(src => src.create_time))
            //    .ForMember(dest => dest.LatestTime, opt => opt.MapFrom(src => src.lagtest_time))
            //    .ForMember(dest => dest.CurrEditTxt, opt => opt.MapFrom(src => src.curr_edit_txt))
            //    .ForMember(dest => dest.ViewTxt, opt => opt.MapFrom(src => src.view_txt));
            //CreateMap<edit_blog, Blog>()
            //    .ForMember(dest => dest.BlogId, opt => opt.MapFrom(src => src.blog_id))
            //    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.user_name))
            //    .ForMember(dest => dest.BlogName, opt => opt.MapFrom(src => src.blog_name))
            //    .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.category))
            //    .ForMember(dest => dest.CreateTime, opt => opt.MapFrom(src => src.create_time))
            //    .ForMember(dest => dest.LatestTime, opt => opt.MapFrom(src => src.lagtest_time))
            //    .ForMember(dest => dest.CurrEditTxt, opt => opt.MapFrom(src => src.curr_edit_txt))
            //    .ForMember(dest => dest.ViewTxt, opt => opt.MapFrom(src => src.view_txt));
            CreateMap<query_blog, Blog>()
                .ForMember(dest => dest.BlogId, opt => opt.MapFrom(src => src.blog_id))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.user_name ?? ""))
                .ForMember(dest => dest.BlogName, opt => opt.MapFrom(src => src.blog_name ?? ""))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.category ?? ""))
                .ForMember(dest => dest.CreateTime, opt => opt.MapFrom(src => src.create_time ?? DateTime.Now))
                .ForMember(dest => dest.LatestTime, opt => opt.MapFrom(src => src.latest_time ?? DateTime.Now))
                .ForMember(dest => dest.CurrEditTxt, opt => opt.MapFrom(src => src.curr_edit_txt ?? ""))
                .ForMember(dest => dest.ViewTxt, opt => opt.MapFrom(src => src.view_txt ?? "")).ReverseMap();
            #endregion
        }
    }
}
