﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using KGT.Data.Models.Dogs;

namespace KGT.Data.Models
{
    [Table("DogCertificates")]
    public class DogCertificate
    {
        public int DogId { get; set; }
        public virtual Dog Dog { get; set; }

        public int CertificateId { get; set; }
        public virtual Certificate Certificate { get; set; }

        public DateTime AcquiredOn { get; set; }
    }
}
