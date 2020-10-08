namespace SerilogDynamicTest.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Serilog;
    using Serilog.Events;

    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        static ILogger Logger = Log.ForContext<TestController>();
        readonly ILoggingService _loggingService;

        public TestController(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            Logger.Verbose("Vebose log string");
            Logger.Debug("Debug log string");
            Logger.Information("Info log string");
            return Ok();
        }

        [HttpGet("set-logging")]
        public IActionResult SetLoggingLevel([FromQuery] LogEventLevel level)
        {
            _loggingService.SetLoggingLevel(level);
            return Ok();
        }
    }
}
