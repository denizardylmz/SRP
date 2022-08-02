using Trys.Interfaces;

namespace Trys;


public class CsvParser : ICsvParser
{
    public string[] Parse(string csvContent)
    {
        string[] result = csvContent.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        return result;
    }
}


