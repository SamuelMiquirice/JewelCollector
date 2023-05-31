/*
Jewel.cs - A classe Jewel deverá armazenar as informações da joia, como a posição (x, y) 
no mapa e o tipo, que poderá ser Red, no valor de 100 pontos; Green, no valor de 50 pontos; 
e Blue, no valor de 10 pontos. 
*/

    // • Crie e insira as joias de acordo com o tipo e posição (x, y) abaixo: 
    //     ◦ Red - (1, 9) 
    //     ◦ Red - (8, 8) 
    //     ◦ Green - (9, 1) 
    //     ◦ Green - (7, 6) 
    //     ◦ Blue - (3, 4) 
    //     ◦ Blue - (2, 1) 

// A impressão do mapa deverá seguir a seguinte regra:Joias Red,como JR; Joias Green, como JG; Joias Blue, como JB;

public class Jewel : ICell {
    public int X { get; }
    public int Y { get; }
    public string Type { get; }

    public Jewel(int x, int y, string type) {
        X = x;
        Y = y;
        Type = type;
    }

    public string Symbol {
        get {
            switch (Type) {
                case "Red":
                    return "JR";
                case "Green":
                    return "JG";
                case "Blue":
                    return "JB";
                default:
                    return "--";
            }
        }
    }
}





/*

public class Jewel {
    public int X { get; set; }
    public int Y { get; set; }
    public string Type { get; set; }

    public Jewel(int x, int y, string type) {
        X = x;
        Y = y;
        Type = type;
    }
}

*/