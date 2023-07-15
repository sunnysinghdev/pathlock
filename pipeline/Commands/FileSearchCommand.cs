namespace Pipeline.Commands
{
    public class FileSearchCommand : ICommand
    {
        private string _sourceFile;
        private string _searchString;

        public FileSearchCommand(string sourceFile, string searchString)
        {
            _sourceFile = sourceFile;
            _searchString = searchString;
        }
        public void Execute()
        {
            int count = 0;
            string[] lines = File.ReadAllLines(_sourceFile);
            foreach(var line in lines)
            {
                if(line.Contains(_searchString))
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of rows = {count}");
        }
    }
}