public class EmptyCell : ICell {
    public int X { get; }
    public int Y { get; }
    
    public override string ToString() {
        return "--";
    }
}