using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
           this.CreatedDate = DateTime.Now; 
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public virtual Int64 Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        
    }
}
