using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using C500Hemis.Models;
using System.Text;
using System.Text.Json;
using Microsoft.IdentityModel.Tokens;
using C500Hemis.Models.DM;

namespace C500Hemis.Controllers.KHCN
{
    public class DoiTuongThamGiumController : Controller
    {
        private readonly string _apiBaseUrl = "http://192.168.56.1:5224";

        // GET: DoiTuongThamGium
        public async Task<IActionResult> Index()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(_apiBaseUrl + "/api/ctdt/DoiTuongThamGia");
                    response.EnsureSuccessStatusCode();
                    var responseData = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<IEnumerable<TbDoiTuongThamGium>>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    return View(data);
                }
            }
            catch (Exception ex)
            {
                return Content("An error occurred: " + ex.Message);
            }
        }

        // GET: DoiTuongThamGium/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/DoiTuongThamGia/{id}");
                    response.EnsureSuccessStatusCode();
                    var responseData = await response.Content.ReadAsStringAsync();
                    var tbDoiTuongThamGia = JsonSerializer.Deserialize<TbDoiTuongThamGium>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    return View(tbDoiTuongThamGia);
                }
            }
            catch (Exception ex)
            {
                return Content("An error occurred: " + ex.Message);
            }
        }

        // GET: DoiTuongThamGium/Create
        public async Task<IActionResult> Create()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var responses = await Task.WhenAll(
                        client.GetAsync($"{_apiBaseUrl}/api/models/tbNguoi"),
                        client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiThamGia"),
                        client.GetAsync($"{_apiBaseUrl}/api/dm/PhanLoaiDoiNguNguoiHoc"),
                        client.GetAsync($"{_apiBaseUrl}/api/dm/VaiTroThamGia"));

                    var responseDatas = await Task.WhenAll(
                        responses[0].Content.ReadAsStringAsync(),
                        responses[1].Content.ReadAsStringAsync(),
                        responses[2].Content.ReadAsStringAsync(),
                        responses[3].Content.ReadAsStringAsync());

                    var TbNguois = JsonSerializer.Deserialize<IEnumerable<TbNguoi>>(responseDatas[0] ?? "[]", new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    var DmLoaiThamGias = JsonSerializer.Deserialize<IEnumerable<DmLoaiThamGium>>(responseDatas[1] ?? "[]", new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    var DmPhanLoaiDoiNguNguoiHocs = JsonSerializer.Deserialize<IEnumerable<DmPhanLoaiDoiNguNguoiHoc>>(responseDatas[2] ?? "[]", new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    var DmVaiTroThamGias = JsonSerializer.Deserialize<IEnumerable<DmVaiTroThamGium>>(responseDatas[3] ?? "[]", new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    ViewData["IdNguoi"] = new SelectList(TbNguois, "IdNguoi", "Ten");
                    ViewData["IdLoaiThamGia"] = new SelectList(DmLoaiThamGias, "IdLoaiThamGia", "LoaiThamGia");
                    ViewData["IdPhanLoaiDoiNguNguoiHoc"] = new SelectList(DmPhanLoaiDoiNguNguoiHocs, "IdPhanLoaiDoiNguNguoiHoc", "PhanLoaiDoiNguNguoiHoc");
                    ViewData["IdVaiTroThamGia"] = new SelectList(DmVaiTroThamGias, "IdVaiTroThamGia", "VaiTroThamGia");
                }

                return View();
            }
            catch (Exception ex)
            {
                return Content("An error occurred: " + ex.Message);
            }
        }

        // POST: DoiTuongThamGium/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDoiTuongThamGia,IdLoaiThamGia,MaLoaiThamGia,IdNguoi,IdVaiTro,IdPhanLoai")] TbDoiTuongThamGium tbDoiTuongThamGium)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var jsonData = JsonSerializer.Serialize(tbDoiTuongThamGium);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    using (var client = new HttpClient())
                    {
                        var response = await client.PostAsync($"{_apiBaseUrl}/api/ctdt/DoiTuongThamGia", content);
                        response.EnsureSuccessStatusCode();
                    }

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred: " + ex.Message);
                }
            }

            // Reload dropdown lists in case of errors
            await LoadDropdownLists();
            return View(tbDoiTuongThamGium);
        }

        // GET: DoiTuongThamGium/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/DoiTuongThamGia/{id}");
                    response.EnsureSuccessStatusCode();
                    var responseData = await response.Content.ReadAsStringAsync();
                    var tbDoiTuongThamGia = JsonSerializer.Deserialize<TbDoiTuongThamGium>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    await LoadDropdownLists();

                    return View(tbDoiTuongThamGia);
                }
            }
            catch (Exception ex)
            {
                return Content("An error occurred: " + ex.Message);
            }
        }

        // POST: DoiTuongThamGium/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDoiTuongThamGia,IdLoaiThamGia,MaLoaiThamGia,IdNguoi,IdVaiTro,IdPhanLoai")] TbDoiTuongThamGium tbDoiTuongThamGium)
        {
            if (id != tbDoiTuongThamGium.IdDoiTuongThamGia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var jsonData = JsonSerializer.Serialize(tbDoiTuongThamGium);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    using (var client = new HttpClient())
                    {
                        var response = await client.PutAsync($"{_apiBaseUrl}/api/ctdt/DoiTuongThamGia/{id}", content);
                        response.EnsureSuccessStatusCode();
                    }

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred: " + ex.Message);
                }
            }

            // Reload dropdown lists in case of errors
            await LoadDropdownLists();
            return View(tbDoiTuongThamGium);
        }

        // GET: DoiTuongThamGium/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/DoiTuongThamGia/{id}");
                    response.EnsureSuccessStatusCode();
                    var responseData = await response.Content.ReadAsStringAsync();
                    var tbDoiTuongThamGia = JsonSerializer.Deserialize<TbDoiTuongThamGium>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    await LoadDropdownLists();

                    return View(tbDoiTuongThamGia);
                }
            }
            catch (Exception ex)
            {
                return Content("An error occurred: " + ex.Message);
            }
        }

        // POST: DoiTuongThamGium/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.DeleteAsync(_apiBaseUrl + $"/api/ctdt/DoiTuongThamGia/{id}");
                    response.EnsureSuccessStatusCode();
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Content("An error occurred: " + ex.Message);
            }
        }

        private async Task LoadDropdownLists()
        {
            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll(
                    client.GetAsync($"{_apiBaseUrl}/api/models/tbNguoi"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiThamGia"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/PhanLoaiDoiNguNguoiHoc"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/VaiTroThamGia"));

                var responseDatas = await Task.WhenAll(
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync(),
                    responses[2].Content.ReadAsStringAsync(),
                    responses[3].Content.ReadAsStringAsync());

                var TbNguois = JsonSerializer.Deserialize<IEnumerable<TbNguoi>>(responseDatas[0] ?? "[]", new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var DmLoaiThamGias = JsonSerializer.Deserialize<IEnumerable<DmLoaiThamGium>>(responseDatas[1] ?? "[]", new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var DmPhanLoaiDoiNguNguoiHocs = JsonSerializer.Deserialize<IEnumerable<DmPhanLoaiDoiNguNguoiHoc>>(responseDatas[2] ?? "[]", new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var DmVaiTroThamGias = JsonSerializer.Deserialize<IEnumerable<DmVaiTroThamGium>>(responseDatas[3] ?? "[]", new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                ViewData["IdNguoi"] = new SelectList(TbNguois, "IdNguoi", "Ten");
                ViewData["IdLoaiThamGia"] = new SelectList(DmLoaiThamGias, "IdLoaiThamGia", "LoaiThamGia");
                ViewData["IdPhanLoaiDoiNguNguoiHoc"] = new SelectList(DmPhanLoaiDoiNguNguoiHocs, "IdPhanLoaiDoiNguNguoiHoc", "PhanLoaiDoiNguNguoiHoc");
                ViewData["IdVaiTroThamGia"] = new SelectList(DmVaiTroThamGias, "IdVaiTroThamGia", "VaiTroThamGia");
            }
        }
    }
}
