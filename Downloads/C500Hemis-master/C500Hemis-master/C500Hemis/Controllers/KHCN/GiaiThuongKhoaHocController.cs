using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using C500Hemis.Models;
using System.Text.Json;
using Microsoft.IdentityModel.Tokens;
using C500Hemis.Models.DM;
using System.Text;
using System.Net.Http;
using System.Net;

namespace C500Hemis.Controllers.KHCN
{
    public class GiaiThuongKhoaHocController : Controller
    {
        private readonly string _apiBaseUrl = "http://192.168.56.1:5224";

        // GET: GiaiThuongKhoaHoc
        public async Task<IActionResult> Index()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(_apiBaseUrl + "/api/ctdt/GiaiThuongKhoaHoc");
                    if (!response.IsSuccessStatusCode)
                    {
                        // Log the error or display a message
                        return Content($"Error: Unable to fetch data (Status code: {response.StatusCode})");
                    }

                    var responseData = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<IEnumerable<TbGiaiThuongKhoaHoc>>(responseData, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    return View(data);
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                return Content($"Exception: {ex.Message}");
            }
        }

        // GET: GiaiThuongKhoaHoc/Details/5
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
                    var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/GiaiThuongKhoaHoc/{id}");
                    if (!response.IsSuccessStatusCode)
                    {
                        return Content($"Error: Unable to fetch data for ID {id} (Status code: {response.StatusCode})");
                    }

                    var responseData = await response.Content.ReadAsStringAsync();
                    var tbGiaiThuongKhoaHoc = JsonSerializer.Deserialize<TbGiaiThuongKhoaHoc>(responseData, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    return View(tbGiaiThuongKhoaHoc);
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                return Content($"Exception: {ex.Message}");
            }
        }

        // GET: GiaiThuongKhoaHoc/Create
        public async Task<IActionResult> Create()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var responses = await Task.WhenAll([
                        client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiGiaiThuongKhcn"),
                client.GetAsync($"{_apiBaseUrl}/api/dm/MucGiaiThuong")
                    ]);

                    var responseDatas = await Task.WhenAll([
                        responses[0].Content.ReadAsStringAsync(),
                responses[1].Content.ReadAsStringAsync()
                    ]);

                    var DmLoaiGiaiThuongKhcns = JsonSerializer.Deserialize<IEnumerable<DmLoaiGiaiThuongKhcn>>(responseDatas[0] ?? "[]", new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    var DmMucGiaiThuongs = JsonSerializer.Deserialize<IEnumerable<DmMucGiaiThuong>>(responseDatas[1] ?? "[]", new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                    // Truyền trực tiếp vào Model hoặc ViewData
                    var viewModel = new TbGiaiThuongKhoaHoc
                    {
                        // Có thể gắn dữ liệu cho các thuộc tính model nếu cần
                    };

                    ViewData["IdLoaiGiaiThuongKhcn"] = new SelectList(DmLoaiGiaiThuongKhcns, "IdLoaiGiaiThuongKhcn", "LoaiGiaiThuongKhcn");
                    ViewData["IdMucGiaiThuong"] = new SelectList(DmMucGiaiThuongs, "IdMucGiaiThuong", "MucGiaThuong");

                    return View(viewModel); // Trả về model hoặc dữ liệu liên quan
                }
            }
            catch (Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }
        }


        // POST: GiaiThuongKhoaHoc/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdGiaiThuongKhoaHoc,MaGiaiThuong,IdLoaiGiaiThuong,CoQuanToChucGiaiThuong,TenDeTaiDuocTraoGiai,TenDonViDuocTraoGiai,IdMucGiaiThuong,QuyetDinhCapBangKhen,CoQuanBanHanhQuyetDinh")] TbGiaiThuongKhoaHoc tbGiaiThuongKhoaHoc)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var jsonData = JsonSerializer.Serialize(tbGiaiThuongKhoaHoc);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    using (var client = new HttpClient())
                    {
                        var response = await client.PostAsync($"{_apiBaseUrl}/api/ctdt/GiaiThuongKhoaHoc", content);
                        if (!response.IsSuccessStatusCode)
                        {
                            return Content($"Error: Unable to create data (Status code: {response.StatusCode})");
                        }

                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (Exception ex)
                {
                    return Content($"Error: {ex.Message}");
                }
            }

            // If the model state is not valid, fetch the dropdowns again
            await LoadDropdowns();
            return View(tbGiaiThuongKhoaHoc);
        }

        // GET: GiaiThuongKhoaHoc/Edit/5
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
                    var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/GiaiThuongKhoaHoc/{id}");
                    if (!response.IsSuccessStatusCode)
                    {
                        return Content($"Error: Unable to fetch data for edit (Status code: {response.StatusCode})");
                    }

                    var responseData = await response.Content.ReadAsStringAsync();
                    var tbGiaiThuongKhoaHoc = JsonSerializer.Deserialize<TbGiaiThuongKhoaHoc>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    await LoadDropdowns();
                    return View(tbGiaiThuongKhoaHoc);
                }
            }
            catch (Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }
        }

        // POST: GiaiThuongKhoaHoc/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdGiaiThuongKhoaHoc,MaGiaiThuong,IdLoaiGiaiThuong,CoQuanToChucGiaiThuong,TenDeTaiDuocTraoGiai,TenDonViDuocTraoGiai,IdMucGiaiThuong,QuyetDinhCapBangKhen,CoQuanBanHanhQuyetDinh")] TbGiaiThuongKhoaHoc tbGiaiThuongKhoaHoc)
        {
            if (id != tbGiaiThuongKhoaHoc.IdGiaiThuongKhoaHoc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var jsonData = JsonSerializer.Serialize(tbGiaiThuongKhoaHoc);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    using (var client = new HttpClient())
                    {
                        var response = await client.PutAsync($"{_apiBaseUrl}/api/ctdt/GiaiThuongKhoaHoc/{id}", content);
                        if (!response.IsSuccessStatusCode)
                        {
                            return Content($"Error: Unable to update data (Status code: {response.StatusCode})");
                        }

                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (Exception ex)
                {
                    return Content($"Error: {ex.Message}");
                }
            }

            // If the model state is not valid, fetch the dropdowns again
            await LoadDropdowns();
            return View(tbGiaiThuongKhoaHoc);
        }

        // GET: GiaiThuongKhoaHoc/Delete/5
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
                    var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/GiaiThuongKhoaHoc/{id}");
                    if (!response.IsSuccessStatusCode)
                    {
                        return Content($"Error: Unable to fetch data for delete (Status code: {response.StatusCode})");
                    }

                    var responseData = await response.Content.ReadAsStringAsync();
                    var tbGiaiThuongKhoaHoc = JsonSerializer.Deserialize<TbGiaiThuongKhoaHoc>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return View(tbGiaiThuongKhoaHoc);
                }
            }
            catch (Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }
        }

        // POST: GiaiThuongKhoaHoc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.DeleteAsync(_apiBaseUrl + $"/api/ctdt/GiaiThuongKhoaHoc/{id}");
                if (!response.IsSuccessStatusCode)
                {
                    return Content($"Error: Unable to delete data (Status code: {response.StatusCode})");
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }
        }

        private async Task LoadDropdowns()
        {
            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiGiaiThuongKhcn"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/MucGiaiThuong")
                ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync()
                ]);

                var DmLoaiGiaiThuongKhcns = JsonSerializer.Deserialize<IEnumerable<DmLoaiGiaiThuongKhcn>>(responseDatas[0] ?? "[]", new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                var DmMucGiaiThuongs = JsonSerializer.Deserialize<IEnumerable<DmMucGiaiThuong>>(responseDatas[1] ?? "[]", new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                ViewData["IdLoaiGiaiThuongKhcn"] = new SelectList(DmLoaiGiaiThuongKhcns, "IdLoaiGiaiThuongKhcn", "LoaiGiaiThuongKhcn");
                ViewData["IdMucGiaiThuong"] = new SelectList(DmMucGiaiThuongs, "IdMucGiaiThuong", "MucGiaThuong");
            }
        }
    }
}
