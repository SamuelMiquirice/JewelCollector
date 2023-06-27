// Crie um mapa com dimensão 10x10 

// namespace JewelCollector


/// <summary>
/// Essa classe armazena as informações do mapa 2D e implementar métodos para adição e remoção de joias e obstáculos. 
/// A classe implementa um método que imprimir o mapa na tela. 
/// A impressão do mapa segue as seguintes regras: 
/// Robo será impresso como ME; 
/// Joias Red, como JR; 
/// Joias Green, como JG; 
/// Joias Blue, como JB; 
/// Obstáculos do tipo Tree, como $$; 
/// Obstáculos do tipo Water, como ##; 
/// Espaços vazios, como --.
/// </summary>

public class Map {
    public ICell[,] Cells { get; set; }
    public int size { get; set; }

    public Map() {
        size = 10;
        Cells = new ICell[size, size];
        InitializeEmptyCells();
    }


        // var radioactiveElement = new RadioactiveElement(2, 2);
        // Cells[radioactiveElement.X, radioactiveElement.Y] = radioactiveElement;
    

/// <summary>
/// Essa método, verifica se ainda possui uma joia no mapa.  Isso ajuda a definir se o mapa foi finalizado.     
/// </summary>
/// <returns> e possuir ele retorna Falso (o mapa ainda nao esta vazio), se nao retorna true. </returns>
    public bool isEmpty()
    {
       
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++)
            {
                if(Cells[i,j] is Jewel)
                    return false;
            }
            
        } 
        return true;
    }






    // <summary>
/// Essa método, passa para o nível 2 ou fase 2 (da mesma forma poderá passar para os níveis 3, 4, 5, se existirem).
/// Para isso ela inicializa os elementos vazios, recebe o jogador para manter seu score e o coloca na posicao 0. Após isso é colocado no mapa as joias e outros obstaculos.
/// </summary>
    public void levelOne(Robot robot)
    {   

        RedJewel redRedJewel1 = new RedJewel(1, 9);
        this.AddCell(redRedJewel1);

        RedJewel redRedJewel2 = new RedJewel(8, 8);
        this.AddCell(redRedJewel2);

        GreenJewel greenGreenJewel1 = new GreenJewel(9, 1);
        this.AddCell(greenGreenJewel1);

        GreenJewel greenGreenJewel2 = new GreenJewel(7, 6);
        this.AddCell(greenGreenJewel2);

        BlueJewel blueBlueJewel1 = new BlueJewel(3, 4);
        this.AddCell(blueBlueJewel1);

        BlueJewel blueBlueJewel2 = new BlueJewel(2, 1);
        this.AddCell(blueBlueJewel2);

        Water water1 = new Water(5, 0);
        this.AddCell(water1);

        Water water2 = new Water(5, 1);
        this.AddCell(water2);

        Water water3 = new Water(5, 2);
        this.AddCell(water3);

        Water water4 = new Water(5, 3);
        this.AddCell(water4);

        Water water5 = new Water(5, 4);
        this.AddCell(water5);

        Water water6 = new Water(5, 5);
        this.AddCell(water6);

        Water water7 = new Water(5, 6);
        this.AddCell(water7);

        Tree tree1 = new Tree(5, 9);
        this.AddCell(tree1);

        Tree tree2 = new Tree(3, 9);
        this.AddCell(tree2);

        Tree tree3 = new Tree(8, 3);
        this.AddCell(tree3);

        Tree tree4 = new Tree(2, 5);
        this.AddCell(tree4);

        Tree tree5 = new Tree(1, 4);
        this.AddCell(tree5);

        // RadioactiveElement radioactiveElement = new RadioactiveElement(2, 2);
        // map.AddCell(radioactiveElement);
    }



// <summary>
/// Essa método, passa para o nível 2 ou fase 2 (da mesma forma poderá passar para os níveis 3, 4, 5, se existirem).
/// Para isso ela inicializa os elementos vazios, recebe o jogador para manter seu score e o coloca na posicao 0. Após isso é colocado no mapa as joias e outros obstaculos aleatoriamente.
/// </summary>
    public void levelUp(Robot robot)
    {     
        size++;
        Cells = new ICell[size, size];
        InitializeEmptyCells();
  
        robot.setPos(0,0);
        robot.TotalEnergy = size/2;

        // Random random = new Random();
        // random.Next(0, 10); // retorna aleatoriamente um número inteiro >= 0 and < 10

        Random random = new Random();
        for (int i=0; i < 3; i++){
             RadioactiveElement radioactiveElement = new RadioactiveElement(random.Next(0, size), random.Next(0, size));
             this.AddCell(radioactiveElement);
        }


        for (int i=0; i < 3; i++){
             RedJewel redRedJewel = new RedJewel(random.Next(0, size), random.Next(0, size));
             this.AddCell(redRedJewel);
        }

        // RedJewel redRedJewel1 = new RedJewel(1, 9);
        // this.AddCell(redRedJewel1);

        // RadioactiveElement radioactiveElement = new RadioactiveElement(2, 2);
        // this.AddCell(radioactiveElement);

        // RedJewel redRedJewel2 = new RedJewel(8, 8);
        // this.AddCell(redRedJewel2);

        // GreenJewel greenGreenJewel1 = new GreenJewel(9, 1);
        // this.AddCell(greenGreenJewel1);

        // GreenJewel greenGreenJewel2 = new GreenJewel(7, 6);
        // this.AddCell(greenGreenJewel2);

        // BlueJewel blueBlueJewel1 = new BlueJewel(3, 4);
        // this.AddCell(blueBlueJewel1);

        // BlueJewel blueBlueJewel2 = new BlueJewel(2, 1);
        // this.AddCell(blueBlueJewel2);



        for (int i=0; i < 3; i++){
             GreenJewel greenGreenJewel = new GreenJewel(random.Next(0, size), random.Next(0, size));
             this.AddCell(greenGreenJewel);
        }



        for (int i=0; i < 3; i++){
             BlueJewel blueBlueJewel = new BlueJewel(random.Next(0, size), random.Next(0, size));
             this.AddCell(blueBlueJewel);
        }



        for (int i=0; i < 3; i++){
             Water water = new Water(random.Next(0, size), random.Next(0, size));
             this.AddCell(water);
        }



        for (int i=0; i < 3; i++){
             Tree tree = new Tree(random.Next(0, size), random.Next(0, size));
             this.AddCell(tree);
        }
    
        this.AddCell(robot);

    }
    


    public void PrintMap(Robot robot) {
        Console.Clear();
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                if (i == robot.X && j == robot.Y) {
                    Console.Write(robot + " ");
                } else {
                    Console.Write(Cells[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        robot.PrintStats();
    }

    private void InitializeEmptyCells() {
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                Cells[i, j] = new EmptyCell();
            }
        }
    }

    public void AddCell(ICell cell) {
        // Cells[cell.X, cell.Y] = cell;
        int x = cell.X;
        int y = cell.Y;

        if (x >= 0 && x < size && y >= 0 && y < size) {
            Cells[x, y] = cell;
        } else {
            throw new OutOfTheBorderOfMapException("A posição da céluna está fora do limite do mapa.");
        }
    }
    // }

    public void RemoveCell(ICell cell) {  ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Cells[cell.X, cell.Y] = new EmptyCell();
    }

}
