using Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Interface;

namespace Testing.Class
{
   public class GiaoDichHangHoa : GiaoDichInterface
    {
        private string ma_hang_hoa;
        private string ngay;
        private double so_luong;
        public GiaoDichHangHoa()
        {
            ma_hang_hoa = " ";
            ngay = " ";
            so_luong = 0.0;
        }

        public GiaoDichHangHoa(string c, string d, double a)
        {
            ma_hang_hoa = c;
            ngay = d;
            so_luong = a;
        }

        public double LaySoLuong()
        {
            return so_luong;
        }

        public void HienThiThongTinGiaoDich()
        {
            Console.WriteLine("Ma hang hoa: {0}", ma_hang_hoa);
            Console.WriteLine("Ngay giao dich: {0}", ngay);
            //Console.WriteLine("So luong: {0}", LaySoLuong());
        }
    }
}
