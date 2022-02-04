using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Package
    {

        [Key]
        public int Id { get; set; }

        public int ContainerId { get; set; }

        public int TrackingNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Status { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Courier { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Handling { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Chute { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string DeliverySlip { get; set; }



    }
}
