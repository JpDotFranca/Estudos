namespace Builder;

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