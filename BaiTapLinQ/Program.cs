using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhongBan> phongban_224 = new List<PhongBan>
            {
                new PhongBan(1, "Phòng thiết kế"),
                new PhongBan(2, "Phòng kế toán"),
                new PhongBan(3, "Phòng nhân sự"),
                new PhongBan(4, "Phòng marketing")
            };

            List<NhanVien> nhanvien_224 = new List<NhanVien>
            {
                new NhanVien(1, "Nguyễn Phước Kỳ", 21, 5000000, 1),
                new NhanVien(2, "Nguyễn Trãi", 23, 7000000, 1),
                new NhanVien(3, "Phan Tấn Hùng", 25, 9000000, 1),
                new NhanVien(4, "Nguyễn Phước Hoài Thanh", 28, 50000000, 2),
                new NhanVien(5, "Nguyễn Hữu Quân", 32, 25000000, 2),
                new NhanVien(6, "Nguyễn Hữu Lợi", 21, 30000000, 2),
                new NhanVien(7, "Nguyễn Văn Phong", 23, 21000000, 3),
                new NhanVien(8, "Nguyễn Văn A", 24, 25000000, 3),
                new NhanVien(9, "Nguyễn Phước Kỳ", 26, 32000000, 3),
                new NhanVien(10, "Nguyễn Phước Kỳ", 22, 4000000, 4),
                new NhanVien(11, "Nguyễn Phước Kỳ", 25, 7000000, 4),
                new NhanVien(12, "Nguyễn Phước Kỳ", 31, 9000000, 4)
            };


            var danhSachNV = from nv in nhanvien_224
                             join pb in phongban_224
                             on nv.IDClass_224 equals pb.IdPB_224
                             select new
                             {
                                 nv.NameNV_224,
                                 nv.Age_224,
                                 nv.Salary_224,
                                 tenpb = pb.NamePb_224
                             };

            var nhomNhanVienTheoPhong = from nv in danhSachNV
                                        group nv by nv.tenpb into groupPB
                                        select new
                                        {
                                            PhongBan = groupPB.Key,
                                            TreNhat = groupPB.OrderBy(x => x.Age_224).FirstOrDefault(),
                                            GiaNhat = groupPB.OrderByDescending(x => x.Age_224).FirstOrDefault(),
                                            TuoiTrungBinh = groupPB.Average(x => x.Age_224)
                                        };

            foreach (var pb in nhomNhanVienTheoPhong)
            {
                Console.WriteLine($"Phòng: {pb.PhongBan}");
                Console.WriteLine($"- Nhân viên trẻ nhất: {pb.TreNhat.NameNV_224} - Tuổi: {pb.TreNhat.Age_224}");
                Console.WriteLine($"- Nhân viên già nhất: {pb.GiaNhat.NameNV_224} - Tuổi: {pb.GiaNhat.Age_224}");
                Console.WriteLine($"- Tuổi trung bình: {pb.TuoiTrungBinh:F2}\n");
            }

            double luongTrungBinhCongTy = nhanvien_224.Average(nv => nv.Salary_224);
            Console.WriteLine($" Lương trung bình của công ty: {luongTrungBinhCongTy:N0} VND");

            Console.ReadKey();


        }
    }
}
