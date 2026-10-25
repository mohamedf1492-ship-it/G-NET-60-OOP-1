namespace oop1
{
    #region PartA Q1 
    // class is reference type
    // structe is value type

    /*class StudentClass
    {
        public int Age;
    }

    struct StudentStruct
    {
        public int Age;
    }*/
    #endregion

    #region partA Q2
    // pravite توصله من دتخل الكلاس فقط 
    //publice عادي توصله من خارج الكلاس
    /*class Employee
    {
        public string Name = "Ahmed";
        private double Salary = 5000;

        public void PrintSalary()
        {
            Console.WriteLine(Salary);
        }*/
    #endregion

    #region partA Q3
    /*
    namespace MyLibrary
    {
        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
        }
    }*/
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PartA Q1
            /*
            StudentClass s1 = new StudentClass();
            s1.Age = 20;

            StudentClass s2 = s1;
            s2.Age = 25;

            Console.WriteLine(s1.Age);

            StudentStruct st1 = new StudentStruct();
            st1.Age = 20;

            StudentStruct st2 = st1;
            st2.Age = 25;

            Console.WriteLine(st1.Age);*/
            #endregion

            #region partA Q2
            /*
            Employee emp = new Employee();

            Console.WriteLine(emp.Name);
            emp.PrintSalary();
            */
            #endregion
        }
    }
}
