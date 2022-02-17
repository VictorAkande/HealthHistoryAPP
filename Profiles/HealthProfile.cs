using AutoMapper;
using HealthHistory.DTOs;
using HealthHistory.Model;

namespace HealthHistory.Profiles
{
    public class HealthProfile : Profile
    {
        public HealthProfile()
        {
            CreateMap<HealtRecordForCreationDTo, HealthRecord > ().ReverseMap();
        }
    }
}
