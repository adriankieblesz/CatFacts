using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetwiseTest.Components
{
    //Class for appending text in text file located under given path
    public class AddTextToTxtFile
    {
        public static async Task AddText(string path, string content)
        {
            using(StreamWriter streamWriter = new StreamWriter(path, true))
            {
                await streamWriter.WriteLineAsync(content);
            }
        }
    }
}
