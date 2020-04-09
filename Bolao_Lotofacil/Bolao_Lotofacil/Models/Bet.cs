using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolao_Lotofacil.Models
{
    [Table("Bets")]
     public class Bet
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public List<int> Numbers { get; set; }
    }
}
