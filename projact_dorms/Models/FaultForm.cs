using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;


namespace projact_dorms.Models
{
    public class FaultForm
    {
        [Required]
        public int Apartment { get; set; }


        public int RoomNum { get; set; }

        [Required]
        public string Full_name { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Description { get; set; }
    }

}
