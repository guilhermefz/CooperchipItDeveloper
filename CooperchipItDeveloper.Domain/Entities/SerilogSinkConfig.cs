namespace CooperchipItDeveloper.Domain.Entities
{
    public class SerilogSinkConfig
    {
        public bool EnableSeq { get; set; }

        public bool EnableFile { get; set; }

        public string EnableFilePath { get; set; }

        public bool EnableConsole => !EnableFile && !EnableSeq;
    }
}
