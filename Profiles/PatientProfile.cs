using AutoMapper;

namespace HealthHistory.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Model.Patient, DTOs.PatientForCreationDto>().ReverseMap();
        }
    }
}
