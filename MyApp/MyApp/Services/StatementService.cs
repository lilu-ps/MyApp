using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MyApp.DataAccess;
using MyApp.Models;
using MyApp.Filters;
using System.IO;

namespace MyApp.Services
{
    public class StatementService : IStatementService
    {

        private readonly StatementContext statementDBContext;

        public StatementService(StatementContext statementDBContext)
        {
            this.statementDBContext = statementDBContext;
        }


        /*
         * I used this method once to insert data into the database 
         * filePaths array would store paths of the images we would like to insert
         * names array would store names of the statements we are inserting
         */
        void IStatementService.insertDataIntoDatabase()
        {
            string[] filePaths = { "wwwroot//imagesForDB/first.jpg", "wwwroot//imagesForDB/sec.jpg" };
            string[] names = { "statement 1", "statement 2" };
            for (int i = 0; i < filePaths.Count(); i++)
            {
                var filepath = filePaths[i];
                FileStream FS = new FileStream(filepath, FileMode.Open, FileAccess.Read); 

                byte[] img = new byte[FS.Length]; 
                FS.Read(img, 0, Convert.ToInt32(FS.Length));

                StatementModel newStatement = new StatementModel() {
                    statementName = names[i],
                    statementImage = img,
                    statementDescription = names[i] + " statement",
                    phoneNumber = "000000000"
                };

                this.statementDBContext.Statements.Add(newStatement);
                this.statementDBContext.SaveChanges();
            }

        }

        StatementModel IStatementService.GetStatement(long Id)
        {
            return this.statementDBContext.Statements.Find(Id);
        }

        IEnumerable<StatementModel> IStatementService.GetStatementList(StatementFilter statementFilter)
        {
            if (statementFilter.statementName == null)
            {
                return this.statementDBContext.Statements.AsEnumerable();
            }
            return this.statementDBContext.Statements.Where(i => i.statementName == statementFilter.statementName).AsEnumerable();
        }
    }
}
