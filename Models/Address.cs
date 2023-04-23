using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Text.Json.Serialization;

namespace UserApi.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int? UserId { get; set; }
        
        [JsonIgnore]
        [ValidateNever]
        public User User { get; set; }
    }
}
