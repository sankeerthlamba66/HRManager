using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.Entities
{
    public class Organization : EntityBase
    {
        public byte Id { get; set; }
        public string OrganizationName { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<ApplicationText> ApplicationTexts { get; set; }
    }
}
