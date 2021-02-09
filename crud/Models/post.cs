namespace crud.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("post")]
    public partial class post
    {
        public int id { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="La fecha es requerida")]
        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string titulo { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }

        public int? idautor { get; set; }
    }
}
