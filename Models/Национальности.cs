using System;
using System.Collections.Generic;

#nullable disable

namespace BA.Models
{
    public partial class Национальности
    {
        public Национальности()
        {
            Клиентыs = new HashSet<Клиенты>();
        }

        public long КодНациональности { get; set; }
        public string Наименование { get; set; }
        public string Замечания { get; set; }

        public virtual ICollection<Клиенты> Клиентыs { get; set; }
    }
}
