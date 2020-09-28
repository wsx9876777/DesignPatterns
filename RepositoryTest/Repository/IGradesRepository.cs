using Microsoft.AspNetCore.Mvc;
using RepositoryTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryTest.Repository
{
    public interface IGradesRepository
    {
        IEnumerable<Grades> GetGrades();
        IEnumerable<Grades> GetGrade(Expression<Func<Grades, bool>> expression);
        int InsertGrades(Grades grades);
        int UpdateGrades(string sn, int grade);
        int DeleteGrades(string sn);
    }
}
