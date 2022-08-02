using Trys.Interfaces;

namespace Trys;

public class ParserProcessor
{
    private readonly ICsvParser _csvParser;
    private readonly ICsvLineParser _csvLineParser;

    public ParserProcessor(ICsvParser csvParser, ICsvLineParser csvLineParser)
    {
        _csvParser = csvParser;
        _csvLineParser = csvLineParser;
    }

    public List<string[]> Process(string csvContent)
    {
        List<string[]> lineContents = new List<string[]>();
        string[] lines = _csvParser.Parse(csvContent);
        foreach (var line in lines)
        {
            string[] lineContent = _csvLineParser.ParseLine(line);
            lineContents.Add(lineContent);
        }

        return lineContents;
    }

}