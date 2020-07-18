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
    }
}
