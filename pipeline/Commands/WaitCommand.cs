namespace Pipeline.Commands
{
    public class WaitCommand : ICommand
    {
        private int _seconds;
        public WaitCommand(int seconds)
        {

        }
        public void Execute()
        {
            Task.Delay(_seconds).GetAwaiter().GetResult();
        }
    }
}