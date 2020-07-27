using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorViewFhirInteractionApi.Models;
using Microsoft.Extensions.Configuration;

namespace DoctorViewFhirInteractionApi.Interactions
{
    public class PrescriptionInteraction
    {
        private IConfiguration Configuration;

        public PrescriptionInteraction(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public List<Prescription> FindMedication(string patientId)
        {
            var prescriptionResults = new List<Prescription>();


            Hl7.Fhir.Rest.FhirClient fhirClient = FhirClientManager.CreateClientConnection(Configuration);

            fhirClient = FhirClientManager.CreateClientConnection(Configuration);

            Hl7.Fhir.Model.Bundle ReturnedSearchBundle =
            fhirClient.Search<Hl7.Fhir.Model.MedicationRequest>(new string[] { $"patient={patientId}" });

            foreach (var resource in ReturnedSearchBundle.Entry)
            {
                var prescription = (Prescription)resource.Resource;
                prescriptionResults.Add(prescription);
            }

            return prescriptionResults;
        }
    }
}
