 // • Crie e insira as joias de acordo com o tipo e posição (x, y) abaixo: 
    //     ◦ Red - (1, 9) 
    //     ◦ Red - (8, 8) 
    //     ◦ Green - (9, 1) 
    //     ◦ Green - (7, 6) 
    //     ◦ Blue - (3, 4) 
    //     ◦ Blue - (2, 1) 



/// <summary>
/// Essa é a classe, armazena as informações da joia, como a posição (x, y) no mapa e o tipo, que poderá ser Red, no valor de 100 pontos; Green, no valor de 50 pontos; e Blue, no valor de 10 pontos. 
/// A impressão do mapa segue a seguinte regra: Joias Red,como JR; Joias Green, como JG; Joias Blue, como JB;
/// </summary>

public class Jewel : ICell, ICollectable {
    public int X { get; }
    public int Y { get; }

    public int Points { get; set; }

    public Jewel(int x, int y) {
        X = x;
        Y = y;
    }
}



