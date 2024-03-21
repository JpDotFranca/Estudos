using System.Reflection;
using System.Text.RegularExpressions;

namespace Builder;

/*
 * O objetivo do padrão builder é facilitar a criação de objetos complexos de forma organizada.
 * Ele nos leva a criar objetos diferentes usando o mesmo padrão de construção.
 * Ela evita que a criação de alguma classe específica contenha uma infinidade de parâmetros no construtore.
 */

public class Program
{
    static void Main(string[] args)
    {
        // Abordagem convencional
        Program p = new();
        Notebook macBook = p.CriarMacBook();
        Notebook acer = p.CriarAspire();

        // Abordagem com builder
        INotebookBuilder aspireBuilder = new AspireBuilder().DefinirAnoFabricacao(2020)
                                                            .DefinirModeloPlacaVideo("RTX 4070")
                                                            .DefinirGBMemoriaRam(1500);

        Notebook acer_com_builder = aspireBuilder.Build();
    }

    /// <summary>
    /// Podemos notar que na criação do MAC, omitimos o valor para a placa de vídeo pois o modelo não possui.
    /// A alternativa seria criar mais um construtor para o objeto ignorando a condição ou fazer um tipo especialista que
    /// herdasse de macbook. Aí que vem a alternativa do Builder. 
    /// </summary> 
    public Notebook CriarMacBook()
    {
        Notebook mac = new("Apple", "Air", 2015, null, 16, "ssd");
        return mac;
    }

    public Notebook CriarAspire()
    {
        Notebook mac = new("Acer", "ASPIRE", 2020, "RTX 4060", 64, "ssd");
        return mac;
    }
}

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

public interface INotebookBuilder
{
    INotebookBuilder DefinirMarca(string marca);
    INotebookBuilder DefinirModelo(string modelo);
    INotebookBuilder DefinirAnoFabricacao(int anoFabricacao);
    INotebookBuilder DefinirModeloPlacaVideo(string modeloPlacaVideo);
    INotebookBuilder DefinirGBMemoriaRam(int memoriaRam);
    INotebookBuilder DefinirTipoArmazenamento(string tipoArmazenamento);

    Notebook Build();
}

public class AspireBuilder : INotebookBuilder
{
    private int _anoFabricacao;
    private int _gbMemoriaRam;
    private string _marca = "aspire";
    private string _modelo;
    private string _modeloPlacaVideo;
    private string _tipoArmazenamento;
    public INotebookBuilder DefinirAnoFabricacao(int anoFabricacao)
    {
        _anoFabricacao = anoFabricacao;
        return this;
    }

    public INotebookBuilder DefinirGBMemoriaRam(int gbMemoriaRam)
    {
        _gbMemoriaRam = gbMemoriaRam;
        return this;
    }

    /* É possível costumizar alguns comportamentos que façam sentido com as regras utilizando essa abordagem */
    public INotebookBuilder DefinirMarca(string marca)
        => throw new ArgumentException("A marca 'Acer' já está definida.");

    /* É possível costumizar alguns comportamentos que façam sentido com as regras utilizando essa abordagem */
    public INotebookBuilder DefinirModelo(string modelo)
        => throw new ArgumentException("A marca 'aspire' já está definida.");

    public INotebookBuilder DefinirModeloPlacaVideo(string modeloPlacaVideo)
    {
        _modeloPlacaVideo = modeloPlacaVideo;
        return this;
    }

    public INotebookBuilder DefinirTipoArmazenamento(string tipoArmazenamento)
    {
        _tipoArmazenamento = tipoArmazenamento;
        return this;
    }

    public Notebook Build() => new(_marca,
                                  _modelo,
                             _anoFabricacao,
                           _modeloPlacaVideo,
                              _gbMemoriaRam,
                          _tipoArmazenamento);
}