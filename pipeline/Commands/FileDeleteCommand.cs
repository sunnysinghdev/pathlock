namespace Pipeline.Commands
{
    public class FileDeleteCommand : ICommand
    {
        private string _file;
        public FileDeleteCommand(string file)
        {
            _file = file;
        }
        public void Execute()
        {
            File.Delete(_file);
        }
    }
}