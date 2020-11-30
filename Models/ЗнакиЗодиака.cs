using System;
using System.Collections.Generic;

#nullable disable

namespace BA.Models
{
    public partial class ЗнакиЗодиака
    {
        public ЗнакиЗодиака()
        {
            Клиентыs = new HashSet<Клиенты>();
        }

        public long КодЗнака { get; set; }
        public string Наименование { get; set; }
        public string Описание { get; set; }

        public virtual ICollection<Клиенты> Клиентыs { get; set; }
    }
}
