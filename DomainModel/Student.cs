using System;

namespace DomainModel
{
    public class Student : BaseEntity
    {
        /// <summary>
        /// номер зачетной книжки
        /// </summary>
        public string GradeBookNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public Nationality Nationality { get; set; }

        public Citizenship Сitizenship { get; set; }

        /// <summary>
        /// Окончил
        /// </summary>
        public string GraduateInstitutionName { get; set; }

        /// <summary>
        /// Год
        /// </summary>
        public int GraduateInstitutionYear { get; set; }

        public string Adress { get; set; }
        /// <summary>
        ////приказ о зачислении
        /// </summary>
        public Order IncomeOrder { get; set; }

        /// <summary>
        /// со вступительными экзаменами
        /// </summary>
        public bool WithEntranceExams { get; set; }
        /// <summary>
        /// переведен из другого заведения
        /// </summary>
        public bool TransferFromAnother { get; set; }
    }
}
