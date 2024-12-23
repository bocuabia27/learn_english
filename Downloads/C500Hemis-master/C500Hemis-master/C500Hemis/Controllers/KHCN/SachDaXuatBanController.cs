using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using C500Hemis.Models;
using C500Hemis.Models.DM;

public class SachDaXuatBanController : Controller
{
    private readonly string _apiBaseUrl = "http://192.168.56.1:5224";

    // Hiển thị danh sách sách đã xuất bản
    public async Task<IActionResult> Index()
    {
        using (var client = new HttpClient())
        {
            try
            {
                var response = await client.GetAsync(_apiBaseUrl + "/api/ctdt/SachDaXuatBan");
                response.EnsureSuccessStatusCode();  // Đảm bảo yêu cầu thành công
                var responseData = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<IEnumerable<TbSachDaXuatBan>>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(data);
            }
            catch (Exception ex)
            {
                // Log lỗi nếu có
                return RedirectToAction("Error", "Home"); // Chuyển đến trang lỗi
            }
        }
    }

    // Hiển thị chi tiết sách đã xuất bản
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound(); // Nếu không có ID thì trả về lỗi
        }

        using (var client = new HttpClient())
        {
            try
            {
                var response = await client.GetAsync(_apiBaseUrl + $"/api/ctdt/SachDaXuatBan/{id}");
                response.EnsureSuccessStatusCode();
                var responseData = await response.Content.ReadAsStringAsync();
                var tbSachDaXuatBan = JsonSerializer.Deserialize<TbSachDaXuatBan>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(tbSachDaXuatBan);
            }
            catch (Exception ex)
            {
                // Log lỗi nếu có
                return RedirectToAction("Error", "Home");
            }
        }
    }

    // Hiển thị form tạo sách đã xuất bản mới
    public async Task<IActionResult> Create()
    {
        using (var client = new HttpClient())
        {
            try
            {
                var responses = await Task.WhenAll(new[] {
                    client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKhcn"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/DangTaiLieu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiSachTapChi")
                });

                var responseDatas = await Task.WhenAll(responses.Select(r => r.Content.ReadAsStringAsync()));

                var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(string.IsNullOrEmpty(responseDatas[0]) ? "[]" : responseDatas[0], new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var DmDangTaiLieus = JsonSerializer.Deserialize<IEnumerable<DmDangTaiLieu>>(string.IsNullOrEmpty(responseDatas[1]) ? "[]" : responseDatas[1], new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var DmLoaiSachTapChis = JsonSerializer.Deserialize<IEnumerable<DmLoaiSachTapChi>>(string.IsNullOrEmpty(responseDatas[2]) ? "[]" : responseDatas[2], new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                // Cung cấp dữ liệu cho các dropdown trong view
                ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                ViewData["IdDangTaiLieu"] = new SelectList(DmDangTaiLieus, "IdDangTaiLieu", "DangTaiLieu");
                ViewData["IdLoaiSachTapChi"] = new SelectList(DmLoaiSachTapChis, "IdLoaiSachTapChi", "LoaiSachTapChi");

                return View();
            }
            catch (Exception ex)
            {
                // Log lỗi nếu có
                return RedirectToAction("Error", "Home");
            }
        }
    }

    // Xử lý dữ liệu khi tạo mới sách đã xuất bản
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("IdSachDaXuatBan,IdNhiemVuKhcn,MaSach,TenSach,IdLoaiSachTapChi,MaChuanIsbn,SoTrang,Nxb,NamXuatBan,NamViet,IdDangTaiLieu")] TbSachDaXuatBan tbSachDaXuatBan)
    {
        if (ModelState.IsValid)
        {
            var jsonData = JsonSerializer.Serialize(tbSachDaXuatBan);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.PostAsync($"{_apiBaseUrl}/api/ctdt/SachDaXuatBan", content);
                    response.EnsureSuccessStatusCode(); // Đảm bảo yêu cầu thành công
                    return RedirectToAction(nameof(Index)); // Quay lại trang danh sách
                }
                catch (Exception ex)
                {
                    // Log lỗi nếu có
                    return RedirectToAction("Error", "Home");
                }
            }
        }

        // Nếu không hợp lệ, tải lại form với dữ liệu đã nhập
        using (var client = new HttpClient())
        {
            try
            {
                var responses = await Task.WhenAll(new[] {
                    client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKhcn"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/DangTaiLieu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiSachTapChi")
                });

                var responseDatas = await Task.WhenAll(responses.Select(r => r.Content.ReadAsStringAsync()));

                var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(string.IsNullOrEmpty(responseDatas[0]) ? "[]" : responseDatas[0], new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var DmDangTaiLieus = JsonSerializer.Deserialize<IEnumerable<DmDangTaiLieu>>(string.IsNullOrEmpty(responseDatas[1]) ? "[]" : responseDatas[1], new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var DmLoaiSachTapChis = JsonSerializer.Deserialize<IEnumerable<DmLoaiSachTapChi>>(string.IsNullOrEmpty(responseDatas[2]) ? "[]" : responseDatas[2], new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                // Cung cấp dữ liệu lại cho dropdown trong form
                ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu");
                ViewData["IdDangTaiLieu"] = new SelectList(DmDangTaiLieus, "IdDangTaiLieu", "DangTaiLieu");
                ViewData["IdLoaiSachTapChi"] = new SelectList(DmLoaiSachTapChis, "IdLoaiSachTapChi", "LoaiSachTapChi");

                return View(tbSachDaXuatBan); // Hiển thị lại form với dữ liệu đã nhập
            }
            catch (Exception ex)
            {
                // Log lỗi nếu có
                return RedirectToAction("Error", "Home");
            }
        }
    }

    // Hiển thị form chỉnh sửa sách đã xuất bản
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound(); // Nếu không có ID thì trả về lỗi
        }

        using (var client = new HttpClient())
        {
            try
            {
                var response = await client.GetAsync($"{_apiBaseUrl}/api/ctdt/SachDaXuatBan/{id}");
                response.EnsureSuccessStatusCode();
                var responseData = await response.Content.ReadAsStringAsync();
                var tbSachDaXuatBan = JsonSerializer.Deserialize<TbSachDaXuatBan>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                // Lấy dữ liệu dropdown cho form chỉnh sửa
                var responses = await Task.WhenAll(new[] {
                    client.GetAsync($"{_apiBaseUrl}/api/khcn/VNhiemVuKhcn"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/DangTaiLieu"),
                    client.GetAsync($"{_apiBaseUrl}/api/dm/LoaiSachTapChi")
                });

                var responseDatas = await Task.WhenAll(responses.Select(r => r.Content.ReadAsStringAsync()));

                var TbNhiemVuKhcns = JsonSerializer.Deserialize<IEnumerable<TbNhiemVuKhcn>>(string.IsNullOrEmpty(responseDatas[0]) ? "[]" : responseDatas[0], new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var DmDangTaiLieus = JsonSerializer.Deserialize<IEnumerable<DmDangTaiLieu>>(string.IsNullOrEmpty(responseDatas[1]) ? "[]" : responseDatas[1], new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var DmLoaiSachTapChis = JsonSerializer.Deserialize<IEnumerable<DmLoaiSachTapChi>>(string.IsNullOrEmpty(responseDatas[2]) ? "[]" : responseDatas[2], new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                // Cung cấp dữ liệu cho các dropdown trong form
                ViewData["IdNhiemVuKhcn"] = new SelectList(TbNhiemVuKhcns, "IdNhiemVuKhcn", "TenNhiemVu", tbSachDaXuatBan.IdNhiemVuKhcn);
                ViewData["IdDangTaiLieu"] = new SelectList(DmDangTaiLieus, "IdDangTaiLieu", "DangTaiLieu", tbSachDaXuatBan.IdDangTaiLieu);
                ViewData["IdLoaiSachTapChi"] = new SelectList(DmLoaiSachTapChis, "IdLoaiSachTapChi", "LoaiSachTapChi", tbSachDaXuatBan.IdLoaiSachTapChi);

                return View(tbSachDaXuatBan);
            }
            catch (Exception ex)
            {
                // Log lỗi nếu có
                return RedirectToAction("Error", "Home");
            }
        }
    }

    // Xử lý dữ liệu khi chỉnh sửa sách đã xuất bản
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("IdSachDaXuatBan,IdNhiemVuKhcn,MaSach,TenSach,IdLoaiSachTapChi,MaChuanIsbn,SoTrang,Nxb,NamXuatBan,NamViet,IdDangTaiLieu")] TbSachDaXuatBan tbSachDaXuatBan)
    {
        if (id != tbSachDaXuatBan.IdSachDaXuatBan)
        {
            return NotFound();  // Nếu ID không khớp, trả về lỗi
        }

        if (ModelState.IsValid)
        {
            var jsonData = JsonSerializer.Serialize(tbSachDaXuatBan);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.PutAsync($"{_apiBaseUrl}/api/ctdt/SachDaXuatBan/{id}", content);
                    response.EnsureSuccessStatusCode(); // Đảm bảo yêu cầu thành công
                    return RedirectToAction(nameof(Index)); // Quay lại trang danh sách
                }
                catch (Exception ex)
                {
                    // Log lỗi nếu có
                    return RedirectToAction("Error", "Home");
                }
            }
        }

        // Nếu không hợp lệ, tải lại form với dữ liệu đã nhập
        return View(tbSachDaXuatBan);
    }

    // Xác nhận và xóa sách đã xuất bản
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound(); // Nếu không có ID thì trả về lỗi
        }

        using (var client = new HttpClient())
        {
            try
            {
                var response = await client.GetAsync($"{_apiBaseUrl}/api/ctdt/SachDaXuatBan/{id}");
                response.EnsureSuccessStatusCode();
                var responseData = await response.Content.ReadAsStringAsync();
                var tbSachDaXuatBan = JsonSerializer.Deserialize<TbSachDaXuatBan>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(tbSachDaXuatBan);
            }
            catch (Exception ex)
            {
                // Log lỗi nếu có
                return RedirectToAction("Error", "Home");
            }
        }
    }

    // Xử lý xóa sách đã xuất bản
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        using (var client = new HttpClient())
        {
            try
            {
                var response = await client.DeleteAsync($"{_apiBaseUrl}/api/ctdt/SachDaXuatBan/{id}");
                response.EnsureSuccessStatusCode(); // Đảm bảo yêu cầu thành công
                return RedirectToAction(nameof(Index)); // Quay lại trang danh sách
            }
            catch (Exception ex)
            {
                // Log lỗi nếu có
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
