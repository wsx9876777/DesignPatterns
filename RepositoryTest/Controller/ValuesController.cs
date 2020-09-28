using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryTest.Models;
using RepositoryTest.Repository;

namespace RepositoryTest.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IGradesRepository _gradesRepository;

        public ValuesController(IGradesRepository gradesRepository)
        {
            this._gradesRepository = gradesRepository;
        }
        [HttpGet]
        public IEnumerable<Grades> GetAll()
        {

            return _gradesRepository.GetGrades();
        }
        [HttpGet("{id:int}")]
        public IEnumerable<Grades> Get()
        {

            return _gradesRepository.GetGrade(x=>x.GRAGE > 5);
        }
        [HttpPost]
        public IActionResult Insert(Grades grades)
        {
            var a = _gradesRepository.InsertGrades(grades);
            return Ok();
        }
        [HttpPatch]
        public IActionResult Update(string sn,int grade)
        {
            _gradesRepository.UpdateGrades(sn, grade);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(string sn)
        {
            _gradesRepository.DeleteGrades(sn);
            return Ok();
        }
    }
}
