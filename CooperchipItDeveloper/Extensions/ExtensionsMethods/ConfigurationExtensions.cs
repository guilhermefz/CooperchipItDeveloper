using CooperchipItDeveloper.Domain.Entities;
using CooperchipItDeveloper.Domain.Enuns;

namespace CooperchipItDeveloper.Mvc.Extensions.ExtensionsMethods
{
    public static class ConfigurationExtensions
    {
        public static ProvedorLogs ObterProvedorDeLogs(this IConfiguration configuration)
        {
            var provedorSection = configuration.GetSection(nameof(ProvedorLogs));

            if(!provedorSection.Exists()) 
                return ProvedorLogs.Nenhum;

            var provedorSuportado = Enum.TryParse<ProvedorLogs>(provedorSection.Value, true, out var provedorInformado);
            if(!provedorSuportado) return ProvedorLogs.Nenhum;

            return provedorInformado;
        }

        public static SerilogSinkConfig ObterSerilogSinkConfig(this IConfiguration configuration)
        {
            var section = configuration.GetSection(nameof(SerilogSinkConfig));

            if (!section.Exists())
                return new SerilogSinkConfig();

            return section.Get<SerilogSinkConfig>() ?? new SerilogSinkConfig();
        }
    }
}
