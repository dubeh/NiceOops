using LabsApi.Modles;
using LabsApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LabsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly IEmpRepo EmpDb;

        public EmpController(IEmpRepo emp)
        {
            EmpDb = emp;
        }

        [HttpPost("/emp/hire")]
        public IActionResult Hire(Employee emp)
        {
            try
            {
                int id = EmpDb.NewEmp(emp);
                return Created($"created", emp);
            }
            catch (Exception)
            {

                return BadRequest(ModelState);
            }
        }

        [HttpGet("/emp/list")]
        public IActionResult ListEmp()
        {
            return Ok(EmpDb.AllEmp());
        }

        [HttpPut("/emp/update/{id}")]
        public IActionResult desupdate([FromRoute] int id, [FromBody] string update)
        {
            try
            {
                bool update1 = EmpDb.UpdateDesignation(id,update);
                return Accepted("accepted");
            }
            catch (Exception)
            {

                return BadRequest(ModelState);
            }
        }
        [HttpDelete("/emp/resign/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            EmpDb.resign(id);
            return Ok();
        }
        [HttpGet("emp/find/{id}")]
        public IActionResult findemp([FromRoute] int id)
        {
            Employee details = EmpDb.find(id);
            return Ok(details);
        }



    }
}
