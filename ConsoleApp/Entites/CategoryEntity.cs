using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Entites
{
    internal class CategoryEntity
    {
        [Key]
        public int ID { get; set; }
        public int Id { get; internal set; }
        public string CategoryName { get; set; } = null!;
    }
}
