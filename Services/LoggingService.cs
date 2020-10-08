namespace SerilogDynamicTest
{
    using Serilog.Core;
    using Serilog.Events;

    public class LoggingService : ILoggingService
    {
        readonly LoggingLevelSwitch _loggingLevelSwitch;

        public LoggingService(LoggingLevelSwitch loggingLevelSwitch)
        {
            _loggingLevelSwitch = loggingLevelSwitch;
        }

        public void SetLoggingLevel(LogEventLevel level)
        {
            _loggingLevelSwitch.MinimumLevel = level;
        }
    }
}
