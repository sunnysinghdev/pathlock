using Pipeline.Commands;
namespace Pipeline
{

    public static class CommandFactory
    {
        public static ICommand GetCommand(string cmd)
        {
            ICommand command = new VoidCommand();
            string[] parameter = cmd.Split(' ');
            switch (parameter[0])
            {
                case CommandType.FileCopy:
                    return new FileCopyCommand(parameter[1], parameter[2]);
                case CommandType.FileDelete:
                    return new FileDeleteCommand(parameter[1]);
                case CommandType.FileQuery:
                    return new FileQueryCommand(parameter[1]);
                case CommandType.FolderCreate:
                    return new FolderCreateCommand(parameter[1], parameter[2]);
                case CommandType.FileDownload:
                    return new FileDownloadCommand(parameter[1], parameter[2]);
                case CommandType.Wait:
                    int sec = 0;
                    int.TryParse(parameter[1], out sec);
                    return new WaitCommand(sec);
                case CommandType.FileSearch:
                    return new FileSearchCommand(parameter[1], parameter[2]);
                default:
                    break;
            }
            return command;
        }
    }
}