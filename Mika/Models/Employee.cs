using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mika.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }


    }
}
