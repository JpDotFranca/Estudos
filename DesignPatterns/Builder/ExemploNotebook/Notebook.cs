namespace Builder;

public class Notebook
{
    public Notebook(string marca, string modelo, int anoFabricacao, string modeloPlacaVideo, int gbMemoriaRam, string tipoArmazenamento)
    {
        Marca = marca;
        Modelo = modelo;
        AnoFabricacao = anoFabricacao;
        ModeloPlacaDeVideo = modeloPlacaVideo;
        GBMemoriaRAM = gbMemoriaRam;
        TipoArmazenamento = tipoArmazenamento;
    }

    public string Marca { get; init; }
    public string Modelo { get; init; }
    public int AnoFabricacao { get; init; }
    public string ModeloPlacaDeVideo { get; init; }
    public int GBMemoriaRAM { get; init; }
    public string TipoArmazenamento { get; init; }
}
