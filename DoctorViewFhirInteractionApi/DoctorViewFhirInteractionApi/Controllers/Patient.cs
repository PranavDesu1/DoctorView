namespace DoctorViewFhirInteractionApi.Controllers
{
    using System.Net;
    using DoctorViewFhirInteractionApi.Interactions;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class Patient : ControllerBase
    {
        private IConfiguration Configuration;

        public Patient(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        [HttpGet]
        [Route("search")]
        [ProducesResponseType(typeof(Models.Patient),(int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(void),(int)HttpStatusCode.Forbidden)]
        public IActionResult GetPatients(string searchString)
        {
            //https://localhost:44351/api/Patient/search?searchString=test
            var patientInteraction = new PatientInteraction(Configuration);
            var a = patientInteraction.SearchPatients(searchString);
            return Ok(a);
        }
    }
}
