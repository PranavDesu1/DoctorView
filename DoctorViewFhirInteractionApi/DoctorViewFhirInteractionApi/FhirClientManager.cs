
using System;
using System.ComponentModel;
using Hl7.Fhir.Rest;
using Microsoft.Extensions.Configuration;

namespace DoctorViewFhirInteractionApi
{
    public class FhirClientManager : IDisposable
    {
        public static FhirClient CreateClientConnection(IConfiguration _configuration)
        {
            //The fhir server end point address      
            string ServiceRootUrl = _configuration["FhirServerUrl"];
            //Create a client to send to the server at a given endpoint.
            var FhirClient = new Hl7.Fhir.Rest.FhirClient(ServiceRootUrl);
            // increase timeouts since the server might be powered down
            FhirClient.Timeout = Convert.ToInt32(_configuration["FhirClientTimeout"]);

            return FhirClient;
        }

        public void Dispose()
        {
            
        }
    }
}
