using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyGhiDanh.Migrations
{
    public partial class DbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoMon",
                columns: table => new
                {
                    IdBoMon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoMonName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoMon", x => x.IdBoMon);
                });

            migrationBuilder.CreateTable(
                name: "GiaoVien",
                columns: table => new
                {
                    IdGiaoVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaoVienName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhDaiDienGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDTGiaoVien = table.Column<int>(type: "int", nullable: false),
                    NgayHopTac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CacMonGiangDay = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVien", x => x.IdGiaoVien);
                });

            migrationBuilder.CreateTable(
                name: "HocVien",
                columns: table => new
                {
                    IdHocVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HocVienName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhDaiDienHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDTPhuHuynh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVien", x => x.IdHocVien);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHoc",
                columns: table => new
                {
                    IdKhoaHoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoaHocName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHoc", x => x.IdKhoaHoc);
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    IdLopHoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HocPhi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongHoc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.IdLopHoc);
                });

            migrationBuilder.CreateTable(
                name: "NhomBoMon",
                columns: table => new
                {
                    IdNhomBoMon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhomBoMonName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomBoMon", x => x.IdNhomBoMon);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoMon");

            migrationBuilder.DropTable(
                name: "GiaoVien");

            migrationBuilder.DropTable(
                name: "HocVien");

            migrationBuilder.DropTable(
                name: "KhoaHoc");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "NhomBoMon");
        }
    }
}
