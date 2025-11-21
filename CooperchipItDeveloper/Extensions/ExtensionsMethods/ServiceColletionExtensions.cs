using CooperchipItDeveloper.Domain.Enuns;
using Serilog;
using System.Reflection;

namespace CooperchipItDeveloper.Mvc.Extensions.ExtensionsMethods
{
    public static class ServiceColletionExtensions
    {
        public static void AdicionarProvedorDeLogs(this IServiceCollection services, IConfiguration configuration)
        {
            var provedorLogs = configuration.ObterProvedorDeLogs();

            switch (provedorLogs)
            {
                case ProvedorLogs.OpenTelemetry:
                    ConfigurarProvedorOpenTelemetry(services);
                    break;
                case ProvedorLogs.Serilog:
                    ConfigurarProvedorSerilog(services, configuration);
                    break;
                default:
                    break;
            }
        }

        private static void ConfigurarProvedorOpenTelemetry(IServiceCollection services)
        {
            throw new NotImplementedException();
        }

        private static void ConfigurarProvedorSerilog(IServiceCollection services, IConfiguration configuration)
        {
            var sinkConfig = configuration.ObterSerilogSinkConfig();

            var logConfig = new LoggerConfiguration().Enrich.FromLogContext();

            var aplicationName = Assembly.GetEntryAssembly()?.GetName().Name ?? "Scheduller";
            logConfig.Enrich.WithProperty("providerName", aplicationName)
                .Enrich.WithEnvironmentName()
                .Enrich.WithThreadId()
                .Enrich.WithProcessName()
                .Enrich.WithProcessId();

            if (sinkConfig.EnableFile)
            {
                var logPath = sinkConfig.EnableFilePath ?? Path.Combine(AppContext.BaseDirectory, "logs", "schedulle.log");
                var logDir = Path.GetDirectoryName(logPath);
                if(!string.IsNullOrEmpty(logDir)) 
                    Directory.CreateDirectory(logDir);

                logConfig.WriteTo.File(path: logPath, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 10);
            }

            if(sinkConfig.EnableSeq) 
                logConfig.WriteTo.Seq("http://localhost:5342");

            if (sinkConfig.EnableConsole)
                logConfig.WriteTo.Console();

            var logger = logConfig.CreateLogger();

            services.AddLogging(builder =>
            {
                builder.ClearProviders();
                builder.AddSerilog(logger, dispose: true);
            });
        }

    }
}
