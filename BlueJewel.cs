
/// <summary>
/// Essa classe herda as caraterísticas da classe Jewel, por tratar-se de um tipo de joia.
/// </summary>
public class BlueJewel : Jewel, IEnergySource {

    public int Energy { get; }
    public BlueJewel(int x, int y) : base(x, y) {
        Energy = 5;
        Points = 10;
    }

    public override string ToString() {
        return "JB";
    }
}