
// Desenvolva o minigame chamado Jewel Collector. O objetivo desse jogo é que um robô, 
// controlado pelo teclado, se desloque por um mapa 2D de modo a desviar dos obstáculos 
// e coletar todas as joias. Para isso, as seguintes classes devem ser criadas: Jewel.cs,
// Obstacle.cs, Robot.cs, Map.cs, JewelCollector.cs


// Inicie o jogo, isto é, leia o teclado e colete todas as joias e desvie 
// dos obstáculos interativamente.

// public class JewelCollector {
//   public static void Main() {
//       bool running = true;
//       do {
//           Console.WriteLine("Enter the command: ");
//         // string command = Console.ReadLine();
//         // Console.ReadLine() pode ser substituído por um Console.ReadKey() 
//         // para evitar a necessidade de se digitar <ENTER> a cada tecla digitada.
//         // ConsoleKeyInfo command = Console.ReadKey();
//         ConsoleKeyInfo command = Console.ReadKey();
  
//           if (command.Equals("quit")) {
//               running = false;
//           } else if (command.Equals("w")) {
//           } else if (command.Equals("a")) {
//           } else if (command.Equals("s")) {
//           } else if (command.Equals("d")) {
//           } else if (command.Equals("g")) {
//           }
//       } while (running);
//   }

/// <summary>
/// Essa é a classe principal, que é responsável por implementar o método Main() que chama as demais classes existentes no projeto, criar o mapa, inserir as joias, obstáculos, instanciar o robô e ler os comandos do teclado. 
/// Para que o usuário possa controlar o robô, os seguintes comandos deverão ser passados através das teclas w, s, a, d, g. 
/// Sendo que a tecla "w" desloca o robô para o norte, a tecla "s" desloca para o sul, a tecla "a" desloca para oeste e a tecla "d" para leste. Para coletar uma joia, o usuário deve usar a tecla "g".  
/// </summary>


public class JewelCollector {
    public static void Main() {
        Map map = new Map();

        RedJewel redRedJewel1 = new RedJewel(1, 9);
        map.AddCell(redRedJewel1);

        RedJewel redRedJewel2 = new RedJewel(8, 8);
        map.AddCell(redRedJewel2);

        GreenJewel greenGreenJewel1 = new GreenJewel(9, 1);
        map.AddCell(greenGreenJewel1);

        GreenJewel greenGreenJewel2 = new GreenJewel(7, 6);
        map.AddCell(greenGreenJewel2);

        BlueJewel blueBlueJewel1 = new BlueJewel(3, 4);
        map.AddCell(blueBlueJewel1);

        BlueJewel blueBlueJewel2 = new BlueJewel(2, 1);
        map.AddCell(blueBlueJewel2);

        Water water1 = new Water(5, 0);
        map.AddCell(water1);

        Water water2 = new Water(5, 1);
        map.AddCell(water2);

        Water water3 = new Water(5, 2);
        map.AddCell(water3);

        Water water4 = new Water(5, 3);
        map.AddCell(water4);

        Water water5 = new Water(5, 4);
        map.AddCell(water5);

        Water water6 = new Water(5, 5);
        map.AddCell(water6);

        Water water7 = new Water(5, 6);
        map.AddCell(water7);

        Tree tree1 = new Tree(5, 9);
        map.AddCell(tree1);

        Tree tree2 = new Tree(3, 9);
        map.AddCell(tree2);

        Tree tree3 = new Tree(8, 3);
        map.AddCell(tree3);

        Tree tree4 = new Tree(2, 5);
        map.AddCell(tree4);

        Tree tree5 = new Tree(1, 4);
        map.AddCell(tree5);

        // RadioactiveElement radioactiveElement = new RadioactiveElement(2, 2);
        // map.AddCell(radioactiveElement);

          
        Robot robot = new Robot(0, 0);

        bool isGameRunning = true;

        //do {
        while (isGameRunning){
        try {
            map.PrintMap(robot);
            // Console.WriteLine("Enter the command: ");
            ConsoleKeyInfo command = Console.ReadKey();

            if (command.Key == ConsoleKey.Q) {
                isGameRunning = false;
            } else if (command.Key == ConsoleKey.W) {
                robot.MoveNorth(map);
            } else if (command.Key == ConsoleKey.A) {
                robot.MoveWest(map);
            } else if (command.Key == ConsoleKey.S) {
                robot.MoveSouth(map);
            } else if (command.Key == ConsoleKey.D) {
                robot.MoveEast(map);
            } else if (command.Key == ConsoleKey.G) {
                robot.CollectCollectable(map);
            }

      //  try   ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       // {
        //     robot.MoveEast(map);
        //     robot.MoveSouth(map);
        //     robot.MoveSouth(map);
        //     robot.MoveWest(map);
        //     robot.MoveNorth(map);
        //     robot.CollectCollectable(map);
        //     robot.CollectCollectable(map);
        //     robot.CollectCollectable(map);
        }
        catch (NoEnergyToRunException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidPositionToStayException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Total Score: " + robot.TotalScore);
        Console.WriteLine("Total Jewels: " + robot.TotalJewels);
        Console.WriteLine("Total Energy: " + robot.TotalEnergy);
    // }

            ///////////////////////////////////////////////

            map.PrintMap(robot);

            if(robot.TotalEnergy <= 0){
                isGameRunning = false;
            }

            if(map.isEmpty()){
                // map.levelUp(robot);
                try {
                    map.levelUp(robot);
                } catch (OutOfTheBorderOfMapException ex) {
                    Console.WriteLine(ex.Message);
                }

                map.PrintMap(robot);
           }

        }
           

        // } while (isGameRunning);
    }
}