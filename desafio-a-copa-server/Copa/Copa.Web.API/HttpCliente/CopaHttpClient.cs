using Microsoft.AspNetCore.Authentication;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Copa.Web.API.HttpCliente
{
    public class CopaHttpClient<T>
    {
        public async Task<T> Get(string urlRequest, string urlBase = "https://raw.githubusercontent.com/")
        {
            var client = new RestClient(urlBase);
            var request = new RestRequest(urlRequest, DataFormat.Json);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var resultado = await client.GetAsync<T>(request);
            return resultado;
        }
    }
}
