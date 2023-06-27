/// <summary>
/// Essa classe herda as caraterísticas da classe Obstacle, por tratar-se de um tipo de obstáculo.
/// </summary>
public class Water : Obstacle {

    public int Energy { get; }
    public Water (int x, int y) : base(x, y) {
    }

    public override string ToString(){
        return "##";
    }

}