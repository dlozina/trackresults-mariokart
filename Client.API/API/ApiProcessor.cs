using Client.API.Data.Standings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.API.API
{
    public class ApiProcessor
    {
        // Za static nije potrebna instanca !!!
        public static async Task<T> LoadApiCall<T>(string url)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    T apiResponse = await response.Content.ReadAsAsync<T>();
                    return apiResponse;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
