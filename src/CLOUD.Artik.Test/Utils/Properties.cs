using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CLOUD.Artik.Test.Utils
{
    /// <summary>
    ///     Reads a property list (key and element pairs) from the input
    ///     character stream in a simple line-oriented format.
    /// </summary>
    public class Properties : Dictionary<string, string>
    {
        public void LoadFromFile(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                LoadFromStream(fs);
            }
        }

        public void LoadFromStream(Stream stream)
        {
            using (var sr = new StreamReader(stream))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    ParseLine(this, line);
                }
            }
        }

        private void ParseLine(IDictionary<string, string> properties, string line)
        {
            if ((String.IsNullOrEmpty(line)) ||
                (line.StartsWith(";")) ||
                (line.StartsWith("#")) ||
                (line.StartsWith("'")) ||
                (!line.Contains('=')))
                return;

            var index = line.IndexOf('=');
            var key = line.Substring(0, index).Trim();
            var value = line.Substring(index + 1).Trim();

            if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                (value.StartsWith("'") && value.EndsWith("'")))
            {
                value = value.Substring(1, value.Length - 2);
            }

            // Ignore duplicates
            if (!properties.ContainsKey(key))
                properties.Add(key, value);
        }
    }
}