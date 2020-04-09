using System;


namespace AbstractClassInterface
{
    // Đây là một Interface không khai báo 'access modifier'.
    // Mặc định 'access modifier' của nó sẽ là 'internal'.
    // Nó chỉ được dùng trong nội bộ một Assembly.
    interface NoAccessModifierInterface
    {
        // Một lớp chỉ có thể mở rộng từ duy nhất một lớp khác.
        // Nhưng có thể mở rộng từ nhiều Interface.
        //1.Interface có modifier là public hoặc internal, nếu không ghi rõ mặc định là internal.
        //2.Interface không thể định nghĩa các trường(Field).
        //3.Các method của nó đều là method trìu tượng(abstract) và công khai(public), và không có thân hàm.Nhưng khi khai báo phương thức bạn lại không được phép ghi public hoặc abstract.
        //4.Interface không có cấu tử(Constructor).
        /*Một interface trong CSharp có thể khai báo modifier là public hoặc internal,
        nếu không khai báo gì mặc định được hiểu là internal.
        Interface có modifier là public có thể được sử dụng ở mọi nơi, đối với interface có modifier là internal chỉ được sử dụng trong nội bộ Assembly.

        Một Assembly là chính là sản phẩm đã biên dịch (compile) của mã của bạn,
        thường là một DLL, nhưng EXE cũng có thể coi là một assembly.
        Nó là đơn vị nhỏ nhất của việc triển khai cho bất kỳ dự án .NET nào.

        Assembly một cách cụ thể chứa mã .NET theo MSIL (Microsoft Intermediate language -
        Một ngôn ngữ trung gian) sẽ được biên dịch thành mã máy (Native code) ("JITted" -
        biên dịch bởi các trình biên dịch Just-In-Time) trong lần đầu tiên nó được thực thi trên máy tính,.
        Đó là mã đã được biên dịch cũng sẽ được lưu trữ trong Assembly và tái sử dụng cho các lần gọi tiếp theo.
        */
    }
}
