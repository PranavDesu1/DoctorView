using System;
using System.Linq;
using Newtonsoft.Json;

namespace DoctorViewFhirInteractionApi.Models
{
    public class Prescription
    {
        [JsonProperty(PropertyName = "medicine")]
        public string Medicine { get; set; }

        [JsonProperty(PropertyName = "dose")]
        public string Dose { get; set; }

        [JsonProperty(PropertyName = "frequency")]
        public string Frequency { get; set; }

        [JsonProperty(PropertyName = "strength")]
        public string Strength { get; set; }

        [JsonProperty(PropertyName = "startdate")]
        public string StartDate { get; set; }

        [JsonProperty(PropertyName = "enddate")]
        public string EndDate { get; set; }

        public static explicit operator Prescription(Hl7.Fhir.Model.MedicationRequest obj)
        {
            var dose = (Hl7.Fhir.Model.Quantity)obj.DosageInstruction.FirstOrDefault()?.Dose;

            Prescription output = new Prescription()
            {
                Medicine = ((Hl7.Fhir.Model.Medication)obj.Contained.FirstOrDefault())?.Code?.Coding.FirstOrDefault()?.Display,
                Dose = $"{dose?.Value}" + $"{dose?.Unit}",
                Frequency = $"{obj.DosageInstruction.FirstOrDefault()?.MaxDosePerAdministration?.Value}" +
                            $"{obj.DosageInstruction.FirstOrDefault()?.MaxDosePerAdministration?.Unit}",
                Strength = $"{dose?.Value}" + $"{dose?.Unit}",
                StartDate = $"{obj.AuthoredOn}",
                EndDate = ""
            };
            return output;
        }
    }
}
