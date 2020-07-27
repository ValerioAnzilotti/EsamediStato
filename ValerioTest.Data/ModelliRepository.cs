using Microsoft.Extensions.Configuration;         //nuget Microsoft.Extensions.Configuration.Abstractions
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;
using ValerioTest.Models;


namespace ValerioTest.Data                               // classe con il codice di accesso ai dati 
{
    public class ModelliRepository : ImodelliRep         //eredita da ImodelliRep   
    {
        private readonly string _connectionString;
        public ModelliRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<Modelli> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.GetAll<Modelli>();
            }
        }

        public IEnumerable<Modelli> GetByCategory(int categoryID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
SELECT [IdPiano]
      ,[Aula]
      ,[Nome]
      ,[Materia]
      ,[Scadenza]
  FROM [dbo].[Scuola]";
                return connection.Query<Modelli>(query, new { catId = categoryID });
            }
        }

        public Modelli GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Get<Modelli>(id);
            }
        }

        public void Insert(Modelli value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Insert(value);
            }
        }

        public void Update(Modelli value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Update(value);
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Delete(new Modelli
                {
                    IdPiano = id
                });
            }
        }
    }
}
