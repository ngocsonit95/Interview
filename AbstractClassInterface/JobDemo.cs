using System;

namespace AbstractClassInterface
{
    public class JobDemo
    {

        public static void Main(string[] args)
        {
            // Tạo một đối tượng AbstractJob từ Constructor của lớp JavaCoding.
            AbstractJob job1 = new JavaCoding();

            // Gọi phương thức DoJob().
            job1.DoJob();

            // Phương thức GetJobName() là trừu tượng trong lớp AbstractJob
            // Nhưng nó đã được triển khai tại một lớp con nào đó.
            // Vì vậy bạn có thể gọi nó.
            var jobName = job1.GetJobName();

            Console.WriteLine("Job Name 1= " + jobName);


            // Tạo một đối tượng AbstractJob từ Constructor của lớp CSharpCoding.
            AbstractJob job2 = new CSharpCoding();

            // Gọi phương thức DoJob().
            job2.DoJob();

            String jobName2 = job2.GetJobName();

            Console.WriteLine("Job Name 2= " + jobName2);

            // Tạo đối tượng AbstractJob từ Constructor của lớp BuildHouse.
            AbstractJob job3 = new BuildHouse();

            job3.DoJob();

            var jobName3 = job3.GetJobName();

            Console.WriteLine("Job Name 3= " + jobName3);


            Console.ReadLine();
        }
    }
}
