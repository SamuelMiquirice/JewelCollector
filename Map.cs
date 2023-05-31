/* 
Map.cs - A classe Map deverá armazenar as informações do mapa 2D e 
implementar métodos para adição e remoção de joias e obstáculos. 
Além de um método para imprimir o mapa na tela. A impressão do mapa 
deverá seguir a seguinte regra: Robo será impresso como ME; Joias Red, 
como JR; Joias Green, como JG; Joias Blue, como JB; Obstáculos do tipo Tree, 
como $$; Obstáculos do tipo Water, como ##; Espaços vazios, como --. 
*/

// Crie um mapa com dimensão 10x10 

public class Map {
    public ICell[,] Cells { get; }

    public Map() {
        Cells = new ICell[10, 10];
        InitializeEmptyCells();
    }

    public void PrintMap(Robot robot) {
        Console.Clear();
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                if (i == robot.X && j == robot.Y) {
                    Console.Write(robot.Symbol + " ");
                } else {
                    Console.Write(Cells[i, j].Symbol + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        robot.PrintStats();
    }

    private void InitializeEmptyCells() {
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                Cells[i, j] = new EmptyCell();
            }
        }
    }

    public void AddJewel(Jewel jewel) {
        Cells[jewel.X, jewel.Y] = jewel;
    }

    public void RemoveJewel(Jewel jewel) {
        Cells[jewel.X, jewel.Y] = new EmptyCell();
    }

    public void AddObstacle(Obstacle obstacle) {
        Cells[obstacle.X, obstacle.Y] = obstacle;
    }
}





/*


public class Map {
    private string[,] Cells { get; set; }

    public Map() {
        Cells = new string[10, 10];
        InitializeEmptyCells();
    }

    private void InitializeEmptyCells() {
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                Cells[i, j] = "--";
            }
        }
    }

    public void AddJewel(Jewel jewel) {
        Cells[jewel.X, jewel.Y] = GetJewelSymbol(jewel.Type);
    }

    public void RemoveJewel(Jewel jewel) {
        Cells[jewel.X, jewel.Y] = "--";
    }

    public void AddObstacle(Obstacle obstacle) {
        Cells[obstacle.X, obstacle.Y] = GetObstacleSymbol(obstacle.Type);
    }

    public void PrintMap(Robot robot) {
        Console.Clear();
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                if (i == robot.X && j == robot.Y) {
                    Console.Write("ME ");
                } else {
                    Console.Write(Cells[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        robot.PrintStats();
    }

    private string GetJewelSymbol(string type) {
        switch (type) {
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

    private string GetObstacleSymbol(string type) {
        switch (type) {
            case "Water":
                return "##";
            case "Tree":
                return "$$";
            default:
                return "--";
        }
    }
}

*/


