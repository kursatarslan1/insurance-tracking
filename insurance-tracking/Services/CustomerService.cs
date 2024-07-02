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
    public class CustomerService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;
        public CustomerService(HttpClient httpClient, string apiUrl)
        {
            _httpClient = httpClient;
            _apiUrl = apiUrl + "/customers";
        }

        public async Task<List<Customer>> Customers()
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_apiUrl}/customers");

                if (response.IsSuccessStatusCode)
                {

                    var responseContent = await response.Content.ReadAsStringAsync();
                    var responseData = JsonConvert.DeserializeObject<dynamic>(responseContent);
                    var customersJson = responseData.customers.ToString();
                    var customers = JsonConvert.DeserializeObject<List<Customer>>(customersJson);


                    return customers;
                }
                return null;
            } catch(Exception ex)
            {
                Console.WriteLine($"Error in GetCustomers method: {ex.Message}");
                return null;
            }
        } 

    }
}
