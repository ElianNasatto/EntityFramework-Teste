using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    [Table("class")]
    public class Class1
    {
        [Key,Column("Id")]
        public int Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
    }
}
