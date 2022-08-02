using Trys.Interfaces;

namespace Trys;


public class DataProcessor
{
    private readonly IReadCsv _readCsv;
    private readonly ParserProcessor _parserProcessor;
    private readonly IDataCrud _dataCrud;


    public DataProcessor(IReadCsv readCsv, ParserProcessor parserProcessor, IDataCrud dataCrud)
    {
        _readCsv = readCsv;
        _parserProcessor = parserProcessor;
        _dataCrud = dataCrud;
    }

    public void Process(string fileName)
    {
        var fileContent = _readCsv.Read(fileName);
        var data = _parserProcessor.Process(fileContent);
        _dataCrud.DataWrite(data);
    }
}