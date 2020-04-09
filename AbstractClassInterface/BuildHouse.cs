

using System;

namespace AbstractClassInterface
{
    // Lớp này thừa kế từ lớp trừu tượng ManualJob.
    // BuildHouse không khai báo 'abstract'
    // Vì vậy nó cần thực hiện tất cả các phương thức trừu tượng còn lại.
    class BuildHouse: ManualJob
    {
        public BuildHouse()
        {

        }

        public override void DoJob()
        {
            Console.WriteLine("Build a House");
        }
    }
}
