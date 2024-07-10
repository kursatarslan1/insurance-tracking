using insurance_tracking.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace insurance_tracking.Services
{
    public class InsuranceServices
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;
        public InsuranceServices(HttpClient httpClient, string apiUrl)
        {
            _httpClient = httpClient;
            _apiUrl = apiUrl + "/insurances";
        }

        public async Task<bool> AddInsurance(Insure insure)
        {
            try
            {
                // Müşteri nesnesini bir nesne içine sarmalayarak serileştiriyoruz
                var insuranceWrapper = new { insure };

                var settings = new JsonSerializerSettings
                {
                    DateFormatString = "yyyy-MM-ddTHH:mm:ss.fffZ"
                };

                var json = JsonConvert.SerializeObject(insuranceWrapper, settings);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync($"{_apiUrl}/create", content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Failed to add insurance. Status Code: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddInsurance method: {ex.Message}");
                return false;
            }
        }

        public async Task<List<Insure>> GetInsureListByCustomerId(int customer_id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_apiUrl}/insurances/{customer_id}");

                if (response.IsSuccessStatusCode)
                {

                    var responseContent = await response.Content.ReadAsStringAsync();
                    var responseData = JsonConvert.DeserializeObject<dynamic>(responseContent);
                    var insuresJson = responseData.insureList.ToString();
                    var insures = JsonConvert.DeserializeObject<List<Insure>>(insuresJson);


                    return insures;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetInsureListByCustomerId method: {ex.Message}");
                return null;
            }
        }

        public async Task<List<Insure>> GetInsureList()
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_apiUrl}/insures");

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var responseData = JsonConvert.DeserializeObject<dynamic>(responseContent);
                    var insuresJson = responseData.insureList.ToString();
                    var insures = JsonConvert.DeserializeObject<List<Insure>>(insuresJson);

                    return insures;
                }
                return null;
            } catch (Exception ex)
            {
                Console.WriteLine($"Error in GetInsureList method: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> CancelInsurance(int insurance_id)
        {
            try
            {
                var response = await _httpClient.PutAsync($"{_apiUrl}/insurance/{insurance_id}", null);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Failed to cancel insurance. Status Code: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CancelInsurance method: {ex.Message}");
                return false;
            }
        }
    }
}
