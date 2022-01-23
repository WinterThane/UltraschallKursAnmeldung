using System.ComponentModel.DataAnnotations;

namespace UltraschallKursAnmeldung.Models
{
    public class BasisKursModel
    {
        [Required]
        public bool IsInWeiterbildung { get; set; }
        [Required]
        public string Anrede { get; set; }
        [Required]
        public string Fachtitel { get; set; }
        [Required]
        public string Vorname { get; set; }
        [Required]
        public string Nachname { get; set; }
        [Required]
        public string Strasse { get; set; }
        [Required]
        public string StrasseNr { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string PhonePrivate { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailPrivate { get; set; }
        public string PhoneWork { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailWork { get; set; }

    }
}
