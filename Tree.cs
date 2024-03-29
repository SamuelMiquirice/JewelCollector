/// <summary>
/// Essa classe herda as caraterísticas da classe Obstacle, por tratar-se de um tipo de obstáculo.
/// </summary>
public class Tree : Obstacle, IEnergySource, ICollectable { 

    public int Energy { get; }
    public int Points { get; set; }

    public bool Taken { get; set; }

    public Tree(int x, int y) : base(x, y) {
        Energy = 3;
        Points = 0;
        Taken = false;
       
    }

    public override string ToString(){
        return "$$";      
    }
}