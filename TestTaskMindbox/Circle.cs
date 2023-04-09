namespace TestTaskMindbox
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;

            if(radius <= 0)
            {
                throw new ArgumentException("Radius cant be negative");
            }
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
