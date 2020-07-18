namespace DoctorViewFhirInteractionApi.Models
{
    using System.Linq;
    using Newtonsoft.Json;

    public class Patient
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "fname")]
        public string FName { get; set; }

        [JsonProperty(PropertyName = "lname")]
        public string LName { get; set; }

        public static explicit operator Patient(Hl7.Fhir.Model.Patient obj)
        {
            Patient output = new Patient() {
                Id = obj.Id,
                FName = string.IsNullOrEmpty(obj.Name.FirstOrDefault()?.Given.FirstOrDefault()) ? "" : obj.Name.FirstOrDefault()?.Given.FirstOrDefault(),
                LName = string.IsNullOrEmpty(obj.Name.FirstOrDefault()?.Family) ? "" : obj.Name.FirstOrDefault()?.Family
            };
            return output;
        }
    }
}
