namespace DoctorViewFhirInteractionApi.Interactions
{
    using System.Collections.Generic;
    using Microsoft.Extensions.Configuration;
    using DoctorViewFhirInteractionApi.Models;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Hl7.Fhir.Model;

    public class DiagnosisInteraction
    {
        private IConfiguration Configuration;

        public DiagnosisInteraction(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public List<Diagnosis> FindDiagnosis(string patientId)
        {
            var diagnosticResults = new List<Diagnosis>();


            Hl7.Fhir.Rest.FhirClient fhirClient = FhirClientManager.CreateClientConnection(Configuration);

            fhirClient = FhirClientManager.CreateClientConnection(Configuration);

            Hl7.Fhir.Model.Bundle ReturnedSearchBundle =
            fhirClient.Search<Hl7.Fhir.Model.DiagnosticReport>(new string[] { $"patient={patientId}" });

            foreach (var resource in ReturnedSearchBundle.Entry) {             
                var diagnosticReport = (DiagnosticReport)resource.Resource;
                foreach (var item in diagnosticReport.Contained)
                {
                    diagnosticResults.Add((Diagnosis)item);
                }
            }

            return diagnosticResults;
        }
    }
}
