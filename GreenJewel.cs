/// <summary>
/// Essa classe herda as caraterísticas da classe Jewel, por tratar-se de um tipo de joia.
/// </summary>
public class GreenJewel : Jewel {

    public GreenJewel(int x, int y) : base(x, y) {
        Points = 50;
    }

    public override string ToString() {
        return "JG";
    }
}