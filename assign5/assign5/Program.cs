namespace assign5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /*Person p1 = new Person("Ahmed",20);
            Person p2 = new Person("Mohamed",25);
            Person p3 = new Person("Magdy",30);
            object[] people = new object[3];
            people[0] = p1;
            people[1] = p2;
            people[2] = p3;
            foreach (var person in people)
            {
                Person p = (Person)person;
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            }
            */

            //2
            /*Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);
            double ans = Math.Sqrt(Math.Pow(p2.X-p1.X,2)+Math.Pow(p2.Y-p1.Y,2));
            Console.WriteLine($"the distance is {ans}");
            */

            //3
            /*Person p1 = new Person("Ahmed", 20);
            Person p2 = new Person("Mohamed", 25);
            Person p3 = new Person("Magdy", 30);
            if(p3.Age > p2.Age && p3.Age > p1.Age)Console.WriteLine($"the oldest is {p3.Name}");            
            else if(p2.Age > p1.Age && p2.Age > p3.Age)Console.WriteLine($"the oldest is {p2.Name}");
            else Console.WriteLine($"the oldest is {p1.Name}");
            */

            //4
            Rectangle r1 = new Rectangle(5, 10);
            Console.WriteLine(r1.Area()); 
            

        }
    }
}
