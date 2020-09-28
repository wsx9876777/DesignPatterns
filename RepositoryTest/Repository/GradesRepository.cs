using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RepositoryTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryTest.Repository
{
    public class GradesRepository : IGradesRepository
    {
        private readonly IConfiguration _configuration;

        public GradesRepository(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public int DeleteGrades(string sn)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Grades> GetGrades()
        {
            IEnumerable<Grades> data = Enumerable.Empty<Grades>();
            var sql = "SELECT [ID],[SN],[SUBJECT_SN],[TEACHER_SN],[GRAGE] FROM GRADES";
            var a = _configuration.GetConnectionString("DeveloperDB");
            using (var conn = new SqlConnection(_configuration.GetConnectionString("DeveloperDB")))
            {
                data = conn.Query<Grades>(sql);
            }
            return data;
        }
        public IEnumerable<Grades> GetGrade(Expression<Func<Grades,bool>> expression)
        {
            IEnumerable<Grades> data = Enumerable.Empty<Grades>();
            var sql = "SELECT [ID],[SN],[SUBJECT_SN],[TEACHER_SN],[GRAGE] FROM GRADES";
            var a = _configuration.GetConnectionString("DeveloperDB");
        
            using (var conn = new SqlConnection(_configuration.GetConnectionString("DeveloperDB")))
            {
                data = conn.Query<Grades>(sql);
                var aaa = data.AsQueryable().Where<Grades>(expression);
            }
            return data;

        }

        public int InsertGrades(Grades grades)
        {
            throw new NotImplementedException();
        }

        public int UpdateGrades(string sn, int grade)
        {
            throw new NotImplementedException();
        }
    }
}
