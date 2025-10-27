namespace Cooperchip.ITDeveloper.Application.Extensions
{
    public static class ImportsUtils
    {
        //está classe tem uma única responsabilidade
        public static string GetFilePath(string raiz, string fileName, string extension)
        {
            var baseDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(baseDirectory, $"{raiz}\\{fileName}{extension}");

            return filePath;
        }
    }
}
