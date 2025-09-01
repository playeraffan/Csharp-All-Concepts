using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Model;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public EmpController(ApplicationDbContext db)
        {
            this.db=db;
        }


        [HttpPost]

        public ActionResult<Employee> AddEmployee(Employee Emp)
        {
            db.Employees.Add(Emp);
            db.SaveChanges();
            return Ok();

        }

        [HttpGet]

        public ActionResult<List<Employee>> SelectEmployee()
        {
            var select_record = db.Employees.ToList();
            return Ok(select_record);
        }



        [HttpGet("id")]
        public ActionResult<List<Employee>> SearcRrecord(in id)
        { 
          var find_row - db.Employees.Find(id);
            if (find_row == null)
            {
                return NotFound("Record not found");
            }
            return Ok(find_row);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee e)
        {
            if (id != e.id)
            {
                return badrequest();
            }
            db.Entry(e).State = EntityState.Modified;
            await .db.SaveChangesAsync();
            return Ok();


        }


        [HttpDelete("{id}")]
        public ActionResult<Employee> DeleteEmployee(int id)
        {
            var find_row = db.Employees.Find(id);
            if (find_row != null)
            { 
             db.employees.Remove(find_row);
                db.saveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }



    }
  
}
