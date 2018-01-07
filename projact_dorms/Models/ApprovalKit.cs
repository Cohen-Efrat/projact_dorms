using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace projact_dorms.Models
{
    public class ApprovalKit
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        public string User_ID { get; set; }
        [Required]
        public string First_name { get; set; }

        [Required]
        public string Last_name { get; set; }

        [Required]
        public Boolean Paymentrent { get; set; }

        [Required]
        public string TypeRoom { get; set; }

        [Required]
        public Boolean Approve { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string FieldOfStudy { get; set; }

        [Required]
        public string year { get; set; }

        [Required]
        public Boolean Religion { get; set; }

        [Required]
        public Boolean Smoke { get; set; }

        [Required]
        public Boolean Religion_2 { get; set; }

        public string Text { get; set; }

        User[] roomies = new User[3];

        public string Comments { get; set; }
    }
}