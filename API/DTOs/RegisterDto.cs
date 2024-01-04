
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username {get; set;}

        [Required]
        public string Password {get; set;}
        
    }
}