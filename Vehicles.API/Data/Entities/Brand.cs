using System.ComponentModel.DataAnnotations;

namespace Vehicles.API.Data.Entities
{
    public class Brand
    {
        public int ID { get; set; }

        [Display(Name = "Marca del vehiculo")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de 50 carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; }


    }
}

