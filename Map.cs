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


        // var radioactiveElement = new RadioactiveElement(2, 2);
        // Cells[radioactiveElement.X, radioactiveElement.Y] = radioactiveElement;
    
    public bool isEmpty()
    {
        /*
            Verifica se ainda possui uma joia no mapa. Se possuir ele retorna Falso (o mapa ainda nao esta vazio), se nao retorna true.
            isso ajuda a definir se o mapa foi finalizado.

        */
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++)
            {
                if(Cells[i,j] is Jewel)
                    return false;
            }
            
        } 
        return true;
    }

    public void levelUp(Robot robot)
    {
        /*
        Essa funcao passa para o level 2 (pode passar para os leveis 3, 4, 5, se existirem)
        para isso ela inicializa os elementos vazios, recebe o jogador para manter seu score 
        e o coloca na posicao 0. Após isso é colocado no mapa as joias e outros obstaculos

        */


        


        InitializeEmptyCells();
        robot.setPos(0,0);
        RedJewel redRedJewel1 = new RedJewel(1, 9);
        this.AddCell(redRedJewel1);

        RadioactiveElement radioactiveElement = new RadioactiveElement(2, 2);
        this.AddCell(radioactiveElement);

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

        // Water water2 = new Water(5, 1);
        // this.AddCell(water2);

        // Water water3 = new Water(5, 2);
        // this.AddCell(water3);

        // Water water4 = new Water(5, 3);
        // this.AddCell(water4);

        // Water water5 = new Water(5, 4);
        // this.AddCell(water5);

        // Water water6 = new Water(5, 5);
        // this.AddCell(water6);

        // Water water7 = new Water(5, 6);
        // this.AddCell(water7);



        Tree tree3 = new Tree(8, 3);
        this.AddCell(tree3);

        Tree tree4 = new Tree(2, 5);
        this.AddCell(tree4);

        Tree tree5 = new Tree(1, 4);
        this.AddCell(tree5);

        this.AddCell(robot);


    }


    


    public void PrintMap(Robot robot) {
        Console.Clear();
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
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
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                Cells[i, j] = new EmptyCell();
            }
        }
    }

    public void AddCell(ICell cell) {
        Cells[cell.X, cell.Y] = cell;
    }

    public void RemoveCell(ICell cell) {
        Cells[cell.X, cell.Y] = new EmptyCell();
    }

}
