namespace Datatypes;
class Test
{
    public int varX;
}

class Program
{
    static void Main(string[] args)
    {
        /*int x = 10;
        int y = 5;

        Console.WriteLine(@"
        {0}
        {1}"
        , x, y);*/

        var objectOne = new Test();
        var objectTwo = new Test();

        objectOne.varX = 100;
        objectTwo.varX = 250;

        Console.WriteLine(@"
        objectOne: {0}
        objectTwo: {1}",
        objectOne.varX,
        objectTwo.varX);
    }

}
