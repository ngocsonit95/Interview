using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Abstract;
using Testing.Class;
using Testing.Interface;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface trong C#");
            Console.WriteLine("Vi du minh hoa interface");
            Console.WriteLine("--------------------------");

            //tao cac doi tuong GiaoDichHangHoa
            GiaoDichHangHoa t1 = new GiaoDichHangHoa("001", "8/10/2012", 78900.00);
            GiaoDichHangHoa t2 = new GiaoDichHangHoa("002", "9/10/2012", 451900.00);
            t1.HienThiThongTinGiaoDich();
            t2.HienThiThongTinGiaoDich();

            //Không khởi tạo được đối tượng
            //DoSomthing doSomthing = new DoSomthing();
            //GiaoDichInterface giaoDichInterface = new GiaoDichInterface();

            Console.ReadKey();
        }
    }
}
