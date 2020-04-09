using System;

namespace AbstractClassInterface
{
    // Lớp có ít nhất một phương thức trừu tượng,
    // phải được khai báo là trừu tượng (abstract).
    public abstract class AbstractJob
    {

        public AbstractJob()
        {

        }

        // Đây là một phương thức trừu tượng,
        // Nó không có thân (body).
        // Phương thức này trả về tên của công việc.
        public abstract String GetJobName();

        // Đây là một phương thức trừu tượng.
        // Phương thức không có thân (body).
        public abstract void DoJob();

        // Đây là một phương thức thông thường (Không trừu tượng).
        public void StopJob()
        {
            Console.WriteLine("Stop");
        }
    }
}
