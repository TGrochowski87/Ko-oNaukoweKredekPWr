using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomaszGrochowskiZadanieDomowe3.ViewModels;
using TomaszGrochowskiZadanieDomowe4.Models.Entities;

namespace TomaszGrochowskiZadanieDomowe3.Infrastructure
{
    public class MapperProfile : Profile
    {
        /// <summary>
        /// Class with mapper profile, containing map configurations
        /// </summary>
        public MapperProfile()
        {
            //Map for Animal data
            CreateMap<Animal, AnimalViewModel>()
                .ForMember(m => m.Type, opt => opt.MapFrom(src => src.AnimalType.Name))
                .ForMember(m => m.PopulationStatus, opt => opt.MapFrom(src => src.PopulationStatus.Name))
                .ForMember(m => m.Region, opt => opt.MapFrom(src => src.Region.Name));

            //Map for Keeper data
            CreateMap<Keeper, KeeperViewModel>()
                .ForMember(m => m.Lodge, opt => opt.MapFrom(src => src.Lodge.Id))
                .ForMember(m => m.Number, opt => opt.MapFrom(src => src.ContactNumber));

            //Map for Region data
            CreateMap<Region, RegionViewModel>()
                .ForMember(m => m.Accessibility, opt => opt.MapFrom(src => src.AccessibilityType.Name));

            //Map for Mushroom data
            CreateMap<Mushroom, MushroomViewModel>()
                .ForMember(m => m.Region, opt => opt.MapFrom(src => src.Region.Name));
        }
    }
}
