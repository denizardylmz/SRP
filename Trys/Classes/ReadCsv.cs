using Trys.Interfaces;

namespace Trys;


public class ReadCsv : IReadCsv
{
    public string Read(string fileName)
    {
        TextReader tr = new StreamReader(fileName);
        string fileContent = tr.ReadToEnd();
        tr.Close();
        return fileContent;
    }
}