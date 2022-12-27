using System.ComponentModel.DataAnnotations;

namespace string_split.Models
{
    public class Entities
    {
        [Key]
        public int? id { get; set; }
        public string primaryData { get; set; }
        public string dataOne { get; set; }
        public string dataTwo { get; set; }
        public string dataThree { get; set; }
    }
    public class PrimaryEntity
    {
        [Key]
        public int? id { get; set; }
        public string primaryData { get; set; }
    }
}
