using System;
using System.Collections.Generic;

#nullable disable

namespace BA.Models
{
    public partial class Отношения
    {
        public Отношения()
        {
            Клиентыs = new HashSet<Клиенты>();
        }

        public long КодОтношения { get; set; }
        public string Наименование { get; set; }
        public string Описание { get; set; }

        public virtual ICollection<Клиенты> Клиентыs { get; set; }
    }
}
