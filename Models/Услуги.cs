using System;
using System.Collections.Generic;

#nullable disable

namespace BA.Models
{
    public partial class Услуги
    {
        public Услуги()
        {
            Клиентыs = new HashSet<Клиенты>();
        }

        public byte[] Дата { get; set; }
        public double Стоимость { get; set; }
        public long КодУслуги { get; set; }
        public long КодСотрудника { get; set; }

        public virtual Сотрудники КодСотрудникаNavigation { get; set; }
        public virtual ICollection<Клиенты> Клиентыs { get; set; }
    }
}
