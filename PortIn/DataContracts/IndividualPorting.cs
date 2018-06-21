using System.ComponentModel.DataAnnotations;

namespace PortIn.DataContracts
{
    public class IndividualPorting
    {
        [StringLength(100, ErrorMessage = "String length should be less than 101.")]
        public string Name { get; set; }
        [StringLength(255, ErrorMessage = "String length should be less than 256.")]
        public string Id { get; set; }
        public int IdType { get; set; }
    }
}