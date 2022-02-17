using AutoMapper;
using HealthHistory.DTOs;
using HealthHistory.Model;
using HealthHistory.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HealthHistory.Controllers
{
    [ApiController]
    [Route("api/history")]
    public class HealthHistoryController : ControllerBase
    {
        private readonly IHealthRecordRepositories healthRecordRepositories;
        private readonly IMapper mapper;

        public HealthHistoryController(IHealthRecordRepositories healthRecordRepositories,IMapper mapper)
        {
            this.healthRecordRepositories = healthRecordRepositories;
            this.mapper = mapper;
        }

        [HttpGet]

        public IActionResult GetRecord()
        {
            var record =  healthRecordRepositories.GetHealthRecords();
            return Ok(record);
        }

        [HttpPost()]
        public ActionResult<HealtRecordForCreationDTo>AddHealthHistory(Guid patientId, HealtRecordForCreationDTo healthRecord)
        {
            var HealthEntity = mapper.Map<HealthRecord>(healthRecord); 
            healthRecordRepositories.CreateRecord(patientId,HealthEntity);
            //healthRecordRepositories.Save();
            return Ok(HealthEntity);
        }

        [HttpGet("{PatientId}")]

        public IActionResult GetRecord(Guid PatientId)
        {
            var record = healthRecordRepositories.GetRecord(PatientId);
            return Ok(record);
        }


    }

    
}
