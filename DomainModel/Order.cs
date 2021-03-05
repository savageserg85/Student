using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    /// <summary>
    /// приказ
    /// </summary>
    public class Order:BaseEntity
    {
        public string Name { get; set; }

        public string Number { get; set; }
        public DateTime Date { get; set; }   
    }
}
