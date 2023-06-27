
/// <summary>
/// Essa interface é para auxiliar na coleção de pontos, sabendo que:
/// Os itens Tree e Blue Jewel fornecerão energia para o robô; 
/// Tree fornecerá 3 pontos de energia, enquanto que Blue Jewel fornecerá 5 pontos;
/// Todas as joias serão coletadas após o uso;
/// </summary>
public interface ICollectable {
    public int Points { get; set; }
}
