﻿using AutoMapper;
using QTMvc5Shop.Model.Models;
using QTMvc5Shop.Web.Models;

namespace QTMvc5Shop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}