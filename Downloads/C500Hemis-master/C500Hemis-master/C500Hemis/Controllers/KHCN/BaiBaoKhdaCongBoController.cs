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

namespace C500Hemis.Controllers.KHCN
{
    public class BaiBaoKhdaCongBoController : Controller
    {
        private readonly string _apiBaseUrl = "http://192.168.56.1:5224";

        // GET: BaiBaoKhdaCongBo/Index
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + "/api/khcn/BaiBaoKHDaCongBo");
                var responseData = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<IEnumerable<TbBaiBaoKhdaCongBo>>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return View(data);
            }
        }

        // GET: BaiBaoKhdaCongBo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/khcn/BaiBaoKHDaCongBo/{id}");
                var responseData = await response.Content.ReadAsStringAsync();
                var tbBaiBaoKhdaCongBo = JsonSerializer.Deserialize<TbBaiBaoKhdaCongBo>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return View(tbBaiBaoKhdaCongBo);
            }
        }

        // GET: BaiBaoKhdaCongBo/Create
        public async Task<IActionResult> Create()
        {
            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKHCN"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiKhoaHocQuocTe"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiTrongNuoc"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/XepHangQ")
                    ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync(),
                    responses[2].Content.ReadAsStringAsync(),
                    responses[3].Content.ReadAsStringAsync()
                    ]);

                try
                {
                    var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    var DmTapChiKhoaHocQuocTes = JsonSerializer.Deserialize<IEnumerable<DmTapChiKhoaHocQuocTe>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    var DmTapChiTrongNuocs = JsonSerializer.Deserialize<IEnumerable<DmTapChiTrongNuoc>>(responseDatas[2].IsNullOrEmpty() ? "[]" : responseDatas[2], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    var DmXepHangQs = JsonSerializer.Deserialize<IEnumerable<DmXepHangQ>>(responseDatas[3].IsNullOrEmpty() ? "[]" : responseDatas[3], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                    ViewData["IdTapChiQuocTe"] = new SelectList(DmTapChiKhoaHocQuocTes, "IdTapChiKhoaHocQuocTe", "TapChiKhoaHocQuocTe");
                    ViewData["IdTapChiTrongNuoc"] = new SelectList(DmTapChiTrongNuocs, "IdTapChiTrongNuoc", "TapChiTrongNuoc");
                    ViewData["IdXepHangQ"] = new SelectList(DmXepHangQs, "IdXepHangQ", "XepHangQ");

                    Console.WriteLine(responseDatas[0]);
                }
                catch(Exception ex)
                {
                    return Content(responseDatas[0] + "\n\n" + responseDatas[1] + "\n\n" + responseDatas[2] + "\n\n" + responseDatas[3] + "\n\n" + ex.Message);
                }

                return View();
            }
        }

        // POST: BaiBaoKhdaCongBo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]//HTTP
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBaiBaoKhdaCongBo,IdNhiemVuKhcn,MaBaiBaoKh,TenBaiBaoKh,TenTapChi,IdTapChiTrongNuoc,IdTapChiQuocTe,IdXepHangQ,GhiChuDuongDanBaiBao,TapSo,Trang,NamCongBo")] TbBaiBaoKhdaCongBo tbBaiBaoKhdaCongBo)
        {
            if (ModelState.IsValid)
            {
                var jsonData = JsonSerializer.Serialize(tbBaiBaoKhdaCongBo);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync($"{_apiBaseUrl}/api/khcn/BaiBaoKHDaCongBo", content);
                    return RedirectToAction(nameof(Index));
                }
            }

            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKHCN"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiKhoaHocQuocTe"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiTrongNuoc"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/XepHangQ")
                    ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync(),
                    responses[2].Content.ReadAsStringAsync(),
                    responses[3].Content.ReadAsStringAsync()
                    ]);

                var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(responseDatas[0], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmTapChiKhoaHocQuocTes = JsonSerializer.Deserialize<IEnumerable<DmTapChiKhoaHocQuocTe>>(responseDatas[1], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmTapChiTrongNuocs = JsonSerializer.Deserialize<IEnumerable<DmTapChiTrongNuoc>>(responseDatas[2], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmXepHangQs = JsonSerializer.Deserialize<IEnumerable<DmXepHangQ>>(responseDatas[3], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                ViewData["IdTapChiQuocTe"] = new SelectList(DmTapChiKhoaHocQuocTes, "IdTapChiKhoaHocQuocTe", "TapChiKhoaHocQuocTe");
                ViewData["IdTapChiTrongNuoc"] = new SelectList(DmTapChiTrongNuocs, "IdTapChiTrongNuoc", "TapChiTrongNuoc");
                ViewData["IdXepHangQ"] = new SelectList(DmXepHangQs, "IdXepHangQ", "XepHangQ");

                return View(tbBaiBaoKhdaCongBo);
            }
        }

        // GET: BaiBaoKhdaCongBo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/khcn/BaiBaoKHDaCongBo/{id}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound();
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var tbBaiBaoKhdaCongBo = JsonSerializer.Deserialize<TbBaiBaoKhdaCongBo>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKHCN"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiKhoaHocQuocTe"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiTrongNuoc"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/XepHangQ")
                    ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync(),
                    responses[2].Content.ReadAsStringAsync(),
                    responses[3].Content.ReadAsStringAsync()
                    ]);

                var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(responseDatas[0], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmTapChiKhoaHocQuocTes = JsonSerializer.Deserialize<IEnumerable<DmTapChiKhoaHocQuocTe>>(responseDatas[1], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmTapChiTrongNuocs = JsonSerializer.Deserialize<IEnumerable<DmTapChiTrongNuoc>>(responseDatas[2], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmXepHangQs = JsonSerializer.Deserialize<IEnumerable<DmXepHangQ>>(responseDatas[3], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                ViewData["IdTapChiQuocTe"] = new SelectList(DmTapChiKhoaHocQuocTes, "IdTapChiKhoaHocQuocTe", "TapChiKhoaHocQuocTe");
                ViewData["IdTapChiTrongNuoc"] = new SelectList(DmTapChiTrongNuocs, "IdTapChiTrongNuoc", "TapChiTrongNuoc");
                ViewData["IdXepHangQ"] = new SelectList(DmXepHangQs, "IdXepHangQ", "XepHangQ");

                return View(tbBaiBaoKhdaCongBo);
            }
        }

        // POST: BaiBaoKhdaCongBo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdBaiBaoKhdaCongBo,IdNhiemVuKhcn,MaBaiBaoKh,TenBaiBaoKh,TenTapChi,IdTapChiTrongNuoc,IdTapChiQuocTe,IdXepHangQ,GhiChuDuongDanBaiBao,TapSo,Trang,NamCongBo")] TbBaiBaoKhdaCongBo tbBaiBaoKhdaCongBo)
        {
            if (id != tbBaiBaoKhdaCongBo.IdBaiBaoKhdaCongBo)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                var jsonData = JsonSerializer.Serialize(tbBaiBaoKhdaCongBo);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PutAsync($"{_apiBaseUrl}/api/khcn/BaiBaoKHDaCongBo/{id}", content);
                    return RedirectToAction(nameof(Index));
                }
            }

            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKHCN"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiKhoaHocQuocTe"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiTrongNuoc"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/XepHangQ")
                    ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync(),
                    responses[2].Content.ReadAsStringAsync(),
                    responses[3].Content.ReadAsStringAsync()
                    ]);

                var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(responseDatas[0], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmTapChiKhoaHocQuocTes = JsonSerializer.Deserialize<IEnumerable<DmTapChiKhoaHocQuocTe>>(responseDatas[1], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmTapChiTrongNuocs = JsonSerializer.Deserialize<IEnumerable<DmTapChiTrongNuoc>>(responseDatas[2], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmXepHangQs = JsonSerializer.Deserialize<IEnumerable<DmXepHangQ>>(responseDatas[3], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                ViewData["IdTapChiQuocTe"] = new SelectList(DmTapChiKhoaHocQuocTes, "IdTapChiKhoaHocQuocTe", "TapChiKhoaHocQuocTe");
                ViewData["IdTapChiTrongNuoc"] = new SelectList(DmTapChiTrongNuocs, "IdTapChiTrongNuoc", "TapChiTrongNuoc");
                ViewData["IdXepHangQ"] = new SelectList(DmXepHangQs, "IdXepHangQ", "XepHangQ");

                return View(tbBaiBaoKhdaCongBo);
            }
        }

        // GET: BaiBaoKhdaCongBo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/khcn/BaiBaoKHDaCongBo/{id}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound();
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var tbBaiBaoKhdaCongBo = JsonSerializer.Deserialize<TbBaiBaoKhdaCongBo>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKHCN"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiKhoaHocQuocTe"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TapChiTrongNuoc"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/XepHangQ")
                    ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync(),
                    responses[2].Content.ReadAsStringAsync(),
                    responses[3].Content.ReadAsStringAsync()
                    ]);

                var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(responseDatas[0], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmTapChiKhoaHocQuocTes = JsonSerializer.Deserialize<IEnumerable<DmTapChiKhoaHocQuocTe>>(responseDatas[1], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmTapChiTrongNuocs = JsonSerializer.Deserialize<IEnumerable<DmTapChiTrongNuoc>>(responseDatas[2], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var DmXepHangQs = JsonSerializer.Deserialize<IEnumerable<DmXepHangQ>>(responseDatas[3], new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                ViewData["IdTapChiQuocTe"] = new SelectList(DmTapChiKhoaHocQuocTes, "IdTapChiKhoaHocQuocTe", "TapChiKhoaHocQuocTe");
                ViewData["IdTapChiTrongNuoc"] = new SelectList(DmTapChiTrongNuocs, "IdTapChiTrongNuoc", "TapChiTrongNuoc");
                ViewData["IdXepHangQ"] = new SelectList(DmXepHangQs, "IdXepHangQ", "XepHangQ");

                return View(tbBaiBaoKhdaCongBo);
            }
        }

        // POST: BaiBaoKhdaCongBo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using var client = new HttpClient();
            await client.DeleteAsync(_apiBaseUrl + $"/api/khcn/BaiBaoKHDaCongBo/{id}");
            return RedirectToAction(nameof(Index));
        }

/*        private bool TbBaiBaoKhdaCongBoExists(int id)
        {
            return _context.TbBaiBaoKhdaCongBos.Any(e => e.IdBaiBaoKhdaCongBo == id);
        }
        private bool checkexist(string check)
        {
            return _context.TbBaiBaoKhdaCongBos.Any(e => e.MaBaiBaoKh == check);

        }*/

    }
}