using Trys;

DataProcessor dataProcessor = new DataProcessor(new ReadCsv(), new ParserProcessor(new CsvParser(), new LineParser()), new DataCrud());
dataProcessor.Process("Liste1CSV.csv");


