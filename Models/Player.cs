using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace connect_four__server.Models
{
    public class Player
    {
     

            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Range(1, 1000, ErrorMessage = "ID is unique and must be between 1 to 1000")]
            public int Id { get; set; }

            [StringLength(30, MinimumLength = 2, ErrorMessage = "Name must contain at least 2 characters")]
            public string Name { get; set; }
            public string Country { get; set; }

            [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number must contain exactly 10 digits ")]
            public string Phone { get; set; }

        
    }
}
