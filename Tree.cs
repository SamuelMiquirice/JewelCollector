
public class Tree : Obstacle, IEnergySource, ICollectable {

    public int Energy { get; }
    public int Points { get; set; }

    public Tree(int x, int y) : base(x, y) {
        Energy = 3;
        Points = 0;
    }

    public override string ToString(){
        return "$$";
    }
}