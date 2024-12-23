using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using C500Hemis.Models;
using System.Text.Json;
using C500Hemis.Models.DM;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Http.HttpResults;

namespace C500Hemis.Controllers.KHCN
{
    //B8D55 AT13 Ca Kỳ Hòa

    public class TapChiKhoaHocController : Controller
    {
        private readonly string _apiBaseUrl = "http://192.168.1.20:5224";


        // GET: TapChiKhoaHoc
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + "/api/ctdt/TapChiKhoaHoc");
                var responseData = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<IEnumerable<TbTapChiKhoaHoc>>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return View(data);
            }
        }

        // GET: TapChiKhoaHoc/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/TapChiKhoaHoc/{id}");
                var responseData = await response.Content.ReadAsStringAsync();
                var tbTapChiKhoaHoc = JsonSerializer.Deserialize<TbTapChiKhoaHoc>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return View(tbTapChiKhoaHoc);
            }
        }

        // GET: TapChiKhoaHoc/Create

        public async Task<IActionResult> Create()
        {
            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LinhVucNghienCuu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiTrongNuoc")
                    ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync()
                    ]);

                try
                {
                    var DmLinhVucNghienCuus = JsonSerializer.Deserialize<IEnumerable<DmLinhVucNghienCuu>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    var DmTapChiTrongNuocs = JsonSerializer.Deserialize<IEnumerable<DmTapChiTrongNuoc>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    ViewData["IdLinhVucNghienCuu"] = new SelectList(DmLinhVucNghienCuus, "IdLinhVucNghienCuu", "LinhVucNghienCuu");
                    ViewData["IdTapChiTrongNuoc"] = new SelectList(DmTapChiTrongNuocs, "IdTapChiTrongNuoc", "TapChiTrongNuoc");

                    Console.WriteLine(responseDatas[0]);
                }
                catch (Exception ex)
                {
                    return Content(responseDatas[0] + "\n\n" + responseDatas[1] + "\n\n" + ex.Message);
                }

                return View();
            }
        }

        // POST: TapChiKhoaHoc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTapChiKhoaHoc,MaTapChi,TenTapChiTiengViet,TenTapChiTiengAnh,MaChuanIssn,IdLinhVucXuatBan,IdXepLoaiTapChi,SoBaiBao1Nam")] TbTapChiKhoaHoc tbTapChiKhoaHoc)
        {
            if (ModelState.IsValid)
            {
                var jsonData = JsonSerializer.Serialize(tbTapChiKhoaHoc);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync($"{_apiBaseUrl}/api/ctdt/TapChiKhoaHoc", content);
                    return RedirectToAction(nameof(Index));
                }
            }

            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                   client.GetAsync($"{_apiBaseUrl}/api/dm/LinhVucNghienCuu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiTrongNuoc")
                    ]);

                var responseDatas = await Task.WhenAll([
                     responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync()
                    ]);

                var DmLinhVucNghienCuus = JsonSerializer.Deserialize<IEnumerable<DmLinhVucNghienCuu>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmTapChiTrongNuocs = JsonSerializer.Deserialize<IEnumerable<DmTapChiTrongNuoc>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                ViewData["IdLinhVucNghienCuu"] = new SelectList(DmLinhVucNghienCuus, "IdLinhVucNghienCuu", "LinhVucNghienCuu");
                ViewData["IdTapChiTrongNuoc"] = new SelectList(DmTapChiTrongNuocs, "IdTapChiTrongNuoc", "TapChiTrongNuoc");

                return View(tbTapChiKhoaHoc);
            }
        }

        // GET: TapChiKhoaHoc/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Bắt lỗi
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/TapChiKhoaHoc/{id}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound();
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var tbTapChiKhoaHoc = JsonSerializer.Deserialize<TbTapChiKhoaHoc>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var responses = await Task.WhenAll([
                     client.GetAsync($"{_apiBaseUrl}/api/dm/LinhVucNghienCuu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiTrongNuoc")
                    ]);

                var responseDatas = await Task.WhenAll([
                   responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync()
                    ]);

                 var DmLinhVucNghienCuus = JsonSerializer.Deserialize<IEnumerable<DmLinhVucNghienCuu>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmTapChiTrongNuocs = JsonSerializer.Deserialize<IEnumerable<DmTapChiTrongNuoc>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                ViewData["IdLinhVucNghienCuu"] = new SelectList(DmLinhVucNghienCuus, "IdLinhVucNghienCuu", "LinhVucNghienCuu");
                ViewData["IdTapChiTrongNuoc"] = new SelectList(DmTapChiTrongNuocs, "IdTapChiTrongNuoc", "TapChiTrongNuoc");

                return View(tbTapChiKhoaHoc);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTapChiKhoaHoc,MaTapChi,TenTapChiTiengViet,TenTapChiTiengAnh,MaChuanIssn,IdLinhVucXuatBan,IdXepLoaiTapChi,SoBaiBao1Nam")] TbTapChiKhoaHoc tbTapChiKhoaHoc)
        {
            if (id != tbTapChiKhoaHoc.IdTapChiKhoaHoc)
            {
                return NotFound(); // Use parentheses to call the NotFound method
            }

            if (ModelState.IsValid)
            {
                // Prepare JSON data to send in the request
                var jsonData = JsonSerializer.Serialize(tbTapChiKhoaHoc);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PutAsync($"{_apiBaseUrl}/api/ctdt/TapChiKhoaHoc/{id}", content);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index)); // Redirect to the index view if the update is successful
                    }
                    // Handle the case when the response is not successful
                    else
                    {
                        // You might want to log the error or show a message to the user
                        ModelState.AddModelError("", "Unable to update the record. Please try again later.");
                    }
                }
            }

            // Get additional data for the view
            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll(
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LinhVucNghienCuu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiTrongNuoc")
                );

                var responseDatas = await Task.WhenAll(
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync()
                );

                var DmLinhVucNghienCuus = JsonSerializer.Deserialize<IEnumerable<DmLinhVucNghienCuu>>(responseDatas[0] ?? "[]", new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmTapChiTrongNuocs = JsonSerializer.Deserialize<IEnumerable<DmTapChiTrongNuoc>>(responseDatas[1] ?? "[]", new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                ViewData["IdLinhVucNghienCuu"] = new SelectList(DmLinhVucNghienCuus, "IdLinhVucNghienCuu", "LinhVucNghienCuu");
                ViewData["IdTapChiTrongNuoc"] = new SelectList(DmTapChiTrongNuocs, "IdTapChiTrongNuoc", "TapChiTrongNuoc");
            }

            return View(tbTapChiKhoaHoc);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/TapChiKhoaHoc/{id}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound();
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var tbTapChiKhoaHoc = JsonSerializer.Deserialize<TbTapChiKhoaHoc>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LinhVucNghienCuu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiTrongNuoc")
                    ]);

                var responseDatas = await Task.WhenAll(
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync()
                );

                var DmLinhVucNghienCuus = JsonSerializer.Deserialize<IEnumerable<DmLinhVucNghienCuu>>(responseDatas[0] ?? "[]", new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmTapChiTrongNuocs = JsonSerializer.Deserialize<IEnumerable<DmTapChiTrongNuoc>>(responseDatas[1] ?? "[]", new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                ViewData["IdLinhVucNghienCuu"] = new SelectList(DmLinhVucNghienCuus, "IdLinhVucNghienCuu", "LinhVucNghienCuu");
                ViewData["IdTapChiTrongNuoc"] = new SelectList(DmTapChiTrongNuocs, "IdTapChiTrongNuoc", "TapChiTrongNuoc");
                return View(tbTapChiKhoaHoc);
            }
            }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using var client = new HttpClient();
            await client.DeleteAsync(_apiBaseUrl + $"/api/ctdt/TapChiKhoaHoc/{id}");
            return RedirectToAction(nameof(Index));
        }
        private async Task<bool> TbTapChiKhoaHocExistsAsync(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/TapChiKhoaHoc/{id}");
                return response.IsSuccessStatusCode;
            }
        }
        private void export_message(string Message)
        {
            //Thêm tên để setup cho dễ
            string ten_folder_view = "TapChiKhoaHoc";
            // In lỗi vào file
            //Tạo UTF-8 encoding để encode ký tự về UTF-8
            UTF8Encoding unicode = new UTF8Encoding();
            //Tên của file để in lỗi
            string filename = Path.Combine(Environment.CurrentDirectory, $"Views/{ten_folder_view}/error.txt");
            //Tạo dãy byte để in vào filestream
            byte[] bytes = unicode.GetBytes(Message);
            //Mở file
            using (FileStream file = new FileStream(filename, FileMode.OpenOrCreate))
            {
                //Xóa nội dung của file
                file.SetLength(0);
                //In lỗi vào file
                file.Write(bytes, 0, bytes.Length);
                //Đóng file
                file.Close();
            }
        }
    }
}
