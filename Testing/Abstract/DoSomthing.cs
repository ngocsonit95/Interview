using Testing.Class;

namespace Testing.Abstract
{
    public abstract class DoSomthing : DemoAbstract
    {
        People p1 = new People();
        internal void Test()
        {
            double tmp;
        }

        public abstract void MakNoise();


    }

    public class Animal : DoSomthing
    {
        public override void MakNoise()
        {
            Test();
        }

        //Phương thức abstract phải nằm trong abstract chứ ko được nằm trong class
        //public abstract class Cat();
    }



}
