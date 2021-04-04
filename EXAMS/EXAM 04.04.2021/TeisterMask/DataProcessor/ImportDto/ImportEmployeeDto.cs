namespace TeisterMask.DataProcessor.ImportDto
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    public class ImportEmployeeDto
    {
        [JsonProperty("Username")]
        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Username { get; set; }

        [JsonProperty("Email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [JsonProperty("Phone")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        public string Phone { get; set; }

        public List<int> Tasks { get; set; }
    }
}
