
/// <summary>
/// Essa é a classe, que controla o comportamento de um robô, criado na posição (x, y) = (0, 0).
/// A classe Robot é responsável por armazenar as informações do robô, que será a posição (x, y) e uma sacola (bag), em que o robô colocará as joias coletadas no mapa. 
/// A classe Robot implementa os métodos para que o robô possa interagir com o mapa, isto é, deslocar-se nas quatro direções e coletar as joias. 
/// A classe Robot também implementa um método para imprimir na tela o total de joias armazenadas na sacola e o valor total. 
/// </summary>
public class Robot : ICell {
    public int X { get; private set; }
    public int Y { get; private set; }
    public List<ICell> Bag { get; }
    public int TotalScore { get; set; }
    public int TotalJewels { get; set; }

    public string Symbol => "ME";
    public int TotalEnergy { get; set; }


/// <summary>
/// Este é o construtor da classe Robot.
/// </summary>
/// <param name="x"> Esse parámetro representa a posição do robô em função do eixo das abcisas.</param>
/// <param name="y"> Esse parámetro representa a posição do robô em função do eixo das ordenadas.</param>
    public Robot(int x, int y) {
        X = x;
        Y = y;
        TotalScore = 0;
        TotalJewels = 0;
        TotalEnergy = 5;
        Bag = new List<ICell>();
    }



/// <summary>
/// Este método verifica se a próxima posição (cima, baixo, esquerda ou direita) do robô não contém um elemento radiotivo (elemento que lhe faz perder 10 unidades de energia quando estiver ao lado do robô).
/// </summary>
/// <param name="map"> Representa a posição no mapa.</param>
/// <returns> Este método retorna "menos 10 unidades de energia", caso o elemento radiotivo estiver próximo (ao lado) do robô (após cada jogada).</returns>
    public void NeighborIsRadioactiveElement(Map map) {
        if (X - 1 >= 0 && (map.Cells[X - 1, Y] is RadioactiveElement)){ 
            TotalEnergy -=10; 
        }

        if (X + 1 < map.Cells.GetLength(0) && (map.Cells[X + 1, Y] is RadioactiveElement)){
            TotalEnergy -=10; 
        }

        if (Y - 1 >= 0 && (map.Cells[X, Y - 1] is RadioactiveElement)){ 
            TotalEnergy -=10; 
        }

        if (Y + 1 < map.Cells.GetLength(1) && (map.Cells[X, Y + 1] is RadioactiveElement)){
            TotalEnergy -=10; 
        }

            //  if ((map.Cells[X - 1, Y] is RadioactiveElement) || (map.Cells[X + 1, Y] is RadioactiveElement) || (map.Cells[X, Y - 1] is RadioactiveElement) || (map.Cells[X, Y +1] is RadioactiveElement)) {
            //     TotalEnergy -=10; 
            // }
    }



/// <summary>
/// Este método verifica se a posição a esquerda do robô não contém um obstáculo, se ainda tem energia e se não sai do limite do mapa.
/// </summary>
/// <param name="map"> Representa a posição no mapa.</param>
/// <returns> Este método retorna "menos 30 unidades de energia", caso o robô estiver em cima do elemento radiotivo após o robô deslocar-se para a esquerda.</returns>
    public void MoveNorth(Map map) {

        if (TotalEnergy > 0 && X - 1 >= 0 && !(map.Cells[X - 1, Y] is Obstacle)) {

            map.Cells[X, Y] = new EmptyCell();
            X--;
            TotalEnergy --;

            if (map.Cells[X, Y] is RadioactiveElement) {  
              TotalEnergy -=30;  
            }

            map.Cells[X, Y] = (ICell) this;  
            }

            NeighborIsRadioactiveElement(map);
            
    }   

    

   
/// <summary>
/// Este método verifica se a posição abaixo do robô não contém um obstáculo, se ainda tem energia e se não sai do limite do mapa.
/// </summary>
/// <param name="map"> Representa a posição no mapa.</param>
/// <returns> Este método retorna "menos 30 unidades de energia", caso o robô estiver em cima do elemento radiotivo após o robô deslocar-se para baixo.</returns>
    public void MoveWest(Map map) {
        if (TotalEnergy > 0 && Y - 1 >= 0 && !(map.Cells[X, Y - 1] is Obstacle)) {
            map.Cells[X, Y] = new EmptyCell();
            Y--;
            TotalEnergy --;

            if (map.Cells[X, Y] is RadioactiveElement) { 
              TotalEnergy -=30;  
            }

            map.Cells[X, Y] = this;
        }
        NeighborIsRadioactiveElement(map);      
    }


/// <summary>
/// Este método verifica se a posição a direita do robô não contém um obstáculo, se ainda tem energia e se não sai do limite do mapa.
/// </summary>
/// <param name="map"> Representa a posição no mapa.</param>
/// <returns> Este método retorna "menos 30 unidades de energia", caso o robô estiver em cima do elemento radiotivo após o robô deslocar-se para direita.</returns>
    public void MoveSouth(Map map) {
        if (TotalEnergy > 0 && X < map.Cells.GetLength(0) - 1 && !(map.Cells[X + 1, Y] is Obstacle)) {
            map.Cells[X, Y] = new EmptyCell();
            X++;
            TotalEnergy --;

            if (map.Cells[X, Y] is RadioactiveElement) {  
              TotalEnergy -=30;  
            }

            map.Cells[X, Y] = this;
        }
        NeighborIsRadioactiveElement(map);      
    }


/// <summary>
/// Este método verifica se a posição acima do robô não contém um obstáculo, se ainda tem energia e se não sai do limite do mapa.
/// </summary>
/// <param name="map"> Representa a posição no mapa.</param>
/// <returns> Este método retorna "menos 30 unidades de energia", caso o robô estiver em cima do elemento radiotivo após o robô deslocar-se para cima.</returns>
    public void MoveEast(Map map) {
        if (TotalEnergy > 0 && Y < map.Cells.GetLength(1) - 1 && !(map.Cells[X, Y + 1] is Obstacle)) {
            map.Cells[X, Y] = new EmptyCell();
            Y++;
            TotalEnergy --;

            if (map.Cells[X, Y] is RadioactiveElement) {  
            }

            map.Cells[X, Y] = this;
        }
        NeighborIsRadioactiveElement(map);      
    }

public void setPos(int x, int y)
{
    this.X=y;
    this.Y = y;

}


/// <summary>
/// Este método verifica se a próxima posição (esquerda, direita, cima, baixo) do robô contém um obstáculo ou um objeto (joia) coletável (o que incrementa a energia e a pontuação)
/// <param name="map"> Representa a posição no mapa.</param>
/// <returns> Este método retorna energia e a pontuação atual, após a coleção do objeito (joia)</returns>
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
        if ((collectable is IEnergySource)){
            if ((collectable is Tree)){
                Tree tree = (Tree)collectable;
                if(!tree.Taken) { // tree.Taken == false
                    TotalEnergy += ((IEnergySource)collectable).Energy;
                    tree.Taken = true;
                }
            }
        else{
            TotalEnergy += ((IEnergySource)collectable).Energy;
        }

        }

        TotalScore += collectable.Points;

        if (collectable is not Tree) {      // Para não remover a árvore ($$) do mapa
        map.RemoveCell((ICell)collectable);
        Bag.Add((ICell)collectable);
        }
    }
}


/// <summary>
/// Este método imprime na tela o total de joias armazenadas na sacola e a pontuação total. 
/// </summary>
    public void PrintStats() {
        Console.WriteLine("Total Jewels: " + TotalJewels);
        Console.WriteLine("Total Score: " + TotalScore);
        Console.WriteLine("Total Energy: " + TotalEnergy);
        Console.WriteLine($"Current Position: ({X}, {Y})");
    }

    public override string ToString() {
        return "ME";
    }
}
