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
    public int TotalEnergy { get; set; }

    public Robot(int x, int y) {
        X = x;
        Y = y;
        TotalScore = 0;
        TotalJewels = 0;
        TotalEnergy = 5;
        Bag = new List<ICell>();
    }

    public void MoveNorth(Map map) {
        // if (X > 0 && !(map.Cells[X - 1, Y] is Obstacle)) {
        //     map.Cells[X, Y] = new EmptyCell();
        //     X--;
        //     map.Cells[X, Y] = (ICell) this;
        // }

        
        if (TotalEnergy > 0 && X > 0 && !(map.Cells[X - 1, Y] is Obstacle)) {
            map.Cells[X, Y] = new EmptyCell();
            X--;
            TotalEnergy --;
            map.Cells[X, Y] = (ICell) this;
            }
    }

    public void MoveWest(Map map) {
        if (TotalEnergy > 0 && Y > 0 && !(map.Cells[X, Y - 1] is Obstacle)) {
            map.Cells[X, Y] = new EmptyCell();
            Y--;
            TotalEnergy --;
            map.Cells[X, Y] = this;
        }
    }

    public void MoveSouth(Map map) {
        if (TotalEnergy > 0 && X < 9 && !(map.Cells[X + 1, Y] is Obstacle)) {
            map.Cells[X, Y] = new EmptyCell();
            X++;
            TotalEnergy --;
            map.Cells[X, Y] = this;
        }
    }
    public void MoveEast(Map map) {
        if (TotalEnergy > 0 && Y < 9 && !(map.Cells[X, Y + 1] is Obstacle)) {
            map.Cells[X, Y] = new EmptyCell();
            Y++;
            TotalEnergy --;
            map.Cells[X, Y] = this;
        }
    }

public void setPos(int x, int y)
{
    this.X=y;
    this.Y = y;

}


public void CollectCollectable(Map map) {
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

    ICollectable? collectable = null;
    // Verificar se alguma célula vizinha contém um coletavel
    if (rightCell is ICollectable) {
        collectable = (ICollectable) rightCell;
    } else if (leftCell is ICollectable) {
        collectable = (ICollectable) leftCell;
    } else if (topCell is ICollectable) {
        collectable = (ICollectable) topCell;
    } else if (bottomCell is ICollectable) {
        collectable = (ICollectable) bottomCell;
    }

    if (collectable != null) {
        if (collectable is Jewel) {
            TotalJewels++;
        }
        if (collectable is IEnergySource) {
            TotalEnergy += ((IEnergySource)collectable).Energy;
        }

        TotalScore += collectable.Points;

        map.RemoveCell((ICell)collectable);
        Bag.Add((ICell)collectable);
    }
}

    public void PrintStats() {
        Console.WriteLine("Total Jewels: " + TotalJewels);
        Console.WriteLine("Total Score: " + TotalScore);
        Console.WriteLine("Total Energy: " + TotalEnergy);
    }

    public override string ToString() {
        return "ME";
    }
}
