class program{
    static void Main(string[] args) {
        Console.WriteLine("Input Centerpoint1: ");
        Console.Write("Input x1 = ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Input y1 = ");
        double y1 = double.Parse(Console.ReadLine());
        
        Console.Write("Input Width1: ");
        double w1 = double.Parse(Console.ReadLine());

        Console.Write("Input Height1: ");
        double h1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Input Centerpoint2: ");
        Console.Write("Input x2 = ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Input y1 = ");
        double y2 = double.Parse(Console.ReadLine());
        
        Console.Write("Input Width2: ");
        double w2 = double.Parse(Console.ReadLine());

        Console.Write("Input Height2: ");
        double h2 = double.Parse(Console.ReadLine());

        
        double area1 = x1 * y1 * h1 * w1;
        double area2 = x2 * y2 * h2 * w2;

        if(area1 - area2 >= 8){
            Console.WriteLine("Too much overlapping");
        }
        else if(area1 - area2 <= 8 && area1 - area2 >=1){
            Console.WriteLine("Not much overlapping");
        }
        else Console.WriteLine("No overlapping");

    }
}
