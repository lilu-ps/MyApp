using MyApp.Models;
using MyApp.Filters;
using System.Collections.Generic;

namespace MyApp.Services
{
    public interface IStatementService
    {
        IEnumerable<StatementModel> GetStatementList(StatementFilter statementFilter);
        StatementModel GetStatement(long Id);
        void insertDataIntoDatabase();
    }
}
