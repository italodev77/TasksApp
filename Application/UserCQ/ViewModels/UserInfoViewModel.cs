using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserCQ.ViewModels
{
    public record UserInfoViewModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? RefreshnToken { get; set; }
        public DateTime? RefreshTokenExpirationTime { get; set; }
        public string? TokenJWT { get; set; }

    }
}
