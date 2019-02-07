using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Description
    {
        public int ID { get; set; }
        //[ForeignKey("Product")]
        public int ID_Product { get; set; }
        public string Descriptions { get; set; }
    }
}
