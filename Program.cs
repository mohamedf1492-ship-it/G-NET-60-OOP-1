using System.Net.Sockets;

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

    #region Q4

   /* enum TicketType
    {
        Standard,
        VIP,
        IMAX
    }

    struct SeatLocation
    {
        public char Row;
        public int Number;

        public SeatLocation(char row, int number)
        {
            Row = row;
            Number = number;
        }
    }

    class Ticket
    {
        public string MovieName;
        public TicketType Type;
        public SeatLocation Seat;

        private double Price;

        public Ticket(
            string movieName,
            TicketType type,
            SeatLocation seat,
            double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public Ticket(string movieName)
            : this(
                movieName,
                TicketType.Standard,
                new SeatLocation('A', 1),
                50)
        {
        }

        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent / 100);
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }
        }

        public void PrintTicket()
        {
            Console.WriteLine("Movie : " + MovieName);
            Console.WriteLine("Type : " + Type);
            Console.WriteLine("Seat : " + Seat.Row + Seat.Number);
            Console.WriteLine("Price : " + Price.ToString("F2"));
            Console.WriteLine(
                "Total (14% tax) : " + CalcTotal(14).ToString("F2"));
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

            #region Q4
            /*
            Console.Write("Enter Movie Name: ");
            string movieName = Console.ReadLine();

            Console.Write(
                "Enter Ticket Type (0 = Standard, 1 = VIP, 2 = IMAX): ");
            int typeNumber = Convert.ToInt32(Console.ReadLine());

            TicketType type = (TicketType)typeNumber;

            Console.Write("Enter Seat Row (A, B, C...): ");
            char row = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Seat Number: ");
            int seatNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Discount Amount: ");
            double discountAmount = Convert.ToDouble(Console.ReadLine());

            SeatLocation seat = new SeatLocation(row, seatNumber);

            Ticket ticket = new Ticket(
                movieName,
                type,
                seat,
                price);

            Console.WriteLine("\n===== Ticket Info =====");
            ticket.PrintTicket();

            double discountBefore = discountAmount;

            ticket.ApplyDiscount(ref discountAmount);

            Console.WriteLine("\n===== After Discount =====");
            Console.WriteLine(
                "Discount Before : " + discountBefore.ToString("F2"));

            Console.WriteLine(
                "Discount After : " + discountAmount.ToString("F2"));

            ticket.PrintTicket();*/
            #endregion
        }
    }
}
