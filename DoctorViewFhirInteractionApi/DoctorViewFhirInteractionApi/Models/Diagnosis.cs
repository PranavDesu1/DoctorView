namespace DoctorViewFhirInteractionApi.Models
{
    using System;
    using System.Linq;
    using Newtonsoft.Json;

    public class Diagnosis
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "action")]
        public string Value { get; set; }

        public static explicit operator Diagnosis(Hl7.Fhir.Model.Observation obj)
        {
            Diagnosis output = new Diagnosis()
            {
                Code = obj.Code?.Coding.FirstOrDefault()?.Code,
                Description = obj.Code?.Coding.FirstOrDefault()?.Display,
                Value = Convert.ToString(((Hl7.Fhir.Model.Quantity)obj.Value)?.Value)
            };
            return output;
        }
    }
}
