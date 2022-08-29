using LabsApi.Modles;

namespace LabsApi.Repository
{
    public class EmpRepo : IEmpRepo
    {

        private static List<Employee> empData = new List<Employee>();

        public int NewEmp(Employee emp)
        {
            try
            {
                emp.ID = new Random().Next(1,100);
                empData.Add(emp);
                return 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Employee> AllEmp()
        {
            return empData;

        }

        public bool UpdateDesignation(int id, string Designation)
        {
            try
            {
                var emp = empData.Where((m) => { return m.ID == id; }).FirstOrDefault();
                emp.Designation = Designation;
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool resign(int id)
        {
            var emp = empData.Where((m) => { return m.ID == id; }).FirstOrDefault();
            empData.Remove(emp);
            return true;
        }

        public Employee find(int id)
        {
            var emp = empData.Where((m) => { return m.ID == id; }).FirstOrDefault();
            return emp;
        }


    }
}
