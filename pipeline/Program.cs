// See https://aka.ms/new-console-template for more information
using Pipeline;

internal class Program
{
    private static void Main(string[] args)
    {
        string cmdFile = args[0];
        string[] commands = File.ReadAllLines(cmdFile);
        foreach (var cmd in commands)
        {
            var cmdObj = CommandFactory.GetCommand(cmd);
            Console.WriteLine(cmd);
            cmdObj.Execute();
        }
    }
}

public class FileCopyCommand : ICommand
{
    public FileCopyCommand(string sourceFile, string destinationFile)
    {
        
    }
    public void Execute()
    {
        throw new NotImplementedException();
    }
}
public class FileDeleteCommand : ICommand
{
    public FileDeleteCommand(string file)
    {
        
    }
    public void Execute()
    {
        throw new NotImplementedException();
    }
}
public class FileQueryCommand : ICommand
{
    public FileQueryCommand(string folderPath)
    {

    }
    public void Execute()
    {
        throw new NotImplementedException();
    }
}
public class FolderCreateCommand : ICommand
{
    public FolderCreateCommand(string folderPath, string folderName)
    {
        
    }
    public void Execute()
    {
        throw new NotImplementedException();
    }
}
public class FileDownloadCommand : ICommand
{
    public FileDownloadCommand(string sourceUrl, string outputFile)
    {
        
    }
    public void Execute()
    {
        throw new NotImplementedException();
    }
}
public class FileSearchCommand : ICommand
{
    public FileSearchCommand(string sourceFile, string searchString)
    {
        
    }
    public void Execute()
    {
        throw new NotImplementedException();
    }
}
public class WaitCommand : ICommand
{
    public WaitCommand(string waitTimeSec)
    {
        
    }
    public void Execute()
    {
        throw new NotImplementedException();
    }
}
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
                return new WaitCommand(parameter[1]);
            case CommandType.FileSearch:
                return new FileSearchCommand(parameter[1], parameter[2]);
            default:
                break;
        }
        return command;
    }
}



public class VoidCommand : ICommand
{
    public void Execute()
    {
        throw new NotImplementedException();
    }
}