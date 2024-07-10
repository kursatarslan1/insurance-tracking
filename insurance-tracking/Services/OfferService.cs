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
    public class OfferService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public OfferService(HttpClient httpClient, string apiUrl)
        {
            _httpClient = httpClient;
            _apiUrl = apiUrl + "/offers";
        }

        public async Task<bool> AddOffer(Offer offer)
        {
            try
            {
                var offerWrapper = new { offer };

                var settings = new JsonSerializerSettings
                {
                    DateFormatString = "yyyy-MM-ddTHH:mm:ss.fffZ"
                };

                var json = JsonConvert.SerializeObject(offerWrapper, settings);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync($"{_apiUrl}/create", content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Failed to add offer. Status Code: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddOffer method: {ex.Message}");
                return false;
            }
        }

        public async Task<List<Offer>> GetOfferList()
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_apiUrl}/offers");

                if (response.IsSuccessStatusCode)
                {

                    var responseContent = await response.Content.ReadAsStringAsync();
                    var responseData = JsonConvert.DeserializeObject<dynamic>(responseContent);
                    var offersJson = responseData.offerList.ToString();
                    var offers = JsonConvert.DeserializeObject<List<Offer>>(offersJson);


                    return offers;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetCustomers method: {ex.Message}");
                return null;
            }
        }
    }
}
