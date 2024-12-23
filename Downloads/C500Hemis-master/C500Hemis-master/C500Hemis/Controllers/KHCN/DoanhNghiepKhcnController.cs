using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using C500Hemis.Models;
using C500Hemis.Models.DM;
using Microsoft.IdentityModel.Tokens;

public class DoanhNghiepKhcnController : Controller
{
    private readonly string _apiBaseUrl = "http://192.168.56.1:5224";

    // GET: DoanhNghiepKhcn
    public async Task<IActionResult> Index()
    {
        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(_apiBaseUrl + "/api/ctdt/DoanhNghiepKHCN");
            var responseData = await response.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<IEnumerable<TbDoanhNghiepKhcn>>(responseData, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return View(data);
        }
    }

    // GET: DoanhNghiepKhcn/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/DoanhNghiepKHCN/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var responseData = await response.Content.ReadAsStringAsync();
            var tbDoanhNghiepKHCN = JsonSerializer.Deserialize<TbDoanhNghiepKhcn>(responseData, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return View(tbDoanhNghiepKHCN);
        }
    }

    // GET: DoanhNghiepKhcn/Create
    public async Task<IActionResult> Create()
    {
        using (var client = new HttpClient())
        {
            var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/dm/HinhThucDoanhNghiepKhcn")
                ]);

            var responseDatas = await Task.WhenAll([
                responses[0].Content.ReadAsStringAsync()
                ]);

            try
            {
                var DmHinhThucDoanhNghiepKhcns = JsonSerializer.Deserialize<IEnumerable<DmHinhThucDoanhNghiepKhcn>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                }); 
                ViewData["IdHinhThucDoanhNghiepKhcn"] = new SelectList(DmHinhThucDoanhNghiepKhcns, "IdHinhThucDoanhNghiepKhcn", "HinhThucDoanhNghiepKhcn");

                Console.WriteLine(responseDatas[0]);
            }
            catch (Exception ex)
            {
                return Content(responseDatas[0] + "\n\n" + ex.Message);
            }

            return View();
        }
    }

    // POST: DoanhNghiepKhcn/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TbDoanhNghiepKhcn tbDoanhNghiepKhcn)
    {
        if (ModelState.IsValid)
        {
            var jsonData = JsonSerializer.Serialize(tbDoanhNghiepKhcn);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync($"{_apiBaseUrl}/api/ctdt/DoanhNghiepKHCN", content);
                return RedirectToAction(nameof(Index));
            }
        }

        using (var client = new HttpClient())
        {
            var responses = await Task.WhenAll([
                   client.GetAsync($"{_apiBaseUrl}/api/dm/HinhThucDoanhNghiepKhcn")
               ]);

            var responseDatas = await Task.WhenAll([
                responses[0].Content.ReadAsStringAsync()
                ]);
            var DmHinhThucDoanhNghiepKhcns = JsonSerializer.Deserialize<IEnumerable<DmHinhThucDoanhNghiepKhcn>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });
            ViewData["IdHinhThucDoanhNghiepKhcn"] = new SelectList(DmHinhThucDoanhNghiepKhcns, "IdHinhThucDoanhNghiepKhcn", "HinhThucDoanhNghiepKhcn");


            return View(tbDoanhNghiepKhcn);
        }
    }

    // GET: DoanhNghiepKhcn/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/DoanhNghiepKHCN/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var responseData = await response.Content.ReadAsStringAsync();
            var tbDoanhNghiepKhcn = JsonSerializer.Deserialize<TbDoanhNghiepKhcn>(responseData, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            await LoadHinhThucDoanhNghiepKhcnData();
            return View(tbDoanhNghiepKhcn);
        }
    }

    // POST: DoanhNghiepKhcn/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, TbDoanhNghiepKhcn tbDoanhNghiepKhcn)
    {
        if (id != tbDoanhNghiepKhcn.IdDoanhNghiepKhcn)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            var jsonData = JsonSerializer.Serialize(tbDoanhNghiepKhcn);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = await client.PutAsync($"{_apiBaseUrl}/api/ctdt/DoanhNghiepKHCN/{id}", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
        }

        await LoadHinhThucDoanhNghiepKhcnData();
        return View(tbDoanhNghiepKhcn);
    }

    // GET: DoanhNghiepKhcn/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/DoanhNghiepKHCN/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var responseData = await response.Content.ReadAsStringAsync();
            var tbDoanhNghiepKhcn = JsonSerializer.Deserialize<TbDoanhNghiepKhcn>(responseData, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return View(tbDoanhNghiepKhcn);
        }
    }

    // POST: DoanhNghiepKhcn/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        using (var client = new HttpClient())
        {
            var response = await client.DeleteAsync(_apiBaseUrl + $"/api/ctdt/DoanhNghiepKHCN/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        return RedirectToAction(nameof(Index));
    }

    private async Task LoadHinhThucDoanhNghiepKhcnData()
    {
        using (var client = new HttpClient())
        {
            var response = await client.GetAsync($"{_apiBaseUrl}/api/dm/HinhThucDoanhNghiepKhcn");
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var DmHinhThucDoanhNghiepKHCNs = JsonSerializer.Deserialize<IEnumerable<DmHinhThucDoanhNghiepKhcn>>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                ViewData["IdHinhThucDoanhNghiepKhcn"] = new SelectList(DmHinhThucDoanhNghiepKHCNs, "IdHinhThucDoanhNghiepKhcn", "HinhThucDoanhNghiepKhcn");
            }
        }
    }
}
