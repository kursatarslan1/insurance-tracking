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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetCustomers method: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> AddCustomer(Customer customer)
        {
            try
            {
                // Müşteri nesnesini bir nesne içine sarmalayarak serileştiriyoruz
                var customerWrapper = new { customer };

                var settings = new JsonSerializerSettings
                {
                    DateFormatString = "yyyy-MM-ddTHH:mm:ss.fffZ"
                };

                var json = JsonConvert.SerializeObject(customerWrapper, settings);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync($"{_apiUrl}/create", content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Failed to add customer. Status Code: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddCustomer method: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            try
            {
                var customerWrapper = new { customer };

                var settings = new JsonSerializerSettings
                {
                    DateFormatString = "yyyy-MM-ddTHH:mm:ss.fffZ"
                };

                var json = JsonConvert.SerializeObject(customerWrapper, settings);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"{_apiUrl}/customers", content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Failed to update customer. Status Code: {response.StatusCode}");
                    return false;
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateCustomer method: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteCustomer(int customer_id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{_apiUrl}/customer/{customer_id}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Failed to delete customer. Status Code: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteCustomer method: {ex.Message}");
                return false;
            }
        }
    }
}