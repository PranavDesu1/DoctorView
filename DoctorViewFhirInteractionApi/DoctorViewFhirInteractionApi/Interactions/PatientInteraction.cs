namespace DoctorViewFhirInteractionApi.Interactions
{
    using System;
    using System.Collections.Generic;
    using DoctorViewFhirInteractionApi.Models;
    using Microsoft.Extensions.Configuration;

    public class PatientInteraction
    {

        private IConfiguration Configuration;

        public PatientInteraction(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public List<Patient> SearchPatients(string searchString)
        {
            var patientResults = new List<Patient>();


            Hl7.Fhir.Rest.FhirClient fhirClient = FhirClientManager.CreateClientConnection(Configuration);

            fhirClient = FhirClientManager.CreateClientConnection(Configuration);

            Hl7.Fhir.Model.Bundle ReturnedSearchBundle =
            fhirClient.Search<Hl7.Fhir.Model.Patient>(new string[] { $"name={searchString}" });

            foreach (var resource in ReturnedSearchBundle.Entry)
            {
                patientResults.Add((Patient)resource.Resource);
            }

            return patientResults;
        }
    }
}
