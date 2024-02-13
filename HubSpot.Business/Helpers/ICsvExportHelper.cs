
namespace HubSpot.Business.Helpers
{
    /// <summary>
    /// Interface to Define the implementation of the <see cref="CsvExportHelper"/>
    /// </summary>
    public interface ICsvExportHelper
    {
        bool ExportRecords<TRecord>(IEnumerable<TRecord> records, string filepath);
    }
}
