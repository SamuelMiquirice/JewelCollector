/// <summary>
/// Essa classe herda as caraterísticas da classe Jewel, por tratar-se de um tipo de joia.
/// </summary>
public class RedJewel : Jewel {

    public RedJewel(int x, int y) : base(x, y) {
        Points = 100;
    }

    public override string ToString() {
        return "JR";
    }
}