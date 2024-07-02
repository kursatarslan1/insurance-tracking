using insurance_tracking.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace insurance_tracking.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;
        public UserService(HttpClient httpClient, string apiUrl)
        {
            _httpClient = httpClient;
            _apiUrl = apiUrl + "/users";
        }

        public async Task<User> Login(string email, string password)
        {
            try
            {
                var loginData = new
                {
                    email,
                    password
                };

                var json = JsonConvert.SerializeObject(loginData);

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync($"{_apiUrl}/login", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var responseData = JsonConvert.DeserializeObject<dynamic>(responseContent);
                    string token = responseData.token;

                    var handler = new JwtSecurityTokenHandler();
                    var jwtToken = handler.ReadJwtToken(token);
                    var claims = jwtToken.Claims.ToList();

                    // Kullanıcı bilgilerini claims içerisinden al
                    var userClaim = claims.FirstOrDefault(c => c.Type == "user")?.Value;

                    if (userClaim != null)
                    {
                        var user = JsonConvert.DeserializeObject<User>(userClaim);
                        return user;
                    }
                    else
                    {
                        throw new Exception("User claim not found in token.");
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Login method: {ex.Message}");
                throw;
            }
        }
    }
}
