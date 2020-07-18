namespace DoctorViewFhirInteractionApi.Controllers
{
    using System.Collections.Generic;
    using System.Net;
    using DoctorViewFhirInteractionApi.Interactions;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

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
        [ProducesResponseType(typeof(Patient),(int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(void),(int)HttpStatusCode.Forbidden)]
        public IActionResult GetPatients(string searchString)
        {
            //https://localhost:44351/api/Patient/search?searchString=test
            var patientInteraction = new PatientInteraction(Configuration);
            return Ok(patientInteraction.SearchPatients(searchString));
        }
    }
}
