using System.ComponentModel.DataAnnotations;

namespace PortIn.DataContracts
{
    public class OrganizationPorting
    {
        [StringLength(100, ErrorMessage = "String length should be less than 101.")]
        public string Name { get; set; }
        [StringLength(20, ErrorMessage = "String length should be less than 21.")]
        public string Id { get; set; }
        [StringLength(30, ErrorMessage = "String length should be less than 31.")]
        public int AccountNumber { get; set; }
    }
}