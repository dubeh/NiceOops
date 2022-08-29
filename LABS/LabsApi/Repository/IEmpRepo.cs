using LabsApi.Modles;

namespace LabsApi.Repository
{
    public interface IEmpRepo
    {
        List<Employee> AllEmp();
        Employee find(int id);
        int NewEmp(Employee emp);
        bool resign(int id);
        bool UpdateDesignation(int id, string Designation);
    }
}