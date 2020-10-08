namespace SerilogDynamicTest
{
    using Serilog.Events;

    public interface ILoggingService
    {
        public void SetLoggingLevel(LogEventLevel level);
    }
}
