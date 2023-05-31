public class Water : Obstacle {

    public int Energy { get; }
    public Water (int x, int y) : base(x, y) {
    }

    public override string ToString(){
        return "##";
    }

}