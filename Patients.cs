﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    [Serializable]
    public class Patients
    {
        //id
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        // PatientId
        [BsonElement("PatientId"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int PatientId { get; set; }

        // Name
        [BsonElement("Name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Name { get; set; }

        // Age
        [BsonElement("Age"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Age { get; set; }


        // MedicalHistory
        [BsonElement("MedicalHistory")]
        public List<string> MedicalHistory { get; set; }

        // Flattened MedicalHistory
        [BsonIgnore]
        public string MedicalHistoryString
        {
            get { return MedicalHistory != null ? string.Join(", ", MedicalHistory) : string.Empty; }
        }
    }
}