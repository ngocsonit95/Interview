using System;


namespace AbstractClassInterface
{
    //Không thể kế thừa từ nhiều
    public class CSharpCoding : AbstractJob
    {
        public CSharpCoding()
        {
        }

        // Thực hiện phương thức trừu tượng khai báo tại lớp cha.
        // Nó phải có thân (body).
        // (Cần phải có từ khóa 'override').
        public override void DoJob()
        {
            Console.WriteLine("Coding CSharp...");
        }

        // Thực hiện phương thức trừu tượng của lớp cha.
        public override String GetJobName()
        {
            return "CSharp Coding";
        }

        public void RunningExample()
        {
            Console.WriteLine("Running Example...");
        }
    }
}
