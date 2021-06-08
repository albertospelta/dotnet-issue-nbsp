namespace ConsoleAppNET50
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = System.IO.File.ReadAllText(@"Model.bim");
            _ = Microsoft.AnalysisServices.JsonSerializer.DeserializeDatabase(json);
        }
    }
}
