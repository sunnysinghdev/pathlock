namespace Pipeline.Commands
{
    public class FolderCreateCommand : ICommand
    {
        private string _folderPath;
        private string _folderName;
        public FolderCreateCommand(string folderPath, string folderName)
        {
            _folderName = folderName;
            _folderPath = folderPath;
        }
        public void Execute()
        {
            var path = Path.Combine(_folderPath, _folderName);
            if (!Directory.Exists(path))
            { 
                Directory.CreateDirectory(path);
            }
        }
    }
}