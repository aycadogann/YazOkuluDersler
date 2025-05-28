using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;  Initial Catalog=YazOkulu; Integrated Security=true");
    }
}
