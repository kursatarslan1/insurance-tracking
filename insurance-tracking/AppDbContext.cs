using insurance_tracking.Class;
using insurance_tracking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace insurance_tracking
{
    public class AppDbContext
    {
        private readonly UserService _userService;
        private readonly CustomerService _customerService;
        public AppDbContext()
        {
            var httpClient = new HttpClient();
            var apiUrl = "http://localhost:3000/insurance";

            _userService = new UserService(httpClient, apiUrl);
            _customerService = new CustomerService(httpClient, apiUrl);
        }

        public async Task<User> Login(string email, string password)
        {
            return await _userService.Login(email, password);
        }

        public async Task<List<Customer>> GetCustomerList()
        {
            return await _customerService.Customers();
        }
    }
}
