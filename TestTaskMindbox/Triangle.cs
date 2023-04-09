namespace TestTaskMindbox
{
    public class Triangle : Figure
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Neither side of a triangle cant be negative");
            }

            if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentException("Triangle does not exists");
            }
        }

        public override double Area()
        {
            var halfPerimeter = (a + b + c) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        }

        public bool IsRight()
        {
            const double delta = 0.01;
            var perimeter = a + b + c;

            var theBiggestSIde = Math.Max(Math.Max(a, b), c);
            var theSmallestSide = Math.Min(Math.Min(a, b), c);
            var theMiddleSide = perimeter - theBiggestSIde - theSmallestSide;

            return theBiggestSIde * theBiggestSIde - theSmallestSide * theSmallestSide - theMiddleSide * theMiddleSide <= delta;
        }
    }
}
