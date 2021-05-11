using Microsoft.Data.Sqlite;

//This class accesses the manifest
namespace VBLibrary
{
    public class ManifestAccess
    {
        private static string myreader;

        public static string ReadData(string table, int num)
        {
            var sql = "SELECT json FROM " + table + " WHERE id = " + num;
            using (SqliteConnection c = new SqliteConnection(@"Data Source= C:\Users\chais.strand\Documents\Personal Documents\VaultBuddyDesktop\VaultBuddyDesktop\VBLibrary\Destiny2Manifest.db"))
            {
                c.Open();
                using (SqliteCommand cmd = new SqliteCommand(sql, c))
                {
                    using (SqliteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            myreader = rdr.GetString(0);
                        }
                    }
                }
            }
            return myreader;
        }
    }
}
