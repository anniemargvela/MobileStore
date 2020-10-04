using AutoMapper;
using MS.Domain.Entities;
using MS.Infrastructure.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS.Infrastructure.ObjectMapping
{
    public class MSProfile : Profile
    {
        public MSProfile()
        {
            CreateMap<MobileVideoModel, MobileVideo>();
            CreateMap<MobilePhotoModel, MobilePhoto>();
            CreateMap<MobileModel, Mobile>().ForMember(
                d => d.Video,
                op => op.MapFrom(s => s.Videos.FirstOrDefault())
                );
        }
    }
}
