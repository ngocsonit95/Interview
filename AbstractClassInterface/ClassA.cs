using System;

namespace AbstractClassInterface
{
    /*
     Đặc điểm của một class trừu tượng là:
    Nó được khai báo với từ khóa abstract.
    Nó có thể khai báo 0, 1 hoặc nhiều method trừu tượng bên trong.
    Bạn không thể khởi tạo 1 đối tượng trực tiếp từ một class trừu tượng.
    */
    // Một lớp có ít nhất một phương thức trừu tượng,
    // phải khai báo là trừu tượng (abstract).
    public abstract class ClassA
    {
        // Nó không có thân.
        // 'access modifier' của phương thức này là: public
        // (access modifier: Độ truy cập).
        public abstract void DoSomething();

        // 'access modifier' của phương thức này là: protected
        protected abstract String DoNothing();


        protected abstract void Todo();
    }

    // Đây là một class trừu tượng.
    // Nó được khai báo là trừu tượng, mặc dù nó không có phương thức trừu tượng nào.
    public abstract class ClassB
    {

    }
}
