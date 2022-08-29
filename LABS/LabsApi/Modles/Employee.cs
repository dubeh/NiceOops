using System.ComponentModel.DataAnnotations;

namespace LabsApi.Modles
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
    }
}
