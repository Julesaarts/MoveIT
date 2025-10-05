using System.ComponentModel.DataAnnotations;

namespace MoveIT.Models
{
    public class EmployeeModel
    {
        public int Id { get; private set; }

        //onderstaande is nodig om velden te connecten met de Page class
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string Name { get; private set; }
    }
}
