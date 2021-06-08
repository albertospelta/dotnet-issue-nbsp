namespace ConsoleAppNETCore31
{
    class Program
    {
        static void Main()
        {
            var json = System.IO.File.ReadAllText(@"Model.bim");
            _ = Microsoft.AnalysisServices.JsonSerializer.DeserializeDatabase(json);
        }
    }
}
