/// <summary>
/// Essa classe trata as exceções quando o robô tentar sair do mapa (não respeitando as fronteiras), 
/// ou mesmo quando estiver sem energia, ou tentando realizar outras atividades que violam as regras do jogo.
/// </summary>



public class NoEnergyToRunException : Exception {
    public NoEnergyToRunException(string message) : base(message) { }
}

