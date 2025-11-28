namespace CooperchipItDeveloper.Mvc.Extensions.ExtensionsMethods
{
    public static class DateExtension
    {
        public static string ToBrazilianDate (this DateTime valor)
        {
            return valor.ToString("dd/MM/yyyy");
        }

        public static string ToBrazilianDateTime(this DateTime valor)
        {
            return valor.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
