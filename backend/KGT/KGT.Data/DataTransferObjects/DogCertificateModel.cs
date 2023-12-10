using System;

namespace KGT.Data.DataTransferObjects
{
    public class DogCertificateModel
    {
        public int CertificateId { get; set; }
        public CertificateModel Certificate { get; set; }
        public int DogId { get; set; }
        public DogBasicInfo Dog { get; set; }
        public DateTime AcquiredOn { get; set; }

    }
}
