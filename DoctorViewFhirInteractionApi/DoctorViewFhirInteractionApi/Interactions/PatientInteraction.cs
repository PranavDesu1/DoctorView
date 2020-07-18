namespace DoctorViewFhirInteractionApi.Interactions
{
    using System.Collections.Generic;
    using DoctorViewFhirInteractionApi.Models;
    using Microsoft.Extensions.Configuration;

    public class PatientInteraction {
        
        private IConfiguration Configuration;

        public PatientInteraction(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public List<Patient> SearchPatients(string searchString) 
        {
            var patientResults = new List<Patient>();

            //The fhir server end point address      
            string ServiceRootUrl = Configuration["FhirServerUrl"];
            //Create a client to send to the server at a given endpoint.
            var FhirClient = new Hl7.Fhir.Rest.FhirClient(ServiceRootUrl);
            // increase timeouts since the server might be powered down
            FhirClient.Timeout = (60 * 1000);

            Hl7.Fhir.Model.Bundle ReturnedSearchBundle =
                FhirClient.Search<Hl7.Fhir.Model.Patient>(new string[] { $"name={searchString}" });

            return patientResults;
        }
    }
}
