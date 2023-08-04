using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }

        [Required(ErrorMessage = "Please enter a name to proceed")]
        public string Name { get; set; }

        public List<MachineEngineer> JoinEntities { get; }
    }
}