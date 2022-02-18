using System;
using System.ComponentModel.DataAnnotations;

namespace DataCore.Models
{
    public class Term
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }

}
