using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Floristeria
{
    public static class clsGlobal
    {
        public static Database globalDatabase;
        public static Establecimiento currentEstablecimiento;

        public static void SaveToXMLDatabase(Database database)
        {
            if (!database.Establecimientos.Any())
                return;

            XmlSerializer xs = new XmlSerializer(typeof(Database));
            TextWriter tw = new StreamWriter(@"database.xml");
            xs.Serialize(tw, database);
        }

        public static Database LoadFromXMLDatabase()
        {
            Database database = new Database();
            if (!File.Exists(@"database.xml"))
                return database;

            XmlSerializer xs = new XmlSerializer(typeof(Database));
            using (var sr = new StreamReader(@"database.xml"))
            {
                database = (Database)xs.Deserialize(sr);
                return database;
            }
        }
    }
}
