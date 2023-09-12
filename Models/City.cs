using System.ComponentModel.DataAnnotations;

namespace HelpingHands.Models
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string? Name { get; set; }
        public string? Abbreviation { get; set; }
    }
}
