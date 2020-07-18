namespace DoctorViewFhirInteractionApi.Controllers
{
    using System.Net;
    using DoctorViewFhirInteractionApi.Interactions;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    [Route("api/[controller]")]
    [ApiController]
    public class Prescription : ControllerBase
    {
        private IConfiguration Configuration;

        public Prescription(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        [HttpGet]
        [Route("findbypatientid")]
        [ProducesResponseType(typeof(Models.Prescription), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.Forbidden)]
        public IActionResult FindDiagnosisByPatientId(string patientId)
        {
            //https://localhost:44351/api/Prescription/findbypatientid?patientId=2716902
            var prescriptionInteraction = new PrescriptionInteraction(Configuration);
            return Ok(prescriptionInteraction.FindMedication(patientId));
        }
    }
}
