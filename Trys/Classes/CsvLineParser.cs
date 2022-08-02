using Trys.Interfaces;

namespace Trys;



public class LineParser : ICsvLineParser
{
    public string[] ParseLine(string line)
    {
        return line.Split(";", StringSplitOptions.RemoveEmptyEntries);
    }
}