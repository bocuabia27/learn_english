using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using C500Hemis.Models;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace C500Hemis.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly string _apiBaseUrl = "http://192.168.56.1:5224";

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Dữ liệu không hợp lệ.";
                return View(model);
            }

            var jsonData = JsonSerializer.Serialize(model);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {

                try
                {
                    var response = await client.PostAsync($"{_apiBaseUrl}/api/user/register", content);

                    if (response.IsSuccessStatusCode)
                    {
                        TempData["Message"] = "Đăng ký thành công, hãy đăng nhập.";
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        var statusCode = response.StatusCode;
                        var responseBody = await response.Content.ReadAsStringAsync();
                        try
                        {
                            var errorJson = JsonDocument.Parse(responseBody);
                            ViewBag.Error = errorJson.RootElement.GetProperty("message").GetString();
                        }
                        catch (JsonException)
                        {
                            ViewBag.Error = $"API trả về mã trạng thái: {statusCode}. Phản hồi: {responseBody}";
                        }
                        return View(model);
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    ViewBag.Error = $"Lỗi HTTP: {httpEx.Message}";
                    return View(model);
                }
                catch (Exception ex)
                {
                    ViewBag.Error = $"Lỗi không xác định: {ex.Message}";
                    return View(model);
                }
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Dữ liệu không hợp lệ.";
                return View(model);
            }

            var jsonData = JsonSerializer.Serialize(model);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.PostAsync($"{_apiBaseUrl}/api/user/login", content);
                    var responseBody = await response.Content.ReadAsStringAsync();

                    try
                    {
                        using (var doc = JsonDocument.Parse(responseBody))
                        {
                            var root = doc.RootElement;
                            int success = root.GetProperty("success").GetInt32();
                            string message = root.GetProperty("message").GetString() ?? "";

                            if (success == 1)
                            {
                                int idUser = root.GetProperty("idUser").GetInt32();

                                // Tạo các Claim
                                var claims = new List<Claim>
                                {
                                    new Claim(ClaimTypes.NameIdentifier, idUser.ToString()),
                                    new Claim(ClaimTypes.Name, model.Username)
                                };

                                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                                var authProperties = new AuthenticationProperties
                                {
                                    IsPersistent = true, // Giữ đăng nhập khi đóng trình duyệt
                                    ExpiresUtc = DateTimeOffset.UtcNow.AddHours(1)
                                };

                                // Đăng nhập người dùng
                                await HttpContext.SignInAsync(
                                    CookieAuthenticationDefaults.AuthenticationScheme,
                                    new ClaimsPrincipal(claimsIdentity),
                                    authProperties
                                );

                                TempData["Message"] = message;
                                return RedirectToAction("Index", "Home");
                            }
                            else
                            {
                                ViewBag.Error = message;
                                return View(model);
                            }
                        }
                    }
                    catch (JsonException)
                    {
                        ViewBag.Error = $"API trả về dữ liệu không hợp lệ:\n{responseBody}";
                        return View(model);
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    ViewBag.Error = $"Lỗi HTTP: {httpEx.Message}";
                    return View(model);
                }
                catch (Exception ex)
                {
                    ViewBag.Error = $"Lỗi không xác định: {ex.Message}";
                    return View(model);
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
