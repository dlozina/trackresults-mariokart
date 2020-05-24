using AutoMapper;
using MarioKart.Model;
using MarioKartWeb.DataTransferObjects.Standings;
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
                cfg.CreateMap<RaceViewModel, Race>().ReverseMap();
                cfg.CreateMap<Tournament, TournamentViewModel>().ReverseMap();
                cfg.CreateMap<TournamentViewModel, Tournament>().ReverseMap();
                cfg.CreateMap<Standings, StandingsViewModel>().ReverseMap();
                cfg.CreateMap<TournamentStandings, TournamentStandingsViewModel>().ReverseMap();
                cfg.CreateMap<GrandPrix, GrandPrixViewModel>().ReverseMap();
                cfg.CreateMap<GrandPrixViewModel, GrandPrix>().ReverseMap();
                cfg.CreateMap<Driver, DriverViewModel>().ReverseMap();
                cfg.CreateMap<DriverViewModel, Driver>().ReverseMap();
                cfg.CreateMap<Announcement, AnnouncementViewModel>().ReverseMap();
                cfg.CreateMap<AnnouncementViewModel, Announcement>().ReverseMap();
            });
        }
    }
}