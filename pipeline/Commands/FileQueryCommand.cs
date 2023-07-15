namespace Pipeline.Commands
{
    public class FileQueryCommand : ICommand
    {
        private string _folderPath;
        public FileQueryCommand(string folderPath)
        {
            _folderPath = folderPath;
        }
        public void Execute()
        {
            if(Directory.Exists(_folderPath))
            {
                var files = Directory.GetFiles(_folderPath);
                foreach (var item in files)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}