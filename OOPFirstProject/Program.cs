namespace OOPFirstProject
{
    internal class Program
    {
       public class Rectangle
        {
           public float Width;
            public float Height;

            public void CalcArea()
            {
                Console.WriteLine("Area of reactangle is " + (Width*Height));
            }

            public void CalcPerimeter()
            {
                Console.WriteLine("Perimeter of reactangle is " + (Width + Height)*2);
            }

            public void Display ()
            {
                Console.WriteLine($"Dimenstions of rectangle is width ={Width},height={Height} ");
                CalcArea();
                CalcPerimeter();

            }

        }

        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
         
            r1.Width=10;
            r1.Height = 5;
            r1.Display();
            Rectangle r2 = new Rectangle();


            r2.Width = 5;
            r2.Height = 5;
            r2.Display();


        }
    }
}
