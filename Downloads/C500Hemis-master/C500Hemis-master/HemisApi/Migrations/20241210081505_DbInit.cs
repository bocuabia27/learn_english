using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HemisApi.Migrations
{
    /// <inheritdoc />
    public partial class DbInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DM");

            migrationBuilder.EnsureSchema(
                name: "KHCN");

            migrationBuilder.EnsureSchema(
                name: "CB");

            migrationBuilder.EnsureSchema(
                name: "TCTS");

            migrationBuilder.EnsureSchema(
                name: "TS");

            migrationBuilder.EnsureSchema(
                name: "CTDT");

            migrationBuilder.EnsureSchema(
                name: "CSGD");

            migrationBuilder.EnsureSchema(
                name: "CSVC");

            migrationBuilder.EnsureSchema(
                name: "NH");

            migrationBuilder.EnsureSchema(
                name: "NDT");

            migrationBuilder.EnsureSchema(
                name: "VB");

            migrationBuilder.EnsureSchema(
                name: "HTQT");

            migrationBuilder.EnsureSchema(
                name: "HTDN");

            migrationBuilder.EnsureSchema(
                name: "PQuyen");

            migrationBuilder.CreateTable(
                name: "dmBacLuong",
                columns: table => new
                {
                    IdBacLuong = table.Column<int>(type: "int", nullable: false),
                    BacLuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmBacLuong", x => x.IdBacLuong);
                });

            migrationBuilder.CreateTable(
                name: "dmBacLuong",
                schema: "DM",
                columns: table => new
                {
                    IdBacLuong = table.Column<int>(type: "int", nullable: false),
                    BacLuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmBacLuong", x => x.IdBacLuong);
                });

            migrationBuilder.CreateTable(
                name: "dmCapHoiNghi",
                schema: "DM",
                columns: table => new
                {
                    IdCapHoiNghi = table.Column<int>(type: "int", nullable: false),
                    CapHoiNghi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "dmCapKhenThuong",
                schema: "DM",
                columns: table => new
                {
                    IdCapKhenThuong = table.Column<int>(type: "int", nullable: false),
                    CapKhenThuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmCapKhenThuong", x => x.IdCapKhenThuong);
                });

            migrationBuilder.CreateTable(
                name: "dmChucDanhGiangVien",
                schema: "DM",
                columns: table => new
                {
                    IdChucDanhGiangVien = table.Column<int>(type: "int", nullable: false),
                    ChucDanhGiangVien = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbChucDanhGiangDay", x => x.IdChucDanhGiangVien);
                });

            migrationBuilder.CreateTable(
                name: "dmChucDanhHoiDong",
                schema: "DM",
                columns: table => new
                {
                    IdChucDanhHoiDong = table.Column<int>(type: "int", nullable: false),
                    ChucDanhHoiDong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmChucDanhHoiDong", x => x.IdChucDanhHoiDong);
                });

            migrationBuilder.CreateTable(
                name: "dmChucDanhKhoaHoc",
                schema: "DM",
                columns: table => new
                {
                    IdChucDanhKhoaHoc = table.Column<int>(type: "int", nullable: false),
                    ChucDanhKhoaHoc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmChucDanhKhoaHoc", x => x.IdChucDanhKhoaHoc);
                });

            migrationBuilder.CreateTable(
                name: "dmChucDanhNCKH",
                schema: "DM",
                columns: table => new
                {
                    IdChucDanhNghienCuuKhoaHoc = table.Column<int>(type: "int", nullable: false),
                    ChucDanhNghienCuuKhoaHoc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbChucDanhNCKH", x => x.IdChucDanhNghienCuuKhoaHoc);
                });

            migrationBuilder.CreateTable(
                name: "dmChucDanhNgheNghiep",
                schema: "DM",
                columns: table => new
                {
                    IdChucDanhNgheNghiep = table.Column<int>(type: "int", nullable: false),
                    ChucDanhNgheNghiep = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmChucDanhNgheNghiep", x => x.IdChucDanhNgheNghiep);
                });

            migrationBuilder.CreateTable(
                name: "dmChucDanhPhongBan",
                schema: "DM",
                columns: table => new
                {
                    IdChucDanhPhongBan = table.Column<int>(type: "int", nullable: false),
                    ChucDanhPhongBan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmChucDanhPhongBan", x => x.IdChucDanhPhongBan);
                });

            migrationBuilder.CreateTable(
                name: "dmChucVu",
                schema: "DM",
                columns: table => new
                {
                    IdChucVu = table.Column<int>(type: "int", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmChucVu", x => x.IdChucVu);
                });

            migrationBuilder.CreateTable(
                name: "dmChuongTrinhDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: false),
                    ChuongTrinhDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmChuongTrinhDaoTao", x => x.IdChuongTrinhDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmChuSoHuu",
                schema: "DM",
                columns: table => new
                {
                    IdChuSoHuu = table.Column<int>(type: "int", nullable: false),
                    ChuSoHuu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmChuSoHuu", x => x.IdChuSoHuu);
                });

            migrationBuilder.CreateTable(
                name: "dmCoQuanBanHanh",
                schema: "DM",
                columns: table => new
                {
                    IdCoQuanBanHanh = table.Column<int>(type: "int", nullable: false),
                    CoQuanBanHanh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmCoQuanBanHanh", x => x.IdCoQuanBanHanh);
                });

            migrationBuilder.CreateTable(
                name: "dmCoQuanChuQuan",
                schema: "DM",
                columns: table => new
                {
                    IdCoQuanChuQuan = table.Column<int>(type: "int", nullable: false),
                    CoQuanChuQuan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmCoQuanChuQuan", x => x.IdCoQuanChuQuan);
                });

            migrationBuilder.CreateTable(
                name: "dmDangTaiLieu",
                schema: "DM",
                columns: table => new
                {
                    IdDangTaiLieu = table.Column<int>(type: "int", nullable: false),
                    DangTaiLieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmDangTaiLieu", x => x.IdDangTaiLieu);
                });

            migrationBuilder.CreateTable(
                name: "dmDanhGiaCongChucVienChuc",
                schema: "DM",
                columns: table => new
                {
                    IdDanhGiaCongChucVienChuc = table.Column<int>(type: "int", nullable: false),
                    DanhGiaCongChucVienChuc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmDanhGiaCongChucVienChuc", x => x.IdDanhGiaCongChucVienChuc);
                });

            migrationBuilder.CreateTable(
                name: "dmDanhHieuVinhDuGiaiThuong",
                schema: "DM",
                columns: table => new
                {
                    IdDanhHieuVinhDuGiaiThuong = table.Column<int>(type: "int", nullable: false),
                    DanhHieuVinhDuGiaiThuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmDanhHieuVinhDuGiaiThuong", x => x.IdDanhHieuVinhDuGiaiThuong);
                });

            migrationBuilder.CreateTable(
                name: "dmDanToc",
                schema: "DM",
                columns: table => new
                {
                    IdDanToc = table.Column<int>(type: "int", nullable: false),
                    DanToc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmDanToc", x => x.IdDanToc);
                });

            migrationBuilder.CreateTable(
                name: "dmDaoTaoGDQPAN",
                schema: "DM",
                columns: table => new
                {
                    IdDaoTaoGDQPAN = table.Column<int>(type: "int", nullable: false),
                    DaoTaoGDQPAN = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmDaoTaoGDQPAN", x => x.IdDaoTaoGDQPAN);
                });

            migrationBuilder.CreateTable(
                name: "dmDauMoiLienHe",
                schema: "DM",
                columns: table => new
                {
                    IdDauMoiLienHe = table.Column<int>(type: "int", nullable: false),
                    DauMoiLienHe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmDauMoiLienHe", x => x.IdDauMoiLienHe);
                });

            migrationBuilder.CreateTable(
                name: "dmDoiTuongChinhSach",
                schema: "DM",
                columns: table => new
                {
                    IdDoiTuongChinhSach = table.Column<int>(type: "int", nullable: false),
                    DoiTuongChinhSach = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmDoiTuongChinhSach", x => x.IdDoiTuongChinhSach);
                });

            migrationBuilder.CreateTable(
                name: "dmDoiTuongDauVao",
                schema: "DM",
                columns: table => new
                {
                    IdDoiTuongDauVao = table.Column<int>(type: "int", nullable: false),
                    DoiTuongDauVao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmDoiTuongDauVao", x => x.IdDoiTuongDauVao);
                });

            migrationBuilder.CreateTable(
                name: "dmDoiTuongUuTien",
                schema: "DM",
                columns: table => new
                {
                    IdDoiTuongUuTien = table.Column<int>(type: "int", nullable: false),
                    DoiTuongUuTien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmDoiTuongUuTien", x => x.IdDoiTuongUuTien);
                });

            migrationBuilder.CreateTable(
                name: "dmDonViCapBang",
                schema: "DM",
                columns: table => new
                {
                    IdDonViCapBang = table.Column<int>(type: "int", nullable: false),
                    DonViCapBang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonViCapBang", x => x.IdDonViCapBang);
                });

            migrationBuilder.CreateTable(
                name: "dmGioiTinh",
                schema: "DM",
                columns: table => new
                {
                    IdGioiTinh = table.Column<int>(type: "int", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmGioiTinh", x => x.IdGioiTinh);
                });

            migrationBuilder.CreateTable(
                name: "dmHangThuongBinh",
                schema: "DM",
                columns: table => new
                {
                    IdHangThuongBinh = table.Column<int>(type: "int", nullable: false),
                    HangThuongBinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHangThuongBinh", x => x.IdHangThuongBinh);
                });

            migrationBuilder.CreateTable(
                name: "dmHeSoLuong",
                schema: "DM",
                columns: table => new
                {
                    IdHeSoLuong = table.Column<int>(type: "int", nullable: false),
                    HeSoLuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHeSoLuong", x => x.IdHeSoLuong);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucBoNhiem",
                schema: "DM",
                columns: table => new
                {
                    IdHinhThucBoNhiem = table.Column<int>(type: "int", nullable: false),
                    HinhThucBoNhiem = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucBoNhiem", x => x.IdHinhThucBoNhiem);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucChuyenGiaoCongNghe",
                schema: "DM",
                columns: table => new
                {
                    IdHinhThucChuyenGiaoCongNghe = table.Column<int>(type: "int", nullable: false),
                    HinhThucChuyenGiaoCongNghe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucChuyenGiaoCongNghe", x => x.IdHinhThucChuyenGiaoCongNghe);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdHinhThucDaoTao = table.Column<int>(type: "int", nullable: false),
                    HinhThucDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucDaoTao", x => x.IdHinhThucDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucDaoTaoTheoChuyenNgu",
                schema: "DM",
                columns: table => new
                {
                    IdHinhThucDaoTaoTheoChuyenNgu = table.Column<int>(type: "int", nullable: false),
                    HinhThucDaoTaoTheoChuyenNgu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucDaoTaoTheoChuyenNgu", x => x.IdHinhThucDaoTaoTheoChuyenNgu);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucDoanhNghiepKHCN",
                schema: "DM",
                columns: table => new
                {
                    IdHinhThucDoanhNghiepKHCN = table.Column<int>(type: "int", nullable: false),
                    HinhThucDoanhNghiepKHCN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucDoanhNghiepKHCN", x => x.IdHinhThucDoanhNghiepKHCN);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucHopTac",
                schema: "DM",
                columns: table => new
                {
                    IdHinhThucHopTac = table.Column<int>(type: "int", nullable: false),
                    HinhThucHopTac = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucHopTac", x => x.IdHinhThucHopTac);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucSoHuu",
                schema: "DM",
                columns: table => new
                {
                    IdHinhThucSoHuu = table.Column<int>(type: "int", nullable: false),
                    HinhThucSoHuu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucSoHuu", x => x.IdHinhThucSoHuu);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucThamGiaGVDuocCuDiDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdHinhThucThamGiaGVDuocCuDiDaoTao = table.Column<int>(type: "int", nullable: false),
                    HinhThucThamGiaGVDuocCuDiDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucThamGiaGVDuocCuDiDaoTao", x => x.IdHinhThucThamGiaGVDuocCuDiDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucThanhLap",
                schema: "DM",
                columns: table => new
                {
                    IdHinhThucThanhLap = table.Column<int>(type: "int", nullable: false),
                    HinhThucThanhLap = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucThanhLap", x => x.IdHinhThucThanhLap);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucTuyenDung",
                schema: "DM",
                columns: table => new
                {
                    IdHinhThucTuyenDung = table.Column<int>(type: "int", nullable: false),
                    HinhThucTuyenDung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucTuyenDung", x => x.IdHinhThucTuyenDung);
                });

            migrationBuilder.CreateTable(
                name: "dmHinhThucTuyenSinh",
                schema: "DM",
                columns: table => new
                {
                    IdHinhThucTuyenSinh = table.Column<int>(type: "int", nullable: false),
                    HinhThucTuyenSinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucTuyenSinh", x => x.IdHinhThucTuyenSinh);
                });

            migrationBuilder.CreateTable(
                name: "dmHoatDongTaiChinh",
                schema: "DM",
                columns: table => new
                {
                    IdHoatDongTaiChinh = table.Column<int>(type: "int", nullable: false),
                    HoatDongTaiChinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHoatDongTaiChinh", x => x.IdHoatDongTaiChinh);
                });

            migrationBuilder.CreateTable(
                name: "dmHocCheDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdHocCheDaoTao = table.Column<int>(type: "int", nullable: false),
                    HocCheDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHocCheDaoTao", x => x.IdHocCheDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmHoGiaDinhChinhSach",
                schema: "DM",
                columns: table => new
                {
                    IdHoGiaDinhChinhSach = table.Column<int>(type: "int", nullable: false),
                    HoGiaDinhChinhSach = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHoGiaDinhChinhSach", x => x.IdHoGiaDinhChinhSach);
                });

            migrationBuilder.CreateTable(
                name: "dmKetQuaKiemDinh",
                schema: "DM",
                columns: table => new
                {
                    IdKetQuaKiemDinh = table.Column<int>(type: "int", nullable: false),
                    KetQuaKiemDinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbKetQuaKiemDinh", x => x.IdKetQuaKiemDinh);
                });

            migrationBuilder.CreateTable(
                name: "dmKhungNangLucNgoaiNgu",
                schema: "DM",
                columns: table => new
                {
                    IdKhungNangLucNgoaiNgu = table.Column<int>(type: "int", nullable: false),
                    TenKhungNangLucNgoaiNgu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmKhungNangLucNgoaiNgu", x => x.IdKhungNangLucNgoaiNgu);
                });

            migrationBuilder.CreateTable(
                name: "dmKhuVuc",
                schema: "DM",
                columns: table => new
                {
                    IdKhuVuc = table.Column<int>(type: "int", nullable: false),
                    KhuVuc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmKhuVuc", x => x.IdKhuVuc);
                });

            migrationBuilder.CreateTable(
                name: "dmLinhVucDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdLinhVucDaoTao = table.Column<int>(type: "int", nullable: false),
                    LinhVucDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLinhVucDaoTao", x => x.IdLinhVucDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmLinhVucNghienCuu",
                schema: "DM",
                columns: table => new
                {
                    IdLinhVucNghienCuu = table.Column<int>(type: "int", nullable: false),
                    LinhVucNghienCuu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLinhVucNghienCuu", x => x.IdLinhVucNghienCuu);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiBoiDuong",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiBoiDuong = table.Column<int>(type: "int", nullable: false),
                    LoaiBoiDuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiBoiDuong", x => x.IdLoaiBoiDuong);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiChuongTrinhDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: false),
                    LoaiChuongTrinhDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLoaiChuongTrinhDaoTao", x => x.IdLoaiChuongTrinhDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiChuongTrinhLienKetDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiChuongTrinhLienKetDaoTao = table.Column<int>(type: "int", nullable: false),
                    LoaiChuongTrinhLienKetDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLoaiChuongTrinhLienKetDaoTao", x => x.IdLoaiChuongTrinhLienKetDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiCongTrinhCoSoVatChat",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiCongTrinhCoSoVatChat = table.Column<int>(type: "int", nullable: false),
                    LoaiCongTrinhCoSoVatChat = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiCongTrinhCoSoVatChat", x => x.IdLoaiCongTrinhCoSoVatChat);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiDanhHieuThiDuaGiaiThuongKhenThuong",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong = table.Column<int>(type: "int", nullable: false),
                    LoaiDanhHieuThiDuaGiaiThuongKhenThuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiDanhHieuThiDuaGiaiThuongKhenThuong", x => x.IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiDeAnChuongTrinh",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiDeAnChuongTrinh = table.Column<int>(type: "int", nullable: false),
                    LoaiDeAnChuongTrinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiDeAnChuongTrinh", x => x.IdLoaiDeAnChuongTrinh);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiDeTai",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiDeTai = table.Column<int>(type: "int", nullable: false),
                    LoaiDeTai = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiDeTai", x => x.IdLoaiDeTai);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiGiaiThuongKHCN",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiGiaiThuongKHCN = table.Column<int>(type: "int", nullable: false),
                    LoaiGiaiThuongKHCN = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiGiaiThuongKHCN", x => x.IdLoaiGiaiThuongKHCN);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiGiangVienQuocPhong",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiGiangVienQuocPhong = table.Column<int>(type: "int", nullable: false),
                    LoaiGiangVienQuocPhong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiGiangVienQuocPhong", x => x.IdLoaiGiangVienQuocPhong);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiHinhCoSoDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiHinhCoSoDaoTao = table.Column<int>(type: "int", nullable: false),
                    LoaiHinhCoSoDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiHinhCoSoDaoTao", x => x.IdLoaiHinhCoSoDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiHinhDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiHinhDaoTao = table.Column<int>(type: "int", nullable: false),
                    LoaiHinhDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiHinhDaoTao", x => x.IdLoaiHinhDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiHinhTruong",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiHinhTruong = table.Column<int>(type: "int", nullable: false),
                    LoaiHinhTruong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiHinhTruong", x => x.IdLoaiHinhTruong);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiHocBong",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiHocBong = table.Column<int>(type: "int", nullable: false),
                    LoaiHocBong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiHocBong", x => x.IdLoaiHocBong);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiHocVien",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiHocVien = table.Column<int>(type: "int", nullable: false),
                    LoaiHocVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiHocVien", x => x.IdLoaiHocVien);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiHopDong",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiHopDong = table.Column<int>(type: "int", nullable: false),
                    LoaiHopDong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiHopDong", x => x.IdLoaiHopDong);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiKhuyetTat",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiKhuyetTat = table.Column<int>(type: "int", nullable: false),
                    LoaiKhuyetTat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiKhuyetTat", x => x.IdLoaiKhuyetTat);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiKyLuat",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiKyLuat = table.Column<int>(type: "int", nullable: false),
                    LoaiKyLuat = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiKyLuat", x => x.IdLoaiKyLuat);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiLienKet",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiLienKet = table.Column<int>(type: "int", nullable: false),
                    LoaiLienKet = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiLienKet", x => x.IdLoaiLienKet);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiLuuHocSinh",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiLuuHocSinh = table.Column<int>(type: "int", nullable: false),
                    LoaiLuuHocSinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiLuuHocSinh", x => x.IdLoaiLuuHocSinh);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiNhiemVu",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiNhiemVu = table.Column<int>(type: "int", nullable: false),
                    LoaiNhiemVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiNhiemVu", x => x.IdLoaiNhiemVu);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiNhiemVuBaoVeMoiTruong",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiNhiemVuBaoVeMoiTruong = table.Column<int>(type: "int", nullable: false),
                    LoaiNhiemVuBaoVeMoiTruong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiNhiemVuBaoVeMoiTruong", x => x.IdLoaiNhiemVuBaoVeMoiTruong);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiPhongBan",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiPhongBan = table.Column<int>(type: "int", nullable: false),
                    LoaiPhongBan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiPhongBan", x => x.IdLoaiPhongBan);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiPhongHoc",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiPhongHoc = table.Column<int>(type: "int", nullable: false),
                    LoaiPhongHoc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiPhongHoc", x => x.IdLoaiPhongHoc);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiPhongThiNghiem",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiPhongThiNghiem = table.Column<int>(type: "int", nullable: false),
                    LoaiPhongThiNghiem = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiPhongThiNghiem", x => x.IdLoaiPhongThiNghiem);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiQuyetDinh",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiQuyetDinh = table.Column<int>(type: "int", nullable: false),
                    LoaiQuyetDinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiQuyetDinh", x => x.IdLoaiQuyetDinh);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiSachTapChi",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiSachTapChi = table.Column<int>(type: "int", nullable: false),
                    LoaiSachTapChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiSachTapChi", x => x.IdLoaiSachTapChi);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiTaiSanTriTue",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiTaiSanTriTue = table.Column<int>(type: "int", nullable: false),
                    LoaiTaiSanTriTue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiTaiSanTriTue", x => x.IdLoaiTaiSanTriTue);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiThamGia",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiThamGia = table.Column<int>(type: "int", nullable: false),
                    LoaiThamGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiThamGia", x => x.IdLoaiThamGia);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiToChuc",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiToChuc = table.Column<int>(type: "int", nullable: false),
                    LoaiToChuc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiToChuc", x => x.IdLoaiToChuc);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiTotNghiep",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiTotNghiep = table.Column<int>(type: "int", nullable: false),
                    LoaiTotNghiep = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiTotNghiep", x => x.IdLoaiTotNghiep);
                });

            migrationBuilder.CreateTable(
                name: "dmLoaiViPham",
                schema: "DM",
                columns: table => new
                {
                    IdLoaiViPham = table.Column<int>(type: "int", nullable: false),
                    LoaiViPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLoaiViPham", x => x.IdLoaiViPham);
                });

            migrationBuilder.CreateTable(
                name: "dmMucDichSuDungCSVC",
                schema: "DM",
                columns: table => new
                {
                    IdMucDichSuDungCSVC = table.Column<int>(type: "int", nullable: false),
                    MucDichSuDungCSVC = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmMucDichSuDungCSVC", x => x.IdMucDichSuDungCSVC);
                });

            migrationBuilder.CreateTable(
                name: "dmMucGiaiThuong",
                schema: "DM",
                columns: table => new
                {
                    IdMucGiaiThuong = table.Column<int>(type: "int", nullable: false),
                    MucGiaiThuong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmMucGiaiThuong", x => x.IdMucGiaiThuong);
                });

            migrationBuilder.CreateTable(
                name: "dmMucTieuNhiemVu",
                schema: "DM",
                columns: table => new
                {
                    IdMucTieuNhiemVu = table.Column<int>(type: "int", nullable: false),
                    MucTieuNhiemVu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmMucTieuNhiemVu", x => x.IdMucTieuNhiemVu);
                });

            migrationBuilder.CreateTable(
                name: "dmNgach",
                schema: "DM",
                columns: table => new
                {
                    IdNgach = table.Column<int>(type: "int", nullable: false),
                    Ngach = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNgach", x => x.IdNgach);
                });

            migrationBuilder.CreateTable(
                name: "dmNganhDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdNganhDaoTao = table.Column<int>(type: "int", nullable: false),
                    NganhDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNganhDaoTao", x => x.IdNganhDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmNganhKinhTe",
                schema: "DM",
                columns: table => new
                {
                    IdNganhKinhTe = table.Column<int>(type: "int", nullable: false),
                    Cap1 = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    NganhKinhTe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNganhKinhTe", x => x.IdNganhKinhTe);
                });

            migrationBuilder.CreateTable(
                name: "dmNgoaiNgu",
                schema: "DM",
                columns: table => new
                {
                    IdNgoaiNgu = table.Column<int>(type: "int", nullable: false),
                    NgoaiNgu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNgoaiNgu", x => x.IdNgoaiNgu);
                });

            migrationBuilder.CreateTable(
                name: "dmNguonKinhPhi",
                schema: "DM",
                columns: table => new
                {
                    IdNguonKinhPhi = table.Column<int>(type: "int", nullable: false),
                    NguonKinhPhi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNguonKinhPhi", x => x.IdNguonKinhPhi);
                });

            migrationBuilder.CreateTable(
                name: "dmNguonKinhPhiChoDeAn",
                schema: "DM",
                columns: table => new
                {
                    IdNguonKinhPhiChoDeAn = table.Column<int>(type: "int", nullable: false),
                    NguonKinhPhiChoDeAn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNguonKinhPhiChoDeAn", x => x.IdNguonKinhPhiChoDeAn);
                });

            migrationBuilder.CreateTable(
                name: "dmNguonKinhPhiChoLuuHocSinh",
                schema: "DM",
                columns: table => new
                {
                    IdNguonKinhPhiChoLuuHocSinh = table.Column<int>(type: "int", nullable: false),
                    NguonKinhPhiChoLuuHocSinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNguonKinhPhiChoLuuHocSinh", x => x.IdNguonKinhPhiChoLuuHocSinh);
                });

            migrationBuilder.CreateTable(
                name: "dmNguonKinhPhiCuaGVDuocCuDiDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdNguonKinhPhiCuaGVDuocCuDiDaoTao = table.Column<int>(type: "int", nullable: false),
                    NguonKinhPhiCuaGVDuocCuDiDaoTao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNguonKinhPhiCuaGVDuocCuDiDaoTao", x => x.IdNguonKinhPhiCuaGVDuocCuDiDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmNhomNganh",
                schema: "DM",
                columns: table => new
                {
                    IdNhomNganh = table.Column<int>(type: "int", nullable: false),
                    NhomNganh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNhomNganh", x => x.IdNhomNganh);
                });

            migrationBuilder.CreateTable(
                name: "dmNoiDungHoatDong",
                schema: "DM",
                columns: table => new
                {
                    IdNoiDungHoatDong = table.Column<int>(type: "int", nullable: false),
                    NoiDungHoatDong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNoiDungHoatDong", x => x.IdNoiDungHoatDong);
                });

            migrationBuilder.CreateTable(
                name: "dmNoiDungHoatDongTaiVietNam",
                schema: "DM",
                columns: table => new
                {
                    IdNoiDungHoatDongTaiVietNam = table.Column<int>(type: "int", nullable: false),
                    NoiDungHoatDongTaiVietNam = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmNoiDungHoatDongTaiVietNam", x => x.IdNoiDungHoatDongTaiVietNam);
                });

            migrationBuilder.CreateTable(
                name: "dmPhanCapNhiemVu",
                schema: "DM",
                columns: table => new
                {
                    IdPhanCapNhiemVu = table.Column<int>(type: "int", nullable: false),
                    PhanCapNhiemVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmPhanCapNhiemVu", x => x.IdPhanCapNhiemVu);
                });

            migrationBuilder.CreateTable(
                name: "dmPhanLoaiCoSo",
                schema: "DM",
                columns: table => new
                {
                    IdPhanLoaiCoSo = table.Column<int>(type: "int", nullable: false),
                    PhanLoaiCoSo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmPhanLoaiCoSo", x => x.IdPhanLoaiCoSo);
                });

            migrationBuilder.CreateTable(
                name: "dmPhanLoaiCSVC",
                schema: "DM",
                columns: table => new
                {
                    IdPhanLoaiCSVC = table.Column<int>(type: "int", nullable: false),
                    PhanLoaiCSVC = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmPhanLoaiCSVC", x => x.IdPhanLoaiCSVC);
                });

            migrationBuilder.CreateTable(
                name: "dmPhanLoaiDoanRaDoanVao",
                schema: "DM",
                columns: table => new
                {
                    IdPhanLoaiDoanRaDoanVao = table.Column<int>(type: "int", nullable: false),
                    PhanLoaiDoanRaDoanVao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmPhanLoaiDoanRaDoanVao", x => x.IdPhanLoaiDoanRaDoanVao);
                });

            migrationBuilder.CreateTable(
                name: "dmPhanLoaiDoiNguNguoiHoc",
                schema: "DM",
                columns: table => new
                {
                    IdPhanLoaiDoiNguNguoiHoc = table.Column<int>(type: "int", nullable: false),
                    PhanLoaiDoiNguNguoiHoc = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmPhanLoaiDoiNguNguoiHoc", x => x.IdPhanLoaiDoiNguNguoiHoc);
                });

            migrationBuilder.CreateTable(
                name: "dmPhanLoaiDoiTuong",
                schema: "DM",
                columns: table => new
                {
                    IdPhanLoaiDoiTuong = table.Column<int>(type: "int", nullable: false),
                    PhanLoaiDoiTuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmPhanLoaiDoiTuong", x => x.IdPhanLoaiDoiTuong);
                });

            migrationBuilder.CreateTable(
                name: "dmPhanLoaiHoiNghiHoiThao",
                schema: "DM",
                columns: table => new
                {
                    IdPhanLoaiHoiNghiHoiThao = table.Column<int>(type: "int", nullable: false),
                    PhanLoaiHoiNghiHoiThao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmPhanLoaiHoiNghiHoiThao", x => x.IdPhanLoaiHoiNghiHoiThao);
                });

            migrationBuilder.CreateTable(
                name: "dmPhanLoaiThuChi",
                schema: "DM",
                columns: table => new
                {
                    IdPhanLoaiThuChi = table.Column<int>(type: "int", nullable: false),
                    PhanLoaiThuChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmPhanLoaiThuChi", x => x.IdPhanLoaiThuChi);
                });

            migrationBuilder.CreateTable(
                name: "dmPhuongThucKhenThuong",
                schema: "DM",
                columns: table => new
                {
                    IdPhuongThucKhenThuong = table.Column<int>(type: "int", nullable: false),
                    PhuongThucKhenThuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmHinhThucKhenThuong", x => x.IdPhuongThucKhenThuong);
                });

            migrationBuilder.CreateTable(
                name: "dmQuanHam",
                schema: "DM",
                columns: table => new
                {
                    IdQuanHam = table.Column<int>(type: "int", nullable: false),
                    QuanHam = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmQuanHam", x => x.IdQuanHam);
                });

            migrationBuilder.CreateTable(
                name: "dmQuocTich",
                schema: "DM",
                columns: table => new
                {
                    IdQuocTich = table.Column<int>(type: "int", nullable: false),
                    TenNuoc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbQuocTich", x => x.IdQuocTich);
                });

            migrationBuilder.CreateTable(
                name: "dmQuyetDinhTuChu",
                schema: "DM",
                columns: table => new
                {
                    IdQuyetDinhTuChu = table.Column<int>(type: "int", nullable: false),
                    QuyetDinhTuChu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmQuyetDinhTuChu", x => x.IdQuyetDinhTuChu);
                });

            migrationBuilder.CreateTable(
                name: "dmSangCheGiaiPhap",
                schema: "DM",
                columns: table => new
                {
                    IdSangCheGiaiPhap = table.Column<int>(type: "int", nullable: false),
                    TenLoaiGiaiPhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmSangCheGiaiPhap", x => x.IdSangCheGiaiPhap);
                });

            migrationBuilder.CreateTable(
                name: "dmSinhVienNam",
                schema: "DM",
                columns: table => new
                {
                    IdSinhVienNam = table.Column<int>(type: "int", nullable: false),
                    SinhVienNam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmSinhVienNam", x => x.IdSinhVienNam);
                });

            migrationBuilder.CreateTable(
                name: "dmTapChiKhoaHocQuocTe",
                schema: "DM",
                columns: table => new
                {
                    IdTapChiKhoaHocQuocTe = table.Column<int>(type: "int", nullable: false),
                    TapChiKhoaHocQuocTe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTapChiKhoaHocQuocTe", x => x.IdTapChiKhoaHocQuocTe);
                });

            migrationBuilder.CreateTable(
                name: "dmTapChiTrongNuoc",
                schema: "DM",
                columns: table => new
                {
                    IdTapChiTrongNuoc = table.Column<int>(type: "int", nullable: false),
                    TapChiTrongNuoc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTapChiTrongNuoc", x => x.IdTapChiTrongNuoc);
                });

            migrationBuilder.CreateTable(
                name: "dmThiDuaGiaiThuongKhenThuong",
                schema: "DM",
                columns: table => new
                {
                    IdThiDuaGiaiThuongKhenThuong = table.Column<int>(type: "int", nullable: false),
                    ThiDuaGiaiThuongKhenThuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmThiDuaGiaiThuongKhenThuong", x => x.IdThiDuaGiaiThuongKhenThuong);
                });

            migrationBuilder.CreateTable(
                name: "dmTiengDanToc",
                schema: "DM",
                columns: table => new
                {
                    IdTiengDanToc = table.Column<int>(type: "int", nullable: false),
                    TiengDanToc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTiengDanToc", x => x.IdTiengDanToc);
                });

            migrationBuilder.CreateTable(
                name: "dmTinh",
                schema: "DM",
                columns: table => new
                {
                    IdTinh = table.Column<int>(type: "int", nullable: false),
                    TenTinh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTinh", x => x.IdTinh);
                });

            migrationBuilder.CreateTable(
                name: "dmTinhTrangCoSoVatChat",
                schema: "DM",
                columns: table => new
                {
                    IdTinhTrangCoSoVatChat = table.Column<int>(type: "int", nullable: false),
                    TinhTrangCoSoVatChat = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTinhTrangCoSoVatChat", x => x.IdTinhTrangCoSoVatChat);
                });

            migrationBuilder.CreateTable(
                name: "dmTinhTrangGiangVienDuocCuDiDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdTinhTrangGiangVienDuocCuDiDaoTao = table.Column<int>(type: "int", nullable: false),
                    TinhTrangGiangVienDuocCuDiDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTinhTrangGiangVienDuocCuDiDaoTao", x => x.IdTinhTrangGiangVienDuocCuDiDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmTinhTrangHopDong",
                schema: "DM",
                columns: table => new
                {
                    IdTinhTrangHopDong = table.Column<int>(type: "int", nullable: false),
                    TinhTrangHopDong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTinhTrangHopDong", x => x.IdTinhTrangHopDong);
                });

            migrationBuilder.CreateTable(
                name: "dmTinhTrangNhiemVu",
                schema: "DM",
                columns: table => new
                {
                    IdTinhTrangNhiemVu = table.Column<int>(type: "int", nullable: false),
                    TinhTrangNhiemVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTinhTrangNhiemVu", x => x.IdTinhTrangNhiemVu);
                });

            migrationBuilder.CreateTable(
                name: "dmTinhTrangThietBi",
                schema: "DM",
                columns: table => new
                {
                    IdTinhTrangThietBi = table.Column<int>(type: "int", nullable: false),
                    TinhTrangThietBi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTinhTrangThietBi", x => x.IdTinhTrangThietBi);
                });

            migrationBuilder.CreateTable(
                name: "dmToChucKiemDinh",
                schema: "DM",
                columns: table => new
                {
                    IdToChucKiemDinh = table.Column<int>(type: "int", nullable: false),
                    ToChucKiemDinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbToChucKiemDinh", x => x.IdToChucKiemDinh);
                });

            migrationBuilder.CreateTable(
                name: "dmTonGiao",
                schema: "DM",
                columns: table => new
                {
                    IdTonGiao = table.Column<int>(type: "int", nullable: false),
                    TonGiao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTonGiao", x => x.IdTonGiao);
                });

            migrationBuilder.CreateTable(
                name: "dmTrangThaiCanBo",
                schema: "DM",
                columns: table => new
                {
                    IdTrangThaiCanBo = table.Column<int>(type: "int", nullable: false),
                    TrangThaiCanBo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrangThaiCanBo", x => x.IdTrangThaiCanBo);
                });

            migrationBuilder.CreateTable(
                name: "dmTrangThaiChuongTrinhDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdTrangThaiChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: false),
                    TrangThaiChuongTrinhDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrangThaiChuongTrinhDaoTao", x => x.IdTrangThaiChuongTrinhDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmTrangThaiCoSoGD",
                schema: "DM",
                columns: table => new
                {
                    IdTrangThaiCoSoGD = table.Column<int>(type: "int", nullable: false),
                    TrangThaiCoSoGD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrangThaiCoSoGD", x => x.IdTrangThaiCoSoGD);
                });

            migrationBuilder.CreateTable(
                name: "dmTrangThaiDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdTrangThaiDaoTao = table.Column<int>(type: "int", nullable: false),
                    TrangThaiDaoTao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrangThaiDaoTao", x => x.IdTrangThaiDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmTrangThaiHoc",
                schema: "DM",
                columns: table => new
                {
                    IdTrangThaiHoc = table.Column<int>(type: "int", nullable: false),
                    TrangThaiHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrangThaiHoc", x => x.IdTrangThaiHoc);
                });

            migrationBuilder.CreateTable(
                name: "dmTrangThaiHopDong",
                schema: "DM",
                columns: table => new
                {
                    IdTrangThaiHopDong = table.Column<int>(type: "int", nullable: false),
                    TrangThaiHopDong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrangThaiHopDong", x => x.IdTrangThaiHopDong);
                });

            migrationBuilder.CreateTable(
                name: "dmTrangThaiThucHien",
                schema: "DM",
                columns: table => new
                {
                    IdTrangThaiThucHien = table.Column<int>(type: "int", nullable: false),
                    TrangThaiThucHien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrangThaiThucHien", x => x.IdTrangThaiThucHien);
                });

            migrationBuilder.CreateTable(
                name: "dmTrinhDo",
                schema: "DM",
                columns: table => new
                {
                    IdTrinhDo = table.Column<int>(type: "int", nullable: false),
                    TrinhDo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrinhDo", x => x.IdTrinhDo);
                });

            migrationBuilder.CreateTable(
                name: "dmTrinhDoDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdTrinhDoDaoTao = table.Column<int>(type: "int", nullable: false),
                    TrinhDoDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrinhDoDaoTao", x => x.IdTrinhDoDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "dmTrinhDoLyLuanChinhTri",
                schema: "DM",
                columns: table => new
                {
                    IdTrinhDoLyLuanChinhTri = table.Column<int>(type: "int", nullable: false),
                    TenTrinhDoLyLuanChinhTri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrinhDoLyLuanChinhTri", x => x.IdTrinhDoLyLuanChinhTri);
                });

            migrationBuilder.CreateTable(
                name: "dmTrinhDoQuanLyNhaNuoc",
                schema: "DM",
                columns: table => new
                {
                    IdTrinhDoQuanLyNhaNuoc = table.Column<int>(type: "int", nullable: false),
                    TrinhDoQuanLyNhaNuoc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrinhDoQuanLyNhaNuoc", x => x.IdTrinhDoQuanLyNhaNuoc);
                });

            migrationBuilder.CreateTable(
                name: "dmTrinhDoTinHoc",
                schema: "DM",
                columns: table => new
                {
                    IdTrinhDoTinHoc = table.Column<int>(type: "int", nullable: false),
                    TrinhDoTinHoc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTrinhDoTinHoc", x => x.IdTrinhDoTinHoc);
                });

            migrationBuilder.CreateTable(
                name: "dmTuChuMoNganh",
                schema: "DM",
                columns: table => new
                {
                    IdTuChuMoNganh = table.Column<int>(type: "int", nullable: false),
                    TuChuMoNganh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTuChuMoNganh", x => x.IdTuChuMoNganh);
                });

            migrationBuilder.CreateTable(
                name: "dmTuyChon",
                schema: "DM",
                columns: table => new
                {
                    IdTuyChon = table.Column<int>(type: "int", nullable: false),
                    TuyChon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmTuyChon", x => x.IdTuyChon);
                });

            migrationBuilder.CreateTable(
                name: "dmVaiTroThamGia",
                schema: "DM",
                columns: table => new
                {
                    IdVaiTroThamGia = table.Column<int>(type: "int", nullable: false),
                    VaiTroThamGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmVaiTroThamGia", x => x.IdVaiTroThamGia);
                });

            migrationBuilder.CreateTable(
                name: "dmViTriViecLam",
                schema: "DM",
                columns: table => new
                {
                    IdViTriViecLam = table.Column<int>(type: "int", nullable: false),
                    ViTriViecLam = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmViTriViecLam", x => x.IdViTriViecLam);
                });

            migrationBuilder.CreateTable(
                name: "dmXepHangQ",
                schema: "DM",
                columns: table => new
                {
                    IdXepHangQ = table.Column<int>(type: "int", nullable: false),
                    XepHangQ = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmXepHangQ", x => x.IdXepHangQ);
                });

            migrationBuilder.CreateTable(
                name: "NganhDungTenGiangDay",
                columns: table => new
                {
                    IdNganhGiangDay = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdNganhDaoTao = table.Column<int>(type: "int", nullable: true),
                    TrongSo = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NganhDungTenGiangDay", x => x.IdNganhGiangDay);
                });

            migrationBuilder.CreateTable(
                name: "tbKhoaHoc",
                schema: "CSGD",
                columns: table => new
                {
                    IdKhoaHoc = table.Column<int>(type: "int", nullable: false),
                    TuNam = table.Column<string>(type: "text", nullable: true),
                    DenNam = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbKhoaHoc", x => x.IdKhoaHoc);
                });

            migrationBuilder.CreateTable(
                name: "tbKhoanNopNganSach",
                schema: "TCTS",
                columns: table => new
                {
                    IdKhoanNopNganSach = table.Column<int>(type: "int", nullable: false),
                    MaKhoanNop = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenKhoanNopNganSach = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoTien = table.Column<int>(type: "int", nullable: true),
                    NamTaiChinh = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbKhoanNopNganSach", x => x.IdKhoanNopNganSach);
                });

            migrationBuilder.CreateTable(
                name: "tbKhoanTrichLapQuy",
                schema: "TCTS",
                columns: table => new
                {
                    IdKhoanTrichLapQuy = table.Column<int>(type: "int", nullable: false),
                    MaKhoanTrichLapQuy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenKhoanTrichLapQuy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NamTaiChinh = table.Column<string>(type: "text", nullable: true),
                    SoTien = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbKhoanTrichLapQuy", x => x.IdKhoanTrichLapQuy);
                });

            migrationBuilder.CreateTable(
                name: "tbKhoiNganhDaoTao",
                schema: "NDT",
                columns: table => new
                {
                    IdKhoiNganhDaoTao = table.Column<int>(type: "int", nullable: false),
                    KhoiNganhDaoTao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmKhoiNganh", x => x.IdKhoiNganhDaoTao);
                });

            migrationBuilder.CreateTable(
                name: "tbLichSuDoiTenTruong",
                schema: "CSGD",
                columns: table => new
                {
                    IdLichSuDoiTenTruong = table.Column<int>(type: "int", nullable: false),
                    TenTruongCu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TenTruongCuTiengAnh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoQuyetDinhDoiTen = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayKyQuyetDinhDoiTen = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLichSuDoiTenTruong", x => x.IdLichSuDoiTenTruong);
                });

            migrationBuilder.CreateTable(
                name: "tbNhomNghienCuuManh",
                schema: "KHCN",
                columns: table => new
                {
                    IdNhomNghienCuuManh = table.Column<int>(type: "int", nullable: false),
                    MaNhomNghienCuuManh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenNhomNghienCuuManh = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    SoQuyetDinhThanhLap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ToChucBanHanhQuyetDinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayQuyetDinh = table.Column<DateOnly>(type: "date", nullable: true),
                    CacNhiemVuNCKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TomTatKetQuaDatDuoc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNhomNghienCuuManh", x => x.IdNhomNghienCuuManh);
                });

            migrationBuilder.CreateTable(
                name: "tbTaiSanDonVi",
                schema: "TCTS",
                columns: table => new
                {
                    IdTaiSanDonVi = table.Column<int>(type: "int", nullable: false),
                    MaLoaiTaiSan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenLoaiTaiSan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MoTa = table.Column<string>(type: "text", nullable: true),
                    NamTaiChinh = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTaiSanDonVi", x => x.IdTaiSanDonVi);
                });

            migrationBuilder.CreateTable(
                name: "TbUser",
                schema: "PQuyen",
                columns: table => new
                {
                    IdNguoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPhong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUser", x => x.IdNguoi);
                });

            migrationBuilder.CreateTable(
                name: "tbVanBanTuChu",
                schema: "CSGD",
                columns: table => new
                {
                    IdVanBanTuChu = table.Column<int>(type: "int", nullable: false),
                    LoaiVanBan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NoiDungVanBan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuyetDinhBanHanh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CoQuanQuyetDinhBanHanh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbVanBanTuChu", x => x.IdVanBanTuChu);
                });

            migrationBuilder.CreateTable(
                name: "tbDauMoiLienHe",
                schema: "CSGD",
                columns: table => new
                {
                    IdDauMoiLienHe = table.Column<int>(type: "int", nullable: false),
                    IdLoaiDauMoiLienHe = table.Column<int>(type: "int", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDauMoiLienHe", x => x.IdDauMoiLienHe);
                    table.ForeignKey(
                        name: "FK_tbDauMoiLienHe_dmDauMoiLienHe",
                        column: x => x.IdLoaiDauMoiLienHe,
                        principalSchema: "DM",
                        principalTable: "dmDauMoiLienHe",
                        principalColumn: "IdDauMoiLienHe");
                });

            migrationBuilder.CreateTable(
                name: "tbDoanhNghiepKHCN",
                schema: "KHCN",
                columns: table => new
                {
                    IdDoanhNghiepKHCN = table.Column<int>(type: "int", nullable: false),
                    MaDoanhNghiep = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenDoanhNghiep = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IdHinhThucDoanhNghiepKHCN = table.Column<int>(type: "int", nullable: true),
                    DiaDiemThanhLap = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    QuyMoDauTu = table.Column<int>(type: "int", nullable: true),
                    KinhPhiGopVonTuTaiSanTriTue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TyLeGopVonCuaCSGDDH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDoanhNghiepKHCN", x => x.IdDoanhNghiepKHCN);
                    table.ForeignKey(
                        name: "FK_tbDoanhNghiepKHCN_dmHinhThucDoanhNghiepKHCN",
                        column: x => x.IdHinhThucDoanhNghiepKHCN,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucDoanhNghiepKHCN",
                        principalColumn: "IdHinhThucDoanhNghiepKHCN");
                });

            migrationBuilder.CreateTable(
                name: "tbDatDai",
                schema: "CSVC",
                columns: table => new
                {
                    IdDatDai = table.Column<int>(type: "int", nullable: false),
                    MaGiayChungNhanQuyenSoHuu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DienTichDat = table.Column<double>(type: "float", nullable: true),
                    IdHinhThucSoHuu = table.Column<int>(type: "int", nullable: true),
                    TenDonViSoHuu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MinhChungQuyenSoHuuDatDai = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MucDichSuDungDat = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ThoiGianSuDungDat = table.Column<int>(type: "int", nullable: true),
                    DienTichDatDaSuDung = table.Column<double>(type: "float", nullable: true),
                    NamBatDauSuDungDat = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDatDai", x => x.IdDatDai);
                    table.ForeignKey(
                        name: "FK_tbDatDai_dmHinhThucSoHuu",
                        column: x => x.IdHinhThucSoHuu,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucSoHuu",
                        principalColumn: "IdHinhThucSoHuu");
                });

            migrationBuilder.CreateTable(
                name: "tbHoatDongTaiChinh",
                schema: "TCTS",
                columns: table => new
                {
                    IdHoatDongTaiChinh = table.Column<int>(type: "int", nullable: false),
                    IdLoaiHoatDongTaiChinh = table.Column<int>(type: "int", nullable: true),
                    NamTaiChinh = table.Column<string>(type: "text", nullable: true),
                    KinhPhi = table.Column<int>(type: "int", nullable: true),
                    NoiDung = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHoatDongTaiChinh", x => x.IdHoatDongTaiChinh);
                    table.ForeignKey(
                        name: "FK_tbHoatDongTaiChinh_dmHoatDongTaiChinh",
                        column: x => x.IdLoaiHoatDongTaiChinh,
                        principalSchema: "DM",
                        principalTable: "dmHoatDongTaiChinh",
                        principalColumn: "IdHoatDongTaiChinh");
                });

            migrationBuilder.CreateTable(
                name: "tbDuLieuTrungTuyen",
                schema: "TS",
                columns: table => new
                {
                    IdDuLieuTrungTuyen = table.Column<int>(type: "int", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HoVaTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaTuyenSinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KhoaDaoTaoTrungTuyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdDoiTuongDauVao = table.Column<int>(type: "int", nullable: true),
                    IdDoiTuongUuTien = table.Column<int>(type: "int", nullable: true),
                    IdHinhThucTuyenSinh = table.Column<int>(type: "int", nullable: true),
                    IdKhuVuc = table.Column<int>(type: "int", nullable: true),
                    TruongTHPT = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ToHopMonTrungTuyen = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DiemMon1 = table.Column<double>(type: "float", nullable: true),
                    DiemMon2 = table.Column<double>(type: "float", nullable: true),
                    DiemMon3 = table.Column<double>(type: "float", nullable: true),
                    DiemUuTien = table.Column<double>(type: "float", nullable: true),
                    TongDiemXetTuyen = table.Column<double>(type: "float", nullable: true),
                    SoQuyetDinhTrungTuyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayBanHanhQuyetDinhTrungTuyen = table.Column<DateOnly>(type: "date", nullable: true),
                    ChuongTrinhDaoTaoDaTotNghiepTrinhDoDaiHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NganhDaTotNghiepTrinhDoDaiHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChuongTrinhDaoTaoDaTotNghiepTrinhDoThacSi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NganhDaTotNghiepTrinhDoThacSi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDuLieuTrungTuyen", x => x.IdDuLieuTrungTuyen);
                    table.ForeignKey(
                        name: "FK_tbDuLieuTrungTuyen_dmDoiTuongDauVao",
                        column: x => x.IdDoiTuongDauVao,
                        principalSchema: "DM",
                        principalTable: "dmDoiTuongDauVao",
                        principalColumn: "IdDoiTuongDauVao");
                    table.ForeignKey(
                        name: "FK_tbDuLieuTrungTuyen_dmDoiTuongUuTien",
                        column: x => x.IdDoiTuongUuTien,
                        principalSchema: "DM",
                        principalTable: "dmDoiTuongUuTien",
                        principalColumn: "IdDoiTuongUuTien");
                    table.ForeignKey(
                        name: "FK_tbDuLieuTrungTuyen_dmHinhThucTuyenSinh",
                        column: x => x.IdHinhThucTuyenSinh,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucTuyenSinh",
                        principalColumn: "IdHinhThucTuyenSinh");
                    table.ForeignKey(
                        name: "FK_tbDuLieuTrungTuyen_dmKhuVuc",
                        column: x => x.IdKhuVuc,
                        principalSchema: "DM",
                        principalTable: "dmKhuVuc",
                        principalColumn: "IdKhuVuc");
                });

            migrationBuilder.CreateTable(
                name: "tbToChucHopTacDoanhNghiep",
                schema: "HTDN",
                columns: table => new
                {
                    IdToChucHopTacDoanhNghiep = table.Column<int>(type: "int", nullable: false),
                    MaToChucHopTacDoanhNghiep = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenToChucHopTacDoanhNghiep = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NoiDungHopTac = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayKyKet = table.Column<DateOnly>(type: "date", nullable: true),
                    KetQuaHopTac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdLoaiDeAn = table.Column<int>(type: "int", nullable: true),
                    GiaTriGiaoDichCuaThiTruong = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbToChucHopTacDoanhNghiep", x => x.IdToChucHopTacDoanhNghiep);
                    table.ForeignKey(
                        name: "FK_tbToChucHopTacDoanhNghiep_dmLoaiDeAnChuongTrinh",
                        column: x => x.IdLoaiDeAn,
                        principalSchema: "DM",
                        principalTable: "dmLoaiDeAnChuongTrinh",
                        principalColumn: "IdLoaiDeAnChuongTrinh");
                });

            migrationBuilder.CreateTable(
                name: "tbGiaiThuongKhoaHoc",
                schema: "KHCN",
                columns: table => new
                {
                    IdGiaiThuongKhoaHoc = table.Column<int>(type: "int", nullable: false),
                    MaGiaiThuong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdLoaiGiaiThuong = table.Column<int>(type: "int", nullable: true),
                    CoQuanToChucGiaiThuong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenDeTaiDuocTraoGiai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenDonViDuocTraoGiai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdMucGiaiThuong = table.Column<int>(type: "int", nullable: true),
                    QuyetDinhCapBangKhen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CoQuanBanHanhQuyetDinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbGiaiThuongKhoaHoc", x => x.IdGiaiThuongKhoaHoc);
                    table.ForeignKey(
                        name: "FK_tbGiaiThuongKhoaHoc_dmLoaiGiaiThuongKHCN",
                        column: x => x.IdLoaiGiaiThuong,
                        principalSchema: "DM",
                        principalTable: "dmLoaiGiaiThuongKHCN",
                        principalColumn: "IdLoaiGiaiThuongKHCN");
                    table.ForeignKey(
                        name: "FK_tbGiaiThuongKhoaHoc_dmMucGiaiThuong",
                        column: x => x.IdMucGiaiThuong,
                        principalSchema: "DM",
                        principalTable: "dmMucGiaiThuong",
                        principalColumn: "IdMucGiaiThuong");
                });

            migrationBuilder.CreateTable(
                name: "tbChiTieuTuyenSinhTheoNganh",
                schema: "TS",
                columns: table => new
                {
                    IdChiTieuTuyenSinhTheoNganh = table.Column<int>(type: "int", nullable: false),
                    IdLoaiHinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdNganhDaoTao = table.Column<int>(type: "int", nullable: true),
                    Nam = table.Column<string>(type: "text", nullable: true),
                    ChiTieu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbChiTieuTuyenSinhTheoNganh", x => x.IdChiTieuTuyenSinhTheoNganh);
                    table.ForeignKey(
                        name: "FK_tbChiTieuTuyenSinhTheoNganh_dmLoaiHinhDaoTao",
                        column: x => x.IdLoaiHinhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLoaiHinhDaoTao",
                        principalColumn: "IdLoaiHinhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbChiTieuTuyenSinhTheoNganh_dmNganhDaoTao",
                        column: x => x.IdNganhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmNganhDaoTao",
                        principalColumn: "IdNganhDaoTao");
                });

            migrationBuilder.CreateTable(
                name: "tbHinhThucDaoTaoCuaNganh",
                schema: "NDT",
                columns: table => new
                {
                    IdHinhThucDaoTaoCuaNganh = table.Column<int>(type: "int", nullable: false),
                    IdNganhDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdHinhThucDaoTao = table.Column<int>(type: "int", nullable: true),
                    SoNamDaoTao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHinhThucDaoTaoCuaNganh", x => x.IdHinhThucDaoTaoCuaNganh);
                    table.ForeignKey(
                        name: "FK_tbHinhThucDaoTaoCuaNganh_dmHinhThucDaoTao",
                        column: x => x.IdHinhThucDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucDaoTao",
                        principalColumn: "IdHinhThucDaoTao");
                    table.ForeignKey(
                        name: "FK_tbHinhThucDaoTaoCuaNganh_dmNganhDaoTao",
                        column: x => x.IdNganhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmNganhDaoTao",
                        principalColumn: "IdNganhDaoTao");
                });

            migrationBuilder.CreateTable(
                name: "tbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh",
                schema: "NDT",
                columns: table => new
                {
                    IdLoaiHinhDaoTaoKhacDuocChoPhepMoNganh = table.Column<int>(type: "int", nullable: false),
                    IdNganhDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdLoaiHinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhChoPhep = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayBanHanhQuyetDinhChoPhep = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh", x => x.IdLoaiHinhDaoTaoKhacDuocChoPhepMoNganh);
                    table.ForeignKey(
                        name: "FK_tbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh_dmLoaiHinhDaoTao",
                        column: x => x.IdLoaiHinhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLoaiHinhDaoTao",
                        principalColumn: "IdLoaiHinhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh_dmNganhDaoTao",
                        column: x => x.IdNganhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmNganhDaoTao",
                        principalColumn: "IdNganhDaoTao");
                });

            migrationBuilder.CreateTable(
                name: "tbHoiThaoHoiNghi",
                schema: "HTQT",
                columns: table => new
                {
                    IdHoiThaoHoiNghi = table.Column<int>(type: "int", nullable: false),
                    MaHoiThaoHoiNghi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenHoiThaoHoiNghi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CoQuanCoThamQuyenCapPhep = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MucTieu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongDaiBieuThamDu = table.Column<int>(type: "int", nullable: true),
                    SoLuongDaiBieuQuocTeThamDu = table.Column<int>(type: "int", nullable: true),
                    ThoiGianToChuc = table.Column<DateOnly>(type: "date", nullable: true),
                    DiaDiemToChuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNguonKinhPhiHoiThao = table.Column<int>(type: "int", nullable: true),
                    DonViChuTri = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHoiThaoHoiNghi", x => x.IdHoiThaoHoiNghi);
                    table.ForeignKey(
                        name: "FK_tbHoiThaoHoiNghi_dmNguonKinhPhi",
                        column: x => x.IdNguonKinhPhiHoiThao,
                        principalSchema: "DM",
                        principalTable: "dmNguonKinhPhi",
                        principalColumn: "IdNguonKinhPhi");
                });

            migrationBuilder.CreateTable(
                name: "tbDeAnDuAnChuongTrinh",
                schema: "HTQT",
                columns: table => new
                {
                    IdDeAnDuAnChuongTrinh = table.Column<int>(type: "int", nullable: false),
                    MaDeAnDuAnChuongTrinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenDeAnDuAnChuongTrinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NoiDungTomTat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucTieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianHopTacTu = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiGianHopTacDen = table.Column<DateOnly>(type: "date", nullable: true),
                    TongKinhPhi = table.Column<double>(type: "float", nullable: true),
                    IdNguonKinhPhiDeAnDuAnChuongTrinh = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDeAnDuAnChuongTrinh", x => x.IdDeAnDuAnChuongTrinh);
                    table.ForeignKey(
                        name: "FK_tbDeAnDuAnChuongTrinh_dmNguonKinhPhiChoDeAn",
                        column: x => x.IdNguonKinhPhiDeAnDuAnChuongTrinh,
                        principalSchema: "DM",
                        principalTable: "dmNguonKinhPhiChoDeAn",
                        principalColumn: "IdNguonKinhPhiChoDeAn");
                });

            migrationBuilder.CreateTable(
                name: "tbLuuHocSinhSinhVienNN",
                schema: "HTQT",
                columns: table => new
                {
                    IdLuuHocSinhSinhVienNN = table.Column<int>(type: "int", nullable: false),
                    IdNguoiHoc = table.Column<int>(type: "int", nullable: true),
                    IdNguonKinhPhiLuuHocSinh = table.Column<int>(type: "int", nullable: true),
                    IdLoaiLuuHocSinh = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLuuHocSinhSinhVienNN", x => x.IdLuuHocSinhSinhVienNN);
                    table.ForeignKey(
                        name: "FK_tbLuuHocSinhSinhVienNN_dmLoaiLuuHocSinh",
                        column: x => x.IdLoaiLuuHocSinh,
                        principalSchema: "DM",
                        principalTable: "dmLoaiLuuHocSinh",
                        principalColumn: "IdLoaiLuuHocSinh");
                    table.ForeignKey(
                        name: "FK_tbLuuHocSinhSinhVienNN_dmNguonKinhPhiChoLuuHocSinh",
                        column: x => x.IdNguonKinhPhiLuuHocSinh,
                        principalSchema: "DM",
                        principalTable: "dmNguonKinhPhiChoLuuHocSinh",
                        principalColumn: "IdNguonKinhPhiChoLuuHocSinh");
                });

            migrationBuilder.CreateTable(
                name: "dmLinhVucNhomNganh",
                schema: "DM",
                columns: table => new
                {
                    IdLinhVucNhomNganh = table.Column<int>(type: "int", nullable: false),
                    IdLinhVucDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdNhomNganh = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLinhVucNhomNganh", x => x.IdLinhVucNhomNganh);
                    table.ForeignKey(
                        name: "FK_dmLinhVucNhomNganh_dmLinhVucDaoTao",
                        column: x => x.IdLinhVucDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLinhVucDaoTao",
                        principalColumn: "IdLinhVucDaoTao");
                    table.ForeignKey(
                        name: "FK_dmLinhVucNhomNganh_dmNhomNganh",
                        column: x => x.IdNhomNganh,
                        principalSchema: "DM",
                        principalTable: "dmNhomNganh",
                        principalColumn: "IdNhomNganh");
                });

            migrationBuilder.CreateTable(
                name: "tbNhomNganhDaoTao",
                schema: "NDT",
                columns: table => new
                {
                    IdNhomNganhDaoTao = table.Column<int>(type: "int", nullable: false),
                    IdLinhVucDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdNganhDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdNhomNganh = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmLinhVucNganhDaoTaoNhomNganh", x => x.IdNhomNganhDaoTao);
                    table.ForeignKey(
                        name: "FK_dmLinhVucNganhDaoTaoNhomNganh_dmLinhVucDaoTao",
                        column: x => x.IdLinhVucDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLinhVucDaoTao",
                        principalColumn: "IdLinhVucDaoTao");
                    table.ForeignKey(
                        name: "FK_dmLinhVucNganhDaoTaoNhomNganh_dmNganhDaoTao",
                        column: x => x.IdNganhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmNganhDaoTao",
                        principalColumn: "IdNganhDaoTao");
                    table.ForeignKey(
                        name: "FK_dmLinhVucNganhDaoTaoNhomNganh_dmNhomNganh",
                        column: x => x.IdNhomNganh,
                        principalSchema: "DM",
                        principalTable: "dmNhomNganh",
                        principalColumn: "IdNhomNganh");
                });

            migrationBuilder.CreateTable(
                name: "tbLoaiThuChi",
                schema: "TCTS",
                columns: table => new
                {
                    IdLoaiThuChi = table.Column<int>(type: "int", nullable: false),
                    MaLoaiThuChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdPhanLoaiThuChi = table.Column<int>(type: "int", nullable: true),
                    TenLoaiThuChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MoTa = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLoaiThuChi", x => x.IdLoaiThuChi);
                    table.ForeignKey(
                        name: "FK_tbLoaiThuChi_dmPhanLoaiThuChi",
                        column: x => x.IdPhanLoaiThuChi,
                        principalSchema: "DM",
                        principalTable: "dmPhanLoaiThuChi",
                        principalColumn: "IdPhanLoaiThuChi");
                });

            migrationBuilder.CreateTable(
                name: "tbDoanCongTac",
                schema: "HTQT",
                columns: table => new
                {
                    IdDoanCongTac = table.Column<int>(type: "int", nullable: false),
                    MaDoanCongTac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdPhanLoaiDoanRaDoanVao = table.Column<int>(type: "int", nullable: true),
                    TenDoanCongTac = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoQuyetDinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayQuyetDinh = table.Column<DateOnly>(type: "date", nullable: true),
                    IdQuocGiaDoan = table.Column<int>(type: "int", nullable: true),
                    ThoiGianBatDau = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiGianketThuc = table.Column<DateOnly>(type: "date", nullable: true),
                    MucDichCongTac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KetQuaCongTac = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDoanCongTac", x => x.IdDoanCongTac);
                    table.ForeignKey(
                        name: "FK_tbDoanCongTac_dmPhanLoaiDoanRaDoanVao",
                        column: x => x.IdPhanLoaiDoanRaDoanVao,
                        principalSchema: "DM",
                        principalTable: "dmPhanLoaiDoanRaDoanVao",
                        principalColumn: "IdPhanLoaiDoanRaDoanVao");
                    table.ForeignKey(
                        name: "FK_tbDoanCongTac_dmQuocTich",
                        column: x => x.IdQuocGiaDoan,
                        principalSchema: "DM",
                        principalTable: "dmQuocTich",
                        principalColumn: "IdQuocTich");
                });

            migrationBuilder.CreateTable(
                name: "tbThoaThuanHopTacQuocTe",
                schema: "HTQT",
                columns: table => new
                {
                    IdThoaThuanHopTacQuocTe = table.Column<int>(type: "int", nullable: false),
                    MaThoaThuan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenThoaThuan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NoiDungTomTat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenToChuc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayKyKet = table.Column<DateOnly>(type: "date", nullable: true),
                    SoVanBanKyKet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdQuocGia = table.Column<int>(type: "int", nullable: true),
                    NgayHetHan = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_tbThoaThuanHopTacQuocTe_dmQuocTich",
                        column: x => x.IdQuocGia,
                        principalSchema: "DM",
                        principalTable: "dmQuocTich",
                        principalColumn: "IdQuocTich");
                });

            migrationBuilder.CreateTable(
                name: "tbToChucHopTacQuocTe",
                schema: "HTQT",
                columns: table => new
                {
                    IdToChucHopTacQuocTe = table.Column<int>(type: "int", nullable: false),
                    MaHopTac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenToChuc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdQuocGia = table.Column<int>(type: "int", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianKyKet = table.Column<DateOnly>(type: "date", nullable: true),
                    KetQuaHopTac = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LoaiToChuc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbToChucHopTacQuocTe", x => x.IdToChucHopTacQuocTe);
                    table.ForeignKey(
                        name: "FK_tbToChucHopTacQuocTe_dmQuocTich",
                        column: x => x.IdQuocGia,
                        principalSchema: "DM",
                        principalTable: "dmQuocTich",
                        principalColumn: "IdQuocTich");
                });

            migrationBuilder.CreateTable(
                name: "tbTapChiKhoaHoc",
                schema: "KHCN",
                columns: table => new
                {
                    IdTapChiKhoaHoc = table.Column<int>(type: "int", nullable: false),
                    MaTapChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenTapChiTiengViet = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    TenTapChiTiengAnh = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    MaChuanISSN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdLinhVucXuatBan = table.Column<int>(type: "int", nullable: true),
                    IdXepLoaiTapChi = table.Column<int>(type: "int", nullable: true),
                    SoBaiBao1Nam = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTapChiKhoaHoc", x => x.IdTapChiKhoaHoc);
                    table.ForeignKey(
                        name: "FK_tbTapChiKhoaHoc_dmLinhVucNghienCuu",
                        column: x => x.IdLinhVucXuatBan,
                        principalSchema: "DM",
                        principalTable: "dmLinhVucNghienCuu",
                        principalColumn: "IdLinhVucNghienCuu");
                    table.ForeignKey(
                        name: "FK_tbTapChiKhoaHoc_dmTapChiTrongNuoc",
                        column: x => x.IdXepLoaiTapChi,
                        principalSchema: "DM",
                        principalTable: "dmTapChiTrongNuoc",
                        principalColumn: "IdTapChiTrongNuoc");
                });

            migrationBuilder.CreateTable(
                name: "tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD",
                schema: "CSGD",
                columns: table => new
                {
                    IdDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD = table.Column<int>(type: "int", nullable: false),
                    IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong = table.Column<int>(type: "int", nullable: true),
                    IdDanhHieuThiDuaGiaiThuongKhenThuong = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhKhenThuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdPhuongThucKhenThuong = table.Column<int>(type: "int", nullable: true),
                    NamKhenThuong = table.Column<string>(type: "text", nullable: true),
                    IdCapKhenThuong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD", x => x.IdDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD);
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD_dmCapKhenThuong",
                        column: x => x.IdCapKhenThuong,
                        principalSchema: "DM",
                        principalTable: "dmCapKhenThuong",
                        principalColumn: "IdCapKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD_dmLoaiDanhHieuThiDuaGiaiThuongKhenThuong",
                        column: x => x.IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong,
                        principalSchema: "DM",
                        principalTable: "dmLoaiDanhHieuThiDuaGiaiThuongKhenThuong",
                        principalColumn: "IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD_dmPhuongThucKhenThuong",
                        column: x => x.IdPhuongThucKhenThuong,
                        principalSchema: "DM",
                        principalTable: "dmPhuongThucKhenThuong",
                        principalColumn: "IdPhuongThucKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD_dmThiDuaGiaiThuongKhenThuong",
                        column: x => x.IdDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD,
                        principalSchema: "DM",
                        principalTable: "dmThiDuaGiaiThuongKhenThuong",
                        principalColumn: "IdThiDuaGiaiThuongKhenThuong");
                });

            migrationBuilder.CreateTable(
                name: "dmHuyen",
                schema: "DM",
                columns: table => new
                {
                    IdHuyen = table.Column<int>(type: "int", nullable: false),
                    TenHuyen = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdTinh = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHuyen", x => x.IdHuyen);
                    table.ForeignKey(
                        name: "FK_tbHuyen_tbTinh",
                        column: x => x.IdTinh,
                        principalSchema: "DM",
                        principalTable: "dmTinh",
                        principalColumn: "IdTinh");
                });

            migrationBuilder.CreateTable(
                name: "tbKiTucXa",
                schema: "CSVC",
                columns: table => new
                {
                    IdKiTucXa = table.Column<int>(type: "int", nullable: false),
                    MaKyTucxa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdHinhThucSoHuu = table.Column<int>(type: "int", nullable: true),
                    TongChoO = table.Column<int>(type: "int", nullable: true),
                    TongDienTich = table.Column<double>(type: "float", nullable: true),
                    IdTinhTrangCSVC = table.Column<int>(type: "int", nullable: true),
                    SoPhong = table.Column<int>(type: "int", nullable: true),
                    NamDuaVaoSuDung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbKiTucXa", x => x.IdKiTucXa);
                    table.ForeignKey(
                        name: "FK_tbKiTucXa_dmHinhThucSoHuu",
                        column: x => x.IdHinhThucSoHuu,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucSoHuu",
                        principalColumn: "IdHinhThucSoHuu");
                    table.ForeignKey(
                        name: "FK_tbKiTucXa_dmTinhTrangCoSoVatChat",
                        column: x => x.IdTinhTrangCSVC,
                        principalSchema: "DM",
                        principalTable: "dmTinhTrangCoSoVatChat",
                        principalColumn: "IdTinhTrangCoSoVatChat");
                });

            migrationBuilder.CreateTable(
                name: "tbPhongHocGiangDuongHoiTruong",
                schema: "CSVC",
                columns: table => new
                {
                    IdPhongHocGiangDuongHoiTruong = table.Column<int>(type: "int", nullable: false),
                    MaPhongHocGiangDuongHoiTruong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenPhongHocGiangDuongHoiTruong = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    DienTich = table.Column<double>(type: "float", nullable: true),
                    IdHinhThucSoHuu = table.Column<int>(type: "int", nullable: true),
                    QuyMoChoNgoi = table.Column<int>(type: "int", nullable: true),
                    IdTinhTrangCoSoVatChat = table.Column<int>(type: "int", nullable: true),
                    IdPhanLoaiCSVC = table.Column<int>(type: "int", nullable: true),
                    IdLoaiPhongHoc = table.Column<int>(type: "int", nullable: true),
                    IdLoaiDeAn = table.Column<int>(type: "int", nullable: true),
                    NamDuaVaoSuDung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPhongHocGiangDuongHoiTruong", x => x.IdPhongHocGiangDuongHoiTruong);
                    table.ForeignKey(
                        name: "FK_tbPhongHocGiangDuongHoiTruong_dmHinhThucSoHuu",
                        column: x => x.IdHinhThucSoHuu,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucSoHuu",
                        principalColumn: "IdHinhThucSoHuu");
                    table.ForeignKey(
                        name: "FK_tbPhongHocGiangDuongHoiTruong_dmLoaiDeAnChuongTrinh",
                        column: x => x.IdLoaiDeAn,
                        principalSchema: "DM",
                        principalTable: "dmLoaiDeAnChuongTrinh",
                        principalColumn: "IdLoaiDeAnChuongTrinh");
                    table.ForeignKey(
                        name: "FK_tbPhongHocGiangDuongHoiTruong_dmLoaiPhongHoc",
                        column: x => x.IdLoaiPhongHoc,
                        principalSchema: "DM",
                        principalTable: "dmLoaiPhongHoc",
                        principalColumn: "IdLoaiPhongHoc");
                    table.ForeignKey(
                        name: "FK_tbPhongHocGiangDuongHoiTruong_dmPhanLoaiCSVC",
                        column: x => x.IdPhanLoaiCSVC,
                        principalSchema: "DM",
                        principalTable: "dmPhanLoaiCSVC",
                        principalColumn: "IdPhanLoaiCSVC");
                    table.ForeignKey(
                        name: "FK_tbPhongHocGiangDuongHoiTruong_dmTinhTrangCoSoVatChat",
                        column: x => x.IdTinhTrangCoSoVatChat,
                        principalSchema: "DM",
                        principalTable: "dmTinhTrangCoSoVatChat",
                        principalColumn: "IdTinhTrangCoSoVatChat");
                });

            migrationBuilder.CreateTable(
                name: "tbThuVienTrungTamHocLieu",
                schema: "CSVC",
                columns: table => new
                {
                    IdThuVienTrungTamHocLieu = table.Column<int>(type: "int", nullable: false),
                    MaThuVienTrungTamHocLieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenThuVienTrungTamHocLieu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NamDuaVaoSuDung = table.Column<string>(type: "text", nullable: true),
                    DienTich = table.Column<double>(type: "float", nullable: true),
                    DienTichPhongDoc = table.Column<double>(type: "float", nullable: true),
                    SoPhongDoc = table.Column<int>(type: "int", nullable: true),
                    SoLuongMayTinh = table.Column<int>(type: "int", nullable: true),
                    SoLuongChoNgoi = table.Column<int>(type: "int", nullable: true),
                    SoLuongSach = table.Column<int>(type: "int", nullable: true),
                    SoLuongTapChi = table.Column<int>(type: "int", nullable: true),
                    SoLuongSachDienTu = table.Column<int>(type: "int", nullable: true),
                    SoLuongTapChiDienTu = table.Column<int>(type: "int", nullable: true),
                    SoLuonngThuVienDienTuLienKetNN = table.Column<int>(type: "int", nullable: true),
                    IdTinhTrangCSVC = table.Column<int>(type: "int", nullable: true),
                    IdHinhThucSoHuu = table.Column<int>(type: "int", nullable: true),
                    SoLuongDauSach = table.Column<int>(type: "int", nullable: true),
                    SoLuongDauTapChi = table.Column<int>(type: "int", nullable: true),
                    SoLuongDauSachDienTu = table.Column<int>(type: "int", nullable: true),
                    SoLuongDauTapChiDienTu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_tbThuVienTrungTamHocLieu_dmHinhThucSoHuu",
                        column: x => x.IdHinhThucSoHuu,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucSoHuu",
                        principalColumn: "IdHinhThucSoHuu");
                    table.ForeignKey(
                        name: "FK_tbThuVienTrungTamHocLieu_dmTinhTrangCoSoVatChat",
                        column: x => x.IdTinhTrangCSVC,
                        principalSchema: "DM",
                        principalTable: "dmTinhTrangCoSoVatChat",
                        principalColumn: "IdTinhTrangCoSoVatChat");
                });

            migrationBuilder.CreateTable(
                name: "tbNhiemVuKHCN",
                schema: "KHCN",
                columns: table => new
                {
                    IdNhiemVuKHCN = table.Column<int>(type: "int", nullable: false),
                    MaNhiemVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenNhiemVu = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IdCapQuanLyNhiemVu = table.Column<int>(type: "int", nullable: true),
                    IdCoQuanChuQuan = table.Column<int>(type: "int", nullable: true),
                    CoQuanChuTri = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NguoiChuTri = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdPhanLoaiNhiemVu = table.Column<int>(type: "int", nullable: true),
                    ThuocNhiemVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdLinhVucNghienCuu = table.Column<int>(type: "int", nullable: true),
                    TongKinhPhiCuaNhiemVu = table.Column<string>(type: "text", nullable: true),
                    IdNguonKinhPhi = table.Column<int>(type: "int", nullable: true),
                    ThoiGianBatDau = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiGianKetThuc = table.Column<DateOnly>(type: "date", nullable: true),
                    DanhGiaKetQuaNhiemVu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SanPhamChinhCuaNhiemVu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdTinhTrangNhiemVu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNhiemVuKHCN", x => x.IdNhiemVuKHCN);
                    table.ForeignKey(
                        name: "FK_tbNhiemVuKHCN_dmCoQuanChuQuan",
                        column: x => x.IdCoQuanChuQuan,
                        principalSchema: "DM",
                        principalTable: "dmCoQuanChuQuan",
                        principalColumn: "IdCoQuanChuQuan");
                    table.ForeignKey(
                        name: "FK_tbNhiemVuKHCN_dmLinhVucNghienCuu",
                        column: x => x.IdLinhVucNghienCuu,
                        principalSchema: "DM",
                        principalTable: "dmLinhVucNghienCuu",
                        principalColumn: "IdLinhVucNghienCuu");
                    table.ForeignKey(
                        name: "FK_tbNhiemVuKHCN_dmLoaiNhiemVu",
                        column: x => x.IdPhanLoaiNhiemVu,
                        principalSchema: "DM",
                        principalTable: "dmLoaiNhiemVu",
                        principalColumn: "IdLoaiNhiemVu");
                    table.ForeignKey(
                        name: "FK_tbNhiemVuKHCN_dmNguonKinhPhi",
                        column: x => x.IdNguonKinhPhi,
                        principalSchema: "DM",
                        principalTable: "dmNguonKinhPhi",
                        principalColumn: "IdNguonKinhPhi");
                    table.ForeignKey(
                        name: "FK_tbNhiemVuKHCN_dmPhanCapNhiemVu",
                        column: x => x.IdCapQuanLyNhiemVu,
                        principalSchema: "DM",
                        principalTable: "dmPhanCapNhiemVu",
                        principalColumn: "IdPhanCapNhiemVu");
                    table.ForeignKey(
                        name: "FK_tbNhiemVuKHCN_dmTinhTrangNhiemVu",
                        column: x => x.IdTinhTrangNhiemVu,
                        principalSchema: "DM",
                        principalTable: "dmTinhTrangNhiemVu",
                        principalColumn: "IdTinhTrangNhiemVu");
                });

            migrationBuilder.CreateTable(
                name: "tbToChucKiemDinh",
                schema: "CSGD",
                columns: table => new
                {
                    IdToChucKiemDinhCSDG = table.Column<int>(type: "int", nullable: false),
                    IdToChucKiemDinh = table.Column<int>(type: "int", nullable: true),
                    IdKetQua = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhKiemDinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayCapChungNhanKiemDinh = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiHanKiemDinh = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbToChucKiemDinh_1", x => x.IdToChucKiemDinhCSDG);
                    table.ForeignKey(
                        name: "FK_tbToChucKiemDinh_dmKetQuaKiemDinh",
                        column: x => x.IdKetQua,
                        principalSchema: "DM",
                        principalTable: "dmKetQuaKiemDinh",
                        principalColumn: "IdKetQuaKiemDinh");
                    table.ForeignKey(
                        name: "FK_tbToChucKiemDinh_dmToChucKiemDinh",
                        column: x => x.IdToChucKiemDinh,
                        principalSchema: "DM",
                        principalTable: "dmToChucKiemDinh",
                        principalColumn: "IdToChucKiemDinh");
                });

            migrationBuilder.CreateTable(
                name: "tbCoCauToChuc",
                schema: "CSGD",
                columns: table => new
                {
                    IdCoCauToChuc = table.Column<int>(type: "int", nullable: false),
                    MaPhongBanDonVi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdLoaiPhongBan = table.Column<int>(type: "int", nullable: true),
                    MaPhongBanDonViCha = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TenPhongBanDonVi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoQuyetDinhThanhLap = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayRaQuyetDinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdTrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCoCauToChuc", x => x.IdCoCauToChuc);
                    table.ForeignKey(
                        name: "FK_tbCoCauToChuc_dmLoaiPhongBan",
                        column: x => x.IdLoaiPhongBan,
                        principalSchema: "DM",
                        principalTable: "dmLoaiPhongBan",
                        principalColumn: "IdLoaiPhongBan");
                    table.ForeignKey(
                        name: "FK_tbCoCauToChuc_dmTrangThaiCoSoGD",
                        column: x => x.IdTrangThai,
                        principalSchema: "DM",
                        principalTable: "dmTrangThaiCoSoGD",
                        principalColumn: "IdTrangThaiCoSoGD");
                });

            migrationBuilder.CreateTable(
                name: "tbChuongTrinhDaoTao",
                schema: "CTDT",
                columns: table => new
                {
                    IdChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: false),
                    MaChuongTrinhDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdNganhDaoTao = table.Column<int>(type: "int", nullable: true),
                    TenChuongTrinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TenChuongTrinhBangTiengAnh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NamBatDauTuyenSinh = table.Column<DateOnly>(type: "date", nullable: true),
                    TenCoSoDaoTaoNuocNgoai = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdLoaiChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdLoaiChuongTrinhLienKetDaoTao = table.Column<int>(type: "int", nullable: true),
                    DiaDiemDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdHocCheDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdQuocGiaCuaTruSoChinh = table.Column<int>(type: "int", nullable: true),
                    NgayBanHanhChuanDauRa = table.Column<DateOnly>(type: "date", nullable: true),
                    IdTrinhDoDaoTao = table.Column<int>(type: "int", nullable: true),
                    ThoiGianDaoTaoChuan = table.Column<int>(type: "int", nullable: true),
                    ChuanDauRa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdDonViCapBang = table.Column<int>(type: "int", nullable: true),
                    LoaiChungChiDuocChapThuan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DonViThucHienChuongTrinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdTrangThaiCuaChuongTrinh = table.Column<int>(type: "int", nullable: true),
                    ChuanDauRaVeNgoaiNgu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ChuanDauRaVeTinHoc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HocPhiTaiVietNam = table.Column<int>(type: "int", nullable: true),
                    HocPhiTaiNuocNgoai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbChuongTrinhDaoTao", x => x.IdChuongTrinhDaoTao);
                    table.ForeignKey(
                        name: "FK_tbChuongTrinhDaoTao_dmDonViCapBang",
                        column: x => x.IdDonViCapBang,
                        principalSchema: "DM",
                        principalTable: "dmDonViCapBang",
                        principalColumn: "IdDonViCapBang");
                    table.ForeignKey(
                        name: "FK_tbChuongTrinhDaoTao_dmHocCheDaoTao",
                        column: x => x.IdHocCheDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmHocCheDaoTao",
                        principalColumn: "IdHocCheDaoTao");
                    table.ForeignKey(
                        name: "FK_tbChuongTrinhDaoTao_dmLoaiChuongTrinhDaoTao",
                        column: x => x.IdLoaiChuongTrinhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLoaiChuongTrinhDaoTao",
                        principalColumn: "IdLoaiChuongTrinhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbChuongTrinhDaoTao_dmLoaiChuongTrinhLienKetDaoTao",
                        column: x => x.IdLoaiChuongTrinhLienKetDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLoaiChuongTrinhLienKetDaoTao",
                        principalColumn: "IdLoaiChuongTrinhLienKetDaoTao");
                    table.ForeignKey(
                        name: "FK_tbChuongTrinhDaoTao_dmNganhDaoTao",
                        column: x => x.IdNganhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmNganhDaoTao",
                        principalColumn: "IdNganhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbChuongTrinhDaoTao_dmQuocTich",
                        column: x => x.IdQuocGiaCuaTruSoChinh,
                        principalSchema: "DM",
                        principalTable: "dmQuocTich",
                        principalColumn: "IdQuocTich");
                    table.ForeignKey(
                        name: "FK_tbChuongTrinhDaoTao_dmTrangThaiChuongTrinhDaoTao",
                        column: x => x.IdTrangThaiCuaChuongTrinh,
                        principalSchema: "DM",
                        principalTable: "dmTrangThaiChuongTrinhDaoTao",
                        principalColumn: "IdTrangThaiChuongTrinhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbChuongTrinhDaoTao_dmTrinhDoDaoTao",
                        column: x => x.IdTrinhDoDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmTrinhDoDaoTao",
                        principalColumn: "IdTrinhDoDaoTao");
                });

            migrationBuilder.CreateTable(
                name: "tbNguoi",
                columns: table => new
                {
                    IdNguoi = table.Column<int>(type: "int", nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdQuocTich = table.Column<int>(type: "int", nullable: true),
                    SoCCCD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayCapCCCD = table.Column<DateOnly>(type: "date", nullable: true),
                    NoiCapCCCD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgaySinh = table.Column<DateOnly>(type: "date", nullable: true),
                    IdGioiTinh = table.Column<int>(type: "int", nullable: true),
                    IdDanToc = table.Column<int>(type: "int", nullable: true),
                    IdTonGiao = table.Column<int>(type: "int", nullable: true),
                    NgayVaoDoan = table.Column<DateOnly>(type: "date", nullable: true),
                    NgayVaoDang = table.Column<DateOnly>(type: "date", nullable: true),
                    NgayVaoDangChinhThuc = table.Column<DateOnly>(type: "date", nullable: true),
                    NgayNhapNgu = table.Column<DateOnly>(type: "date", nullable: true),
                    NgayXuatNgu = table.Column<DateOnly>(type: "date", nullable: true),
                    IdThuongBinhHang = table.Column<int>(type: "int", nullable: true),
                    IdGiaDinhChinhSach = table.Column<int>(type: "int", nullable: true),
                    IdChucDanhKhoaHoc = table.Column<int>(type: "int", nullable: true),
                    IdTrinhDoDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdChuyenMonDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdNgoaiNgu = table.Column<int>(type: "int", nullable: true),
                    IdKhungNangLucNgoaiNguc = table.Column<int>(type: "int", nullable: true),
                    IdTrinhDoLyLuanChinhTri = table.Column<int>(type: "int", nullable: true),
                    IdTrinhDoQuanLyNhaNuoc = table.Column<int>(type: "int", nullable: true),
                    IdTrinhDoTinHoc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNguoi", x => x.IdNguoi);
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmChucDanhKhoaHoc",
                        column: x => x.IdChucDanhKhoaHoc,
                        principalSchema: "DM",
                        principalTable: "dmChucDanhKhoaHoc",
                        principalColumn: "IdChucDanhKhoaHoc");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmDanToc",
                        column: x => x.IdDanToc,
                        principalSchema: "DM",
                        principalTable: "dmDanToc",
                        principalColumn: "IdDanToc");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmGioiTinh",
                        column: x => x.IdGioiTinh,
                        principalSchema: "DM",
                        principalTable: "dmGioiTinh",
                        principalColumn: "IdGioiTinh");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmHangThuongBinh",
                        column: x => x.IdThuongBinhHang,
                        principalSchema: "DM",
                        principalTable: "dmHangThuongBinh",
                        principalColumn: "IdHangThuongBinh");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmHoGiaDinhChinhSach",
                        column: x => x.IdGiaDinhChinhSach,
                        principalSchema: "DM",
                        principalTable: "dmHoGiaDinhChinhSach",
                        principalColumn: "IdHoGiaDinhChinhSach");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmKhungNangLucNgoaiNgu",
                        column: x => x.IdKhungNangLucNgoaiNguc,
                        principalSchema: "DM",
                        principalTable: "dmKhungNangLucNgoaiNgu",
                        principalColumn: "IdKhungNangLucNgoaiNgu");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmNganhDaoTao",
                        column: x => x.IdChuyenMonDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmNganhDaoTao",
                        principalColumn: "IdNganhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmNgoaiNgu",
                        column: x => x.IdNgoaiNgu,
                        principalSchema: "DM",
                        principalTable: "dmNgoaiNgu",
                        principalColumn: "IdNgoaiNgu");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmQuocTich",
                        column: x => x.IdQuocTich,
                        principalSchema: "DM",
                        principalTable: "dmQuocTich",
                        principalColumn: "IdQuocTich");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmTonGiao",
                        column: x => x.IdTonGiao,
                        principalSchema: "DM",
                        principalTable: "dmTonGiao",
                        principalColumn: "IdTonGiao");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmTrinhDoDaoTao",
                        column: x => x.IdTrinhDoDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmTrinhDoDaoTao",
                        principalColumn: "IdTrinhDoDaoTao");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmTrinhDoLyLuanChinhTri",
                        column: x => x.IdTrinhDoLyLuanChinhTri,
                        principalSchema: "DM",
                        principalTable: "dmTrinhDoLyLuanChinhTri",
                        principalColumn: "IdTrinhDoLyLuanChinhTri");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmTrinhDoQuanLyNhaNuoc",
                        column: x => x.IdTrinhDoQuanLyNhaNuoc,
                        principalSchema: "DM",
                        principalTable: "dmTrinhDoQuanLyNhaNuoc",
                        principalColumn: "IdTrinhDoQuanLyNhaNuoc");
                    table.ForeignKey(
                        name: "FK_tbNguoi_dmTrinhDoTinHoc",
                        column: x => x.IdTrinhDoTinHoc,
                        principalSchema: "DM",
                        principalTable: "dmTrinhDoTinHoc",
                        principalColumn: "IdTrinhDoTinHoc");
                });

            migrationBuilder.CreateTable(
                name: "tbCongTrinhCoSoVatChat",
                schema: "CSVC",
                columns: table => new
                {
                    IdCongTrinhCoSoVatChat = table.Column<int>(type: "int", nullable: false),
                    MaCongTrinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenCongTrinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdLoaiCongTrinh = table.Column<int>(type: "int", nullable: true),
                    IdMucDichSuDung = table.Column<int>(type: "int", nullable: true),
                    DoiTuongSuDung = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DienTichSanXayDung = table.Column<double>(type: "float", nullable: true),
                    VonBanDau = table.Column<double>(type: "float", nullable: true),
                    VonDauTu = table.Column<double>(type: "float", nullable: true),
                    IdTinhTrangCSVC = table.Column<int>(type: "int", nullable: true),
                    IdHinhThucSoHuu = table.Column<int>(type: "int", nullable: true),
                    CongTrinhCSVCTrongNha = table.Column<int>(type: "int", nullable: true),
                    SoPhongOCongVu = table.Column<int>(type: "int", nullable: true),
                    SoChoOChoCanBoGiangDay = table.Column<int>(type: "int", nullable: true),
                    NamDuaVaoSuDung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCongTrinhCoSoVatChat", x => x.IdCongTrinhCoSoVatChat);
                    table.ForeignKey(
                        name: "FK_tbCongTrinhCoSoVatChat_dmHinhThucSoHuu",
                        column: x => x.IdHinhThucSoHuu,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucSoHuu",
                        principalColumn: "IdHinhThucSoHuu");
                    table.ForeignKey(
                        name: "FK_tbCongTrinhCoSoVatChat_dmLoaiCongTrinhCoSoVatChat",
                        column: x => x.IdLoaiCongTrinh,
                        principalSchema: "DM",
                        principalTable: "dmLoaiCongTrinhCoSoVatChat",
                        principalColumn: "IdLoaiCongTrinhCoSoVatChat");
                    table.ForeignKey(
                        name: "FK_tbCongTrinhCoSoVatChat_dmMucDichSuDungCSVC",
                        column: x => x.IdMucDichSuDung,
                        principalSchema: "DM",
                        principalTable: "dmMucDichSuDungCSVC",
                        principalColumn: "IdMucDichSuDungCSVC");
                    table.ForeignKey(
                        name: "FK_tbCongTrinhCoSoVatChat_dmTinhTrangCoSoVatChat",
                        column: x => x.IdTinhTrangCSVC,
                        principalSchema: "DM",
                        principalTable: "dmTinhTrangCoSoVatChat",
                        principalColumn: "IdTinhTrangCoSoVatChat");
                    table.ForeignKey(
                        name: "FK_tbCongTrinhCoSoVatChat_dmTuyChon",
                        column: x => x.CongTrinhCSVCTrongNha,
                        principalSchema: "DM",
                        principalTable: "dmTuyChon",
                        principalColumn: "IdTuyChon");
                });

            migrationBuilder.CreateTable(
                name: "tbDanhSachNganhDaoTao",
                schema: "NDT",
                columns: table => new
                {
                    IdDanhSachNganhDaoTao = table.Column<int>(type: "int", nullable: false),
                    IdNganhDaoTao = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhChoPhepMoNganh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayBanHanhVanBanQuyetDinhMoNganh = table.Column<DateOnly>(type: "date", nullable: true),
                    MaNganhMoLanDau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenNganhMoLanDau = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CoQuanBanHanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NguoiKy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoQuyetDinhChoPhepDoiTenNganh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayBanHanhVanBanQuyetDinhDoiTenNganh = table.Column<DateOnly>(type: "date", nullable: true),
                    HinhThucDaoTaoTheoChuyenNgu = table.Column<int>(type: "int", nullable: true),
                    NamBatDauDaoTao = table.Column<string>(type: "text", nullable: true),
                    IdQuyetDinhTuChu = table.Column<int>(type: "int", nullable: true),
                    IdTuChuMoNganh = table.Column<int>(type: "int", nullable: true),
                    SoNamDaoTaoThSTS = table.Column<int>(type: "int", nullable: true),
                    NamTuyenSinhVaDaoTaoGanNhat = table.Column<string>(type: "text", nullable: true),
                    TongSoNamDaoTaoCuaNganh = table.Column<int>(type: "int", nullable: true),
                    UuTienDaoTaoNhanLucDuLichCNTT = table.Column<int>(type: "int", nullable: true),
                    NamBatDauThucHienUuTienDaoTaoNhanLucDuLichCNTT = table.Column<string>(type: "text", nullable: true),
                    SoQuyetDinhDaoTaoTuXa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayQuyetDinhDaoTaoTuXa = table.Column<DateOnly>(type: "date", nullable: true),
                    NamBatDauDaoTaoTuXa = table.Column<string>(type: "text", nullable: true),
                    NganhDaoTaoLienKetNuocNgoai = table.Column<int>(type: "int", nullable: true),
                    IdTrangThaiDaoTao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDanhSachNganhDaoTao", x => x.IdDanhSachNganhDaoTao);
                    table.ForeignKey(
                        name: "FK_tbDanhSachNganhDaoTao_dmNganhDaoTao",
                        column: x => x.IdNganhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmNganhDaoTao",
                        principalColumn: "IdNganhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbDanhSachNganhDaoTao_dmQuyetDinhTuChu",
                        column: x => x.IdQuyetDinhTuChu,
                        principalSchema: "DM",
                        principalTable: "dmQuyetDinhTuChu",
                        principalColumn: "IdQuyetDinhTuChu");
                    table.ForeignKey(
                        name: "FK_tbDanhSachNganhDaoTao_dmTrangThaiDaoTao",
                        column: x => x.IdTrangThaiDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmTrangThaiDaoTao",
                        principalColumn: "IdTrangThaiDaoTao");
                    table.ForeignKey(
                        name: "FK_tbDanhSachNganhDaoTao_dmTuChuMoNganh",
                        column: x => x.IdTuChuMoNganh,
                        principalSchema: "DM",
                        principalTable: "dmTuChuMoNganh",
                        principalColumn: "IdTuChuMoNganh");
                    table.ForeignKey(
                        name: "FK_tbDanhSachNganhDaoTao_dmTuyChon",
                        column: x => x.HinhThucDaoTaoTheoChuyenNgu,
                        principalSchema: "DM",
                        principalTable: "dmTuyChon",
                        principalColumn: "IdTuyChon");
                    table.ForeignKey(
                        name: "FK_tbDanhSachNganhDaoTao_dmTuyChon1",
                        column: x => x.UuTienDaoTaoNhanLucDuLichCNTT,
                        principalSchema: "DM",
                        principalTable: "dmTuyChon",
                        principalColumn: "IdTuyChon");
                    table.ForeignKey(
                        name: "FK_tbDanhSachNganhDaoTao_dmTuyChon2",
                        column: x => x.NganhDaoTaoLienKetNuocNgoai,
                        principalSchema: "DM",
                        principalTable: "dmTuyChon",
                        principalColumn: "IdTuyChon");
                });

            migrationBuilder.CreateTable(
                name: "dmKhoiNganhLinhVucDaoTao",
                schema: "DM",
                columns: table => new
                {
                    IdKhoiNganhLinhVucNghienCuu = table.Column<int>(type: "int", nullable: false),
                    IdKhoiNganh = table.Column<int>(type: "int", nullable: true),
                    IdLinhVucDaoTao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmKhoiNganhLinhVucNghienCuu", x => x.IdKhoiNganhLinhVucNghienCuu);
                    table.ForeignKey(
                        name: "FK_dmKhoiNganhLinhVucDaoTao_dmKhoiNganh",
                        column: x => x.IdKhoiNganh,
                        principalSchema: "NDT",
                        principalTable: "tbKhoiNganhDaoTao",
                        principalColumn: "IdKhoiNganhDaoTao");
                    table.ForeignKey(
                        name: "FK_dmKhoiNganhLinhVucDaoTao_dmLinhVucDaoTao",
                        column: x => x.IdLinhVucDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLinhVucDaoTao",
                        principalColumn: "IdLinhVucDaoTao");
                });

            migrationBuilder.CreateTable(
                name: "tbThongTinLinhVucDaoTao",
                schema: "NDT",
                columns: table => new
                {
                    IdThongTinLinhVucDaoTao = table.Column<int>(type: "int", nullable: false),
                    IdKhoiNganh = table.Column<int>(type: "int", nullable: true),
                    IdLinhVucDaoTao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dmThongTinLinhVucDaoTao", x => x.IdThongTinLinhVucDaoTao);
                    table.ForeignKey(
                        name: "FK_dmThongTinLinhVucDaoTao_dmLinhVucDaoTao",
                        column: x => x.IdLinhVucDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLinhVucDaoTao",
                        principalColumn: "IdLinhVucDaoTao");
                    table.ForeignKey(
                        name: "FK_dmThongTinLinhVucDaoTao_tbKhoiNganhDaoTao",
                        column: x => x.IdKhoiNganh,
                        principalSchema: "NDT",
                        principalTable: "tbKhoiNganhDaoTao",
                        principalColumn: "IdKhoiNganhDaoTao");
                });

            migrationBuilder.CreateTable(
                name: "tbChiTietTaiSanDonVi",
                schema: "TCTS",
                columns: table => new
                {
                    IdChiTietTaiSanDonVi = table.Column<int>(type: "int", nullable: false),
                    IdTaiSanDonVi = table.Column<int>(type: "int", nullable: true),
                    MaTaiSan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenTaiSan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NguyenGia = table.Column<int>(type: "int", nullable: true),
                    IdTinhTrangThietBi = table.Column<int>(type: "int", nullable: true),
                    IdChuSoHuu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbChiTietTaiSanDonVi", x => x.IdChiTietTaiSanDonVi);
                    table.ForeignKey(
                        name: "FK_tbChiTietTaiSanDonVi_dmChuSoHuu",
                        column: x => x.IdChuSoHuu,
                        principalSchema: "DM",
                        principalTable: "dmChuSoHuu",
                        principalColumn: "IdChuSoHuu");
                    table.ForeignKey(
                        name: "FK_tbChiTietTaiSanDonVi_dmTinhTrangThietBi",
                        column: x => x.IdTinhTrangThietBi,
                        principalSchema: "DM",
                        principalTable: "dmTinhTrangThietBi",
                        principalColumn: "IdTinhTrangThietBi");
                    table.ForeignKey(
                        name: "FK_tbChiTietTaiSanDonVi_tbTaiSanDonVi",
                        column: x => x.IdTaiSanDonVi,
                        principalSchema: "TCTS",
                        principalTable: "tbTaiSanDonVi",
                        principalColumn: "IdTaiSanDonVi");
                });

            migrationBuilder.CreateTable(
                name: "tbChiTietThuChi",
                schema: "TCTS",
                columns: table => new
                {
                    IdChiTietThuChi = table.Column<int>(type: "int", nullable: false),
                    IdLoaiThuChi = table.Column<int>(type: "int", nullable: true),
                    TenKhoanThuChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NamTaiChinh = table.Column<string>(type: "text", nullable: true),
                    SoTien = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbChiTietThuChi", x => x.IdChiTietThuChi);
                    table.ForeignKey(
                        name: "FK_tbChiTietThuChi_tbLoaiThuChi",
                        column: x => x.IdLoaiThuChi,
                        principalSchema: "TCTS",
                        principalTable: "tbLoaiThuChi",
                        principalColumn: "IdLoaiThuChi");
                });

            migrationBuilder.CreateTable(
                name: "tbThongTinHopTac",
                schema: "HTQT",
                columns: table => new
                {
                    IdThongTinHopTac = table.Column<int>(type: "int", nullable: false),
                    IdToChucHopTac = table.Column<int>(type: "int", nullable: true),
                    ThoiGianHopTacTu = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiGianHopTacDen = table.Column<DateOnly>(type: "date", nullable: true),
                    TenThoaThuan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ThongTinLienHeDoiTac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucTieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonViTrienKhai = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdHinhThucHopTac = table.Column<int>(type: "int", nullable: true),
                    SanPhamChinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbThongTinHopTac", x => x.IdThongTinHopTac);
                    table.ForeignKey(
                        name: "FK_tbThongTinHopTac_dmHinhThucHopTac",
                        column: x => x.IdHinhThucHopTac,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucHopTac",
                        principalColumn: "IdHinhThucHopTac");
                    table.ForeignKey(
                        name: "FK_tbThongTinHopTac_tbToChucHopTacQuocTe",
                        column: x => x.IdToChucHopTac,
                        principalSchema: "HTQT",
                        principalTable: "tbToChucHopTacQuocTe",
                        principalColumn: "IdToChucHopTacQuocTe");
                });

            migrationBuilder.CreateTable(
                name: "dmXa",
                schema: "DM",
                columns: table => new
                {
                    IdXa = table.Column<int>(type: "int", nullable: false),
                    TenXa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbXa", x => x.IdXa);
                    table.ForeignKey(
                        name: "FK_tbXa_tbHuyen",
                        column: x => x.IdHuyen,
                        principalSchema: "DM",
                        principalTable: "dmHuyen",
                        principalColumn: "IdHuyen");
                });

            migrationBuilder.CreateTable(
                name: "tbBaiBaoKHDaCongBo",
                schema: "KHCN",
                columns: table => new
                {
                    IdBaiBaoKHDaCongBo = table.Column<int>(type: "int", nullable: false),
                    IdNhiemVuKHCN = table.Column<int>(type: "int", nullable: true),
                    MaBaiBaoKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenBaiBaoKH = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    TenTapChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdTapChiTrongNuoc = table.Column<int>(type: "int", nullable: true),
                    IdTapChiQuocTe = table.Column<int>(type: "int", nullable: true),
                    IdXepHangQ = table.Column<int>(type: "int", nullable: true),
                    GhiChuDuongDanBaiBao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TapSo = table.Column<int>(type: "int", nullable: true),
                    Trang = table.Column<int>(type: "int", nullable: true),
                    NamCongBo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbBaiBaoKHDaCongBo", x => x.IdBaiBaoKHDaCongBo);
                    table.ForeignKey(
                        name: "FK_tbBaiBaoKHDaCongBo_dmTapChiKhoaHocQuocTe",
                        column: x => x.IdTapChiQuocTe,
                        principalSchema: "DM",
                        principalTable: "dmTapChiKhoaHocQuocTe",
                        principalColumn: "IdTapChiKhoaHocQuocTe");
                    table.ForeignKey(
                        name: "FK_tbBaiBaoKHDaCongBo_dmTapChiTrongNuoc",
                        column: x => x.IdTapChiTrongNuoc,
                        principalSchema: "DM",
                        principalTable: "dmTapChiTrongNuoc",
                        principalColumn: "IdTapChiTrongNuoc");
                    table.ForeignKey(
                        name: "FK_tbBaiBaoKHDaCongBo_dmXepHangQ",
                        column: x => x.IdXepHangQ,
                        principalSchema: "DM",
                        principalTable: "dmXepHangQ",
                        principalColumn: "IdXepHangQ");
                    table.ForeignKey(
                        name: "FK_tbBaiBaoKHDaCongBo_tbNhiemVuKHCN",
                        column: x => x.IdNhiemVuKHCN,
                        principalSchema: "KHCN",
                        principalTable: "tbNhiemVuKHCN",
                        principalColumn: "IdNhiemVuKHCN");
                });

            migrationBuilder.CreateTable(
                name: "tbChuyenGiaoCongNgheVaDaoTao",
                schema: "KHCN",
                columns: table => new
                {
                    IdChuyenGiaoCongNgheVaDaoTao = table.Column<int>(type: "int", nullable: false),
                    IdNhiemVuKHCN = table.Column<int>(type: "int", nullable: true),
                    MaSoHopDong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TongChiPhiThucHien = table.Column<int>(type: "int", nullable: true),
                    TongThoiGianThucHien = table.Column<int>(type: "int", nullable: true),
                    IdHinhThucChuyenGiaoCongNghe = table.Column<int>(type: "int", nullable: true),
                    PhuongThucChuyenGiaoCongNghe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChuSoHuu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DonViChuTri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DonViPhoiHop = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DonViNhanChuyenGiao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TomTat = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TenDuAn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiaTriHopDong = table.Column<int>(type: "int", nullable: true),
                    IdNganhKinhTe = table.Column<int>(type: "int", nullable: true),
                    IdTrangThaiHopDong = table.Column<int>(type: "int", nullable: true),
                    SoNguoiDuocDaoTaoChuyenGiaoCN = table.Column<int>(type: "int", nullable: true),
                    IdLinhVucNghienCuu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbChuyenGiaoCongNgheVaDaoTao", x => x.IdChuyenGiaoCongNgheVaDaoTao);
                    table.ForeignKey(
                        name: "FK_tbChuyenGiaoCongNgheVaDaoTao_dmHinhThucChuyenGiaoCongNghe",
                        column: x => x.IdHinhThucChuyenGiaoCongNghe,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucChuyenGiaoCongNghe",
                        principalColumn: "IdHinhThucChuyenGiaoCongNghe");
                    table.ForeignKey(
                        name: "FK_tbChuyenGiaoCongNgheVaDaoTao_dmLinhVucNghienCuu",
                        column: x => x.IdLinhVucNghienCuu,
                        principalSchema: "DM",
                        principalTable: "dmLinhVucNghienCuu",
                        principalColumn: "IdLinhVucNghienCuu");
                    table.ForeignKey(
                        name: "FK_tbChuyenGiaoCongNgheVaDaoTao_dmNganhKinhTe",
                        column: x => x.IdNganhKinhTe,
                        principalSchema: "DM",
                        principalTable: "dmNganhKinhTe",
                        principalColumn: "IdNganhKinhTe");
                    table.ForeignKey(
                        name: "FK_tbChuyenGiaoCongNgheVaDaoTao_dmTinhTrangHopDong",
                        column: x => x.IdTrangThaiHopDong,
                        principalSchema: "DM",
                        principalTable: "dmTrangThaiHopDong",
                        principalColumn: "IdTrangThaiHopDong");
                    table.ForeignKey(
                        name: "FK_tbChuyenGiaoCongNgheVaDaoTao_tbNhiemVuKHCN",
                        column: x => x.IdNhiemVuKHCN,
                        principalSchema: "KHCN",
                        principalTable: "tbNhiemVuKHCN",
                        principalColumn: "IdNhiemVuKHCN");
                });

            migrationBuilder.CreateTable(
                name: "tbHoatDongBaoVeMoiTruong",
                schema: "KHCN",
                columns: table => new
                {
                    IdHoatDongBaoVeMoiTruong = table.Column<int>(type: "int", nullable: false),
                    IdNhiemVuKHCN = table.Column<int>(type: "int", nullable: true),
                    TenNhiemVuBVMT = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IdCapQuanLyNhiemVu = table.Column<int>(type: "int", nullable: true),
                    IdCoQuanChuQuan = table.Column<int>(type: "int", nullable: true),
                    CoQuanChuTri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdLoaiNhiemVuBaoVeMoiTruong = table.Column<int>(type: "int", nullable: true),
                    TongKinhPhiCuaNhiemVu = table.Column<int>(type: "int", nullable: true),
                    IdNguonKinhPhi = table.Column<int>(type: "int", nullable: true),
                    ThoiGianBatDau = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiGianKetThuc = table.Column<DateOnly>(type: "date", nullable: true),
                    DanhGiaKetQuaNhiemVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SanPhamChinhCuaNhiemVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DonViThucHienLuuTruSanPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdTinhTrangNhiemVu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHoatDongBaoVeMoiTruong", x => x.IdHoatDongBaoVeMoiTruong);
                    table.ForeignKey(
                        name: "FK_tbHoatDongBaoVeMoiTruong_dmCoQuanChuQuan",
                        column: x => x.IdCoQuanChuQuan,
                        principalSchema: "DM",
                        principalTable: "dmCoQuanChuQuan",
                        principalColumn: "IdCoQuanChuQuan");
                    table.ForeignKey(
                        name: "FK_tbHoatDongBaoVeMoiTruong_dmLoaiNhiemVuBaoVeMoiTruong",
                        column: x => x.IdLoaiNhiemVuBaoVeMoiTruong,
                        principalSchema: "DM",
                        principalTable: "dmLoaiNhiemVuBaoVeMoiTruong",
                        principalColumn: "IdLoaiNhiemVuBaoVeMoiTruong");
                    table.ForeignKey(
                        name: "FK_tbHoatDongBaoVeMoiTruong_dmNguonKinhPhi",
                        column: x => x.IdNguonKinhPhi,
                        principalSchema: "DM",
                        principalTable: "dmNguonKinhPhi",
                        principalColumn: "IdNguonKinhPhi");
                    table.ForeignKey(
                        name: "FK_tbHoatDongBaoVeMoiTruong_dmPhanCapNhiemVu",
                        column: x => x.IdCapQuanLyNhiemVu,
                        principalSchema: "DM",
                        principalTable: "dmPhanCapNhiemVu",
                        principalColumn: "IdPhanCapNhiemVu");
                    table.ForeignKey(
                        name: "FK_tbHoatDongBaoVeMoiTruong_dmTinhTrangNhiemVu",
                        column: x => x.IdTinhTrangNhiemVu,
                        principalSchema: "DM",
                        principalTable: "dmTinhTrangNhiemVu",
                        principalColumn: "IdTinhTrangNhiemVu");
                    table.ForeignKey(
                        name: "FK_tbHoatDongBaoVeMoiTruong_tbNhiemVuKHCN",
                        column: x => x.IdNhiemVuKHCN,
                        principalSchema: "KHCN",
                        principalTable: "tbNhiemVuKHCN",
                        principalColumn: "IdNhiemVuKHCN");
                });

            migrationBuilder.CreateTable(
                name: "tbSachDaXuatBan",
                schema: "KHCN",
                columns: table => new
                {
                    IdSachDaXuatBan = table.Column<int>(type: "int", nullable: false),
                    IdNhiemVuKHCN = table.Column<int>(type: "int", nullable: true),
                    MaSach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenSach = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IdLoaiSachTapChi = table.Column<int>(type: "int", nullable: true),
                    MaChuanISBN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoTrang = table.Column<int>(type: "int", nullable: true),
                    NXB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NamXuatBan = table.Column<string>(type: "text", nullable: true),
                    NamViet = table.Column<string>(type: "text", nullable: true),
                    IdDangTaiLieu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSachDaXuatBan", x => x.IdSachDaXuatBan);
                    table.ForeignKey(
                        name: "FK_tbSachDaXuatBan_dmDangTaiLieu",
                        column: x => x.IdDangTaiLieu,
                        principalSchema: "DM",
                        principalTable: "dmDangTaiLieu",
                        principalColumn: "IdDangTaiLieu");
                    table.ForeignKey(
                        name: "FK_tbSachDaXuatBan_dmLoaiSachTapChi",
                        column: x => x.IdLoaiSachTapChi,
                        principalSchema: "DM",
                        principalTable: "dmLoaiSachTapChi",
                        principalColumn: "IdLoaiSachTapChi");
                    table.ForeignKey(
                        name: "FK_tbSachDaXuatBan_tbNhiemVuKHCN",
                        column: x => x.IdNhiemVuKHCN,
                        principalSchema: "KHCN",
                        principalTable: "tbNhiemVuKHCN",
                        principalColumn: "IdNhiemVuKHCN");
                });

            migrationBuilder.CreateTable(
                name: "tbTaiSanTriTue",
                schema: "KHCN",
                columns: table => new
                {
                    IdTaiSanTriTue = table.Column<int>(type: "int", nullable: false),
                    IdNhiemVuKHCN = table.Column<int>(type: "int", nullable: true),
                    MaGiaiPhapSangChe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenTaiSanTriTue = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ToChucCapBangGiayChungNhan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdLoaiTaiSanTriTue = table.Column<int>(type: "int", nullable: true),
                    NgayCapBangGiayChungNhan = table.Column<DateOnly>(type: "date", nullable: true),
                    ToChucCapBang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoBang = table.Column<int>(type: "int", nullable: true),
                    NgayCap = table.Column<DateOnly>(type: "date", nullable: true),
                    SoDon = table.Column<int>(type: "int", nullable: true),
                    NgayNopDon = table.Column<DateOnly>(type: "date", nullable: true),
                    QuyetDinhCapBangGiayChungNhan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CongBoBang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChuSoHuu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TacGiaSangCheGiaiPhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TomTatNoiDungTaiSanTriTue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiChuTri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NamDuocChapNhanDonHopLe = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTaiSanTriTue", x => x.IdTaiSanTriTue);
                    table.ForeignKey(
                        name: "FK_tbTaiSanTriTue_dmLoaiTaiSanTriTue",
                        column: x => x.IdLoaiTaiSanTriTue,
                        principalSchema: "DM",
                        principalTable: "dmLoaiTaiSanTriTue",
                        principalColumn: "IdLoaiTaiSanTriTue");
                    table.ForeignKey(
                        name: "FK_tbTaiSanTriTue_tbNhiemVuKHCN",
                        column: x => x.IdNhiemVuKHCN,
                        principalSchema: "KHCN",
                        principalTable: "tbNhiemVuKHCN",
                        principalColumn: "IdNhiemVuKHCN");
                });

            migrationBuilder.CreateTable(
                name: "tbGiaHanChuongTrinhDaoTao",
                schema: "CTDT",
                columns: table => new
                {
                    IdGiaHanChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: false),
                    IdChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhGiaHan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayBanHanhVanBanGiaHan = table.Column<DateOnly>(type: "date", nullable: true),
                    GiaHanLanThu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbGiaHanChuongTrinhDaoTao", x => x.IdGiaHanChuongTrinhDaoTao);
                    table.ForeignKey(
                        name: "FK_tbGiaHanChuongTrinhDaoTao_tbChuongTrinhDaoTao",
                        column: x => x.IdChuongTrinhDaoTao,
                        principalSchema: "CTDT",
                        principalTable: "tbChuongTrinhDaoTao",
                        principalColumn: "IdChuongTrinhDaoTao");
                });

            migrationBuilder.CreateTable(
                name: "tbNamApDungChuongTrinh",
                schema: "CTDT",
                columns: table => new
                {
                    IdNamApDungChuongTrinh = table.Column<int>(type: "int", nullable: false),
                    IdChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    SoTinChiToiThieuDeTotNghiep = table.Column<int>(type: "int", nullable: true),
                    TongHocPhiToanKhoa = table.Column<int>(type: "int", nullable: true),
                    NamApDung = table.Column<DateOnly>(type: "date", nullable: true),
                    ChiTieuTuyenSinhHangNam = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNamApDungChuongTrinh", x => x.IdNamApDungChuongTrinh);
                    table.ForeignKey(
                        name: "FK_tbNamApDungChuongTrinh_tbNamApDungChuongTrinh",
                        column: x => x.IdChuongTrinhDaoTao,
                        principalSchema: "CTDT",
                        principalTable: "tbChuongTrinhDaoTao",
                        principalColumn: "IdChuongTrinhDaoTao");
                });

            migrationBuilder.CreateTable(
                name: "tbNgonNguGiangDay",
                schema: "CTDT",
                columns: table => new
                {
                    IdNgonNguGiangDay = table.Column<int>(type: "int", nullable: false),
                    IdChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdNgonNgu = table.Column<int>(type: "int", nullable: true),
                    IdTrinhDoNgonNguDauVao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNgonNguGiangDay", x => x.IdNgonNguGiangDay);
                    table.ForeignKey(
                        name: "FK_tbNgonNguGiangDay_dmKhungNangLucNgoaiNgu",
                        column: x => x.IdTrinhDoNgonNguDauVao,
                        principalSchema: "DM",
                        principalTable: "dmKhungNangLucNgoaiNgu",
                        principalColumn: "IdKhungNangLucNgoaiNgu");
                    table.ForeignKey(
                        name: "FK_tbNgonNguGiangDay_dmNgoaiNgu",
                        column: x => x.IdNgonNgu,
                        principalSchema: "DM",
                        principalTable: "dmNgoaiNgu",
                        principalColumn: "IdNgoaiNgu");
                    table.ForeignKey(
                        name: "FK_tbNgonNguGiangDay_tbChuongTrinhDaoTao",
                        column: x => x.IdChuongTrinhDaoTao,
                        principalSchema: "CTDT",
                        principalTable: "tbChuongTrinhDaoTao",
                        principalColumn: "IdChuongTrinhDaoTao");
                });

            migrationBuilder.CreateTable(
                name: "tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai",
                schema: "CTDT",
                columns: table => new
                {
                    IdQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai = table.Column<int>(type: "int", nullable: false),
                    IdChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdLoaiQuyetDinh = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayBanHanhQuyetDinh = table.Column<DateOnly>(type: "date", nullable: true),
                    IdHinhThucDaoTao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai", x => x.IdQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai);
                    table.ForeignKey(
                        name: "FK_tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai_dmHinhThucDaoTao",
                        column: x => x.IdHinhThucDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucDaoTao",
                        principalColumn: "IdHinhThucDaoTao");
                    table.ForeignKey(
                        name: "FK_tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai_dmLoaiQuyetDinh",
                        column: x => x.IdLoaiQuyetDinh,
                        principalSchema: "DM",
                        principalTable: "dmLoaiQuyetDinh",
                        principalColumn: "IdLoaiQuyetDinh");
                    table.ForeignKey(
                        name: "FK_tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai_tbChuongTrinhDaoTao",
                        column: x => x.IdChuongTrinhDaoTao,
                        principalSchema: "CTDT",
                        principalTable: "tbChuongTrinhDaoTao",
                        principalColumn: "IdChuongTrinhDaoTao");
                });

            migrationBuilder.CreateTable(
                name: "tbThongTinKiemDinhCuaChuongTrinh",
                schema: "CTDT",
                columns: table => new
                {
                    IdThongTinKiemDinhCuaChuongTrinh = table.Column<int>(type: "int", nullable: false),
                    IdChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: false),
                    IdToChucKiemDinh = table.Column<int>(type: "int", nullable: true),
                    IdKetQuaKiemDinh = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayCapChungNhanKiemDinh = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiHanKiemDinh = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbThongTinKiemDinhCuaChuongTrinh", x => x.IdThongTinKiemDinhCuaChuongTrinh);
                    table.ForeignKey(
                        name: "FK_tbThongTinKiemDinhCuaChuongTrinh_dmKetQuaKiemDinh",
                        column: x => x.IdKetQuaKiemDinh,
                        principalSchema: "DM",
                        principalTable: "dmKetQuaKiemDinh",
                        principalColumn: "IdKetQuaKiemDinh");
                    table.ForeignKey(
                        name: "FK_tbThongTinKiemDinhCuaChuongTrinh_dmToChucKiemDinh",
                        column: x => x.IdToChucKiemDinh,
                        principalSchema: "DM",
                        principalTable: "dmToChucKiemDinh",
                        principalColumn: "IdToChucKiemDinh");
                    table.ForeignKey(
                        name: "FK_tbThongTinKiemDinhCuaChuongTrinh_tbChuongTrinhDaoTao",
                        column: x => x.IdChuongTrinhDaoTao,
                        principalSchema: "CTDT",
                        principalTable: "tbChuongTrinhDaoTao",
                        principalColumn: "IdChuongTrinhDaoTao");
                });

            migrationBuilder.CreateTable(
                name: "tbDoiTuongThamGia",
                schema: "KHCN",
                columns: table => new
                {
                    IdDoiTuongThamGia = table.Column<int>(type: "int", nullable: false),
                    IdLoaiThamGia = table.Column<int>(type: "int", nullable: true),
                    MaLoaiThamGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdNguoi = table.Column<int>(type: "int", nullable: true),
                    IdVaiTro = table.Column<int>(type: "int", nullable: true),
                    IdPhanLoai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDoiTuongThamGia", x => x.IdDoiTuongThamGia);
                    table.ForeignKey(
                        name: "FK_tbDoiTuongThamGia_dmLoaiThamGia",
                        column: x => x.IdLoaiThamGia,
                        principalSchema: "DM",
                        principalTable: "dmLoaiThamGia",
                        principalColumn: "IdLoaiThamGia");
                    table.ForeignKey(
                        name: "FK_tbDoiTuongThamGia_dmPhanLoaiDoiNguNguoiHoc",
                        column: x => x.IdPhanLoai,
                        principalSchema: "DM",
                        principalTable: "dmPhanLoaiDoiNguNguoiHoc",
                        principalColumn: "IdPhanLoaiDoiNguNguoiHoc");
                    table.ForeignKey(
                        name: "FK_tbDoiTuongThamGia_dmVaiTroThamGia",
                        column: x => x.IdVaiTro,
                        principalSchema: "DM",
                        principalTable: "dmVaiTroThamGia",
                        principalColumn: "IdVaiTroThamGia");
                    table.ForeignKey(
                        name: "FK_tbDoiTuongThamGia_tbNguoi",
                        column: x => x.IdNguoi,
                        principalTable: "tbNguoi",
                        principalColumn: "IdNguoi");
                });

            migrationBuilder.CreateTable(
                name: "tbPhongThiNghiem",
                schema: "CSVC",
                columns: table => new
                {
                    IdPhongThiNghiem = table.Column<int>(type: "int", nullable: false),
                    IdCongTrinhCSVC = table.Column<int>(type: "int", nullable: true),
                    IdLoaiPhongThiNghiem = table.Column<int>(type: "int", nullable: true),
                    IdLinhVuc = table.Column<int>(type: "int", nullable: true),
                    MucDoDapUngNhuCauNCKH = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NamDuaVaoSuDung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPhongThiNghiem", x => x.IdPhongThiNghiem);
                    table.ForeignKey(
                        name: "FK_tbPhongThiNghiem_dmLinhVucNghienCuu",
                        column: x => x.IdLinhVuc,
                        principalSchema: "DM",
                        principalTable: "dmLinhVucNghienCuu",
                        principalColumn: "IdLinhVucNghienCuu");
                    table.ForeignKey(
                        name: "FK_tbPhongThiNghiem_dmLoaiPhongThiNghiem",
                        column: x => x.IdLoaiPhongThiNghiem,
                        principalSchema: "DM",
                        principalTable: "dmLoaiPhongThiNghiem",
                        principalColumn: "IdLoaiPhongThiNghiem");
                    table.ForeignKey(
                        name: "FK_tbPhongThiNghiem_tbCongTrinhCoSoVatChat",
                        column: x => x.IdCongTrinhCSVC,
                        principalSchema: "CSVC",
                        principalTable: "tbCongTrinhCoSoVatChat",
                        principalColumn: "IdCongTrinhCoSoVatChat");
                });

            migrationBuilder.CreateTable(
                name: "tbPhongThucHanh",
                schema: "CSVC",
                columns: table => new
                {
                    IdPhongThucHanh = table.Column<int>(type: "int", nullable: false),
                    IdCongTrinhCSVC = table.Column<int>(type: "int", nullable: true),
                    IdLinhVuc = table.Column<int>(type: "int", nullable: true),
                    MucDoDapUngNhuCauNCKH = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NamDuaVaoSuDung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPhongThucHanh", x => x.IdPhongThucHanh);
                    table.ForeignKey(
                        name: "FK_tbPhongThucHanh_dmLinhVucNghienCuu",
                        column: x => x.IdLinhVuc,
                        principalSchema: "DM",
                        principalTable: "dmLinhVucNghienCuu",
                        principalColumn: "IdLinhVucNghienCuu");
                    table.ForeignKey(
                        name: "FK_tbPhongThucHanh_tbCongTrinhCoSoVatChat",
                        column: x => x.IdCongTrinhCSVC,
                        principalSchema: "CSVC",
                        principalTable: "tbCongTrinhCoSoVatChat",
                        principalColumn: "IdCongTrinhCoSoVatChat");
                });

            migrationBuilder.CreateTable(
                name: "tbThietBiPTN_THTren500Tr",
                schema: "CSVC",
                columns: table => new
                {
                    IdThietBiPTN_TH = table.Column<int>(type: "int", nullable: false),
                    MaThietBi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdCongTrinhCSVC = table.Column<int>(type: "int", nullable: true),
                    TenThietBi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NamSanXuat = table.Column<string>(type: "text", nullable: true),
                    IdQuocGiaXuatXu = table.Column<int>(type: "int", nullable: true),
                    HangSanXuat = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoLuongThietBiCungLoai = table.Column<int>(type: "int", nullable: true),
                    NamDuaVaoSuDung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbThietBiPTN_THTren500Tr", x => x.IdThietBiPTN_TH);
                    table.ForeignKey(
                        name: "FK_tbThietBiPTN_THTren500Tr_dmQuocTich",
                        column: x => x.IdQuocGiaXuatXu,
                        principalSchema: "DM",
                        principalTable: "dmQuocTich",
                        principalColumn: "IdQuocTich");
                    table.ForeignKey(
                        name: "FK_tbThietBiPTN_THTren500Tr_tbCongTrinhCoSoVatChat",
                        column: x => x.IdCongTrinhCSVC,
                        principalSchema: "CSVC",
                        principalTable: "tbCongTrinhCoSoVatChat",
                        principalColumn: "IdCongTrinhCoSoVatChat");
                });

            migrationBuilder.CreateTable(
                name: "tbCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdCanBo = table.Column<int>(type: "int", nullable: false),
                    IdNguoi = table.Column<int>(type: "int", nullable: true),
                    MaCanBo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdChucVuCongTac = table.Column<int>(type: "int", nullable: true),
                    SoBaoHiemXaHoi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdXa = table.Column<int>(type: "int", nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true),
                    IdTinh = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DienThoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdTrangThaiLamViec = table.Column<int>(type: "int", nullable: true),
                    NgayChuyenTrangThai = table.Column<DateOnly>(type: "date", nullable: true),
                    SoQuyetDinhHuuNghiViec = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NgayQuyetDinhHuuNghiViec = table.Column<DateOnly>(type: "date", nullable: true),
                    HinhThucChuyenDen = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayKetThucTamNghi = table.Column<DateOnly>(type: "date", nullable: true),
                    IdChucDanhNgheNghiep = table.Column<int>(type: "int", nullable: true),
                    IdChucDanhGiangVien = table.Column<int>(type: "int", nullable: true),
                    IdChucDanhNghienCuuKhoaHoc = table.Column<int>(type: "int", nullable: true),
                    IdNgach = table.Column<int>(type: "int", nullable: true),
                    CoQuanCongTac = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayTuyenDung = table.Column<DateOnly>(type: "date", nullable: true),
                    ChungChiSuPhamGiangVien = table.Column<bool>(type: "bit", nullable: true),
                    LaCongChuc = table.Column<bool>(type: "bit", nullable: true),
                    LaVienChuc = table.Column<bool>(type: "bit", nullable: true),
                    CoDayMonMacLeNin = table.Column<bool>(type: "bit", nullable: true),
                    CoDayMonSuPham = table.Column<bool>(type: "bit", nullable: true),
                    SoGiayPhepLaoDong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ThamNienCongTac = table.Column<int>(type: "int", nullable: true),
                    TenDoanhNghiep = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NamKinhNghiemGiangDay = table.Column<int>(type: "int", nullable: true),
                    GiangVienDapUngTT03 = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCanBo", x => x.IdCanBo);
                    table.ForeignKey(
                        name: "FK_tbCanBo_dmChucDanhGiangDay",
                        column: x => x.IdChucDanhGiangVien,
                        principalSchema: "DM",
                        principalTable: "dmChucDanhGiangVien",
                        principalColumn: "IdChucDanhGiangVien");
                    table.ForeignKey(
                        name: "FK_tbCanBo_dmChucDanhNCKH",
                        column: x => x.IdChucDanhNghienCuuKhoaHoc,
                        principalSchema: "DM",
                        principalTable: "dmChucDanhNCKH",
                        principalColumn: "IdChucDanhNghienCuuKhoaHoc");
                    table.ForeignKey(
                        name: "FK_tbCanBo_dmChucDanhNgheNghiep",
                        column: x => x.IdChucDanhNgheNghiep,
                        principalSchema: "DM",
                        principalTable: "dmChucDanhNgheNghiep",
                        principalColumn: "IdChucDanhNgheNghiep");
                    table.ForeignKey(
                        name: "FK_tbCanBo_dmChucVu",
                        column: x => x.IdChucVuCongTac,
                        principalSchema: "DM",
                        principalTable: "dmChucVu",
                        principalColumn: "IdChucVu");
                    table.ForeignKey(
                        name: "FK_tbCanBo_dmHuyen",
                        column: x => x.IdHuyen,
                        principalSchema: "DM",
                        principalTable: "dmHuyen",
                        principalColumn: "IdHuyen");
                    table.ForeignKey(
                        name: "FK_tbCanBo_dmNgach",
                        column: x => x.IdNgach,
                        principalSchema: "DM",
                        principalTable: "dmNgach",
                        principalColumn: "IdNgach");
                    table.ForeignKey(
                        name: "FK_tbCanBo_dmTinh",
                        column: x => x.IdTinh,
                        principalSchema: "DM",
                        principalTable: "dmTinh",
                        principalColumn: "IdTinh");
                    table.ForeignKey(
                        name: "FK_tbCanBo_dmTrangThaiCanBo",
                        column: x => x.IdTrangThaiLamViec,
                        principalSchema: "DM",
                        principalTable: "dmTrangThaiCanBo",
                        principalColumn: "IdTrangThaiCanBo");
                    table.ForeignKey(
                        name: "FK_tbCanBo_dmXa",
                        column: x => x.IdXa,
                        principalSchema: "DM",
                        principalTable: "dmXa",
                        principalColumn: "IdXa");
                    table.ForeignKey(
                        name: "FK_tbCanBo_tbNguoi",
                        column: x => x.IdNguoi,
                        principalTable: "tbNguoi",
                        principalColumn: "IdNguoi");
                });

            migrationBuilder.CreateTable(
                name: "tbCoSoGiaoDuc",
                schema: "CSGD",
                columns: table => new
                {
                    IdCoSoGiaoDuc = table.Column<int>(type: "int", nullable: false),
                    MaDonVi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenDonVi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TenTiengAnh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdHinhThucThanhLap = table.Column<int>(type: "int", nullable: true),
                    IdLoaiHinhTruong = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhChuyenDoiLoaiHinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayKyQuyetDinhChuyenDoiLoaiHinh = table.Column<DateOnly>(type: "date", nullable: true),
                    TenDaiHocTrucThuoc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChiWebsite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdCoQuanChuQuan = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhThanhLap = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayKyQuyetDinhThanhLap = table.Column<DateOnly>(type: "date", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdTinh = table.Column<int>(type: "int", nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true),
                    IdXa = table.Column<int>(type: "int", nullable: true),
                    HoatDongKhongLoiNhuan = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhCapPhepHoatDong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayDuocCapPhepHoatDong = table.Column<DateOnly>(type: "date", nullable: true),
                    IdLoaiHinhCoSoDaoTao = table.Column<int>(type: "int", nullable: true),
                    SoGiaoVienGDTC = table.Column<int>(type: "int", nullable: true),
                    IdPhanLoaiCoSo = table.Column<int>(type: "int", nullable: true),
                    TuChuGiaoDucQPAN = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhGiaoTuChu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DaoTaoSVGDQPAN_1Nam = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhBanHanhQuyCheTaiChinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayKyQuyetDinhBanHanhQuyCheTaiChinh = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCoSoGiaoDuc", x => x.IdCoSoGiaoDuc);
                    table.ForeignKey(
                        name: "FK_tbCoSoGiaoDuc_dmCoQuanChuQuan",
                        column: x => x.IdCoQuanChuQuan,
                        principalSchema: "DM",
                        principalTable: "dmCoQuanChuQuan",
                        principalColumn: "IdCoQuanChuQuan");
                    table.ForeignKey(
                        name: "FK_tbCoSoGiaoDuc_dmHinhThucThanhLap",
                        column: x => x.IdHinhThucThanhLap,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucThanhLap",
                        principalColumn: "IdHinhThucThanhLap");
                    table.ForeignKey(
                        name: "FK_tbCoSoGiaoDuc_dmHuyen",
                        column: x => x.IdHuyen,
                        principalSchema: "DM",
                        principalTable: "dmHuyen",
                        principalColumn: "IdHuyen");
                    table.ForeignKey(
                        name: "FK_tbCoSoGiaoDuc_dmLoaiHinhCoSoDaoTao",
                        column: x => x.IdLoaiHinhCoSoDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLoaiHinhCoSoDaoTao",
                        principalColumn: "IdLoaiHinhCoSoDaoTao");
                    table.ForeignKey(
                        name: "FK_tbCoSoGiaoDuc_dmLoaiHinhTruong",
                        column: x => x.IdLoaiHinhTruong,
                        principalSchema: "DM",
                        principalTable: "dmLoaiHinhTruong",
                        principalColumn: "IdLoaiHinhTruong");
                    table.ForeignKey(
                        name: "FK_tbCoSoGiaoDuc_dmPhanLoaiCoSo",
                        column: x => x.IdPhanLoaiCoSo,
                        principalSchema: "DM",
                        principalTable: "dmPhanLoaiCoSo",
                        principalColumn: "IdPhanLoaiCoSo");
                    table.ForeignKey(
                        name: "FK_tbCoSoGiaoDuc_dmTinh",
                        column: x => x.IdTinh,
                        principalSchema: "DM",
                        principalTable: "dmTinh",
                        principalColumn: "IdTinh");
                    table.ForeignKey(
                        name: "FK_tbCoSoGiaoDuc_dmTuyChon",
                        column: x => x.HoatDongKhongLoiNhuan,
                        principalSchema: "DM",
                        principalTable: "dmTuyChon",
                        principalColumn: "IdTuyChon");
                    table.ForeignKey(
                        name: "FK_tbCoSoGiaoDuc_dmTuyChon1",
                        column: x => x.TuChuGiaoDucQPAN,
                        principalSchema: "DM",
                        principalTable: "dmTuyChon",
                        principalColumn: "IdTuyChon");
                    table.ForeignKey(
                        name: "FK_tbCoSoGiaoDuc_dmXa",
                        column: x => x.IdXa,
                        principalSchema: "DM",
                        principalTable: "dmXa",
                        principalColumn: "IdXa");
                });

            migrationBuilder.CreateTable(
                name: "tbHocVien",
                schema: "NH",
                columns: table => new
                {
                    IdHocVien = table.Column<int>(type: "int", nullable: false),
                    MaHocVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdNguoi = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoSoBaoHiem = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdLoaiKhuyetTat = table.Column<int>(type: "int", nullable: true),
                    IdTinh = table.Column<int>(type: "int", nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true),
                    IdXa = table.Column<int>(type: "int", nullable: true),
                    NoiSinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    QueQuan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHocVien", x => x.IdHocVien);
                    table.ForeignKey(
                        name: "FK_tbHocVien_dmHuyen",
                        column: x => x.IdHuyen,
                        principalSchema: "DM",
                        principalTable: "dmHuyen",
                        principalColumn: "IdHuyen");
                    table.ForeignKey(
                        name: "FK_tbHocVien_dmLoaiKhuyetTat",
                        column: x => x.IdLoaiKhuyetTat,
                        principalSchema: "DM",
                        principalTable: "dmLoaiKhuyetTat",
                        principalColumn: "IdLoaiKhuyetTat");
                    table.ForeignKey(
                        name: "FK_tbHocVien_dmTinh",
                        column: x => x.IdTinh,
                        principalSchema: "DM",
                        principalTable: "dmTinh",
                        principalColumn: "IdTinh");
                    table.ForeignKey(
                        name: "FK_tbHocVien_dmXa",
                        column: x => x.IdXa,
                        principalSchema: "DM",
                        principalTable: "dmXa",
                        principalColumn: "IdXa");
                    table.ForeignKey(
                        name: "FK_tbHocVien_tbNguoi",
                        column: x => x.IdNguoi,
                        principalTable: "tbNguoi",
                        principalColumn: "IdNguoi");
                });

            migrationBuilder.CreateTable(
                name: "tbCanBoHuongDanThanhCongSinhVien",
                schema: "CB",
                columns: table => new
                {
                    IdCanBoHuongDanThanhCongSinhVien = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdSinhVien = table.Column<int>(type: "int", nullable: true),
                    TrachNhiemHuongDan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ThoiGianBatDau = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiGianKetThuc = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCanBoHuongDanThanhCongSinhVien", x => x.IdCanBoHuongDanThanhCongSinhVien);
                    table.ForeignKey(
                        name: "FK_tbCanBoHuongDanThanhCongSinhVien_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbChucDanhKhoaHocCuaCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdChucDanhKhoaHocCuaCanBo = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdChucDanhKhoaHoc = table.Column<int>(type: "int", nullable: true),
                    IdThamQuyenQuyetDinh = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayQuyetDinh = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbChucDanhKhoaHocCuaCanBo", x => x.IdChucDanhKhoaHocCuaCanBo);
                    table.ForeignKey(
                        name: "FK_tbChucDanhKhoaHocCuaCanBo_dmChucDanhKhoaHoc",
                        column: x => x.IdChucDanhKhoaHoc,
                        principalSchema: "DM",
                        principalTable: "dmChucDanhKhoaHoc",
                        principalColumn: "IdChucDanhKhoaHoc");
                    table.ForeignKey(
                        name: "FK_tbChucDanhKhoaHocCuaCanBo_dmLoaiQuyetDinh",
                        column: x => x.IdThamQuyenQuyetDinh,
                        principalSchema: "DM",
                        principalTable: "dmLoaiQuyetDinh",
                        principalColumn: "IdLoaiQuyetDinh");
                    table.ForeignKey(
                        name: "FK_tbChucDanhKhoaHocCuaCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbDanhGiaXepLoaiCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdDanhGiaXepLoaiCanBo = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdDanhGia = table.Column<int>(type: "int", nullable: true),
                    NamDanhGia = table.Column<DateOnly>(type: "date", nullable: true),
                    NganhDuocKhenThuong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDanhGiaXepLoaiCanBo", x => x.IdDanhGiaXepLoaiCanBo);
                    table.ForeignKey(
                        name: "FK_tbDanhGiaXepLoaiCanBo_dmDanhGiaCongChucVienChuc",
                        column: x => x.IdDanhGia,
                        principalSchema: "DM",
                        principalTable: "dmDanhGiaCongChucVienChuc",
                        principalColumn: "IdDanhGiaCongChucVienChuc");
                    table.ForeignKey(
                        name: "FK_tbDanhGiaXepLoaiCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdDanhHieuThiDuaGiaiThuongKhenThuongCanBo = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong = table.Column<int>(type: "int", nullable: true),
                    IdThiDuaGiaiThuongKhenThuong = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinh = table.Column<int>(type: "int", nullable: true),
                    IdPhuongThucKhenThuong = table.Column<int>(type: "int", nullable: true),
                    NamKhenThuong = table.Column<DateOnly>(type: "date", nullable: true),
                    IdCapKhenThuong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo", x => x.IdDanhHieuThiDuaGiaiThuongKhenThuongCanBo);
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo_dmCapKhenThuong",
                        column: x => x.IdCapKhenThuong,
                        principalSchema: "DM",
                        principalTable: "dmCapKhenThuong",
                        principalColumn: "IdCapKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo_dmLoaiDanhHieuThiDuaGiaiThuongKhenThuong",
                        column: x => x.IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong,
                        principalSchema: "DM",
                        principalTable: "dmLoaiDanhHieuThiDuaGiaiThuongKhenThuong",
                        principalColumn: "IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo_dmPhuongThucKhenThuong",
                        column: x => x.IdPhuongThucKhenThuong,
                        principalSchema: "DM",
                        principalTable: "dmPhuongThucKhenThuong",
                        principalColumn: "IdPhuongThucKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo_dmThiDuaGiaiThuongKhenThuong",
                        column: x => x.IdThiDuaGiaiThuongKhenThuong,
                        principalSchema: "DM",
                        principalTable: "dmThiDuaGiaiThuongKhenThuong",
                        principalColumn: "IdThiDuaGiaiThuongKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbDienBienLuong",
                schema: "CB",
                columns: table => new
                {
                    IdDienBienLuong = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdTrinhDoDaoTao = table.Column<int>(type: "int", nullable: true),
                    NgayThangNam = table.Column<DateOnly>(type: "date", nullable: true),
                    IdBacLuong = table.Column<int>(type: "int", nullable: true),
                    IdHeSoLuong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDienBienLuong", x => x.IdDienBienLuong);
                    table.ForeignKey(
                        name: "FK_tbDienBienLuong_dmBacLuong",
                        column: x => x.IdBacLuong,
                        principalSchema: "DM",
                        principalTable: "dmBacLuong",
                        principalColumn: "IdBacLuong");
                    table.ForeignKey(
                        name: "FK_tbDienBienLuong_dmHeSoLuong",
                        column: x => x.IdHeSoLuong,
                        principalSchema: "DM",
                        principalTable: "dmHeSoLuong",
                        principalColumn: "IdHeSoLuong");
                    table.ForeignKey(
                        name: "FK_tbDienBienLuong_dmTrinhDoDaoTao",
                        column: x => x.IdTrinhDoDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmTrinhDoDaoTao",
                        principalColumn: "IdTrinhDoDaoTao");
                    table.ForeignKey(
                        name: "FK_tbDienBienLuong_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbDoiTuongChinhSachCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdDoiTuongChinhSachCanBo = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdDoiTuongChinhSach = table.Column<int>(type: "int", nullable: true),
                    TuNgay = table.Column<DateOnly>(type: "date", nullable: true),
                    DenNgay = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDoiTuongChinhSachCanBo", x => x.IdDoiTuongChinhSachCanBo);
                    table.ForeignKey(
                        name: "FK_tbDoiTuongChinhSachCanBo_dmDoiTuongChinhSach",
                        column: x => x.IdDoiTuongChinhSach,
                        principalSchema: "DM",
                        principalTable: "dmDoiTuongChinhSach",
                        principalColumn: "IdDoiTuongChinhSach");
                    table.ForeignKey(
                        name: "FK_tbDoiTuongChinhSachCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbDonViCongTacCuaCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdDVCT = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    MaPhongBanDonVi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdChucVu = table.Column<int>(type: "int", nullable: true),
                    IdHinhThucBoNhiem = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayQuyetDinh = table.Column<DateOnly>(type: "date", nullable: true),
                    LaDonViChinh = table.Column<bool>(type: "bit", nullable: true),
                    LaDonViGiangDay = table.Column<bool>(type: "bit", nullable: true),
                    ThoiGianCoHieuLuc = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiGianHetHieuLuc = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDVCT", x => x.IdDVCT);
                    table.ForeignKey(
                        name: "FK_tbDonViCongTacCuaCanBo_dmChucVu",
                        column: x => x.IdChucVu,
                        principalSchema: "DM",
                        principalTable: "dmChucVu",
                        principalColumn: "IdChucVu");
                    table.ForeignKey(
                        name: "FK_tbDonViCongTacCuaCanBo_dmHinhThucBoNhiem",
                        column: x => x.IdHinhThucBoNhiem,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucBoNhiem",
                        principalColumn: "IdHinhThucBoNhiem");
                    table.ForeignKey(
                        name: "FK_tbDonViCongTacCuaCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbDonViThinhGiangCuaCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdDonViThinhGiangCuaCanBo = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    DonViThinhGiang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoHopDongThinhGiang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ThoiGianBatDau = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiGianKetThuc = table.Column<DateOnly>(type: "date", nullable: true),
                    ThamNienGiangDay = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonViThinhGiangCuaCanBo", x => x.IdDonViThinhGiangCuaCanBo);
                    table.ForeignKey(
                        name: "FK_tbDonViThinhGiangCuaCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbGiangVienNN",
                schema: "CB",
                columns: table => new
                {
                    IdGVNN = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    CoQuanChuQuanONuocNgoai = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdNoiDungHoatDongTaiVietNam = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbGiangVienNN", x => x.IdGVNN);
                    table.ForeignKey(
                        name: "FK_tbGiangVienNN_dmNoiDungHoatDongTaiVietNam",
                        column: x => x.IdNoiDungHoatDongTaiVietNam,
                        principalSchema: "DM",
                        principalTable: "dmNoiDungHoatDongTaiVietNam",
                        principalColumn: "IdNoiDungHoatDongTaiVietNam");
                    table.ForeignKey(
                        name: "FK_tbGiangVienNN_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbGiaoVienQPAN",
                schema: "CB",
                columns: table => new
                {
                    IdGiaoVienQPAN = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    NamBatDauBietPhai = table.Column<DateOnly>(type: "date", nullable: true),
                    SoNamBietPhai = table.Column<DateOnly>(type: "date", nullable: true),
                    IdLoaiGiangVienQP = table.Column<int>(type: "int", nullable: true),
                    DaoTaoGDQPAN = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdQuanHam = table.Column<int>(type: "int", nullable: true),
                    SoTruongCongTac = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbGiaoVienQPAN", x => x.IdGiaoVienQPAN);
                    table.ForeignKey(
                        name: "FK_tbGiaoVienQPAN_dmLoaiGiangVienQuocPhong",
                        column: x => x.IdLoaiGiangVienQP,
                        principalSchema: "DM",
                        principalTable: "dmLoaiGiangVienQuocPhong",
                        principalColumn: "IdLoaiGiangVienQuocPhong");
                    table.ForeignKey(
                        name: "FK_tbGiaoVienQPAN_dmQuanHam",
                        column: x => x.IdQuanHam,
                        principalSchema: "DM",
                        principalTable: "dmQuanHam",
                        principalColumn: "IdQuanHam");
                    table.ForeignKey(
                        name: "FK_tbGiaoVienQPAN_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbGVDuocCuDiDaoTao",
                schema: "HTQT",
                columns: table => new
                {
                    IdGVDuocCuDiDaoTao = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdHinhThucThamGiaGVDuocCuDiDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdQuocGiaDen = table.Column<int>(type: "int", nullable: true),
                    TenCoSoGiaoDucThamGiaONN = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ThoiGianBatDau = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiGianKetThuc = table.Column<DateOnly>(type: "date", nullable: true),
                    IdTinhTrangGVDuocCuDiDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdNguonKinhPhiCuaGV = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbGVDuocCuDiDaoTao", x => x.IdGVDuocCuDiDaoTao);
                    table.ForeignKey(
                        name: "FK_tbGVDuocCuDiDaoTao_dmHinhThucThamGiaGVDuocCuDiDaoTao",
                        column: x => x.IdHinhThucThamGiaGVDuocCuDiDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucThamGiaGVDuocCuDiDaoTao",
                        principalColumn: "IdHinhThucThamGiaGVDuocCuDiDaoTao");
                    table.ForeignKey(
                        name: "FK_tbGVDuocCuDiDaoTao_dmNguonKinhPhiCuaGVDuocCuDiDaoTao",
                        column: x => x.IdNguonKinhPhiCuaGV,
                        principalSchema: "DM",
                        principalTable: "dmNguonKinhPhiCuaGVDuocCuDiDaoTao",
                        principalColumn: "IdNguonKinhPhiCuaGVDuocCuDiDaoTao");
                    table.ForeignKey(
                        name: "FK_tbGVDuocCuDiDaoTao_dmQuocTich",
                        column: x => x.IdQuocGiaDen,
                        principalSchema: "DM",
                        principalTable: "dmQuocTich",
                        principalColumn: "IdQuocTich");
                    table.ForeignKey(
                        name: "FK_tbGVDuocCuDiDaoTao_dmTinhTrangGiangVienDuocCuDiDaoTao",
                        column: x => x.IdTinhTrangGVDuocCuDiDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmTinhTrangGiangVienDuocCuDiDaoTao",
                        principalColumn: "IdTinhTrangGiangVienDuocCuDiDaoTao");
                    table.ForeignKey(
                        name: "FK_tbGVDuocCuDiDaoTao_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbHopDong",
                schema: "CB",
                columns: table => new
                {
                    IdHopDong = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    SoHopDong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdLoaiHopDong = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayQuyetDinh = table.Column<DateOnly>(type: "date", nullable: true),
                    CoGiaTriTu = table.Column<DateOnly>(type: "date", nullable: true),
                    CoGiaTriDen = table.Column<DateOnly>(type: "date", nullable: true),
                    IdTinhTrangHopDong = table.Column<int>(type: "int", nullable: true),
                    LamViecToanThoiGian = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHopDong", x => x.IdHopDong);
                    table.ForeignKey(
                        name: "FK_tbHopDong_dmLoaiHopDong",
                        column: x => x.IdLoaiHopDong,
                        principalSchema: "DM",
                        principalTable: "dmLoaiHopDong",
                        principalColumn: "IdLoaiHopDong");
                    table.ForeignKey(
                        name: "FK_tbHopDong_dmTinhTrangHopDong",
                        column: x => x.IdTinhTrangHopDong,
                        principalSchema: "DM",
                        principalTable: "dmTinhTrangHopDong",
                        principalColumn: "IdTinhTrangHopDong");
                    table.ForeignKey(
                        name: "FK_tbHopDong_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbHopDongThinhGiang",
                schema: "CB",
                columns: table => new
                {
                    IdHopDongThinhGiang = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    MaHopDongThinhGiang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoSoLaoDong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayCapSoLaoDong = table.Column<DateOnly>(type: "date", nullable: true),
                    NoiCapSoLaoDong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CoGiaTriTu = table.Column<DateOnly>(type: "date", nullable: true),
                    CoGiaTriDen = table.Column<DateOnly>(type: "date", nullable: true),
                    IdTrangThaiHopDong = table.Column<int>(type: "int", nullable: true),
                    TyLeThoiGianGiangDay = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbHopDongThinhGiang", x => x.IdHopDongThinhGiang);
                    table.ForeignKey(
                        name: "FK_tbHopDongThinhGiang_dmTrangThaiHopDong",
                        column: x => x.IdTrangThaiHopDong,
                        principalSchema: "DM",
                        principalTable: "dmTrangThaiHopDong",
                        principalColumn: "IdTrangThaiHopDong");
                    table.ForeignKey(
                        name: "FK_tbHopDongThinhGiang_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbKhoaBoiDuongTapHuanThamGiaCuaCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdKhoaBoiDuongTapHuanThamGiaCuaCanBo = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    TenKhoaBoiDuongTapHuan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DonViToChuc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdLoaiBoiDuong = table.Column<int>(type: "int", nullable: true),
                    DiaDiemToChuc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ThoiGianBatDau = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiGianKetThuc = table.Column<DateOnly>(type: "date", nullable: true),
                    IdNguonKinhPhi = table.Column<int>(type: "int", nullable: true),
                    ChungChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayCap = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbKhoaBoiDuongTapHuanThamGiaCuaCanBo", x => x.IdKhoaBoiDuongTapHuanThamGiaCuaCanBo);
                    table.ForeignKey(
                        name: "FK_tbKhoaBoiDuongTapHuanThamGiaCuaCanBo_dmLoaiBoiDuong",
                        column: x => x.IdLoaiBoiDuong,
                        principalSchema: "DM",
                        principalTable: "dmLoaiBoiDuong",
                        principalColumn: "IdLoaiBoiDuong");
                    table.ForeignKey(
                        name: "FK_tbKhoaBoiDuongTapHuanThamGiaCuaCanBo_dmNguonKinhPhi",
                        column: x => x.IdNguonKinhPhi,
                        principalSchema: "DM",
                        principalTable: "dmNguonKinhPhi",
                        principalColumn: "IdNguonKinhPhi");
                    table.ForeignKey(
                        name: "FK_tbKhoaBoiDuongTapHuanThamGiaCuaCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbKyLuatCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdKyLuatCanBo = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdLoaiKyLuat = table.Column<int>(type: "int", nullable: true),
                    LyDo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdCapQuyetDinh = table.Column<int>(type: "int", nullable: true),
                    NgayThangNamQuyetDinh = table.Column<DateOnly>(type: "date", nullable: true),
                    SoQuyetDinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NamBiKyLuat = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbKyLuatCanBo", x => x.IdKyLuatCanBo);
                    table.ForeignKey(
                        name: "FK_tbKyLuatCanBo_dmCapKhenThuong",
                        column: x => x.IdCapQuyetDinh,
                        principalSchema: "DM",
                        principalTable: "dmCapKhenThuong",
                        principalColumn: "IdCapKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbKyLuatCanBo_dmLoaiKyLuat",
                        column: x => x.IdLoaiKyLuat,
                        principalSchema: "DM",
                        principalTable: "dmLoaiKyLuat",
                        principalColumn: "IdLoaiKyLuat");
                    table.ForeignKey(
                        name: "FK_tbKyLuatCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbLinhVucNghienCuuCuaCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdLinhVucNghienCuuCuaCanBo = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdLinhVucNghienCuu = table.Column<int>(type: "int", nullable: true),
                    LaLinhVucNghienCuuChuyenSau = table.Column<bool>(type: "bit", nullable: true),
                    SoNamNghienCuu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLinhVucNghienCuuCuaCanBo", x => x.IdLinhVucNghienCuuCuaCanBo);
                    table.ForeignKey(
                        name: "FK_tbLinhVucNghienCuuCuaCanBo_dmLinhVucNghienCuu",
                        column: x => x.IdLinhVucNghienCuu,
                        principalSchema: "DM",
                        principalTable: "dmLinhVucNghienCuu",
                        principalColumn: "IdLinhVucNghienCuu");
                    table.ForeignKey(
                        name: "FK_tbLinhVucNghienCuuCuaCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbNganhDungTenGiangDay",
                schema: "CB",
                columns: table => new
                {
                    IdNganhDungTenGiangDay = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdNganhDaoTao = table.Column<int>(type: "int", nullable: true),
                    TrongSo = table.Column<double>(type: "float", nullable: true),
                    TenCanBo = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    TenNganhGiangDay = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNganhDungTenGiangDay", x => x.IdNganhDungTenGiangDay);
                    table.ForeignKey(
                        name: "FK_tbNganhDungTenGiangDay_dmNganhDaoTao",
                        column: x => x.IdNganhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmNganhDaoTao",
                        principalColumn: "IdNganhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbNganhDungTenGiangDay_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbNganhGiangDayCuaCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdNganhGiangDayCuaCanBo = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdTrinhDoDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdNganh = table.Column<int>(type: "int", nullable: true),
                    LaNganhChinh = table.Column<bool>(type: "bit", nullable: true),
                    DonViThinhGiang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNganhGiangDayCuaCanBo", x => x.IdNganhGiangDayCuaCanBo);
                    table.ForeignKey(
                        name: "FK_tbNganhGiangDayCuaCanBo_dmNganhDaoTao",
                        column: x => x.IdNganh,
                        principalSchema: "DM",
                        principalTable: "dmNganhDaoTao",
                        principalColumn: "IdNganhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbNganhGiangDayCuaCanBo_dmTrinhDoDaoTao",
                        column: x => x.IdTrinhDoDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmTrinhDoDaoTao",
                        principalColumn: "IdTrinhDoDaoTao");
                    table.ForeignKey(
                        name: "FK_tbNganhGiangDayCuaCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbPhuCap",
                schema: "CB",
                columns: table => new
                {
                    IdPhuCap = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    PhuCapThuHutNghe = table.Column<int>(type: "int", nullable: true),
                    PhuCapThamNien = table.Column<int>(type: "int", nullable: true),
                    PhuCapUuDaiNghe = table.Column<int>(type: "int", nullable: true),
                    PhuCapChucVu = table.Column<int>(type: "int", nullable: true),
                    PhuCapDocHai = table.Column<int>(type: "int", nullable: true),
                    PhuCapKhac = table.Column<int>(type: "int", nullable: true),
                    IdBacLuong = table.Column<int>(type: "int", nullable: true),
                    PhanTramVuotKhung = table.Column<int>(type: "int", nullable: true),
                    IdHeSoLuong = table.Column<int>(type: "int", nullable: true),
                    NgayThangNamHuongLuong = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPhuCap", x => x.IdPhuCap);
                    table.ForeignKey(
                        name: "FK_tbPhuCap_dmBacLuong",
                        column: x => x.IdBacLuong,
                        principalSchema: "DM",
                        principalTable: "dmBacLuong",
                        principalColumn: "IdBacLuong");
                    table.ForeignKey(
                        name: "FK_tbPhuCap_dmHeSoLuong",
                        column: x => x.IdHeSoLuong,
                        principalSchema: "DM",
                        principalTable: "dmHeSoLuong",
                        principalColumn: "IdHeSoLuong");
                    table.ForeignKey(
                        name: "FK_tbPhuCap_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbQuaTrinhCongTacCuaCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdQuaTrinhCongTacCuaCanBo = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    TuThangNam = table.Column<DateOnly>(type: "date", nullable: true),
                    DenThangNam = table.Column<DateOnly>(type: "date", nullable: true),
                    IdChucVu = table.Column<int>(type: "int", nullable: true),
                    IdChucDanhGiangVien = table.Column<int>(type: "int", nullable: true),
                    DonViCongTac = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbQuaTrinhCongTacCuaCanBo", x => x.IdQuaTrinhCongTacCuaCanBo);
                    table.ForeignKey(
                        name: "FK_tbQuaTrinhCongTacCuaCanBo_dmChucDanhGiangVien",
                        column: x => x.IdChucDanhGiangVien,
                        principalSchema: "DM",
                        principalTable: "dmChucDanhGiangVien",
                        principalColumn: "IdChucDanhGiangVien");
                    table.ForeignKey(
                        name: "FK_tbQuaTrinhCongTacCuaCanBo_dmChucVu",
                        column: x => x.IdChucVu,
                        principalSchema: "DM",
                        principalTable: "dmChucVu",
                        principalColumn: "IdChucVu");
                    table.ForeignKey(
                        name: "FK_tbQuaTrinhCongTacCuaCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbQuaTrinhDaoTaoCuaCanBo",
                schema: "CB",
                columns: table => new
                {
                    IdQuaTrinhDaoTaoCuaCanBo = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdTrinhDoDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdQuocGiaDaoTao = table.Column<int>(type: "int", nullable: true),
                    CoSoDaoTao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ThoiGianBatDau = table.Column<DateOnly>(type: "date", nullable: true),
                    ThoiGianKetThuc = table.Column<DateOnly>(type: "date", nullable: true),
                    IdNganhDaoTao = table.Column<int>(type: "int", nullable: true),
                    NamTotNghiep = table.Column<DateOnly>(type: "date", nullable: true),
                    IdLoaiHinhDaoTao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbQuaTrinhDaoTaoCuaCanBo", x => x.IdQuaTrinhDaoTaoCuaCanBo);
                    table.ForeignKey(
                        name: "FK_tbQuaTrinhDaoTaoCuaCanBo_dmLoaiHinhDaoTao",
                        column: x => x.IdLoaiHinhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLoaiHinhDaoTao",
                        principalColumn: "IdLoaiHinhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbQuaTrinhDaoTaoCuaCanBo_dmNganhDaoTao",
                        column: x => x.IdNganhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmNganhDaoTao",
                        principalColumn: "IdNganhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbQuaTrinhDaoTaoCuaCanBo_dmQuocTich",
                        column: x => x.IdQuocGiaDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmQuocTich",
                        principalColumn: "IdQuocTich");
                    table.ForeignKey(
                        name: "FK_tbQuaTrinhDaoTaoCuaCanBo_dmTrinhDoDaoTao",
                        column: x => x.IdTrinhDoDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmTrinhDoDaoTao",
                        principalColumn: "IdTrinhDoDaoTao");
                    table.ForeignKey(
                        name: "FK_tbQuaTrinhDaoTaoCuaCanBo_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbThanhPhanThamGiaDoanCongTac",
                schema: "HTQT",
                columns: table => new
                {
                    IdThanhPhanThamGiaDoanCongTac = table.Column<int>(type: "int", nullable: false),
                    IdDoanCongTac = table.Column<int>(type: "int", nullable: true),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdVaiTroThamGia = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbThanhPhanThamGiaDoanCongTac", x => x.IdThanhPhanThamGiaDoanCongTac);
                    table.ForeignKey(
                        name: "FK_tbThanhPhanThamGiaDoanCongTac_dmVaiTroThamGia",
                        column: x => x.IdVaiTroThamGia,
                        principalSchema: "DM",
                        principalTable: "dmVaiTroThamGia",
                        principalColumn: "IdVaiTroThamGia");
                    table.ForeignKey(
                        name: "FK_tbThanhPhanThamGiaDoanCongTac_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                    table.ForeignKey(
                        name: "FK_tbThanhPhanThamGiaDoanCongTac_tbDoanCongTac",
                        column: x => x.IdDoanCongTac,
                        principalSchema: "HTQT",
                        principalTable: "tbDoanCongTac",
                        principalColumn: "IdDoanCongTac");
                });

            migrationBuilder.CreateTable(
                name: "tbTrinhDoTiengDanToc",
                schema: "CB",
                columns: table => new
                {
                    IdTrinhDoTiengDanToc = table.Column<int>(type: "int", nullable: false),
                    IdCanBo = table.Column<int>(type: "int", nullable: true),
                    IdTiengDanToc = table.Column<int>(type: "int", nullable: true),
                    IdKhungNangLucNgoaiNgu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTrinhDoTiengDanToc", x => x.IdTrinhDoTiengDanToc);
                    table.ForeignKey(
                        name: "FK_tbTrinhDoTiengDanToc_dmKhungNangLucNgoaiNgu",
                        column: x => x.IdKhungNangLucNgoaiNgu,
                        principalSchema: "DM",
                        principalTable: "dmKhungNangLucNgoaiNgu",
                        principalColumn: "IdKhungNangLucNgoaiNgu");
                    table.ForeignKey(
                        name: "FK_tbTrinhDoTiengDanToc_dmTiengDanToc",
                        column: x => x.IdTiengDanToc,
                        principalSchema: "DM",
                        principalTable: "dmTiengDanToc",
                        principalColumn: "IdTiengDanToc");
                    table.ForeignKey(
                        name: "FK_tbTrinhDoTiengDanToc_tbCanBo",
                        column: x => x.IdCanBo,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                });

            migrationBuilder.CreateTable(
                name: "tbDonViLienKetDaoTaoGiaoDuc",
                schema: "CSGD",
                columns: table => new
                {
                    IdDonViLienKetDaoTaoGiaoDuc = table.Column<int>(type: "int", nullable: false),
                    IdCoSoGiaoDuc = table.Column<int>(type: "int", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DienThoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdLoaiLienKet = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonViLienKetDaoTaoGiaoDuc", x => x.IdDonViLienKetDaoTaoGiaoDuc);
                    table.ForeignKey(
                        name: "FK_tbDonViLienKetDaoTaoGiaoDuc_tbCoSoGiaoDuc",
                        column: x => x.IdCoSoGiaoDuc,
                        principalSchema: "CSGD",
                        principalTable: "tbCoSoGiaoDuc",
                        principalColumn: "IdCoSoGiaoDuc");
                    table.ForeignKey(
                        name: "FK_tbDonViLienKetDaoTaoGiaoDuc_tbDonViLienKetDaoTaoGiaoDuc",
                        column: x => x.IdLoaiLienKet,
                        principalSchema: "DM",
                        principalTable: "dmLoaiLienKet",
                        principalColumn: "IdLoaiLienKet");
                });

            migrationBuilder.CreateTable(
                name: "tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc",
                schema: "NH",
                columns: table => new
                {
                    IdDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc = table.Column<int>(type: "int", nullable: false),
                    IdHocVien = table.Column<int>(type: "int", nullable: true),
                    IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong = table.Column<int>(type: "int", nullable: true),
                    IdDanhHieuThiDuaGiaiThuongKhenThuong = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhKhenThuong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdPhuongThucKhenThuong = table.Column<int>(type: "int", nullable: true),
                    NamKhenThuong = table.Column<string>(type: "text", nullable: true),
                    IdCapKhenThuong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc", x => x.IdDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc);
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc_dmCapKhenThuong",
                        column: x => x.IdCapKhenThuong,
                        principalSchema: "DM",
                        principalTable: "dmCapKhenThuong",
                        principalColumn: "IdCapKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc_dmLoaiDanhHieuThiDuaGiaiThuongKhenThuong",
                        column: x => x.IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong,
                        principalSchema: "DM",
                        principalTable: "dmLoaiDanhHieuThiDuaGiaiThuongKhenThuong",
                        principalColumn: "IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc_dmPhuongThucKhenThuong",
                        column: x => x.IdPhuongThucKhenThuong,
                        principalSchema: "DM",
                        principalTable: "dmPhuongThucKhenThuong",
                        principalColumn: "IdPhuongThucKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc_dmThiDuaGiaiThuongKhenThuong",
                        column: x => x.IdDanhHieuThiDuaGiaiThuongKhenThuong,
                        principalSchema: "DM",
                        principalTable: "dmThiDuaGiaiThuongKhenThuong",
                        principalColumn: "IdThiDuaGiaiThuongKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc_tbHocVien",
                        column: x => x.IdHocVien,
                        principalSchema: "NH",
                        principalTable: "tbHocVien",
                        principalColumn: "IdHocVien");
                });

            migrationBuilder.CreateTable(
                name: "tbDanhSachVanBangChungChi",
                schema: "VB",
                columns: table => new
                {
                    IdDanhSachVanBangChungChi = table.Column<int>(type: "int", nullable: false),
                    IdHocVien = table.Column<int>(type: "int", nullable: true),
                    TenVanBang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    TenDonViBangCap = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayCap = table.Column<DateOnly>(type: "date", nullable: true),
                    NamTotNghiep = table.Column<string>(type: "text", nullable: true),
                    IdLoaiTotNghiep = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhCongNhanTotNghiep = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayQuyetDinhCongNhanTotNghiep = table.Column<DateOnly>(type: "date", nullable: true),
                    SoHieuVanBang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoVaoSoGocCapVanBang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoQuyetDinhThanhLapHoiDongDanhGiaLuanVan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayBaoVe = table.Column<DateOnly>(type: "date", nullable: true),
                    LinkFileScan = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDanhSachVanBangChungChi", x => x.IdDanhSachVanBangChungChi);
                    table.ForeignKey(
                        name: "FK_tbDanhSachVanBangChungChi_dmLoaiTotNghiep",
                        column: x => x.IdLoaiTotNghiep,
                        principalSchema: "DM",
                        principalTable: "dmLoaiTotNghiep",
                        principalColumn: "IdLoaiTotNghiep");
                    table.ForeignKey(
                        name: "FK_tbDanhSachVanBangChungChi_tbHocVien",
                        column: x => x.IdHocVien,
                        principalSchema: "NH",
                        principalTable: "tbHocVien",
                        principalColumn: "IdHocVien");
                });

            migrationBuilder.CreateTable(
                name: "tbKyLuatNguoiHoc",
                schema: "NH",
                columns: table => new
                {
                    IdKyLuatNguoiHoc = table.Column<int>(type: "int", nullable: false),
                    IdHocVien = table.Column<int>(type: "int", nullable: true),
                    IdLoaiKyLuat = table.Column<int>(type: "int", nullable: true),
                    LyDo = table.Column<string>(type: "ntext", nullable: true),
                    IdCapQuyetDinh = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayQuyetDinh = table.Column<DateOnly>(type: "date", nullable: true),
                    NamBiKyLuat = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbKyLuatNguoiHoc", x => x.IdKyLuatNguoiHoc);
                    table.ForeignKey(
                        name: "FK_tbKyLuatNguoiHoc_dmCapKhenThuong",
                        column: x => x.IdCapQuyetDinh,
                        principalSchema: "DM",
                        principalTable: "dmCapKhenThuong",
                        principalColumn: "IdCapKhenThuong");
                    table.ForeignKey(
                        name: "FK_tbKyLuatNguoiHoc_dmLoaiKyLuat",
                        column: x => x.IdLoaiKyLuat,
                        principalSchema: "DM",
                        principalTable: "dmLoaiKyLuat",
                        principalColumn: "IdLoaiKyLuat");
                    table.ForeignKey(
                        name: "FK_tbKyLuatNguoiHoc_tbHocVien",
                        column: x => x.IdHocVien,
                        principalSchema: "NH",
                        principalTable: "tbHocVien",
                        principalColumn: "IdHocVien");
                });

            migrationBuilder.CreateTable(
                name: "tbNguoiHocVayTinDung",
                schema: "NH",
                columns: table => new
                {
                    IdNguoiHocVayTinDung = table.Column<int>(type: "int", nullable: false),
                    IdHocVien = table.Column<int>(type: "int", nullable: true),
                    SoTienDuocVay = table.Column<int>(type: "int", nullable: true),
                    TenToChucTinDung = table.Column<string>(type: "text", nullable: true),
                    NgayVay = table.Column<DateOnly>(type: "date", nullable: true),
                    DiaChi = table.Column<string>(type: "text", nullable: true),
                    ThoiHanVay = table.Column<int>(type: "int", nullable: true),
                    TinhTrangVay = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNguoiHocVayTinDung", x => x.IdNguoiHocVayTinDung);
                    table.ForeignKey(
                        name: "FK_tbNguoiHocVayTinDung_dmTuyChon",
                        column: x => x.TinhTrangVay,
                        principalSchema: "DM",
                        principalTable: "dmTuyChon",
                        principalColumn: "IdTuyChon");
                    table.ForeignKey(
                        name: "FK_tbNguoiHocVayTinDung_tbHocVien",
                        column: x => x.IdHocVien,
                        principalSchema: "NH",
                        principalTable: "tbHocVien",
                        principalColumn: "IdHocVien");
                });

            migrationBuilder.CreateTable(
                name: "tbThongTinHocBong",
                schema: "NH",
                columns: table => new
                {
                    IdThongTinHocBong = table.Column<int>(type: "int", nullable: false),
                    IdHocVien = table.Column<int>(type: "int", nullable: true),
                    TenHocBong = table.Column<string>(type: "text", nullable: true),
                    DonViTaiTro = table.Column<string>(type: "text", nullable: true),
                    ThoiGianTraoTangHocBong = table.Column<DateOnly>(type: "date", nullable: true),
                    IdLoaiHocBong = table.Column<int>(type: "int", nullable: true),
                    GiaTriHocBong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbThongTinHocBong", x => x.IdThongTinHocBong);
                    table.ForeignKey(
                        name: "FK_tbThongTinHocBong_dmLoaiHocBong",
                        column: x => x.IdLoaiHocBong,
                        principalSchema: "DM",
                        principalTable: "dmLoaiHocBong",
                        principalColumn: "IdLoaiHocBong");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocBong_tbHocVien",
                        column: x => x.IdHocVien,
                        principalSchema: "NH",
                        principalTable: "tbHocVien",
                        principalColumn: "IdHocVien");
                });

            migrationBuilder.CreateTable(
                name: "tbThongTinHocTapNghienCuuSinh",
                schema: "NH",
                columns: table => new
                {
                    IdThongTinHocTapNghienCuuSinh = table.Column<int>(type: "int", nullable: false),
                    IdHocVien = table.Column<int>(type: "int", nullable: true),
                    IdDoiTuongDauVao = table.Column<int>(type: "int", nullable: true),
                    IdSinhVienNam = table.Column<int>(type: "int", nullable: true),
                    IdChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdLoaiHinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    DaoTaoTuNam = table.Column<DateOnly>(type: "date", nullable: true),
                    DaoTaoDenNam = table.Column<DateOnly>(type: "date", nullable: true),
                    NgayNhapHoc = table.Column<DateOnly>(type: "date", nullable: true),
                    IdTrangThaiHoc = table.Column<int>(type: "int", nullable: true),
                    NgayChuyenTrangThai = table.Column<DateOnly>(type: "date", nullable: true),
                    SoQuyetDinhThoiHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayBaoVeCapTruong = table.Column<DateOnly>(type: "date", nullable: true),
                    NgayBaoVeCapCoSo = table.Column<DateOnly>(type: "date", nullable: true),
                    QuyChuanNguoiHuongDan = table.Column<string>(type: "ntext", nullable: true),
                    IdNguoiHuongDanChinh = table.Column<int>(type: "int", nullable: true),
                    IdNguoiHuongDanPhu = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhCongNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayQuyetDinhCongNhan = table.Column<DateOnly>(type: "date", nullable: true),
                    IdLoaiTotNghiep = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhThanhLapHoiDongBaoVeCapCoSo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayQuyetDinhThanhLapHoiDongBaoVeCapCoSo = table.Column<DateOnly>(type: "date", nullable: true),
                    SoQuyetDinhThanhLapHoiDongBaoVeCapTruong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayQuyetDinhThanhLapHoiDongBaoVeCapTruong = table.Column<DateOnly>(type: "date", nullable: true),
                    TenLuanVan = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbThongTinHocTapNghienCuuSinh", x => x.IdThongTinHocTapNghienCuuSinh);
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapNghienCuuSinh_dmChuongTrinhDaoTao",
                        column: x => x.IdChuongTrinhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmChuongTrinhDaoTao",
                        principalColumn: "IdChuongTrinhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapNghienCuuSinh_dmDoiTuongDauVao",
                        column: x => x.IdDoiTuongDauVao,
                        principalSchema: "DM",
                        principalTable: "dmDoiTuongDauVao",
                        principalColumn: "IdDoiTuongDauVao");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapNghienCuuSinh_dmLoaiHinhDaoTao",
                        column: x => x.IdLoaiHinhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLoaiHinhDaoTao",
                        principalColumn: "IdLoaiHinhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapNghienCuuSinh_dmLoaiTotNghiep",
                        column: x => x.IdLoaiTotNghiep,
                        principalSchema: "DM",
                        principalTable: "dmLoaiTotNghiep",
                        principalColumn: "IdLoaiTotNghiep");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapNghienCuuSinh_dmSinhVienNam",
                        column: x => x.IdSinhVienNam,
                        principalSchema: "DM",
                        principalTable: "dmSinhVienNam",
                        principalColumn: "IdSinhVienNam");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapNghienCuuSinh_dmTrangThaiHoc",
                        column: x => x.IdTrangThaiHoc,
                        principalSchema: "DM",
                        principalTable: "dmTrangThaiHoc",
                        principalColumn: "IdTrangThaiHoc");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapNghienCuuSinh_tbCanBo",
                        column: x => x.IdNguoiHuongDanChinh,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapNghienCuuSinh_tbCanBo1",
                        column: x => x.IdNguoiHuongDanPhu,
                        principalSchema: "CB",
                        principalTable: "tbCanBo",
                        principalColumn: "IdCanBo");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapNghienCuuSinh_tbHocVien",
                        column: x => x.IdHocVien,
                        principalSchema: "NH",
                        principalTable: "tbHocVien",
                        principalColumn: "IdHocVien");
                });

            migrationBuilder.CreateTable(
                name: "tbThongTinHocTapSinhVien",
                schema: "NH",
                columns: table => new
                {
                    IdThongTinHocTapHocVien = table.Column<int>(type: "int", nullable: false),
                    IdHocVien = table.Column<int>(type: "int", nullable: true),
                    IdDoiTuongDauVao = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhTrungTuyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayKyQuyetDinhTrungTuyen = table.Column<DateOnly>(type: "date", nullable: true),
                    IdSinhVienNam = table.Column<int>(type: "int", nullable: true),
                    KetQuaTuyenSinh = table.Column<string>(type: "text", nullable: true),
                    IdChuongTrinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    IdLoaiHinhDaoTao = table.Column<int>(type: "int", nullable: true),
                    DaoTaoTuNam = table.Column<DateOnly>(type: "date", nullable: true),
                    DaoTaoDenNam = table.Column<DateOnly>(type: "date", nullable: true),
                    Khoa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Lop = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BangTotNghiepLienThong = table.Column<int>(type: "int", nullable: true),
                    DangONoiTru = table.Column<int>(type: "int", nullable: true),
                    NgayNhapHoc = table.Column<DateOnly>(type: "date", nullable: true),
                    IdTrangThaiHoc = table.Column<int>(type: "int", nullable: true),
                    NgayChuyenTrangThai = table.Column<DateOnly>(type: "date", nullable: true),
                    SoQuyetDinhThoiHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ThoiGianTotNghiep = table.Column<DateOnly>(type: "date", nullable: true),
                    IdLoaiTotNghiep = table.Column<int>(type: "int", nullable: true),
                    SoQuyetDinhTotNghiep = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayQuyetDinhCongNhanTotNghiep = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapHocVien_dmChuongTrinhDaoTao",
                        column: x => x.IdChuongTrinhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmChuongTrinhDaoTao",
                        principalColumn: "IdChuongTrinhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapHocVien_dmDoiTuongDauVao",
                        column: x => x.IdDoiTuongDauVao,
                        principalSchema: "DM",
                        principalTable: "dmDoiTuongDauVao",
                        principalColumn: "IdDoiTuongDauVao");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapHocVien_dmLoaiHinhDaoTao",
                        column: x => x.IdLoaiHinhDaoTao,
                        principalSchema: "DM",
                        principalTable: "dmLoaiHinhDaoTao",
                        principalColumn: "IdLoaiHinhDaoTao");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapHocVien_dmLoaiTotNghiep",
                        column: x => x.IdLoaiTotNghiep,
                        principalSchema: "DM",
                        principalTable: "dmLoaiTotNghiep",
                        principalColumn: "IdLoaiTotNghiep");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapHocVien_dmSinhVienNam",
                        column: x => x.IdSinhVienNam,
                        principalSchema: "DM",
                        principalTable: "dmSinhVienNam",
                        principalColumn: "IdSinhVienNam");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapHocVien_dmTrangThaiHoc",
                        column: x => x.IdTrangThaiHoc,
                        principalSchema: "DM",
                        principalTable: "dmTrangThaiHoc",
                        principalColumn: "IdTrangThaiHoc");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapHocVien_dmTuyChon",
                        column: x => x.BangTotNghiepLienThong,
                        principalSchema: "DM",
                        principalTable: "dmTuyChon",
                        principalColumn: "IdTuyChon");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapHocVien_dmTuyChon1",
                        column: x => x.DangONoiTru,
                        principalSchema: "DM",
                        principalTable: "dmTuyChon",
                        principalColumn: "IdTuyChon");
                    table.ForeignKey(
                        name: "FK_tbThongTinHocTapHocVien_tbHocVien",
                        column: x => x.IdHocVien,
                        principalSchema: "NH",
                        principalTable: "tbHocVien",
                        principalColumn: "IdHocVien");
                });

            migrationBuilder.CreateTable(
                name: "tbThongTinNguoiHocGDTC",
                schema: "NH",
                columns: table => new
                {
                    IdThongTinNguoiHocGDTC = table.Column<int>(type: "int", nullable: false),
                    IdHocVien = table.Column<int>(type: "int", nullable: true),
                    KetQuaHocTap = table.Column<string>(type: "text", nullable: true),
                    TieuChuanDanhGiaXepLoaiTheLuc = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbThongTinNguoiHocGDTC", x => x.IdThongTinNguoiHocGDTC);
                    table.ForeignKey(
                        name: "FK_tbThongTinNguoiHocGDTC_tbHocVien",
                        column: x => x.IdHocVien,
                        principalSchema: "NH",
                        principalTable: "tbHocVien",
                        principalColumn: "IdHocVien");
                });

            migrationBuilder.CreateTable(
                name: "tbThongTinViecLamSauTotNghiep",
                schema: "NH",
                columns: table => new
                {
                    IdThongTinViecLamSauTotNghiep = table.Column<int>(type: "int", nullable: false),
                    IdHocVien = table.Column<int>(type: "int", nullable: true),
                    TenDonViCapBang = table.Column<string>(type: "text", nullable: true),
                    DonViTuyenDung = table.Column<string>(type: "text", nullable: true),
                    IdHinhThucTuyenDung = table.Column<int>(type: "int", nullable: true),
                    ThoiGianTuyenDung = table.Column<DateOnly>(type: "date", nullable: true),
                    IdViTriViecLam = table.Column<int>(type: "int", nullable: true),
                    MucLuongKhoiDiem = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbThongTinViecLamSauTotNghiep", x => x.IdThongTinViecLamSauTotNghiep);
                    table.ForeignKey(
                        name: "FK_tbThongTinViecLamSauTotNghiep_dmHinhThucTuyenDung",
                        column: x => x.IdHinhThucTuyenDung,
                        principalSchema: "DM",
                        principalTable: "dmHinhThucTuyenDung",
                        principalColumn: "IdHinhThucTuyenDung");
                    table.ForeignKey(
                        name: "FK_tbThongTinViecLamSauTotNghiep_dmViTriViecLam",
                        column: x => x.IdViTriViecLam,
                        principalSchema: "DM",
                        principalTable: "dmViTriViecLam",
                        principalColumn: "IdViTriViecLam");
                    table.ForeignKey(
                        name: "FK_tbThongTinViecLamSauTotNghiep_tbHocVien",
                        column: x => x.IdHocVien,
                        principalSchema: "NH",
                        principalTable: "tbHocVien",
                        principalColumn: "IdHocVien");
                });

            migrationBuilder.CreateTable(
                name: "tbThongTinViPham",
                schema: "NH",
                columns: table => new
                {
                    IdThongTinViPham = table.Column<int>(type: "int", nullable: false),
                    IdHocVien = table.Column<int>(type: "int", nullable: true),
                    ThoiGianViPham = table.Column<DateOnly>(type: "date", nullable: true),
                    NoiDungViPham = table.Column<string>(type: "text", nullable: true),
                    HinhThucXuLy = table.Column<string>(type: "text", nullable: true),
                    IdLoaiViPham = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbThongTinViPham", x => x.IdThongTinViPham);
                    table.ForeignKey(
                        name: "FK_tbThongTinViPham_dmLoaiViPham",
                        column: x => x.IdLoaiViPham,
                        principalSchema: "DM",
                        principalTable: "dmLoaiViPham",
                        principalColumn: "IdLoaiViPham");
                    table.ForeignKey(
                        name: "FK_tbThongTinViPham_tbHocVien",
                        column: x => x.IdHocVien,
                        principalSchema: "NH",
                        principalTable: "tbHocVien",
                        principalColumn: "IdHocVien");
                });

            migrationBuilder.CreateIndex(
                name: "IX_dmHuyen_IdTinh",
                schema: "DM",
                table: "dmHuyen",
                column: "IdTinh");

            migrationBuilder.CreateIndex(
                name: "IX_dmKhoiNganhLinhVucDaoTao_IdKhoiNganh",
                schema: "DM",
                table: "dmKhoiNganhLinhVucDaoTao",
                column: "IdKhoiNganh");

            migrationBuilder.CreateIndex(
                name: "IX_dmKhoiNganhLinhVucDaoTao_IdLinhVucDaoTao",
                schema: "DM",
                table: "dmKhoiNganhLinhVucDaoTao",
                column: "IdLinhVucDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_dmLinhVucNhomNganh_IdLinhVucDaoTao",
                schema: "DM",
                table: "dmLinhVucNhomNganh",
                column: "IdLinhVucDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_dmLinhVucNhomNganh_IdNhomNganh",
                schema: "DM",
                table: "dmLinhVucNhomNganh",
                column: "IdNhomNganh");

            migrationBuilder.CreateIndex(
                name: "IX_dmXa_IdHuyen",
                schema: "DM",
                table: "dmXa",
                column: "IdHuyen");

            migrationBuilder.CreateIndex(
                name: "IX_tbBaiBaoKHDaCongBo_IdNhiemVuKHCN",
                schema: "KHCN",
                table: "tbBaiBaoKHDaCongBo",
                column: "IdNhiemVuKHCN");

            migrationBuilder.CreateIndex(
                name: "IX_tbBaiBaoKHDaCongBo_IdTapChiQuocTe",
                schema: "KHCN",
                table: "tbBaiBaoKHDaCongBo",
                column: "IdTapChiQuocTe");

            migrationBuilder.CreateIndex(
                name: "IX_tbBaiBaoKHDaCongBo_IdTapChiTrongNuoc",
                schema: "KHCN",
                table: "tbBaiBaoKHDaCongBo",
                column: "IdTapChiTrongNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_tbBaiBaoKHDaCongBo_IdXepHangQ",
                schema: "KHCN",
                table: "tbBaiBaoKHDaCongBo",
                column: "IdXepHangQ");

            migrationBuilder.CreateIndex(
                name: "IX_tbCanBo_IdChucDanhGiangVien",
                schema: "CB",
                table: "tbCanBo",
                column: "IdChucDanhGiangVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbCanBo_IdChucDanhNgheNghiep",
                schema: "CB",
                table: "tbCanBo",
                column: "IdChucDanhNgheNghiep");

            migrationBuilder.CreateIndex(
                name: "IX_tbCanBo_IdChucDanhNghienCuuKhoaHoc",
                schema: "CB",
                table: "tbCanBo",
                column: "IdChucDanhNghienCuuKhoaHoc");

            migrationBuilder.CreateIndex(
                name: "IX_tbCanBo_IdChucVuCongTac",
                schema: "CB",
                table: "tbCanBo",
                column: "IdChucVuCongTac");

            migrationBuilder.CreateIndex(
                name: "IX_tbCanBo_IdHuyen",
                schema: "CB",
                table: "tbCanBo",
                column: "IdHuyen");

            migrationBuilder.CreateIndex(
                name: "IX_tbCanBo_IdNgach",
                schema: "CB",
                table: "tbCanBo",
                column: "IdNgach");

            migrationBuilder.CreateIndex(
                name: "IX_tbCanBo_IdNguoi",
                schema: "CB",
                table: "tbCanBo",
                column: "IdNguoi");

            migrationBuilder.CreateIndex(
                name: "IX_tbCanBo_IdTinh",
                schema: "CB",
                table: "tbCanBo",
                column: "IdTinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbCanBo_IdTrangThaiLamViec",
                schema: "CB",
                table: "tbCanBo",
                column: "IdTrangThaiLamViec");

            migrationBuilder.CreateIndex(
                name: "IX_tbCanBo_IdXa",
                schema: "CB",
                table: "tbCanBo",
                column: "IdXa");

            migrationBuilder.CreateIndex(
                name: "IX_tbCanBoHuongDanThanhCongSinhVien_IdCanBo",
                schema: "CB",
                table: "tbCanBoHuongDanThanhCongSinhVien",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbChiTietTaiSanDonVi_IdChuSoHuu",
                schema: "TCTS",
                table: "tbChiTietTaiSanDonVi",
                column: "IdChuSoHuu");

            migrationBuilder.CreateIndex(
                name: "IX_tbChiTietTaiSanDonVi_IdTaiSanDonVi",
                schema: "TCTS",
                table: "tbChiTietTaiSanDonVi",
                column: "IdTaiSanDonVi");

            migrationBuilder.CreateIndex(
                name: "IX_tbChiTietTaiSanDonVi_IdTinhTrangThietBi",
                schema: "TCTS",
                table: "tbChiTietTaiSanDonVi",
                column: "IdTinhTrangThietBi");

            migrationBuilder.CreateIndex(
                name: "IX_tbChiTietThuChi_IdLoaiThuChi",
                schema: "TCTS",
                table: "tbChiTietThuChi",
                column: "IdLoaiThuChi");

            migrationBuilder.CreateIndex(
                name: "IX_tbChiTieuTuyenSinhTheoNganh_IdLoaiHinhDaoTao",
                schema: "TS",
                table: "tbChiTieuTuyenSinhTheoNganh",
                column: "IdLoaiHinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbChiTieuTuyenSinhTheoNganh_IdNganhDaoTao",
                schema: "TS",
                table: "tbChiTieuTuyenSinhTheoNganh",
                column: "IdNganhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbChucDanhKhoaHocCuaCanBo_IdCanBo",
                schema: "CB",
                table: "tbChucDanhKhoaHocCuaCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbChucDanhKhoaHocCuaCanBo_IdChucDanhKhoaHoc",
                schema: "CB",
                table: "tbChucDanhKhoaHocCuaCanBo",
                column: "IdChucDanhKhoaHoc");

            migrationBuilder.CreateIndex(
                name: "IX_tbChucDanhKhoaHocCuaCanBo_IdThamQuyenQuyetDinh",
                schema: "CB",
                table: "tbChucDanhKhoaHocCuaCanBo",
                column: "IdThamQuyenQuyetDinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuongTrinhDaoTao_IdDonViCapBang",
                schema: "CTDT",
                table: "tbChuongTrinhDaoTao",
                column: "IdDonViCapBang");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuongTrinhDaoTao_IdHocCheDaoTao",
                schema: "CTDT",
                table: "tbChuongTrinhDaoTao",
                column: "IdHocCheDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuongTrinhDaoTao_IdLoaiChuongTrinhDaoTao",
                schema: "CTDT",
                table: "tbChuongTrinhDaoTao",
                column: "IdLoaiChuongTrinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuongTrinhDaoTao_IdLoaiChuongTrinhLienKetDaoTao",
                schema: "CTDT",
                table: "tbChuongTrinhDaoTao",
                column: "IdLoaiChuongTrinhLienKetDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuongTrinhDaoTao_IdNganhDaoTao",
                schema: "CTDT",
                table: "tbChuongTrinhDaoTao",
                column: "IdNganhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuongTrinhDaoTao_IdQuocGiaCuaTruSoChinh",
                schema: "CTDT",
                table: "tbChuongTrinhDaoTao",
                column: "IdQuocGiaCuaTruSoChinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuongTrinhDaoTao_IdTrangThaiCuaChuongTrinh",
                schema: "CTDT",
                table: "tbChuongTrinhDaoTao",
                column: "IdTrangThaiCuaChuongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuongTrinhDaoTao_IdTrinhDoDaoTao",
                schema: "CTDT",
                table: "tbChuongTrinhDaoTao",
                column: "IdTrinhDoDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuyenGiaoCongNgheVaDaoTao_IdHinhThucChuyenGiaoCongNghe",
                schema: "KHCN",
                table: "tbChuyenGiaoCongNgheVaDaoTao",
                column: "IdHinhThucChuyenGiaoCongNghe");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuyenGiaoCongNgheVaDaoTao_IdLinhVucNghienCuu",
                schema: "KHCN",
                table: "tbChuyenGiaoCongNgheVaDaoTao",
                column: "IdLinhVucNghienCuu");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuyenGiaoCongNgheVaDaoTao_IdNganhKinhTe",
                schema: "KHCN",
                table: "tbChuyenGiaoCongNgheVaDaoTao",
                column: "IdNganhKinhTe");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuyenGiaoCongNgheVaDaoTao_IdNhiemVuKHCN",
                schema: "KHCN",
                table: "tbChuyenGiaoCongNgheVaDaoTao",
                column: "IdNhiemVuKHCN");

            migrationBuilder.CreateIndex(
                name: "IX_tbChuyenGiaoCongNgheVaDaoTao_IdTrangThaiHopDong",
                schema: "KHCN",
                table: "tbChuyenGiaoCongNgheVaDaoTao",
                column: "IdTrangThaiHopDong");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoCauToChuc_IdLoaiPhongBan",
                schema: "CSGD",
                table: "tbCoCauToChuc",
                column: "IdLoaiPhongBan");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoCauToChuc_IdTrangThai",
                schema: "CSGD",
                table: "tbCoCauToChuc",
                column: "IdTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_tbCongTrinhCoSoVatChat_CongTrinhCSVCTrongNha",
                schema: "CSVC",
                table: "tbCongTrinhCoSoVatChat",
                column: "CongTrinhCSVCTrongNha");

            migrationBuilder.CreateIndex(
                name: "IX_tbCongTrinhCoSoVatChat_IdHinhThucSoHuu",
                schema: "CSVC",
                table: "tbCongTrinhCoSoVatChat",
                column: "IdHinhThucSoHuu");

            migrationBuilder.CreateIndex(
                name: "IX_tbCongTrinhCoSoVatChat_IdLoaiCongTrinh",
                schema: "CSVC",
                table: "tbCongTrinhCoSoVatChat",
                column: "IdLoaiCongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbCongTrinhCoSoVatChat_IdMucDichSuDung",
                schema: "CSVC",
                table: "tbCongTrinhCoSoVatChat",
                column: "IdMucDichSuDung");

            migrationBuilder.CreateIndex(
                name: "IX_tbCongTrinhCoSoVatChat_IdTinhTrangCSVC",
                schema: "CSVC",
                table: "tbCongTrinhCoSoVatChat",
                column: "IdTinhTrangCSVC");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoSoGiaoDuc_HoatDongKhongLoiNhuan",
                schema: "CSGD",
                table: "tbCoSoGiaoDuc",
                column: "HoatDongKhongLoiNhuan");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoSoGiaoDuc_IdCoQuanChuQuan",
                schema: "CSGD",
                table: "tbCoSoGiaoDuc",
                column: "IdCoQuanChuQuan");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoSoGiaoDuc_IdHinhThucThanhLap",
                schema: "CSGD",
                table: "tbCoSoGiaoDuc",
                column: "IdHinhThucThanhLap");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoSoGiaoDuc_IdHuyen",
                schema: "CSGD",
                table: "tbCoSoGiaoDuc",
                column: "IdHuyen");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoSoGiaoDuc_IdLoaiHinhCoSoDaoTao",
                schema: "CSGD",
                table: "tbCoSoGiaoDuc",
                column: "IdLoaiHinhCoSoDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoSoGiaoDuc_IdLoaiHinhTruong",
                schema: "CSGD",
                table: "tbCoSoGiaoDuc",
                column: "IdLoaiHinhTruong");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoSoGiaoDuc_IdPhanLoaiCoSo",
                schema: "CSGD",
                table: "tbCoSoGiaoDuc",
                column: "IdPhanLoaiCoSo");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoSoGiaoDuc_IdTinh",
                schema: "CSGD",
                table: "tbCoSoGiaoDuc",
                column: "IdTinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoSoGiaoDuc_IdXa",
                schema: "CSGD",
                table: "tbCoSoGiaoDuc",
                column: "IdXa");

            migrationBuilder.CreateIndex(
                name: "IX_tbCoSoGiaoDuc_TuChuGiaoDucQPAN",
                schema: "CSGD",
                table: "tbCoSoGiaoDuc",
                column: "TuChuGiaoDucQPAN");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhGiaXepLoaiCanBo_IdCanBo",
                schema: "CB",
                table: "tbDanhGiaXepLoaiCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhGiaXepLoaiCanBo_IdDanhGia",
                schema: "CB",
                table: "tbDanhGiaXepLoaiCanBo",
                column: "IdDanhGia");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo_IdCanBo",
                schema: "CB",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo_IdCapKhenThuong",
                schema: "CB",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo",
                column: "IdCapKhenThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo_IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong",
                schema: "CB",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo",
                column: "IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo_IdPhuongThucKhenThuong",
                schema: "CB",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo",
                column: "IdPhuongThucKhenThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo_IdThiDuaGiaiThuongKhenThuong",
                schema: "CB",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo",
                column: "IdThiDuaGiaiThuongKhenThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD_IdCapKhenThuong",
                schema: "CSGD",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD",
                column: "IdCapKhenThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD_IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong",
                schema: "CSGD",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD",
                column: "IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD_IdPhuongThucKhenThuong",
                schema: "CSGD",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD",
                column: "IdPhuongThucKhenThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc_IdCapKhenThuong",
                schema: "NH",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc",
                column: "IdCapKhenThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc_IdDanhHieuThiDuaGiaiThuongKhenThuong",
                schema: "NH",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc",
                column: "IdDanhHieuThiDuaGiaiThuongKhenThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc_IdHocVien",
                schema: "NH",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc",
                column: "IdHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc_IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong",
                schema: "NH",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc",
                column: "IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc_IdPhuongThucKhenThuong",
                schema: "NH",
                table: "tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc",
                column: "IdPhuongThucKhenThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhSachNganhDaoTao_HinhThucDaoTaoTheoChuyenNgu",
                schema: "NDT",
                table: "tbDanhSachNganhDaoTao",
                column: "HinhThucDaoTaoTheoChuyenNgu");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhSachNganhDaoTao_IdNganhDaoTao",
                schema: "NDT",
                table: "tbDanhSachNganhDaoTao",
                column: "IdNganhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhSachNganhDaoTao_IdQuyetDinhTuChu",
                schema: "NDT",
                table: "tbDanhSachNganhDaoTao",
                column: "IdQuyetDinhTuChu");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhSachNganhDaoTao_IdTrangThaiDaoTao",
                schema: "NDT",
                table: "tbDanhSachNganhDaoTao",
                column: "IdTrangThaiDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhSachNganhDaoTao_IdTuChuMoNganh",
                schema: "NDT",
                table: "tbDanhSachNganhDaoTao",
                column: "IdTuChuMoNganh");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhSachNganhDaoTao_NganhDaoTaoLienKetNuocNgoai",
                schema: "NDT",
                table: "tbDanhSachNganhDaoTao",
                column: "NganhDaoTaoLienKetNuocNgoai");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhSachNganhDaoTao_UuTienDaoTaoNhanLucDuLichCNTT",
                schema: "NDT",
                table: "tbDanhSachNganhDaoTao",
                column: "UuTienDaoTaoNhanLucDuLichCNTT");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhSachVanBangChungChi_IdHocVien",
                schema: "VB",
                table: "tbDanhSachVanBangChungChi",
                column: "IdHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbDanhSachVanBangChungChi_IdLoaiTotNghiep",
                schema: "VB",
                table: "tbDanhSachVanBangChungChi",
                column: "IdLoaiTotNghiep");

            migrationBuilder.CreateIndex(
                name: "IX_tbDatDai_IdHinhThucSoHuu",
                schema: "CSVC",
                table: "tbDatDai",
                column: "IdHinhThucSoHuu");

            migrationBuilder.CreateIndex(
                name: "IX_tbDauMoiLienHe_IdLoaiDauMoiLienHe",
                schema: "CSGD",
                table: "tbDauMoiLienHe",
                column: "IdLoaiDauMoiLienHe");

            migrationBuilder.CreateIndex(
                name: "IX_tbDeAnDuAnChuongTrinh_IdNguonKinhPhiDeAnDuAnChuongTrinh",
                schema: "HTQT",
                table: "tbDeAnDuAnChuongTrinh",
                column: "IdNguonKinhPhiDeAnDuAnChuongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbDienBienLuong_IdBacLuong",
                schema: "CB",
                table: "tbDienBienLuong",
                column: "IdBacLuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDienBienLuong_IdCanBo",
                schema: "CB",
                table: "tbDienBienLuong",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbDienBienLuong_IdHeSoLuong",
                schema: "CB",
                table: "tbDienBienLuong",
                column: "IdHeSoLuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbDienBienLuong_IdTrinhDoDaoTao",
                schema: "CB",
                table: "tbDienBienLuong",
                column: "IdTrinhDoDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbDoanCongTac_IdPhanLoaiDoanRaDoanVao",
                schema: "HTQT",
                table: "tbDoanCongTac",
                column: "IdPhanLoaiDoanRaDoanVao");

            migrationBuilder.CreateIndex(
                name: "IX_tbDoanCongTac_IdQuocGiaDoan",
                schema: "HTQT",
                table: "tbDoanCongTac",
                column: "IdQuocGiaDoan");

            migrationBuilder.CreateIndex(
                name: "IX_tbDoanhNghiepKHCN_IdHinhThucDoanhNghiepKHCN",
                schema: "KHCN",
                table: "tbDoanhNghiepKHCN",
                column: "IdHinhThucDoanhNghiepKHCN");

            migrationBuilder.CreateIndex(
                name: "IX_tbDoiTuongChinhSachCanBo_IdCanBo",
                schema: "CB",
                table: "tbDoiTuongChinhSachCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbDoiTuongChinhSachCanBo_IdDoiTuongChinhSach",
                schema: "CB",
                table: "tbDoiTuongChinhSachCanBo",
                column: "IdDoiTuongChinhSach");

            migrationBuilder.CreateIndex(
                name: "IX_tbDoiTuongThamGia_IdLoaiThamGia",
                schema: "KHCN",
                table: "tbDoiTuongThamGia",
                column: "IdLoaiThamGia");

            migrationBuilder.CreateIndex(
                name: "IX_tbDoiTuongThamGia_IdNguoi",
                schema: "KHCN",
                table: "tbDoiTuongThamGia",
                column: "IdNguoi");

            migrationBuilder.CreateIndex(
                name: "IX_tbDoiTuongThamGia_IdPhanLoai",
                schema: "KHCN",
                table: "tbDoiTuongThamGia",
                column: "IdPhanLoai");

            migrationBuilder.CreateIndex(
                name: "IX_tbDoiTuongThamGia_IdVaiTro",
                schema: "KHCN",
                table: "tbDoiTuongThamGia",
                column: "IdVaiTro");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonViCongTacCuaCanBo_IdCanBo",
                schema: "CB",
                table: "tbDonViCongTacCuaCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonViCongTacCuaCanBo_IdChucVu",
                schema: "CB",
                table: "tbDonViCongTacCuaCanBo",
                column: "IdChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonViCongTacCuaCanBo_IdHinhThucBoNhiem",
                schema: "CB",
                table: "tbDonViCongTacCuaCanBo",
                column: "IdHinhThucBoNhiem");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonViLienKetDaoTaoGiaoDuc_IdCoSoGiaoDuc",
                schema: "CSGD",
                table: "tbDonViLienKetDaoTaoGiaoDuc",
                column: "IdCoSoGiaoDuc");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonViLienKetDaoTaoGiaoDuc_IdLoaiLienKet",
                schema: "CSGD",
                table: "tbDonViLienKetDaoTaoGiaoDuc",
                column: "IdLoaiLienKet");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonViThinhGiangCuaCanBo_IdCanBo",
                schema: "CB",
                table: "tbDonViThinhGiangCuaCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbDuLieuTrungTuyen_IdDoiTuongDauVao",
                schema: "TS",
                table: "tbDuLieuTrungTuyen",
                column: "IdDoiTuongDauVao");

            migrationBuilder.CreateIndex(
                name: "IX_tbDuLieuTrungTuyen_IdDoiTuongUuTien",
                schema: "TS",
                table: "tbDuLieuTrungTuyen",
                column: "IdDoiTuongUuTien");

            migrationBuilder.CreateIndex(
                name: "IX_tbDuLieuTrungTuyen_IdHinhThucTuyenSinh",
                schema: "TS",
                table: "tbDuLieuTrungTuyen",
                column: "IdHinhThucTuyenSinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbDuLieuTrungTuyen_IdKhuVuc",
                schema: "TS",
                table: "tbDuLieuTrungTuyen",
                column: "IdKhuVuc");

            migrationBuilder.CreateIndex(
                name: "IX_tbGiaHanChuongTrinhDaoTao_IdChuongTrinhDaoTao",
                schema: "CTDT",
                table: "tbGiaHanChuongTrinhDaoTao",
                column: "IdChuongTrinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbGiaiThuongKhoaHoc_IdLoaiGiaiThuong",
                schema: "KHCN",
                table: "tbGiaiThuongKhoaHoc",
                column: "IdLoaiGiaiThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbGiaiThuongKhoaHoc_IdMucGiaiThuong",
                schema: "KHCN",
                table: "tbGiaiThuongKhoaHoc",
                column: "IdMucGiaiThuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbGiangVienNN_IdCanBo",
                schema: "CB",
                table: "tbGiangVienNN",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbGiangVienNN_IdNoiDungHoatDongTaiVietNam",
                schema: "CB",
                table: "tbGiangVienNN",
                column: "IdNoiDungHoatDongTaiVietNam");

            migrationBuilder.CreateIndex(
                name: "IX_tbGiaoVienQPAN_IdCanBo",
                schema: "CB",
                table: "tbGiaoVienQPAN",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbGiaoVienQPAN_IdLoaiGiangVienQP",
                schema: "CB",
                table: "tbGiaoVienQPAN",
                column: "IdLoaiGiangVienQP");

            migrationBuilder.CreateIndex(
                name: "IX_tbGiaoVienQPAN_IdQuanHam",
                schema: "CB",
                table: "tbGiaoVienQPAN",
                column: "IdQuanHam");

            migrationBuilder.CreateIndex(
                name: "IX_tbGVDuocCuDiDaoTao_IdCanBo",
                schema: "HTQT",
                table: "tbGVDuocCuDiDaoTao",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbGVDuocCuDiDaoTao_IdHinhThucThamGiaGVDuocCuDiDaoTao",
                schema: "HTQT",
                table: "tbGVDuocCuDiDaoTao",
                column: "IdHinhThucThamGiaGVDuocCuDiDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbGVDuocCuDiDaoTao_IdNguonKinhPhiCuaGV",
                schema: "HTQT",
                table: "tbGVDuocCuDiDaoTao",
                column: "IdNguonKinhPhiCuaGV");

            migrationBuilder.CreateIndex(
                name: "IX_tbGVDuocCuDiDaoTao_IdQuocGiaDen",
                schema: "HTQT",
                table: "tbGVDuocCuDiDaoTao",
                column: "IdQuocGiaDen");

            migrationBuilder.CreateIndex(
                name: "IX_tbGVDuocCuDiDaoTao_IdTinhTrangGVDuocCuDiDaoTao",
                schema: "HTQT",
                table: "tbGVDuocCuDiDaoTao",
                column: "IdTinhTrangGVDuocCuDiDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbHinhThucDaoTaoCuaNganh_IdHinhThucDaoTao",
                schema: "NDT",
                table: "tbHinhThucDaoTaoCuaNganh",
                column: "IdHinhThucDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbHinhThucDaoTaoCuaNganh_IdNganhDaoTao",
                schema: "NDT",
                table: "tbHinhThucDaoTaoCuaNganh",
                column: "IdNganhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbHoatDongBaoVeMoiTruong_IdCapQuanLyNhiemVu",
                schema: "KHCN",
                table: "tbHoatDongBaoVeMoiTruong",
                column: "IdCapQuanLyNhiemVu");

            migrationBuilder.CreateIndex(
                name: "IX_tbHoatDongBaoVeMoiTruong_IdCoQuanChuQuan",
                schema: "KHCN",
                table: "tbHoatDongBaoVeMoiTruong",
                column: "IdCoQuanChuQuan");

            migrationBuilder.CreateIndex(
                name: "IX_tbHoatDongBaoVeMoiTruong_IdLoaiNhiemVuBaoVeMoiTruong",
                schema: "KHCN",
                table: "tbHoatDongBaoVeMoiTruong",
                column: "IdLoaiNhiemVuBaoVeMoiTruong");

            migrationBuilder.CreateIndex(
                name: "IX_tbHoatDongBaoVeMoiTruong_IdNguonKinhPhi",
                schema: "KHCN",
                table: "tbHoatDongBaoVeMoiTruong",
                column: "IdNguonKinhPhi");

            migrationBuilder.CreateIndex(
                name: "IX_tbHoatDongBaoVeMoiTruong_IdNhiemVuKHCN",
                schema: "KHCN",
                table: "tbHoatDongBaoVeMoiTruong",
                column: "IdNhiemVuKHCN");

            migrationBuilder.CreateIndex(
                name: "IX_tbHoatDongBaoVeMoiTruong_IdTinhTrangNhiemVu",
                schema: "KHCN",
                table: "tbHoatDongBaoVeMoiTruong",
                column: "IdTinhTrangNhiemVu");

            migrationBuilder.CreateIndex(
                name: "IX_tbHoatDongTaiChinh_IdLoaiHoatDongTaiChinh",
                schema: "TCTS",
                table: "tbHoatDongTaiChinh",
                column: "IdLoaiHoatDongTaiChinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbHocVien_IdHuyen",
                schema: "NH",
                table: "tbHocVien",
                column: "IdHuyen");

            migrationBuilder.CreateIndex(
                name: "IX_tbHocVien_IdLoaiKhuyetTat",
                schema: "NH",
                table: "tbHocVien",
                column: "IdLoaiKhuyetTat");

            migrationBuilder.CreateIndex(
                name: "IX_tbHocVien_IdNguoi",
                schema: "NH",
                table: "tbHocVien",
                column: "IdNguoi");

            migrationBuilder.CreateIndex(
                name: "IX_tbHocVien_IdTinh",
                schema: "NH",
                table: "tbHocVien",
                column: "IdTinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbHocVien_IdXa",
                schema: "NH",
                table: "tbHocVien",
                column: "IdXa");

            migrationBuilder.CreateIndex(
                name: "IX_tbHoiThaoHoiNghi_IdNguonKinhPhiHoiThao",
                schema: "HTQT",
                table: "tbHoiThaoHoiNghi",
                column: "IdNguonKinhPhiHoiThao");

            migrationBuilder.CreateIndex(
                name: "IX_tbHopDong_IdCanBo",
                schema: "CB",
                table: "tbHopDong",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbHopDong_IdLoaiHopDong",
                schema: "CB",
                table: "tbHopDong",
                column: "IdLoaiHopDong");

            migrationBuilder.CreateIndex(
                name: "IX_tbHopDong_IdTinhTrangHopDong",
                schema: "CB",
                table: "tbHopDong",
                column: "IdTinhTrangHopDong");

            migrationBuilder.CreateIndex(
                name: "IX_tbHopDongThinhGiang_IdCanBo",
                schema: "CB",
                table: "tbHopDongThinhGiang",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbHopDongThinhGiang_IdTrangThaiHopDong",
                schema: "CB",
                table: "tbHopDongThinhGiang",
                column: "IdTrangThaiHopDong");

            migrationBuilder.CreateIndex(
                name: "IX_tbKhoaBoiDuongTapHuanThamGiaCuaCanBo_IdCanBo",
                schema: "CB",
                table: "tbKhoaBoiDuongTapHuanThamGiaCuaCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbKhoaBoiDuongTapHuanThamGiaCuaCanBo_IdLoaiBoiDuong",
                schema: "CB",
                table: "tbKhoaBoiDuongTapHuanThamGiaCuaCanBo",
                column: "IdLoaiBoiDuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbKhoaBoiDuongTapHuanThamGiaCuaCanBo_IdNguonKinhPhi",
                schema: "CB",
                table: "tbKhoaBoiDuongTapHuanThamGiaCuaCanBo",
                column: "IdNguonKinhPhi");

            migrationBuilder.CreateIndex(
                name: "IX_tbKiTucXa_IdHinhThucSoHuu",
                schema: "CSVC",
                table: "tbKiTucXa",
                column: "IdHinhThucSoHuu");

            migrationBuilder.CreateIndex(
                name: "IX_tbKiTucXa_IdTinhTrangCSVC",
                schema: "CSVC",
                table: "tbKiTucXa",
                column: "IdTinhTrangCSVC");

            migrationBuilder.CreateIndex(
                name: "IX_tbKyLuatCanBo_IdCanBo",
                schema: "CB",
                table: "tbKyLuatCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbKyLuatCanBo_IdCapQuyetDinh",
                schema: "CB",
                table: "tbKyLuatCanBo",
                column: "IdCapQuyetDinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbKyLuatCanBo_IdLoaiKyLuat",
                schema: "CB",
                table: "tbKyLuatCanBo",
                column: "IdLoaiKyLuat");

            migrationBuilder.CreateIndex(
                name: "IX_tbKyLuatNguoiHoc_IdCapQuyetDinh",
                schema: "NH",
                table: "tbKyLuatNguoiHoc",
                column: "IdCapQuyetDinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbKyLuatNguoiHoc_IdHocVien",
                schema: "NH",
                table: "tbKyLuatNguoiHoc",
                column: "IdHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbKyLuatNguoiHoc_IdLoaiKyLuat",
                schema: "NH",
                table: "tbKyLuatNguoiHoc",
                column: "IdLoaiKyLuat");

            migrationBuilder.CreateIndex(
                name: "IX_tbLinhVucNghienCuuCuaCanBo_IdCanBo",
                schema: "CB",
                table: "tbLinhVucNghienCuuCuaCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbLinhVucNghienCuuCuaCanBo_IdLinhVucNghienCuu",
                schema: "CB",
                table: "tbLinhVucNghienCuuCuaCanBo",
                column: "IdLinhVucNghienCuu");

            migrationBuilder.CreateIndex(
                name: "IX_tbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh_IdLoaiHinhDaoTao",
                schema: "NDT",
                table: "tbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh",
                column: "IdLoaiHinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh_IdNganhDaoTao",
                schema: "NDT",
                table: "tbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh",
                column: "IdNganhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbLoaiThuChi_IdPhanLoaiThuChi",
                schema: "TCTS",
                table: "tbLoaiThuChi",
                column: "IdPhanLoaiThuChi");

            migrationBuilder.CreateIndex(
                name: "IX_tbLuuHocSinhSinhVienNN_IdLoaiLuuHocSinh",
                schema: "HTQT",
                table: "tbLuuHocSinhSinhVienNN",
                column: "IdLoaiLuuHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbLuuHocSinhSinhVienNN_IdNguonKinhPhiLuuHocSinh",
                schema: "HTQT",
                table: "tbLuuHocSinhSinhVienNN",
                column: "IdNguonKinhPhiLuuHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbNamApDungChuongTrinh_IdChuongTrinhDaoTao",
                schema: "CTDT",
                table: "tbNamApDungChuongTrinh",
                column: "IdChuongTrinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbNganhDungTenGiangDay_IdCanBo",
                schema: "CB",
                table: "tbNganhDungTenGiangDay",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbNganhDungTenGiangDay_IdNganhDaoTao",
                schema: "CB",
                table: "tbNganhDungTenGiangDay",
                column: "IdNganhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbNganhGiangDayCuaCanBo_IdCanBo",
                schema: "CB",
                table: "tbNganhGiangDayCuaCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbNganhGiangDayCuaCanBo_IdNganh",
                schema: "CB",
                table: "tbNganhGiangDayCuaCanBo",
                column: "IdNganh");

            migrationBuilder.CreateIndex(
                name: "IX_tbNganhGiangDayCuaCanBo_IdTrinhDoDaoTao",
                schema: "CB",
                table: "tbNganhGiangDayCuaCanBo",
                column: "IdTrinhDoDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbNgonNguGiangDay_IdChuongTrinhDaoTao",
                schema: "CTDT",
                table: "tbNgonNguGiangDay",
                column: "IdChuongTrinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbNgonNguGiangDay_IdNgonNgu",
                schema: "CTDT",
                table: "tbNgonNguGiangDay",
                column: "IdNgonNgu");

            migrationBuilder.CreateIndex(
                name: "IX_tbNgonNguGiangDay_IdTrinhDoNgonNguDauVao",
                schema: "CTDT",
                table: "tbNgonNguGiangDay",
                column: "IdTrinhDoNgonNguDauVao");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdChucDanhKhoaHoc",
                table: "tbNguoi",
                column: "IdChucDanhKhoaHoc");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdChuyenMonDaoTao",
                table: "tbNguoi",
                column: "IdChuyenMonDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdDanToc",
                table: "tbNguoi",
                column: "IdDanToc");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdGiaDinhChinhSach",
                table: "tbNguoi",
                column: "IdGiaDinhChinhSach");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdGioiTinh",
                table: "tbNguoi",
                column: "IdGioiTinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdKhungNangLucNgoaiNguc",
                table: "tbNguoi",
                column: "IdKhungNangLucNgoaiNguc");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdNgoaiNgu",
                table: "tbNguoi",
                column: "IdNgoaiNgu");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdQuocTich",
                table: "tbNguoi",
                column: "IdQuocTich");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdThuongBinhHang",
                table: "tbNguoi",
                column: "IdThuongBinhHang");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdTonGiao",
                table: "tbNguoi",
                column: "IdTonGiao");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdTrinhDoDaoTao",
                table: "tbNguoi",
                column: "IdTrinhDoDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdTrinhDoLyLuanChinhTri",
                table: "tbNguoi",
                column: "IdTrinhDoLyLuanChinhTri");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdTrinhDoQuanLyNhaNuoc",
                table: "tbNguoi",
                column: "IdTrinhDoQuanLyNhaNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoi_IdTrinhDoTinHoc",
                table: "tbNguoi",
                column: "IdTrinhDoTinHoc");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoiHocVayTinDung_IdHocVien",
                schema: "NH",
                table: "tbNguoiHocVayTinDung",
                column: "IdHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbNguoiHocVayTinDung_TinhTrangVay",
                schema: "NH",
                table: "tbNguoiHocVayTinDung",
                column: "TinhTrangVay");

            migrationBuilder.CreateIndex(
                name: "IX_tbNhiemVuKHCN_IdCapQuanLyNhiemVu",
                schema: "KHCN",
                table: "tbNhiemVuKHCN",
                column: "IdCapQuanLyNhiemVu");

            migrationBuilder.CreateIndex(
                name: "IX_tbNhiemVuKHCN_IdCoQuanChuQuan",
                schema: "KHCN",
                table: "tbNhiemVuKHCN",
                column: "IdCoQuanChuQuan");

            migrationBuilder.CreateIndex(
                name: "IX_tbNhiemVuKHCN_IdLinhVucNghienCuu",
                schema: "KHCN",
                table: "tbNhiemVuKHCN",
                column: "IdLinhVucNghienCuu");

            migrationBuilder.CreateIndex(
                name: "IX_tbNhiemVuKHCN_IdNguonKinhPhi",
                schema: "KHCN",
                table: "tbNhiemVuKHCN",
                column: "IdNguonKinhPhi");

            migrationBuilder.CreateIndex(
                name: "IX_tbNhiemVuKHCN_IdPhanLoaiNhiemVu",
                schema: "KHCN",
                table: "tbNhiemVuKHCN",
                column: "IdPhanLoaiNhiemVu");

            migrationBuilder.CreateIndex(
                name: "IX_tbNhiemVuKHCN_IdTinhTrangNhiemVu",
                schema: "KHCN",
                table: "tbNhiemVuKHCN",
                column: "IdTinhTrangNhiemVu");

            migrationBuilder.CreateIndex(
                name: "IX_tbNhomNganhDaoTao_IdLinhVucDaoTao",
                schema: "NDT",
                table: "tbNhomNganhDaoTao",
                column: "IdLinhVucDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbNhomNganhDaoTao_IdNganhDaoTao",
                schema: "NDT",
                table: "tbNhomNganhDaoTao",
                column: "IdNganhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbNhomNganhDaoTao_IdNhomNganh",
                schema: "NDT",
                table: "tbNhomNganhDaoTao",
                column: "IdNhomNganh");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhongHocGiangDuongHoiTruong_IdHinhThucSoHuu",
                schema: "CSVC",
                table: "tbPhongHocGiangDuongHoiTruong",
                column: "IdHinhThucSoHuu");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhongHocGiangDuongHoiTruong_IdLoaiDeAn",
                schema: "CSVC",
                table: "tbPhongHocGiangDuongHoiTruong",
                column: "IdLoaiDeAn");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhongHocGiangDuongHoiTruong_IdLoaiPhongHoc",
                schema: "CSVC",
                table: "tbPhongHocGiangDuongHoiTruong",
                column: "IdLoaiPhongHoc");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhongHocGiangDuongHoiTruong_IdPhanLoaiCSVC",
                schema: "CSVC",
                table: "tbPhongHocGiangDuongHoiTruong",
                column: "IdPhanLoaiCSVC");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhongHocGiangDuongHoiTruong_IdTinhTrangCoSoVatChat",
                schema: "CSVC",
                table: "tbPhongHocGiangDuongHoiTruong",
                column: "IdTinhTrangCoSoVatChat");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhongThiNghiem_IdCongTrinhCSVC",
                schema: "CSVC",
                table: "tbPhongThiNghiem",
                column: "IdCongTrinhCSVC");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhongThiNghiem_IdLinhVuc",
                schema: "CSVC",
                table: "tbPhongThiNghiem",
                column: "IdLinhVuc");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhongThiNghiem_IdLoaiPhongThiNghiem",
                schema: "CSVC",
                table: "tbPhongThiNghiem",
                column: "IdLoaiPhongThiNghiem");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhongThucHanh_IdCongTrinhCSVC",
                schema: "CSVC",
                table: "tbPhongThucHanh",
                column: "IdCongTrinhCSVC");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhongThucHanh_IdLinhVuc",
                schema: "CSVC",
                table: "tbPhongThucHanh",
                column: "IdLinhVuc");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhuCap_IdBacLuong",
                schema: "CB",
                table: "tbPhuCap",
                column: "IdBacLuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhuCap_IdCanBo",
                schema: "CB",
                table: "tbPhuCap",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhuCap_IdHeSoLuong",
                schema: "CB",
                table: "tbPhuCap",
                column: "IdHeSoLuong");

            migrationBuilder.CreateIndex(
                name: "IX_tbQuaTrinhCongTacCuaCanBo_IdCanBo",
                schema: "CB",
                table: "tbQuaTrinhCongTacCuaCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbQuaTrinhCongTacCuaCanBo_IdChucDanhGiangVien",
                schema: "CB",
                table: "tbQuaTrinhCongTacCuaCanBo",
                column: "IdChucDanhGiangVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbQuaTrinhCongTacCuaCanBo_IdChucVu",
                schema: "CB",
                table: "tbQuaTrinhCongTacCuaCanBo",
                column: "IdChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_tbQuaTrinhDaoTaoCuaCanBo_IdCanBo",
                schema: "CB",
                table: "tbQuaTrinhDaoTaoCuaCanBo",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbQuaTrinhDaoTaoCuaCanBo_IdLoaiHinhDaoTao",
                schema: "CB",
                table: "tbQuaTrinhDaoTaoCuaCanBo",
                column: "IdLoaiHinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbQuaTrinhDaoTaoCuaCanBo_IdNganhDaoTao",
                schema: "CB",
                table: "tbQuaTrinhDaoTaoCuaCanBo",
                column: "IdNganhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbQuaTrinhDaoTaoCuaCanBo_IdQuocGiaDaoTao",
                schema: "CB",
                table: "tbQuaTrinhDaoTaoCuaCanBo",
                column: "IdQuocGiaDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbQuaTrinhDaoTaoCuaCanBo_IdTrinhDoDaoTao",
                schema: "CB",
                table: "tbQuaTrinhDaoTaoCuaCanBo",
                column: "IdTrinhDoDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai_IdChuongTrinhDaoTao",
                schema: "CTDT",
                table: "tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai",
                column: "IdChuongTrinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai_IdHinhThucDaoTao",
                schema: "CTDT",
                table: "tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai",
                column: "IdHinhThucDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai_IdLoaiQuyetDinh",
                schema: "CTDT",
                table: "tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai",
                column: "IdLoaiQuyetDinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbSachDaXuatBan_IdDangTaiLieu",
                schema: "KHCN",
                table: "tbSachDaXuatBan",
                column: "IdDangTaiLieu");

            migrationBuilder.CreateIndex(
                name: "IX_tbSachDaXuatBan_IdLoaiSachTapChi",
                schema: "KHCN",
                table: "tbSachDaXuatBan",
                column: "IdLoaiSachTapChi");

            migrationBuilder.CreateIndex(
                name: "IX_tbSachDaXuatBan_IdNhiemVuKHCN",
                schema: "KHCN",
                table: "tbSachDaXuatBan",
                column: "IdNhiemVuKHCN");

            migrationBuilder.CreateIndex(
                name: "IX_tbTaiSanTriTue_IdLoaiTaiSanTriTue",
                schema: "KHCN",
                table: "tbTaiSanTriTue",
                column: "IdLoaiTaiSanTriTue");

            migrationBuilder.CreateIndex(
                name: "IX_tbTaiSanTriTue_IdNhiemVuKHCN",
                schema: "KHCN",
                table: "tbTaiSanTriTue",
                column: "IdNhiemVuKHCN");

            migrationBuilder.CreateIndex(
                name: "IX_tbTapChiKhoaHoc_IdLinhVucXuatBan",
                schema: "KHCN",
                table: "tbTapChiKhoaHoc",
                column: "IdLinhVucXuatBan");

            migrationBuilder.CreateIndex(
                name: "IX_tbTapChiKhoaHoc_IdXepLoaiTapChi",
                schema: "KHCN",
                table: "tbTapChiKhoaHoc",
                column: "IdXepLoaiTapChi");

            migrationBuilder.CreateIndex(
                name: "IX_tbThanhPhanThamGiaDoanCongTac_IdCanBo",
                schema: "HTQT",
                table: "tbThanhPhanThamGiaDoanCongTac",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbThanhPhanThamGiaDoanCongTac_IdDoanCongTac",
                schema: "HTQT",
                table: "tbThanhPhanThamGiaDoanCongTac",
                column: "IdDoanCongTac");

            migrationBuilder.CreateIndex(
                name: "IX_tbThanhPhanThamGiaDoanCongTac_IdVaiTroThamGia",
                schema: "HTQT",
                table: "tbThanhPhanThamGiaDoanCongTac",
                column: "IdVaiTroThamGia");

            migrationBuilder.CreateIndex(
                name: "IX_tbThietBiPTN_THTren500Tr_IdCongTrinhCSVC",
                schema: "CSVC",
                table: "tbThietBiPTN_THTren500Tr",
                column: "IdCongTrinhCSVC");

            migrationBuilder.CreateIndex(
                name: "IX_tbThietBiPTN_THTren500Tr_IdQuocGiaXuatXu",
                schema: "CSVC",
                table: "tbThietBiPTN_THTren500Tr",
                column: "IdQuocGiaXuatXu");

            migrationBuilder.CreateIndex(
                name: "IX_tbThoaThuanHopTacQuocTe_IdQuocGia",
                schema: "HTQT",
                table: "tbThoaThuanHopTacQuocTe",
                column: "IdQuocGia");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocBong_IdHocVien",
                schema: "NH",
                table: "tbThongTinHocBong",
                column: "IdHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocBong_IdLoaiHocBong",
                schema: "NH",
                table: "tbThongTinHocBong",
                column: "IdLoaiHocBong");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapNghienCuuSinh_IdChuongTrinhDaoTao",
                schema: "NH",
                table: "tbThongTinHocTapNghienCuuSinh",
                column: "IdChuongTrinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapNghienCuuSinh_IdDoiTuongDauVao",
                schema: "NH",
                table: "tbThongTinHocTapNghienCuuSinh",
                column: "IdDoiTuongDauVao");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapNghienCuuSinh_IdHocVien",
                schema: "NH",
                table: "tbThongTinHocTapNghienCuuSinh",
                column: "IdHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapNghienCuuSinh_IdLoaiHinhDaoTao",
                schema: "NH",
                table: "tbThongTinHocTapNghienCuuSinh",
                column: "IdLoaiHinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapNghienCuuSinh_IdLoaiTotNghiep",
                schema: "NH",
                table: "tbThongTinHocTapNghienCuuSinh",
                column: "IdLoaiTotNghiep");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapNghienCuuSinh_IdNguoiHuongDanChinh",
                schema: "NH",
                table: "tbThongTinHocTapNghienCuuSinh",
                column: "IdNguoiHuongDanChinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapNghienCuuSinh_IdNguoiHuongDanPhu",
                schema: "NH",
                table: "tbThongTinHocTapNghienCuuSinh",
                column: "IdNguoiHuongDanPhu");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapNghienCuuSinh_IdSinhVienNam",
                schema: "NH",
                table: "tbThongTinHocTapNghienCuuSinh",
                column: "IdSinhVienNam");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapNghienCuuSinh_IdTrangThaiHoc",
                schema: "NH",
                table: "tbThongTinHocTapNghienCuuSinh",
                column: "IdTrangThaiHoc");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapSinhVien_BangTotNghiepLienThong",
                schema: "NH",
                table: "tbThongTinHocTapSinhVien",
                column: "BangTotNghiepLienThong");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapSinhVien_DangONoiTru",
                schema: "NH",
                table: "tbThongTinHocTapSinhVien",
                column: "DangONoiTru");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapSinhVien_IdChuongTrinhDaoTao",
                schema: "NH",
                table: "tbThongTinHocTapSinhVien",
                column: "IdChuongTrinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapSinhVien_IdDoiTuongDauVao",
                schema: "NH",
                table: "tbThongTinHocTapSinhVien",
                column: "IdDoiTuongDauVao");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapSinhVien_IdHocVien",
                schema: "NH",
                table: "tbThongTinHocTapSinhVien",
                column: "IdHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapSinhVien_IdLoaiHinhDaoTao",
                schema: "NH",
                table: "tbThongTinHocTapSinhVien",
                column: "IdLoaiHinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapSinhVien_IdLoaiTotNghiep",
                schema: "NH",
                table: "tbThongTinHocTapSinhVien",
                column: "IdLoaiTotNghiep");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapSinhVien_IdSinhVienNam",
                schema: "NH",
                table: "tbThongTinHocTapSinhVien",
                column: "IdSinhVienNam");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHocTapSinhVien_IdTrangThaiHoc",
                schema: "NH",
                table: "tbThongTinHocTapSinhVien",
                column: "IdTrangThaiHoc");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHopTac_IdHinhThucHopTac",
                schema: "HTQT",
                table: "tbThongTinHopTac",
                column: "IdHinhThucHopTac");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinHopTac_IdToChucHopTac",
                schema: "HTQT",
                table: "tbThongTinHopTac",
                column: "IdToChucHopTac");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinKiemDinhCuaChuongTrinh_IdChuongTrinhDaoTao",
                schema: "CTDT",
                table: "tbThongTinKiemDinhCuaChuongTrinh",
                column: "IdChuongTrinhDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinKiemDinhCuaChuongTrinh_IdKetQuaKiemDinh",
                schema: "CTDT",
                table: "tbThongTinKiemDinhCuaChuongTrinh",
                column: "IdKetQuaKiemDinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinKiemDinhCuaChuongTrinh_IdToChucKiemDinh",
                schema: "CTDT",
                table: "tbThongTinKiemDinhCuaChuongTrinh",
                column: "IdToChucKiemDinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinLinhVucDaoTao_IdKhoiNganh",
                schema: "NDT",
                table: "tbThongTinLinhVucDaoTao",
                column: "IdKhoiNganh");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinLinhVucDaoTao_IdLinhVucDaoTao",
                schema: "NDT",
                table: "tbThongTinLinhVucDaoTao",
                column: "IdLinhVucDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinNguoiHocGDTC_IdHocVien",
                schema: "NH",
                table: "tbThongTinNguoiHocGDTC",
                column: "IdHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinViecLamSauTotNghiep_IdHinhThucTuyenDung",
                schema: "NH",
                table: "tbThongTinViecLamSauTotNghiep",
                column: "IdHinhThucTuyenDung");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinViecLamSauTotNghiep_IdHocVien",
                schema: "NH",
                table: "tbThongTinViecLamSauTotNghiep",
                column: "IdHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinViecLamSauTotNghiep_IdViTriViecLam",
                schema: "NH",
                table: "tbThongTinViecLamSauTotNghiep",
                column: "IdViTriViecLam");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinViPham_IdHocVien",
                schema: "NH",
                table: "tbThongTinViPham",
                column: "IdHocVien");

            migrationBuilder.CreateIndex(
                name: "IX_tbThongTinViPham_IdLoaiViPham",
                schema: "NH",
                table: "tbThongTinViPham",
                column: "IdLoaiViPham");

            migrationBuilder.CreateIndex(
                name: "IX_tbThuVienTrungTamHocLieu_IdHinhThucSoHuu",
                schema: "CSVC",
                table: "tbThuVienTrungTamHocLieu",
                column: "IdHinhThucSoHuu");

            migrationBuilder.CreateIndex(
                name: "IX_tbThuVienTrungTamHocLieu_IdTinhTrangCSVC",
                schema: "CSVC",
                table: "tbThuVienTrungTamHocLieu",
                column: "IdTinhTrangCSVC");

            migrationBuilder.CreateIndex(
                name: "IX_tbToChucHopTacDoanhNghiep_IdLoaiDeAn",
                schema: "HTDN",
                table: "tbToChucHopTacDoanhNghiep",
                column: "IdLoaiDeAn");

            migrationBuilder.CreateIndex(
                name: "IX_tbToChucHopTacQuocTe_IdQuocGia",
                schema: "HTQT",
                table: "tbToChucHopTacQuocTe",
                column: "IdQuocGia");

            migrationBuilder.CreateIndex(
                name: "IX_tbToChucKiemDinh_IdKetQua",
                schema: "CSGD",
                table: "tbToChucKiemDinh",
                column: "IdKetQua");

            migrationBuilder.CreateIndex(
                name: "IX_tbToChucKiemDinh_IdToChucKiemDinh",
                schema: "CSGD",
                table: "tbToChucKiemDinh",
                column: "IdToChucKiemDinh");

            migrationBuilder.CreateIndex(
                name: "IX_tbTrinhDoTiengDanToc_IdCanBo",
                schema: "CB",
                table: "tbTrinhDoTiengDanToc",
                column: "IdCanBo");

            migrationBuilder.CreateIndex(
                name: "IX_tbTrinhDoTiengDanToc_IdKhungNangLucNgoaiNgu",
                schema: "CB",
                table: "tbTrinhDoTiengDanToc",
                column: "IdKhungNangLucNgoaiNgu");

            migrationBuilder.CreateIndex(
                name: "IX_tbTrinhDoTiengDanToc_IdTiengDanToc",
                schema: "CB",
                table: "tbTrinhDoTiengDanToc",
                column: "IdTiengDanToc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dmBacLuong");

            migrationBuilder.DropTable(
                name: "dmCapHoiNghi",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmChucDanhHoiDong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmChucDanhPhongBan",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmCoQuanBanHanh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmDanhHieuVinhDuGiaiThuong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmDaoTaoGDQPAN",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHinhThucDaoTaoTheoChuyenNgu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmKhoiNganhLinhVucDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLinhVucNhomNganh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiDeTai",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiHocVien",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiToChuc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmMucTieuNhiemVu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmNoiDungHoatDong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmPhanLoaiDoiTuong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmPhanLoaiHoiNghiHoiThao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmSangCheGiaiPhap",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrangThaiThucHien",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrinhDo",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "NganhDungTenGiangDay");

            migrationBuilder.DropTable(
                name: "tbBaiBaoKHDaCongBo",
                schema: "KHCN");

            migrationBuilder.DropTable(
                name: "tbCanBoHuongDanThanhCongSinhVien",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbChiTietTaiSanDonVi",
                schema: "TCTS");

            migrationBuilder.DropTable(
                name: "tbChiTietThuChi",
                schema: "TCTS");

            migrationBuilder.DropTable(
                name: "tbChiTieuTuyenSinhTheoNganh",
                schema: "TS");

            migrationBuilder.DropTable(
                name: "tbChucDanhKhoaHocCuaCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbChuyenGiaoCongNgheVaDaoTao",
                schema: "KHCN");

            migrationBuilder.DropTable(
                name: "tbCoCauToChuc",
                schema: "CSGD");

            migrationBuilder.DropTable(
                name: "tbDanhGiaXepLoaiCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbDanhHieuThiDuaGiaiThuongKhenThuongCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGD",
                schema: "CSGD");

            migrationBuilder.DropTable(
                name: "tbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc",
                schema: "NH");

            migrationBuilder.DropTable(
                name: "tbDanhSachNganhDaoTao",
                schema: "NDT");

            migrationBuilder.DropTable(
                name: "tbDanhSachVanBangChungChi",
                schema: "VB");

            migrationBuilder.DropTable(
                name: "tbDatDai",
                schema: "CSVC");

            migrationBuilder.DropTable(
                name: "tbDauMoiLienHe",
                schema: "CSGD");

            migrationBuilder.DropTable(
                name: "tbDeAnDuAnChuongTrinh",
                schema: "HTQT");

            migrationBuilder.DropTable(
                name: "tbDienBienLuong",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbDoanhNghiepKHCN",
                schema: "KHCN");

            migrationBuilder.DropTable(
                name: "tbDoiTuongChinhSachCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbDoiTuongThamGia",
                schema: "KHCN");

            migrationBuilder.DropTable(
                name: "tbDonViCongTacCuaCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbDonViLienKetDaoTaoGiaoDuc",
                schema: "CSGD");

            migrationBuilder.DropTable(
                name: "tbDonViThinhGiangCuaCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbDuLieuTrungTuyen",
                schema: "TS");

            migrationBuilder.DropTable(
                name: "tbGiaHanChuongTrinhDaoTao",
                schema: "CTDT");

            migrationBuilder.DropTable(
                name: "tbGiaiThuongKhoaHoc",
                schema: "KHCN");

            migrationBuilder.DropTable(
                name: "tbGiangVienNN",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbGiaoVienQPAN",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbGVDuocCuDiDaoTao",
                schema: "HTQT");

            migrationBuilder.DropTable(
                name: "tbHinhThucDaoTaoCuaNganh",
                schema: "NDT");

            migrationBuilder.DropTable(
                name: "tbHoatDongBaoVeMoiTruong",
                schema: "KHCN");

            migrationBuilder.DropTable(
                name: "tbHoatDongTaiChinh",
                schema: "TCTS");

            migrationBuilder.DropTable(
                name: "tbHoiThaoHoiNghi",
                schema: "HTQT");

            migrationBuilder.DropTable(
                name: "tbHopDong",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbHopDongThinhGiang",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbKhoaBoiDuongTapHuanThamGiaCuaCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbKhoaHoc",
                schema: "CSGD");

            migrationBuilder.DropTable(
                name: "tbKhoanNopNganSach",
                schema: "TCTS");

            migrationBuilder.DropTable(
                name: "tbKhoanTrichLapQuy",
                schema: "TCTS");

            migrationBuilder.DropTable(
                name: "tbKiTucXa",
                schema: "CSVC");

            migrationBuilder.DropTable(
                name: "tbKyLuatCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbKyLuatNguoiHoc",
                schema: "NH");

            migrationBuilder.DropTable(
                name: "tbLichSuDoiTenTruong",
                schema: "CSGD");

            migrationBuilder.DropTable(
                name: "tbLinhVucNghienCuuCuaCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh",
                schema: "NDT");

            migrationBuilder.DropTable(
                name: "tbLuuHocSinhSinhVienNN",
                schema: "HTQT");

            migrationBuilder.DropTable(
                name: "tbNamApDungChuongTrinh",
                schema: "CTDT");

            migrationBuilder.DropTable(
                name: "tbNganhDungTenGiangDay",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbNganhGiangDayCuaCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbNgonNguGiangDay",
                schema: "CTDT");

            migrationBuilder.DropTable(
                name: "tbNguoiHocVayTinDung",
                schema: "NH");

            migrationBuilder.DropTable(
                name: "tbNhomNganhDaoTao",
                schema: "NDT");

            migrationBuilder.DropTable(
                name: "tbNhomNghienCuuManh",
                schema: "KHCN");

            migrationBuilder.DropTable(
                name: "tbPhongHocGiangDuongHoiTruong",
                schema: "CSVC");

            migrationBuilder.DropTable(
                name: "tbPhongThiNghiem",
                schema: "CSVC");

            migrationBuilder.DropTable(
                name: "tbPhongThucHanh",
                schema: "CSVC");

            migrationBuilder.DropTable(
                name: "tbPhuCap",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbQuaTrinhCongTacCuaCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbQuaTrinhDaoTaoCuaCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "tbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai",
                schema: "CTDT");

            migrationBuilder.DropTable(
                name: "tbSachDaXuatBan",
                schema: "KHCN");

            migrationBuilder.DropTable(
                name: "tbTaiSanTriTue",
                schema: "KHCN");

            migrationBuilder.DropTable(
                name: "tbTapChiKhoaHoc",
                schema: "KHCN");

            migrationBuilder.DropTable(
                name: "tbThanhPhanThamGiaDoanCongTac",
                schema: "HTQT");

            migrationBuilder.DropTable(
                name: "tbThietBiPTN_THTren500Tr",
                schema: "CSVC");

            migrationBuilder.DropTable(
                name: "tbThoaThuanHopTacQuocTe",
                schema: "HTQT");

            migrationBuilder.DropTable(
                name: "tbThongTinHocBong",
                schema: "NH");

            migrationBuilder.DropTable(
                name: "tbThongTinHocTapNghienCuuSinh",
                schema: "NH");

            migrationBuilder.DropTable(
                name: "tbThongTinHocTapSinhVien",
                schema: "NH");

            migrationBuilder.DropTable(
                name: "tbThongTinHopTac",
                schema: "HTQT");

            migrationBuilder.DropTable(
                name: "tbThongTinKiemDinhCuaChuongTrinh",
                schema: "CTDT");

            migrationBuilder.DropTable(
                name: "tbThongTinLinhVucDaoTao",
                schema: "NDT");

            migrationBuilder.DropTable(
                name: "tbThongTinNguoiHocGDTC",
                schema: "NH");

            migrationBuilder.DropTable(
                name: "tbThongTinViecLamSauTotNghiep",
                schema: "NH");

            migrationBuilder.DropTable(
                name: "tbThongTinViPham",
                schema: "NH");

            migrationBuilder.DropTable(
                name: "tbThuVienTrungTamHocLieu",
                schema: "CSVC");

            migrationBuilder.DropTable(
                name: "tbToChucHopTacDoanhNghiep",
                schema: "HTDN");

            migrationBuilder.DropTable(
                name: "tbToChucKiemDinh",
                schema: "CSGD");

            migrationBuilder.DropTable(
                name: "tbTrinhDoTiengDanToc",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "TbUser",
                schema: "PQuyen");

            migrationBuilder.DropTable(
                name: "tbVanBanTuChu",
                schema: "CSGD");

            migrationBuilder.DropTable(
                name: "dmTapChiKhoaHocQuocTe",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmXepHangQ",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmChuSoHuu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTinhTrangThietBi",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "tbTaiSanDonVi",
                schema: "TCTS");

            migrationBuilder.DropTable(
                name: "tbLoaiThuChi",
                schema: "TCTS");

            migrationBuilder.DropTable(
                name: "dmHinhThucChuyenGiaoCongNghe",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmNganhKinhTe",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiPhongBan",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrangThaiCoSoGD",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmDanhGiaCongChucVienChuc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiDanhHieuThiDuaGiaiThuongKhenThuong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmPhuongThucKhenThuong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmThiDuaGiaiThuongKhenThuong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmQuyetDinhTuChu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrangThaiDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTuChuMoNganh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmDauMoiLienHe",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmNguonKinhPhiChoDeAn",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHinhThucDoanhNghiepKHCN",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmDoiTuongChinhSach",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiThamGia",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmPhanLoaiDoiNguNguoiHoc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHinhThucBoNhiem",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "tbCoSoGiaoDuc",
                schema: "CSGD");

            migrationBuilder.DropTable(
                name: "dmLoaiLienKet",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmDoiTuongUuTien",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHinhThucTuyenSinh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmKhuVuc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiGiaiThuongKHCN",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmMucGiaiThuong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmNoiDungHoatDongTaiVietNam",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiGiangVienQuocPhong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmQuanHam",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHinhThucThamGiaGVDuocCuDiDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmNguonKinhPhiCuaGVDuocCuDiDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTinhTrangGiangVienDuocCuDiDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiNhiemVuBaoVeMoiTruong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHoatDongTaiChinh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiHopDong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTinhTrangHopDong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrangThaiHopDong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiBoiDuong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmCapKhenThuong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiKyLuat",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiLuuHocSinh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmNguonKinhPhiChoLuuHocSinh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmNhomNganh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiPhongHoc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmPhanLoaiCSVC",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiPhongThiNghiem",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmBacLuong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHeSoLuong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHinhThucDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiQuyetDinh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmDangTaiLieu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiSachTapChi",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiTaiSanTriTue",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "tbNhiemVuKHCN",
                schema: "KHCN");

            migrationBuilder.DropTable(
                name: "dmTapChiTrongNuoc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmVaiTroThamGia",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "tbDoanCongTac",
                schema: "HTQT");

            migrationBuilder.DropTable(
                name: "tbCongTrinhCoSoVatChat",
                schema: "CSVC");

            migrationBuilder.DropTable(
                name: "dmLoaiHocBong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmChuongTrinhDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmDoiTuongDauVao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiHinhDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiTotNghiep",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmSinhVienNam",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrangThaiHoc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHinhThucHopTac",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "tbToChucHopTacQuocTe",
                schema: "HTQT");

            migrationBuilder.DropTable(
                name: "tbChuongTrinhDaoTao",
                schema: "CTDT");

            migrationBuilder.DropTable(
                name: "dmLinhVucDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "tbKhoiNganhDaoTao",
                schema: "NDT");

            migrationBuilder.DropTable(
                name: "dmHinhThucTuyenDung",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmViTriViecLam",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiViPham",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "tbHocVien",
                schema: "NH");

            migrationBuilder.DropTable(
                name: "dmLoaiDeAnChuongTrinh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmKetQuaKiemDinh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmToChucKiemDinh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTiengDanToc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "tbCanBo",
                schema: "CB");

            migrationBuilder.DropTable(
                name: "dmPhanLoaiThuChi",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHinhThucThanhLap",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiHinhCoSoDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiHinhTruong",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmPhanLoaiCoSo",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmCoQuanChuQuan",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLinhVucNghienCuu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiNhiemVu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmNguonKinhPhi",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmPhanCapNhiemVu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTinhTrangNhiemVu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmPhanLoaiDoanRaDoanVao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHinhThucSoHuu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiCongTrinhCoSoVatChat",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmMucDichSuDungCSVC",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTinhTrangCoSoVatChat",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTuyChon",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmDonViCapBang",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHocCheDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiChuongTrinhDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiChuongTrinhLienKetDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrangThaiChuongTrinhDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmLoaiKhuyetTat",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmChucDanhGiangVien",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmChucDanhNCKH",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmChucDanhNgheNghiep",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmChucVu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmNgach",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrangThaiCanBo",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmXa",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "tbNguoi");

            migrationBuilder.DropTable(
                name: "dmHuyen",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmChucDanhKhoaHoc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmDanToc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmGioiTinh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHangThuongBinh",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmHoGiaDinhChinhSach",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmKhungNangLucNgoaiNgu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmNganhDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmNgoaiNgu",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmQuocTich",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTonGiao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrinhDoDaoTao",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrinhDoLyLuanChinhTri",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrinhDoQuanLyNhaNuoc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTrinhDoTinHoc",
                schema: "DM");

            migrationBuilder.DropTable(
                name: "dmTinh",
                schema: "DM");
        }
    }
}
