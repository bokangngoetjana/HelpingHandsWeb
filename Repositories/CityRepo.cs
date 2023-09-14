using Dapper;
using HelpingHands.Models;
using System.Data;

namespace HelpingHands.Repositories
{
    public class CityRepo
    {
        private readonly IDbConnection _dbConnection;

        public CityRepo(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<City>> GetAllCitiesAsync()
        {
            return await _dbConnection.QueryAsync<City>("sp_GetAllCities", commandType: CommandType.StoredProcedure);
        }
    }
}
