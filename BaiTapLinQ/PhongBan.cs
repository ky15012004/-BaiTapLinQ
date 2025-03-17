using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinQ
{
    class PhongBan
    {
        public int IdPB_224;
        public string NamePb_224;

        public PhongBan(int IdPb_224,string NamePb_224)
        {
            this.IdPB_224 = IdPB_224;
            this.NamePb_224 = NamePb_224;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Tên: {this.NamePb_224}");
        }
    }
}
