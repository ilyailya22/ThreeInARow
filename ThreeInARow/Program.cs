namespace TreeInARow;
class Program
{
    static void Main(string[] args)
    {
        int flag1 = 1;
        int flag2 = 2;
        int colums = 9;
        int rows = 9;
        Matrix matrix = new Matrix();
        matrix.Create(colums, rows);
        matrix.Fill();
        Console.WriteLine("Created matrix");
        matrix.Show();
        while (true)
        {

            Console.WriteLine("Vertical Shifts ");
            matrix.Vertical(ref flag2);
            matrix.Show();

            Console.WriteLine("Horizontal Shifts ");
            matrix.Horisontal(ref flag2);
            matrix.Show();

            if (flag1 == flag2) break;
            flag1 = flag2;
        }
        Console.WriteLine("Result");
        matrix.Show();

    }
}
