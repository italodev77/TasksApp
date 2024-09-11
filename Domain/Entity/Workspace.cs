using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Workspace
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public User? User { get; set; }
        public ICollection<ListCard>? ListsCards { get; set; }
        public DateTime? CreatedAt { get; set; }  = DateTime.Now;   

    }
}
