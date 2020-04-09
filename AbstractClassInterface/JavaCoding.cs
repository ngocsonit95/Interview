using System;

namespace AbstractClassInterface
{
    public class JavaCoding : AbstractJob
    {
        // Thực hiện phương thức trừu tượng khai báo tại lớp cha.
        // Nó phải có thân (body).
        // (Cần phải có từ khóa 'override').
        //Mặc dù lớp cha của nó ko cớ từ khóa virtual
        public override void DoJob()
        {
            throw new NotImplementedException();
        }

        public override string GetJobName()
        {
            throw new NotImplementedException();
        }
    }
}
