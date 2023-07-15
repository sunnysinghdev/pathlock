namespace Pipeline.Commands
{
    public class FileCopyCommand : ICommand
    {
        private string _sourceFile;
        private string _destinationFile;
        public FileCopyCommand(string sourceFile, string destinationFile)
        {
            _sourceFile = sourceFile;
            _destinationFile = destinationFile;
        }
        public void Execute()
        {
            File.Copy(_sourceFile, _destinationFile);
        }
    }
}