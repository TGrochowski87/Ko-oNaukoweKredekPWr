using AutoMapper;
using CPC2020_2_Lab4.Models.Entities;
using CPC2020_2_Lab4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPC2020_2_Lab4.Infrastructure
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Book, BookSimpleViewModel>();

            CreateMap<Book, BookViewModel>()
                .ForMember(b => b.AuthorFirstName, opt => opt.MapFrom(src => src.Author.FirstName))
                .ForMember(b => b.AuthorLastName, opt => opt.MapFrom(src => src.Author.LastName))
                .ForMember(b => b.Genre, opt => opt.MapFrom(src => src.Genre.Name));
        }
    }
}
