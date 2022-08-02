namespace Trys.Interfaces;

public interface ICsvLineParser
{
    public string[] ParseLine(string line);
}

public interface ICsvParser
{
    public string[] Parse(string csvData);
}

public interface IDataCrud
{
    public void DataWrite(List<string[]> csvData);
}

public interface IReadCsv
{
    public string Read(string fileName);
}
