using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Application.Extensions
{
    public static class CopiarArquivo
    {
        public static void Copiar(IFormFile file, string filePath)
        {
            using (FileStream fileStream = System.IO.File.Create(filePath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }


            //if (System.IO.File.Exists(filePath))
            //{
            //    using (FileStream fileStream = System.IO.File.Create(filePath))
            //    {
            //        file.CopyTo(fileStream);
            //        fileStream.Flush();
            //    }
        }
    }
}
