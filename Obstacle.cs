/*
Obstacle.cs - A classe Obstacle deverá armazenar as informações do obstáculo, 
que será a posição (x, y) e o tipo. Cada obstáculo deverá possuir um tipo, que 
poderá ser Water ou Tree. 
*/

    // • Crie e insira os obstáculos de acordo com o tipo e posição (x, y) abaixo: 
    //     ◦ Water - (5, 0) 
    //     ◦ Water - (5, 1) 
    //     ◦ Water - (5, 2) 
    //     ◦ Water - (5, 3) 
    //     ◦ Water - (5, 4) 
    //     ◦ Water - (5, 5) 
    //     ◦ Water - (5, 6) 
    //     ◦ Tree - (5, 9) 
    //     ◦ Tree - (3, 9) 
    //     ◦ Tree - (8, 3) 
    //     ◦ Tree - (2, 5) 
    //     ◦ Tree - (1, 4) 


public class Obstacle : ICell {
    public int X { get; }
    public int Y { get; }
    public string Type { get; }

    public Obstacle(int x, int y, string type) {
        X = x;
        Y = y;
        Type = type;
    }

    public string Symbol {
        get {
            switch (Type) {
                case "Water":
                    return "##";
                case "Tree":
                    return "$$";
                default:
                    return "--";
            }
        }
    }
}



/*

public class Obstacle {
    public int X { get; set; }
    public int Y { get; set; }
    public string Type { get; set; }

    public Obstacle(int x, int y, string type) {
        X = x;
        Y = y;
        Type = type;
    }
}

*/