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
    //Các thao tác thực hiện trong Controller:
    //1. Thêm phần báo lỗi nếu như trùng id 
    //2. Hiển thị giá trị các danh mục 
    //3. Thêm Error Message cho các trường bắt buộc nhập
    //4. Thêm các khối lệnh try, catch để xử lí ngoại lệ 
    public class NhiemVuKhcnController : Controller
    {
        private readonly string _apiBaseUrl = "http://192.168.56.1:5224";

        // GET: NhiemVuKhcn
        // Thu thập các dữ liệu cần thiết của table TbNhiemVuKhcn để trả về hiển thị trên trang index
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + "/api/ctdt/NhiemVuKhcn");
                var responseData = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return View(data);
            }
        }

        // GET: NhiemVuKhcn/Details/5
        // Thu thập thông tin chi tiết của Hồ sơ nhiệm vụ KHCN với Id cụ thể để trả về hiện thị ở Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/NhiemVuKhcn/{id}");
                var responseData = await response.Content.ReadAsStringAsync();
                var tbNhiemVuKhcn = JsonSerializer.Deserialize<TbNhiemVuKhcn>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return View(tbNhiemVuKhcn);
            }
        }
        //=============================================================TẠO MỚI=====================================================================================
        // GET: NhiemVuKhcn/Create 
        //Thực hiện tạo mới hồ sơ nhiệm vụ KHCN 
        public async Task<IActionResult> Create()
        {
            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                    client.GetAsync($"{_apiBaseUrl}/api/dm/CoQuanChuQuan"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LinhVucNghienCuu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiNhiemVu"),
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
                    var DmCoQuanChuQuans = JsonSerializer.Deserialize<IEnumerable<DmCoQuanChuQuan>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    var DmLinhVucNghienCuus = JsonSerializer.Deserialize<IEnumerable<DmLinhVucNghienCuu>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    var DmLoaiNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmLoaiNhiemVu>>(responseDatas[2].IsNullOrEmpty() ? "[]" : responseDatas[2], new JsonSerializerOptions()
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

                    ViewData["IdCoQuanChuQuan"] = new SelectList(DmCoQuanChuQuans, "IdCoQuanChuQuan", "CoQuanChuQuan");
                    ViewData["IdLinhVucNghienCuu"] = new SelectList(DmLinhVucNghienCuus, "IdLinhVucNghienCuu", "LinhVucNghienCuu");
                    ViewData["IdPhanLoaiNhiemVu"] = new SelectList(DmLoaiNhiemVus, "IdLoaiNhiemVu", "LoaiNhiemVu");
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

        // POST: NhiemVuKhcn/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNhiemVuKhcn,MaNhiemVu,TenNhiemVu,IdCapQuanLyNhiemVu,IdCoQuanChuQuan,CoQuanChuTri,NguoiChuTri,IdPhanLoaiNhiemVu,ThuocNhiemVu,IdLinhVucNghienCuu,TongKinhPhiCuaNhiemVu,IdNguonKinhPhi,ThoiGianBatDau,ThoiGianKetThuc,DanhGiaKetQuaNhiemVu,SanPhamChinhCuaNhiemVu,IdTinhTrangNhiemVu")] TbNhiemVuKhcn tbNhiemVuKhcn)
        {
            /*
            //========= Báo lỗi nếu nhập trùng với IdNhiemVuKhcn (Số thứ tự của hồ sơ) đã tồn tại==================
            if (TbNhiemVuKhcnExists(tbNhiemVuKhcn.IdNhiemVuKhcn)) ModelState.AddModelError("IdNhiemVuKhcn", "Số thứ tự hồ sơ này đã tồn tại. Vui lòng nhập lại!");
            //========= Báo lỗi nếu không nhập một số trường bắt buộc phải nhập  ============================
            if (tbNhiemVuKhcn.IdNhiemVuKhcn == null) ModelState.AddModelError("IdNhiemVuKhcn", "Bạn bắt buộc phải nhập Mã quản lí nhiệm vụ Khoa học công nghệ!");
            if (tbNhiemVuKhcn.MaNhiemVu == null) ModelState.AddModelError("MaNhiemVu", "Bạn bắt buộc phải nhập Mã nhiệm vụ Khoa học công nghệ!");
            if (tbNhiemVuKhcn.TenNhiemVu == null) ModelState.AddModelError("TenNhiemVu", "Bạn bắt buộc phải nhập Tên nhiệm vụ Khoa học công nghệ!");
            if (tbNhiemVuKhcn.IdCapQuanLyNhiemVu == null) ModelState.AddModelError("IdCapQuanLyNhiemVu", "Bạn bắt buộc phải nhập Cấp quản lí nhiệm vụ Khoa học công nghệ!");
            if (tbNhiemVuKhcn.IdPhanLoaiNhiemVu == null) ModelState.AddModelError("IdPhanLoaiNhiemVu", "Bạn bắt buộc phải chọn Phân loại nhiệm vụ từ danh sách!");
            if (tbNhiemVuKhcn.ThoiGianBatDau == null) ModelState.AddModelError("ThoiGianBatDau", "Bạn bắt buộc phải nhập Thời gian bắt đầu của nhiệm vụ Khoa học công nghệ!");
            
            */

            if (ModelState.IsValid)
            {
                var jsonData = JsonSerializer.Serialize(tbNhiemVuKhcn);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync($"{_apiBaseUrl}/api/ctdt/NhiemVuKhcn", content);
                    return RedirectToAction(nameof(Index));
                }
            }

            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                     client.GetAsync($"{_apiBaseUrl}/api/dm/CoQuanChuQuan"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LinhVucNghienCuu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiNhiemVu"),
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

                var DmCoQuanChuQuans = JsonSerializer.Deserialize<IEnumerable<DmCoQuanChuQuan>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLinhVucNghienCuus = JsonSerializer.Deserialize<IEnumerable<DmLinhVucNghienCuu>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLoaiNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmLoaiNhiemVu>>(responseDatas[2].IsNullOrEmpty() ? "[]" : responseDatas[2], new JsonSerializerOptions()
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

                ViewData["IdCoQuanChuQuan"] = new SelectList(DmCoQuanChuQuans, "IdCoQuanChuQuan", "CoQuanChuQuan");
                ViewData["IdLinhVucNghienCuu"] = new SelectList(DmLinhVucNghienCuus, "IdLinhVucNghienCuu", "LinhVucNghienCuu");
                ViewData["IdPhanLoaiNhiemVu"] = new SelectList(DmLoaiNhiemVus, "IdLoaiNhiemVu", "LoaiNhiemVu");
                ViewData["IdNguonKinhPhi"] = new SelectList(DmNguonKinhPhis, "IdNguonKinhPhi", "NguonKinhPhi");
                ViewData["IdCapQuanLyNhiemVu"] = new SelectList(DmPhanCapNhiemVus, "IdPhanCapNhiemVu", "PhanCapNhiemVu");
                ViewData["IdTinhTrangNhiemVu"] = new SelectList(DmTinhTrangNhiemVus, "IdTinhTrangNhiemVu", "TinhTrangNhiemVu");

                return View(tbNhiemVuKhcn);
            }

        }

        //===================================================Cập nhật===================================================================================
        // GET: NhiemVuKhcn/Edit/5 
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/NhiemVuKhcn/{id}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound();
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var tbNhiemVuKhcn = JsonSerializer.Deserialize<TbNhiemVuKhcn>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var responses = await Task.WhenAll([
                     client.GetAsync($"{_apiBaseUrl}/api/dm/CoQuanChuQuan"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LinhVucNghienCuu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiNhiemVu"),
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

                var DmCoQuanChuQuans = JsonSerializer.Deserialize<IEnumerable<DmCoQuanChuQuan>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLinhVucNghienCuus = JsonSerializer.Deserialize<IEnumerable<DmLinhVucNghienCuu>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLoaiNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmLoaiNhiemVu>>(responseDatas[2].IsNullOrEmpty() ? "[]" : responseDatas[2], new JsonSerializerOptions()
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

                ViewData["IdCoQuanChuQuan"] = new SelectList(DmCoQuanChuQuans, "IdCoQuanChuQuan", "CoQuanChuQuan");
                ViewData["IdLinhVucNghienCuu"] = new SelectList(DmLinhVucNghienCuus, "IdLinhVucNghienCuu", "LinhVucNghienCuu");
                ViewData["IdPhanLoaiNhiemVu"] = new SelectList(DmLoaiNhiemVus, "IdLoaiNhiemVu", "LoaiNhiemVu");
                ViewData["IdNguonKinhPhi"] = new SelectList(DmNguonKinhPhis, "IdNguonKinhPhi", "NguonKinhPhi");
                ViewData["IdCapQuanLyNhiemVu"] = new SelectList(DmPhanCapNhiemVus, "IdPhanCapNhiemVu", "PhanCapNhiemVu");
                ViewData["IdTinhTrangNhiemVu"] = new SelectList(DmTinhTrangNhiemVus, "IdTinhTrangNhiemVu", "TinhTrangNhiemVu");

                return View(tbNhiemVuKhcn);
            }

        }

        // POST: NhiemVuKhcn/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNhiemVuKhcn,MaNhiemVu,TenNhiemVu,IdCapQuanLyNhiemVu,IdCoQuanChuQuan,CoQuanChuTri,NguoiChuTri,IdPhanLoaiNhiemVu,ThuocNhiemVu,IdLinhVucNghienCuu,TongKinhPhiCuaNhiemVu,IdNguonKinhPhi,ThoiGianBatDau,ThoiGianKetThuc,DanhGiaKetQuaNhiemVu,SanPhamChinhCuaNhiemVu,IdTinhTrangNhiemVu")] TbNhiemVuKhcn tbNhiemVuKhcn)
        {
            if (id != tbNhiemVuKhcn.IdNhiemVuKhcn)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                var jsonData = JsonSerializer.Serialize(tbNhiemVuKhcn);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PutAsync($"{_apiBaseUrl}/api/ctdt/NhiemVuKhcn/{id}", content);
                    return RedirectToAction(nameof(Index));
                }
            }

            using (var client = new HttpClient())
            {
                var responses = await Task.WhenAll([
                     client.GetAsync($"{_apiBaseUrl}/api/dm/CoQuanChuQuan"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LinhVucNghienCuu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiNhiemVu"),
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

                var DmCoQuanChuQuans = JsonSerializer.Deserialize<IEnumerable<DmCoQuanChuQuan>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLinhVucNghienCuus = JsonSerializer.Deserialize<IEnumerable<DmLinhVucNghienCuu>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLoaiNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmLoaiNhiemVu>>(responseDatas[2].IsNullOrEmpty() ? "[]" : responseDatas[2], new JsonSerializerOptions()
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

                ViewData["IdCoQuanChuQuan"] = new SelectList(DmCoQuanChuQuans, "IdCoQuanChuQuan", "CoQuanChuQuan");
                ViewData["IdLinhVucNghienCuu"] = new SelectList(DmLinhVucNghienCuus, "IdLinhVucNghienCuu", "LinhVucNghienCuu");
                ViewData["IdPhanLoaiNhiemVu"] = new SelectList(DmLoaiNhiemVus, "IdLoaiNhiemVu", "LoaiNhiemVu");
                ViewData["IdNguonKinhPhi"] = new SelectList(DmNguonKinhPhis, "IdNguonKinhPhi", "NguonKinhPhi");
                ViewData["IdCapQuanLyNhiemVu"] = new SelectList(DmPhanCapNhiemVus, "IdPhanCapNhiemVu", "PhanCapNhiemVu");
                ViewData["IdTinhTrangNhiemVu"] = new SelectList(DmTinhTrangNhiemVus, "IdTinhTrangNhiemVu", "TinhTrangNhiemVu");

                return View(tbNhiemVuKhcn);
            }

        }

        //=================================================== XÓA ===================================================================================
        // GET: NhiemVuKhcn/Delete/5
        // Xóa một hồ sơ KHCN ra khỏi danh sách 
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/NhiemVuKhcn/{id}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound();
                }

                var responseData = await response.Content.ReadAsStringAsync();
                var tbNhiemVuKhcn = JsonSerializer.Deserialize<TbNhiemVuKhcn>(responseData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                var responses = await Task.WhenAll([
                      client.GetAsync($"{_apiBaseUrl}/api/dm/CoQuanChuQuan"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LinhVucNghienCuu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiNhiemVu"),
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

                var DmCoQuanChuQuans = JsonSerializer.Deserialize<IEnumerable<DmCoQuanChuQuan>>(responseDatas[0].IsNullOrEmpty() ? "[]" : responseDatas[0], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLinhVucNghienCuus = JsonSerializer.Deserialize<IEnumerable<DmLinhVucNghienCuu>>(responseDatas[1].IsNullOrEmpty() ? "[]" : responseDatas[1], new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var DmLoaiNhiemVus = JsonSerializer.Deserialize<IEnumerable<DmLoaiNhiemVu>>(responseDatas[2].IsNullOrEmpty() ? "[]" : responseDatas[2], new JsonSerializerOptions()
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

                ViewData["IdCoQuanChuQuan"] = new SelectList(DmCoQuanChuQuans, "IdCoQuanChuQuan", "CoQuanChuQuan");
                ViewData["IdLinhVucNghienCuu"] = new SelectList(DmLinhVucNghienCuus, "IdLinhVucNghienCuu", "LinhVucNghienCuu");
                ViewData["IdPhanLoaiNhiemVu"] = new SelectList(DmLoaiNhiemVus, "IdLoaiNhiemVu", "LoaiNhiemVu");
                ViewData["IdNguonKinhPhi"] = new SelectList(DmNguonKinhPhis, "IdNguonKinhPhi", "NguonKinhPhi");
                ViewData["IdCapQuanLyNhiemVu"] = new SelectList(DmPhanCapNhiemVus, "IdPhanCapNhiemVu", "PhanCapNhiemVu");
                ViewData["IdTinhTrangNhiemVu"] = new SelectList(DmTinhTrangNhiemVus, "IdTinhTrangNhiemVu", "TinhTrangNhiemVu");

                return View(tbNhiemVuKhcn);
            }

        }

        // POST: NhiemVuKhcn/Delete/5
        [HttpPost, ActionName("Delete")] //ActionName dùng để định dạng tên action
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) //Xác nhận lại hồ sơ muốn xóa 
        {
            using var client = new HttpClient();
            await client.DeleteAsync(_apiBaseUrl + $"/api/ctdt/NhiemVuKhcn/{id}");
            return RedirectToAction(nameof(Index));

        }

        //Kiểm tra lỗi id khi nhập có trùng lặp trong khi tạo mới hay cập nhật hay không
        //Kiểm tra xem có tồn tại id hay không nếu có return true ngược lại return false
    }
}
