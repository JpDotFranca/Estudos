namespace Builder;

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
