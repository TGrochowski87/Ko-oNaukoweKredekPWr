using System.Data.SqlClient;

namespace TomaszGrochowskiZadanieDomowe3.Repositories
{
    /// <summary>
    /// A abstract class that contains variables and methods inherited by every Repository class
    /// </summary>
    public abstract class Repository
    {
        /// <summary>
        /// Variable containing connection to data base
        /// </summary>
        protected readonly SqlConnection Connection;

        /// <summary>
        /// Constructor in which the connection is made
        /// </summary>
        public Repository()
        {
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
            Connection.Close();
        }
    }
}
