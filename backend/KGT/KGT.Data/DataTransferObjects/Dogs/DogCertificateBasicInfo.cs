using System;

namespace KGT.Data.DataTransferObjects.Dogs
{
    public class DogCertificateBasicInfo
    {
        public Guid DogCertificateId { get; set; }
        public Guid CertificateId { get; set; }
        public string Name { get; set; }
        public DateTime DateObtained { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}
