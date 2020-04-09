using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Class;

namespace Testing.Interface
{
    public interface GiaoDichInterface
    {
        // cac thanh vien cua interface
        //cac phuong thuc
        void HienThiThongTinGiaoDich();
        double LaySoLuong();
        //Interface không thể khởi tạo được đối tượng
        // People p1 = new People();

    }

    public interface IPath
    {
        void setSize();
    }
    public interface IColor
    {
        void setBorderColor();
        void setFillColor();
    }
    public interface IPoint
    {
        void setPoint();
    }

    // interface có thể implement nhiều interface
    public interface IShape : IColor, IPoint
    {
        void Draw();
       double Side { get; set; }
    }

    //Một class khi kế thừa Interface thì phải implement tất cả các phương thức, thuộc tính của interface đó
    public class KeThuaInterface : IShape
    {
        public double Side
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void Draw()
        {
        }

        public void setBorderColor()
        {
            throw new NotImplementedException();
        }

        public void setFillColor()
        {
            throw new NotImplementedException();
        }

        public void setPoint()
        {
            throw new NotImplementedException();
        }
    }
}
