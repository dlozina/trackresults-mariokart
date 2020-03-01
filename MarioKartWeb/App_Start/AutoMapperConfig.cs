using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MarioKartWeb.Helper;
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
                cfg.CreateMap<Standings, StandingsViewModel>().ReverseMap();
                cfg.CreateMap<TournamentStandings, TournamentStandingsViewModel>().ReverseMap();
            });
        }
    }
}