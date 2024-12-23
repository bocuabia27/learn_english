using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using C500Hemis.Models;
using System.Text.Json;
using System.Net.Http;
using System.Text;

namespace C500Hemis.Controllers.KHCN
{
    public class NhomNghienCuuManhController : Controller
    {
        private readonly string _apiBaseUrl = "http://192.168.56.1:5224";

        // GET: NhomNghienCuuManh
        public async Task<IActionResult> Index(string searchString)
        {
            using (var client = new HttpClient())
            {
                // Kiểm tra nếu có từ khóa tìm kiếm
                var url = string.IsNullOrEmpty(searchString)
                    ? _apiBaseUrl + "/api/ctdt/NhomNghienCuuManh"
                    : _apiBaseUrl + $"/api/ctdt/NhomNghienCuuManh?search={searchString}";

                var response = await client.GetAsync(url);
                var responseData = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<IEnumerable<TbNhomNghienCuuManh>>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return View(data);
            }
        }

        // GET: NhomNghienCuuManh/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/NhomNghienCuuManh/{id}");
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound();
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var tbNhomNghienCuuManh = JsonSerializer.Deserialize<TbNhomNghienCuuManh>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return View(tbNhomNghienCuuManh);
            }
        }

        // GET: NhomNghienCuuManh/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NhomNghienCuuManh/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNhomNghienCuuManh,MaNhomNghienCuuManh,TenNhomNghienCuuManh,SoQuyetDinhThanhLap,ToChucBanHanhQuyetDinh,NgayQuyetDinh,CacNhiemVuNckh,TomTatKetQuaDatDuoc")] TbNhomNghienCuuManh tbNhomNghienCuuManh)
        {
            if (ModelState.IsValid)
            {
                var jsonData = JsonSerializer.Serialize(tbNhomNghienCuuManh);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync($"{_apiBaseUrl}/api/ctdt/NhomNghienCuuManh", content);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Lỗi khi thêm mới dữ liệu.");
                    }
                }
            }

            return View(tbNhomNghienCuuManh);
        }

        // GET: NhomNghienCuuManh/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/NhomNghienCuuManh/{id}");
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound();
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var tbNhomNghienCuuManh = JsonSerializer.Deserialize<TbNhomNghienCuuManh>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return View(tbNhomNghienCuuManh);
            }
        }

        // POST: NhomNghienCuuManh/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNhomNghienCuuManh,MaNhomNghienCuuManh,TenNhomNghienCuuManh,SoQuyetDinhThanhLap,ToChucBanHanhQuyetDinh,NgayQuyetDinh,CacNhiemVuNckh,TomTatKetQuaDatDuoc")] TbNhomNghienCuuManh tbNhomNghienCuuManh)
        {
            if (id != tbNhomNghienCuuManh.IdNhomNghienCuuManh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var jsonData = JsonSerializer.Serialize(tbNhomNghienCuuManh);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PutAsync($"{_apiBaseUrl}/api/ctdt/NhomNghienCuuManh/{id}", content);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Lỗi khi cập nhật dữ liệu.");
                    }
                }
            }
            return View(tbNhomNghienCuuManh);
        }

        // GET: NhomNghienCuuManh/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/NhomNghienCuuManh/{id}");
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound();
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var tbNhomNghienCuuManh = JsonSerializer.Deserialize<TbNhomNghienCuuManh>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return View(tbNhomNghienCuuManh);
            }
        }

        // POST: NhomNghienCuuManh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync(_apiBaseUrl + $"/api/ctdt/NhomNghienCuuManh/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Lỗi khi xóa dữ liệu.");
                    return RedirectToAction(nameof(Index));
                }
            }
        }
    }
}
