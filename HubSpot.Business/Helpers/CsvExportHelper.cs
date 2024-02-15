using CsvHelper;
using System.Globalization;

namespace HubSpot.Business.Helpers
{
    /// <summary>
    /// Helper Class for Writing Records to a file in CSV Format. 
    /// 
    /// Thanks: https://joshclose.github.io/CsvHelper/
    /// </summary>
    public class CsvExportHelper : ICsvExportHelper
    {
        #region ExportRecords
        /// <summary>
        /// A generic way to Export Records in CSV Format.
        /// 
        /// If the Directory does not Exist, Lets Create it. 
        /// 
        /// Use StreamWriter and CsvWriter to write the records to the specified file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="records"></param>
        /// <param name="outputPath"></param>
        public bool ExportRecords<TRecord>(IEnumerable<TRecord> records, string filepath)
        {
            try
            {
                var directory = Path.GetDirectoryName(filepath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                using var writer = new StreamWriter(filepath);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(records);
                return true;
            }
            catch
            {
                return false;
            }
            }       
        }
    #endregion
}
