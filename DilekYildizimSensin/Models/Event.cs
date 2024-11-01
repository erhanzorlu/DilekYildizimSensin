using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilekYildizimSensin.Models
{
    public class Event : BaseEntity
    {
        public string EventName { get; set; }

        public ICollection<UserEvent> UserEvents { get; set; }
    }
}
