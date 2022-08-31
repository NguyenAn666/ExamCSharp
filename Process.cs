namespace GeometryExample

{
    internal class Process
    {
        

        static void Main(string[] args)
        {
            float Radius;
            float PI = 3.1415926535f;
            double BaseArea;
            double LateralArea;
            double TotalArea;
            double Volume;
            int Height;


            Console.WriteLine("Enter the dimenstion of the cylinder");

            Console.Write("Radius");
            Radius = Convert.ToSingle(Console.ReadLine());

            Console.Write("Height");
            Height = (int)Convert.ToSingle(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Cylinder Characteristics");
            

            Console.Write("Base");
            Console.WriteLine( Radius * Radius * Math.PI );

            Console.Write("Lateral");
            Console.WriteLine( 2 * Math.PI * Radius * Height );

            Console.Write("Total");
            Console.WriteLine(2 * Math.PI * Radius * (Height + Radius));

            Console.Write("Volume");
            Console.WriteLine(Math.PI * Radius * Radius * Height);
        }
    }
}