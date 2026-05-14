// using AutoMapper;
// using Portal.Domain.AppModels;
// using Portal.Models.DBModels;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using static System.Runtime.InteropServices.JavaScript.JSType;

// namespace Portal.Common.Mapper
// {
//     public class Mapper : Profile
//     {
//         public Mapper()
//         {
//             CreateMap<UserDBModel, UserAppModel>()
//                 .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DOB))
//                 .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

//             CreateMap<UserAppModel, UserDBModel>()
//                 .ForMember(dest=>dest.DOB,opt=>opt.MapFrom(src=>src.DateOfBirth))
//                 .ForMember(dest=>dest.Name,opt=>opt.MapFrom(src=>src.Name));



//         }
//     }
// }
