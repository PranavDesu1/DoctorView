namespace DoctorViewFhirInteractionApi.Controllers
{
    using System.Net;
    using DoctorViewFhirInteractionApi.Interactions;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    [Route("api/[controller]")]
    [ApiController]
    public class Diagnosis : ControllerBase
    {
        private IConfiguration Configuration;

        public Diagnosis(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        [HttpGet]
        [Route("findbypatientid")]
        [ProducesResponseType(typeof(Patient), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.Forbidden)]
        public IActionResult FindDiagnosisByPatientId(string patientId)
        {
            //https://localhost:44351/api/Diagnosis/findbypatientid?patientId=2723122
            var diagnosisInteraction = new DiagnosisInteraction(Configuration);
            return Ok(diagnosisInteraction.FindDiagnosis(patientId));
        }
    }
}
