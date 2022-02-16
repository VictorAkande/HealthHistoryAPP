using HealthHistory.Model;
using HealthHistory.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System;
using AutoMapper;
using HealthHistory.Context;
using HealthHistory.DTOs;

namespace HealthHistory.Controllers
{
    [ApiController]
    [Route("api/patients")]
    public class PatientController :ControllerBase
    {
        private readonly IPatientRepositories patientRepositories;
        private readonly IMapper mapper;


        public PatientController(IPatientRepositories patientRepositories, IMapper mapper)
        {
            this.patientRepositories = patientRepositories;
            this.mapper = mapper;
           
        }
        [HttpGet]
        
        public IActionResult GetPatients()
        {
            var patients = patientRepositories.GetPatients();
            return Ok(patients);
        }

        [HttpPost]

        public ActionResult<PatientForCreationDto> CreatePatient(PatientForCreationDto patient)
        {
            var patientEntity = mapper.Map<Model.Patient>(patient);
          
           var patientToSave = mapper.Map<DTOs.PatientForCreationDto>(patientEntity);

            patientRepositories.CreatePatient(patientEntity);
            patientRepositories.Save();

            return Ok(patientToSave);

        }
    }
}
