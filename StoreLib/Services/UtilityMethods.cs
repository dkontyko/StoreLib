using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StoreLib.Services
{
    /// <summary>
    /// This class is replaced with a PowerShell class in the
    /// PowerShell branch, since this code contains system calls
    /// that would work incorrectly when imported into PowerShell.
    /// </summary>
    internal class UtilityMethods
    {
        /// <summary>
        /// Internal function used to read premade xml. 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        internal static string GetResourceTextFile(string filename)
        {
            string result = string.Empty;

            using (Stream stream = Assembly.GetExecutingAssembly().
                       GetManifestResourceStream("StoreLib.Xml." + filename))
            {
                using StreamReader sr = new StreamReader(stream);
                result = sr.ReadToEnd();
            }
            return result;
        }
    }
}
