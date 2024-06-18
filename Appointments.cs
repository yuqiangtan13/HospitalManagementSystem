using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    [Serializable]
    public class Appointments
    {
        //id
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        // AppointmentId
        [BsonElement("AppointmentId"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int AppointmentId { get; set; }

        // PatientId
        [BsonElement("PatientId"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string PatientId { get; set; }

        //Doctor
        [BsonElement("Doctor"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Doctor { get; set; }

        // Date
        [BsonElement("Date"), BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime Date { get; set; }

        //Status
        [BsonElement("Status"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Status { get; set; }


    }
}
