using Restauracia;

public class Program
{

    public static void Main(string[] args)
    {
        var table = new Table(0, 4);
        var table2 = new Table(1, 4);
        var table3 = new Table(2, 4);
        var table4 = new Table(3, 5);
        var table5 = new Table(4, 5);

        var RestaurantSystem = new Restauracny_system();
        RestaurantSystem.AddTable(table);
        RestaurantSystem.AddTable(table2);
        RestaurantSystem.AddTable(table3);
        RestaurantSystem.AddTable(table4);
        RestaurantSystem.AddTable(table5);


        var random = new Random();
        var people = random.Next(3, 8);

        Console.WriteLine("prislo nam:" + people);


        if (people > table.Numberofchairs )
        {
            Console.WriteLine("Prepačte nemame kapacitu");
        }

        if (people <= table.Numberofchairs )
        {
            Console.WriteLine("vaš stôl");
        }









    }
}