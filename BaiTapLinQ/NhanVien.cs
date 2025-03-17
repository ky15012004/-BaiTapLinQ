using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinQ
{
    class NhanVien
    {
        public int IDnv_224;
        public string NameNV_224;
        public int Age_224;
        public double Salary_224;
        public int IDClass_224;

        public NhanVien(int IDnv_224, string NameNV_224,int Age_224, double Salary_224, int IDClass_224)
        {
            this.IDnv_224 = IDnv_224;
            this.NameNV_224 = NameNV_224;
            this.Age_224 = Age_224;
            this.Salary_224 = Salary_224;
            this.IDClass_224 = IDClass_224;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Tên: {this.NameNV_224}, Tuổi: {this.Age_224}, Lương: {this.Salary_224}");
        }
    }
}
