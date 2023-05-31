// Desenvolva o minigame chamado Jewel Collector. O objetivo desse jogo é que um robô, 
// controlado pelo teclado, se desloque por um mapa 2D de modo a desviar dos obstáculos 
// e coletar todas as joias. Para isso, as seguintes classes devem ser criadas: Jewel.cs,
// Obstacle.cs, Robot.cs, Map.cs, JewelCollector.cs


/*
JewelCollector.cs - A classe JewelCollector deverá ser responsável por 
implementar o método Main(), criar o mapa, inserir as joias, obstáculos,
instanciar o robô e ler os comandos do teclado. Para que o usuário possa 
controlar o robô, os seguintes comandos deverão ser passados através das 
teclas w, s, a, d, g. Sendo que a tecla w desloca o robô para o norte, a 
tecla s desloca para o sul, a tecla a desloca para oeste e a tecla d para
leste. Para coletar uma joia, use a tecla g. 
*/


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



public class JewelCollector {
    public static void Main() {
        Map map = new Map();

        Jewel redJewel1 = new Jewel(1, 9, "Red");
        map.AddJewel(redJewel1);

        Jewel redJewel2 = new Jewel(8, 8, "Red");
        map.AddJewel(redJewel2);

        Jewel greenJewel1 = new Jewel(9, 1, "Green");
        map.AddJewel(greenJewel1);

        Jewel greenJewel2 = new Jewel(7, 6, "Green");
        map.AddJewel(greenJewel2);

        Jewel blueJewel1 = new Jewel(3, 4, "Blue");
        map.AddJewel(blueJewel1);

        Jewel blueJewel2 = new Jewel(2, 1, "Blue");
        map.AddJewel(blueJewel2);

        Obstacle water1 = new Obstacle(5, 0, "Water");
        map.AddObstacle(water1);

        Obstacle water2 = new Obstacle(5, 1, "Water");
        map.AddObstacle(water2);

        Obstacle water3 = new Obstacle(5, 2, "Water");
        map.AddObstacle(water3);

        Obstacle water4 = new Obstacle(5, 3, "Water");
        map.AddObstacle(water4);

        Obstacle water5 = new Obstacle(5, 4, "Water");
        map.AddObstacle(water5);

        Obstacle water6 = new Obstacle(5, 5, "Water");
        map.AddObstacle(water6);

        Obstacle water7 = new Obstacle(5, 6, "Water");
        map.AddObstacle(water7);

        Obstacle tree1 = new Obstacle(5, 9, "Tree");
        map.AddObstacle(tree1);

        Obstacle tree2 = new Obstacle(3, 9, "Tree");
        map.AddObstacle(tree2);

        Obstacle tree3 = new Obstacle(8, 3, "Tree");
        map.AddObstacle(tree3);

        Obstacle tree4 = new Obstacle(2, 5, "Tree");
        map.AddObstacle(tree4);

        Obstacle tree5 = new Obstacle(1, 4, "Tree");
        map.AddObstacle(tree5);

        Robot robot = new Robot(0, 0);

        bool isGameRunning = true;

        do {
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
                robot.CollectJewel(map);
            }
        } while (isGameRunning);
    }
}