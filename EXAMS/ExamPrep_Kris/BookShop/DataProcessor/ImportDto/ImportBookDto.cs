namespace BookShop.DataProcessor.ImportDto
{

    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [XmlType("Book")]
    public class ImportBookDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        [XmlElement("Name")]
        public string Name { get; set; }

        [Range(1,3)]
        [XmlElement("Genre")]
        public int Genre { get; set; }

        [Range(0.01, double.MaxValue)]
        [XmlElement("Price")]
        public decimal Price { get; set; }

        [Range(50,5000)]
        [XmlElement("Pages")]
        public int Pages { get; set; }

        [Required]
        [XmlElement("PublishedOn")]
        public string PublishedOn { get; set; }
    }
}
