public class RadioactiveElement : ICell
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public string Symbol => "!!";

    public RadioactiveElement(int x, int y)
    {
        X = x;
        Y = y;
    }

    // public void Interact(Robot robot)
    // {
    //     if (IsAdjacent(robot.X, robot.Y))
    //     {
    //         robot.TotalEnergy -= 10;
    //         Console.WriteLine("O robô passou por um elemento radioativo adjacente e perdeu 10 pontos de energia.");
    //     }
    // }

    // public bool Transpose(Robot robot)
    // {
    //     if (robot.TotalEnergy >= 30)
    //     {
    //         robot.TotalEnergy -= 30;
    //         Console.WriteLine("O robô transpôs o elemento radioativo e perdeu 30 pontos de energia.");
    //         return true;
    //     }
    //     else
    //     {
    //         Console.WriteLine("O robô não possui energia suficiente para transpor o elemento radioativo.");
    //         return false;
    //     }
    // }

    // private bool IsAdjacent(int x, int y)
    // {
    //     return (Math.Abs(x - X) == 1 && y == Y) || (Math.Abs(y - Y) == 1 && x == X);
    // }

    public override string ToString() {  
        return "!!";   // Imprime/subscreve "!!" no lugar de RadioactiveElement no mapa do jogo
    }
}