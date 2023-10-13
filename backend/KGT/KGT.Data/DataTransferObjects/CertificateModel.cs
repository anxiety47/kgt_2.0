using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KGT.Data.DataTransferObjects
{
    public class CertificateModel
    {
        public int CertificateId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
        public int ValidThroughMonths { get; set; }
        public virtual List<int> DogIds { get; set; }
    }
}
