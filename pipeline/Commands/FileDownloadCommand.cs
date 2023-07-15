namespace Pipeline.Commands
{
    public class FileDownloadCommand : ICommand
    {
        private string _sourceUrl;
        private string _outputFile;
        public FileDownloadCommand(string sourceUrl, string outputFile)
        {
            _outputFile = outputFile;
            _sourceUrl = sourceUrl;
        }
        public void Execute()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                using (var s = client.GetStreamAsync(_sourceUrl).GetAwaiter().GetResult())
                {
                    using (var fs = new FileStream(_outputFile, FileMode.CreateNew))
                    {
                        s.CopyToAsync(fs);
                    }
                }
            }
        }
    }
}