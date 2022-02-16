using HealthHistory.Model;
using HealthHistory.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System;

namespace HealthHistory.Controllers
{
    [ApiController]
    [Route("api/patients")]
    public class PatientController :ControllerBase
    {
        private readonly IPatientRepositories patientRepositories;

        public PatientController(IPatientRepositories patientRepositories)
        {
            this.patientRepositories = patientRepositories;
        }
        [HttpGet]
        
        public IActionResult GetPatients()
        {
            var patients = patientRepositories.GetPatients();
            return Ok(patients);
        }
    }
}
