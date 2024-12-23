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

namespace C500Hemis.Controllers.KHCN
{
    public class HoatDongBaoVeMoiTruongController : Controller
    {
        private readonly string _apiBaseUrl = "http://192.168.56.1:5224";

        // Toàn bộ action mặc định không xuất lổi chỉ trả về BadRequest
        // GET: HoatDongBaoVeMoiTruong

        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + "/api/ctdt/HoatDongBaoVeMoiTruong");
                var responseData = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<IEnumerable<TbHoatDongBaoVeMoiTruong>>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return View(data);
            }
        }
        //chức năng tìm kiếm
        [HttpGet("index-search")]
        public async Task<IActionResult> Index(string searchString)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Xây dựng URL với tham số tìm kiếm (nếu có)
                    var apiUrl = _apiBaseUrl + "/api/ctdt/HoatDongBaoVeMoiTruong";
                    if (!string.IsNullOrEmpty(searchString))
                    {
                        apiUrl += $"?searchString={Uri.EscapeDataString(searchString)}";
                    }

                    // Gửi yêu cầu GET tới API
                    var response = await client.GetAsync(apiUrl);
                    if (!response.IsSuccessStatusCode)
                    {
                        return BadRequest(); // Trả về lỗi nếu không thành công
                    }

                    // Đọc dữ liệu trả về
                    var responseData = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<IEnumerable<TbHoatDongBaoVeMoiTruong>>(responseData, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    // Truyền lại từ khóa tìm kiếm vào ViewData để hiển thị trên View
                    ViewData["CurrentFilter"] = searchString;

                    // Trả dữ liệu cho View
                    return View(data);
                }
            }
            catch (Exception ex)
            {
                // Ghi log nếu cần
                Console.WriteLine(ex.Message);

                // Trả về BadRequest khi có lỗi
                return BadRequest();
            }
        }
        // GET: HoatDongBaoVeMoiTruong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/HoatDongBaoVeMoiTruong/{id}");
                var responseData = await response.Content.ReadAsStringAsync();
                var tbHoatDongBaoVeMoiTruong = JsonSerializer.Deserialize<TbHoatDongBaoVeMoiTruong>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return View(tbHoatDongBaoVeMoiTruong);
            }
        }

        // GET: HoatDongBaoVeMoiTruong/Create
        public async Task<IActionResult> Create()
        {
            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKHCN"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/CoQuanChuQuan"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiNhiemVuBaoVeMoiTruong"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/NguonKinhPhi"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/PhanCapNhiemVu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TinhTrangNhiemVu")
                    ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync(),
                    responses[2].Content.ReadAsStringAsync(),
                    responses[3].Content.ReadAsStringAsync(), 
                    responses[4].Content.ReadAsStringAsync(),
                    responses[5].Content.ReadAsStringAsync()
                    ]);

                try
                {
                    var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    var DmCoQuanChuQuans = JsonSerializer.Deserialize<IEnumerable<DmCoQuanChuQuan>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    var DmLoaiNhiemVuBaoVeMoiTruongs = JsonSerializer.Deserialize<IEnumerable<DmLoaiNhiemVuBaoVeMoiTruong>>(responseDatas[2].IsNullOrEmpty() ? "[]" : responseDatas[2], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    var DmNguonKinhPhis = JsonSerializer.Deserialize<IEnumerable<DmNguonKinhPhi>>(responseDatas[3].IsNullOrEmpty() ? "[]" : responseDatas[3], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    var DmPhanCapNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmPhanCapNhiemVu>>(responseDatas[4].IsNullOrEmpty() ? "[]" : responseDatas[4], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    var DmTinhTrangNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmTinhTrangNhiemVu>>(responseDatas[5].IsNullOrEmpty() ? "[]" : responseDatas[5], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });


                    ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                    ViewData["IdCoQuanChuQuan"] = new SelectList(DmCoQuanChuQuans, "IdCoQuanChuQuan", "CoQuanChuQuan");
                    ViewData["IdLoaiNhiemVuBaoVeMoiTruong"] = new SelectList(DmLoaiNhiemVuBaoVeMoiTruongs, "IdLoaiNhiemVuBaoVeMoiTruong", "LoaiNhiemVuBaoVeMoiTruong");
                    ViewData["IdNguonKinhPhi"] = new SelectList(DmNguonKinhPhis, "IdNguonKinhPhi", "NguonKinhPhi");
                    ViewData["IdCapQuanLyNhiemVu"] = new SelectList(DmPhanCapNhiemVus, "IdPhanCapNhiemVu", "PhanCapNhiemVu");
                    ViewData["IdTinhTrangNhiemVu"] = new SelectList(DmTinhTrangNhiemVus, "IdTinhTrangNhiemVu", "TinhTrangNhiemVu");

                    Console.WriteLine(responseDatas[0]);
                }
                catch (Exception ex)
                {
                    return Content(responseDatas[0] + "\n\n" + responseDatas[1] + "\n\n" + responseDatas[2] + "\n\n" + responseDatas[3] + "\n\n"+ responseDatas[4] + "\n\n" + responseDatas[5] + "\n\n" + ex.Message);
                }

                return View();
            }
        }

        // POST: HoatDongBaoVeMoiTruong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHoatDongBaoVeMoiTruong,IdNhiemVuKhcn,TenNhiemVuBvmt,IdCapQuanLyNhiemVu,IdCoQuanChuQuan,CoQuanChuTri,IdLoaiNhiemVuBaoVeMoiTruong,TongKinhPhiCuaNhiemVu,IdNguonKinhPhi,ThoiGianBatDau,ThoiGianKetThuc,DanhGiaKetQuaNhiemVu,SanPhamChinhCuaNhiemVu,DonViThucHienLuuTruSanPham,IdTinhTrangNhiemVu")] TbHoatDongBaoVeMoiTruong tbHoatDongBaoVeMoiTruong)
        {
            if (ModelState.IsValid)
            {
                var jsonData = JsonSerializer.Serialize(tbHoatDongBaoVeMoiTruong);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync($"{_apiBaseUrl}/api/ctdt/HoatDongBaoVeMoiTruong", content);
                    return RedirectToAction(nameof(Index));
                }
            }

            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                   client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKHCN"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/CoQuanChuQuan"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiNhiemVuBaoVeMoiTruong"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/NguonKinhPhi"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/PhanCapNhiemVu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TinhTrangNhiemVu")
                   ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync(),
                    responses[2].Content.ReadAsStringAsync(),
                    responses[3].Content.ReadAsStringAsync(),
                    responses[4].Content.ReadAsStringAsync(),
                    responses[5].Content.ReadAsStringAsync()
                    ]);

                var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmCoQuanChuQuans = JsonSerializer.Deserialize<IEnumerable<DmCoQuanChuQuan>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLoaiNhiemVuBaoVeMoiTruongs = JsonSerializer.Deserialize<IEnumerable<DmLoaiNhiemVuBaoVeMoiTruong>>(responseDatas[2].IsNullOrEmpty() ? "[]" : responseDatas[2], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmNguonKinhPhis = JsonSerializer.Deserialize<IEnumerable<DmNguonKinhPhi>>(responseDatas[3].IsNullOrEmpty() ? "[]" : responseDatas[3], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmPhanCapNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmPhanCapNhiemVu>>(responseDatas[4].IsNullOrEmpty() ? "[]" : responseDatas[4], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmTinhTrangNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmTinhTrangNhiemVu>>(responseDatas[5].IsNullOrEmpty() ? "[]" : responseDatas[5], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });


                ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                ViewData["IdCoQuanChuQuan"] = new SelectList(DmCoQuanChuQuans, "IdCoQuanChuQuan", "CoQuanChuQuan");
                ViewData["IdLoaiNhiemVuBaoVeMoiTruong"] = new SelectList(DmLoaiNhiemVuBaoVeMoiTruongs, "IdLoaiNhiemVuBaoVeMoiTruong", "LoaiNhiemVuBaoVeMoiTruong");
                ViewData["IdNguonKinhPhi"] = new SelectList(DmNguonKinhPhis, "IdNguonKinhPhi", "NguonKinhPhi");
                ViewData["IdCapQuanLyNhiemVu"] = new SelectList(DmPhanCapNhiemVus, "IdPhanCapNhiemVu", "PhanCapNhiemVu");
                ViewData["IdTinhTrangNhiemVu"] = new SelectList(DmTinhTrangNhiemVus, "IdTinhTrangNhiemVu", "TinhTrangNhiemVu");

                return View(tbHoatDongBaoVeMoiTruong);
            }
        }

        // GET: HoatDongBaoVeMoiTruong/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/HoatDongBaoVeMoiTruong/{id}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound();
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var tbHoatDongBaoVeMoiTruong = JsonSerializer.Deserialize<TbHoatDongBaoVeMoiTruong>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var responses = await Task.WhenAll([
                   client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKHCN"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/CoQuanChuQuan"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiNhiemVuBaoVeMoiTruong"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/NguonKinhPhi"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/PhanCapNhiemVu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TinhTrangNhiemVu")
                   ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync(),
                    responses[2].Content.ReadAsStringAsync(),
                    responses[3].Content.ReadAsStringAsync(),
                    responses[4].Content.ReadAsStringAsync(),
                    responses[5].Content.ReadAsStringAsync()
                    ]);

                var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmCoQuanChuQuans = JsonSerializer.Deserialize<IEnumerable<DmCoQuanChuQuan>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLoaiNhiemVuBaoVeMoiTruongs = JsonSerializer.Deserialize<IEnumerable<DmLoaiNhiemVuBaoVeMoiTruong>>(responseDatas[2].IsNullOrEmpty() ? "[]" : responseDatas[2], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmNguonKinhPhis = JsonSerializer.Deserialize<IEnumerable<DmNguonKinhPhi>>(responseDatas[3].IsNullOrEmpty() ? "[]" : responseDatas[3], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmPhanCapNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmPhanCapNhiemVu>>(responseDatas[4].IsNullOrEmpty() ? "[]" : responseDatas[4], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmTinhTrangNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmTinhTrangNhiemVu>>(responseDatas[5].IsNullOrEmpty() ? "[]" : responseDatas[5], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });


                ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                ViewData["IdCoQuanChuQuan"] = new SelectList(DmCoQuanChuQuans, "IdCoQuanChuQuan", "CoQuanChuQuan");
                ViewData["IdLoaiNhiemVuBaoVeMoiTruong"] = new SelectList(DmLoaiNhiemVuBaoVeMoiTruongs, "IdLoaiNhiemVuBaoVeMoiTruong", "LoaiNhiemVuBaoVeMoiTruong");
                ViewData["IdNguonKinhPhi"] = new SelectList(DmNguonKinhPhis, "IdNguonKinhPhi", "NguonKinhPhi");
                ViewData["IdCapQuanLyNhiemVu"] = new SelectList(DmPhanCapNhiemVus, "IdPhanCapNhiemVu", "PhanCapNhiemVu");
                ViewData["IdTinhTrangNhiemVu"] = new SelectList(DmTinhTrangNhiemVus, "IdTinhTrangNhiemVu", "TinhTrangNhiemVu");

                return View(tbHoatDongBaoVeMoiTruong);
            }
        }

        // POST: HoatDongBaoVeMoiTruong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdHoatDongBaoVeMoiTruong,IdNhiemVuKhcn,TenNhiemVuBvmt,IdCapQuanLyNhiemVu,IdCoQuanChuQuan,CoQuanChuTri,IdLoaiNhiemVuBaoVeMoiTruong,TongKinhPhiCuaNhiemVu,IdNguonKinhPhi,ThoiGianBatDau,ThoiGianKetThuc,DanhGiaKetQuaNhiemVu,SanPhamChinhCuaNhiemVu,DonViThucHienLuuTruSanPham,IdTinhTrangNhiemVu")] TbHoatDongBaoVeMoiTruong tbHoatDongBaoVeMoiTruong)
        {
            if (id != tbHoatDongBaoVeMoiTruong.IdHoatDongBaoVeMoiTruong)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                var jsonData = JsonSerializer.Serialize(tbHoatDongBaoVeMoiTruong);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PutAsync($"{_apiBaseUrl}/api/ctdt/HoatDongBaoVeMoiTruong/{id}", content);
                    return RedirectToAction(nameof(Index));
                }
            }

            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKHCN"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/CoQuanChuQuan"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiNhiemVuBaoVeMoiTruong"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/NguonKinhPhi"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/PhanCapNhiemVu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TinhTrangNhiemVu")
                    ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync(),
                    responses[2].Content.ReadAsStringAsync(),
                    responses[3].Content.ReadAsStringAsync(),
                    responses[4].Content.ReadAsStringAsync(),
                    responses[5].Content.ReadAsStringAsync()
                    ]);

                var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmCoQuanChuQuans = JsonSerializer.Deserialize<IEnumerable<DmCoQuanChuQuan>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLoaiNhiemVuBaoVeMoiTruongs = JsonSerializer.Deserialize<IEnumerable<DmLoaiNhiemVuBaoVeMoiTruong>>(responseDatas[2].IsNullOrEmpty() ? "[]" : responseDatas[2], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmNguonKinhPhis = JsonSerializer.Deserialize<IEnumerable<DmNguonKinhPhi>>(responseDatas[3].IsNullOrEmpty() ? "[]" : responseDatas[3], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmPhanCapNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmPhanCapNhiemVu>>(responseDatas[4].IsNullOrEmpty() ? "[]" : responseDatas[4], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmTinhTrangNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmTinhTrangNhiemVu>>(responseDatas[5].IsNullOrEmpty() ? "[]" : responseDatas[5], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });


                ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                ViewData["IdCoQuanChuQuan"] = new SelectList(DmCoQuanChuQuans, "IdCoQuanChuQuan", "CoQuanChuQuan");
                ViewData["IdLoaiNhiemVuBaoVeMoiTruong"] = new SelectList(DmLoaiNhiemVuBaoVeMoiTruongs, "IdLoaiNhiemVuBaoVeMoiTruong", "LoaiNhiemVuBaoVeMoiTruong");
                ViewData["IdNguonKinhPhi"] = new SelectList(DmNguonKinhPhis, "IdNguonKinhPhi", "NguonKinhPhi");
                ViewData["IdCapQuanLyNhiemVu"] = new SelectList(DmPhanCapNhiemVus, "IdPhanCapNhiemVu", "PhanCapNhiemVu");
                ViewData["IdTinhTrangNhiemVu"] = new SelectList(DmTinhTrangNhiemVus, "IdTinhTrangNhiemVu", "TinhTrangNhiemVu");

                return View(tbHoatDongBaoVeMoiTruong);
            }
        }

        // GET: HoatDongBaoVeMoiTruong/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/HoatDongBaoVeMoiTruong/{id}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound();
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var tbHoatDongBaoVeMoiTruong = JsonSerializer.Deserialize<TbHoatDongBaoVeMoiTruong>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var responses = await Task.WhenAll([
                     client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKHCN"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/CoQuanChuQuan"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiNhiemVuBaoVeMoiTruong"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/NguonKinhPhi"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/PhanCapNhiemVu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/TinhTrangNhiemVu")
                     ]);

                var responseDatas = await Task.WhenAll([
                    responses[0].Content.ReadAsStringAsync(),
                    responses[1].Content.ReadAsStringAsync(),
                    responses[2].Content.ReadAsStringAsync(),
                    responses[3].Content.ReadAsStringAsync(),
                    responses[4].Content.ReadAsStringAsync(),
                    responses[5].Content.ReadAsStringAsync()
                    ]);

                var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmCoQuanChuQuans = JsonSerializer.Deserialize<IEnumerable<DmCoQuanChuQuan>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLoaiNhiemVuBaoVeMoiTruongs = JsonSerializer.Deserialize<IEnumerable<DmLoaiNhiemVuBaoVeMoiTruong>>(responseDatas[2].IsNullOrEmpty() ? "[]" : responseDatas[2], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmNguonKinhPhis = JsonSerializer.Deserialize<IEnumerable<DmNguonKinhPhi>>(responseDatas[3].IsNullOrEmpty() ? "[]" : responseDatas[3], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmPhanCapNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmPhanCapNhiemVu>>(responseDatas[4].IsNullOrEmpty() ? "[]" : responseDatas[4], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmTinhTrangNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmTinhTrangNhiemVu>>(responseDatas[5].IsNullOrEmpty() ? "[]" : responseDatas[5], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });


                ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                ViewData["IdCoQuanChuQuan"] = new SelectList(DmCoQuanChuQuans, "IdCoQuanChuQuan", "CoQuanChuQuan");
                ViewData["IdLoaiNhiemVuBaoVeMoiTruong"] = new SelectList(DmLoaiNhiemVuBaoVeMoiTruongs, "IdLoaiNhiemVuBaoVeMoiTruong", "LoaiNhiemVuBaoVeMoiTruong");
                ViewData["IdNguonKinhPhi"] = new SelectList(DmNguonKinhPhis, "IdNguonKinhPhi", "NguonKinhPhi");
                ViewData["IdCapQuanLyNhiemVu"] = new SelectList(DmPhanCapNhiemVus, "IdPhanCapNhiemVu", "PhanCapNhiemVu");
                ViewData["IdTinhTrangNhiemVu"] = new SelectList(DmTinhTrangNhiemVus, "IdTinhTrangNhiemVu", "TinhTrangNhiemVu");

                return View(tbHoatDongBaoVeMoiTruong);
            }
        }

        // POST: HoatDongBaoVeMoiTruong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using var client = new HttpClient();
            await client.DeleteAsync(_apiBaseUrl + $"/api/ctdt/HoatDongBaoVeMoiTruong/{id}");
            return RedirectToAction(nameof(Index));
        }

    }
}
