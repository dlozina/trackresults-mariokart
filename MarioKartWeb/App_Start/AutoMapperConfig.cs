using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MarioKartWeb.Models;
using MarioKartWeb.ViewModel;

namespace MarioKartWeb.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Race, RaceViewModel>().ReverseMap();
            });
        }
    }
}