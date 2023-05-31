/*  
Robot.cs - A classe Robot deverá ser responsável por armazenar as informações do robô, 
que será a posição (x, y) e uma sacola (bag), em que o robô colocará as joias coletadas 
no mapa. Além disso, a classe Robot deverá implementar os métodos para que o robô possa 
interagir com o mapa, isto é, deslocar-se nas quatro direções e coletar as joias. Além 
disso, implemente um método para imprimir na tela o total de joias armazenadas na sacola 
e o valor total. 
*/

// Crie o robô na posição (x, y) = (0, 0). 



public class Robot : ICell {
    public int X { get; private set; }
    public int Y { get; private set; }
    public List<ICell> Bag { get; }
    public int TotalScore { get; set; }
    public int TotalJewels { get; set; }

    public string Symbol => "ME";

    public Robot(int x, int y) {
        X = x;
        Y = y;
        TotalScore = 0;
        TotalJewels = 0;
        Bag = new List<ICell>();
    }

    public void MoveNorth(Map map) {
        if (X > 0 && !(map.Cells[X - 1, Y] is Obstacle)) {
            map.Cells[X, Y] = new EmptyCell();
            X--;
            map.Cells[X, Y] = (ICell) this;
        }
    }

    public void MoveWest(Map map) {
        if (Y > 0 && !(map.Cells[X, Y - 1] is Obstacle)) {
            map.Cells[X, Y] = new EmptyCell();
            Y--;
            map.Cells[X, Y] = this;
        }
    }

    public void MoveSouth(Map map) {
        if (X < 9 && !(map.Cells[X + 1, Y] is Obstacle)) {
            map.Cells[X, Y] = new EmptyCell();
            X++;
            map.Cells[X, Y] = this;
        }
    }
    public void MoveEast(Map map) {
        if (Y < 9 && !(map.Cells[X, Y + 1] is Obstacle)) {
            map.Cells[X, Y] = new EmptyCell();
            Y++;
            map.Cells[X, Y] = this;
        }
    }

    // public void CollectJewel(Map map) {
        
    //     ICell rightCell = map.Cells[X+1, Y];
    //     ICell leftCell = map.Cells[X-1, Y];
    //     ICell topCell = map.Cells[X, Y+1];
    //     ICell bottomCell = map.Cells[X, Y-1];

    //     Jewel? foundJewel;

    //     if (rightCell is Jewel){
    //         foundJewel = (Jewel) rightCell;
    //     } else if (leftCell is Jewel){
    //         foundJewel = (Jewel) leftCell;
    //     } else if (topCell is Jewel){
    //         foundJewel = (Jewel) topCell;
    //     } else if (bottomCell is Jewel){
    //         foundJewel = (Jewel) bottomCell;
    //     } else {
    //         foundJewel = null;
    //     }

    //     if (foundJewel != null) {
    //         TotalJewels++;
    //         TotalScore += GetJewelValue(foundJewel.Type);
            
    //         map.RemoveJewel(foundJewel);
    //         // map.Cells[foundJewel.X, foundJewel.Y] = new EmptyCell(); // Implementação caso não estivesse implementado na outra classe (Map)
            
    //         Bag.Add(foundJewel);
    //     }

    // }


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// // map.Size não está definido
// public void CollectJewel(Map map)
// {
//     ICell rightCell = null;
//     ICell leftCell = null;
//     ICell topCell = null;
//     ICell bottomCell = null;

//     if (X + 1 < map.Size && !(map.Cells[X + 1, Y] is Obstacle))
//         rightCell = map.Cells[X + 1, Y];

//     if (X - 1 >= 0 && !(map.Cells[X - 1, Y] is Obstacle))
//         leftCell = map.Cells[X - 1, Y];

//     if (Y + 1 < map.Size && !(map.Cells[X, Y + 1] is Obstacle))
//         topCell = map.Cells[X, Y + 1];

//     if (Y - 1 >= 0 && !(map.Cells[X, Y - 1] is Obstacle))
//         bottomCell = map.Cells[X, Y - 1];

//     Jewel foundJewel = null;

//     if (rightCell is Jewel)
//     {
//         foundJewel = (Jewel)rightCell;
//     }
//     else if (leftCell is Jewel)
//     {
//         foundJewel = (Jewel)leftCell;
//     }
//     else if (topCell is Jewel)
//     {
//         foundJewel = (Jewel)topCell;
//     }
//     else if (bottomCell is Jewel)
//     {
//         foundJewel = (Jewel)bottomCell;
//     }

//     if (foundJewel != null)
//     {
//         TotalJewels++;
//         TotalScore += GetJewelValue(foundJewel.Type);

//         map.RemoveJewel(foundJewel);
//         // map.Cells[foundJewel.X, foundJewel.Y] = new EmptyCell(); // Implementação caso não estivesse implementado na outra classe (Map)

//         Bag.Add(foundJewel);
//     }
// }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// // map.Width não funciona
// // map.Height também não funciona
// public void CollectJewel(Map map) {
//     if (X + 1 < map.Width) {
//         ICell rightCell = map.Cells[X + 1, Y];
//         if (rightCell is Jewel foundJewel) {
//             CollectJewelHelper(map, foundJewel);
//             return;
//         }
//     }
    
//     if (X - 1 >= 0) {
//         ICell leftCell = map.Cells[X - 1, Y];
//         if (leftCell is Jewel foundJewel) {
//             CollectJewelHelper(map, foundJewel);
//             return;
//         }
//     }
    
//     if (Y + 1 < map.Height) {
//         ICell topCell = map.Cells[X, Y + 1];
//         if (topCell is Jewel foundJewel) {
//             CollectJewelHelper(map, foundJewel);
//             return;
//         }
//     }
    
//     if (Y - 1 >= 0) {
//         ICell bottomCell = map.Cells[X, Y - 1];
//         if (bottomCell is Jewel foundJewel) {
//             CollectJewelHelper(map, foundJewel);
//             return;
//         }
//     }
// }

// private void CollectJewelHelper(Map map, Jewel foundJewel) {
//     TotalJewels++;
//     TotalScore += GetJewelValue(foundJewel.Type);

//     map.RemoveJewel(foundJewel);
//     Bag.Add(foundJewel);
// }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

public void CollectJewel(Map map) {
    int mapSize = 10;
    
    ICell rightCell = null;
    ICell leftCell = null;
    ICell topCell = null;
    ICell bottomCell = null;

    // Verificar se as células vizinhas estão dentro dos limites do mapa
    if (X < mapSize - 1) {
        rightCell = map.Cells[X + 1, Y];
    }
    if (X > 0) {
        leftCell = map.Cells[X - 1, Y];
    }
    if (Y < mapSize - 1) {
        topCell = map.Cells[X, Y + 1];
    }
    if (Y > 0) {
        bottomCell = map.Cells[X, Y - 1];
    }

    Jewel foundJewel = null;

    // Verificar se alguma célula vizinha contém uma joia
    if (rightCell is Jewel) {
        foundJewel = (Jewel)rightCell;
    } else if (leftCell is Jewel) {
        foundJewel = (Jewel)leftCell;
    } else if (topCell is Jewel) {
        foundJewel = (Jewel)topCell;
    } else if (bottomCell is Jewel) {
        foundJewel = (Jewel)bottomCell;
    }

    if (foundJewel != null) {
        TotalJewels++;
        TotalScore += GetJewelValue(foundJewel.Type);

        map.RemoveJewel(foundJewel);
        Bag.Add(foundJewel);
    }
}



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    private int GetJewelValue(string type) {
        switch (type) {
            case "Red":
                return 100;
            case "Green":
                return 50;
            case "Blue":
                return 10;
            default:
                return 0;
        }
    }

    public void PrintStats() {
        Console.WriteLine("Total Jewels: " + TotalJewels);
        Console.WriteLine("Total Score: " + TotalScore);
    }
}






/*public void CollectJewel(Jewel jewel) {
        Bag[jewel.X, jewel.Y] = jewel.Type;
        TotalJewels++;
        switch (jewel.Type) {
            case "Red":
                TotalScore += 100;
                break;
            case "Green":
                TotalScore += 50;
                break;
            case "Blue":
                TotalScore += 10;
                break;
        }
    }
    public int TotalScore { get; set; }
    public int TotalJewels { get; set; }
    public string[,] Bag { get; set; }

    public Robot(int x, int y) {
        X = x;
        Y = y;
        TotalScore = 0;
        TotalJewels = 0;
        Bag = new string[10, 10];
    }

    public void CollectJewel(Jewel jewel) {
        Bag[jewel.X, jewel.Y] = jewel.Type;
        TotalJewels++;
        switch (jewel.Type) {
            case "Red":
                TotalScore += 100;
                break;
            case "Green":
                TotalScore += 50;
                break;
            case "Blue":
                TotalScore += 10;
                break;
        }
    }

    public void Move(string direction) {
        switch (direction) {
            case "w":
                if (X > 0) {
                    X--;
                }
                break;
            case "s":
                if (X < 9) {
                    X++;
                }
                break;
            case "a":
                if (Y > 0) {
                    Y--;
                }
                break;
            case "d":
                if (Y < 9) {
                    Y++;
                }
                break;
        }
    }

    public void PrintStats() {
        Console.WriteLine("Total Jewels: " + TotalJewels);
        Console.WriteLine("Total Score: " + TotalScore);
    }
}

*/






