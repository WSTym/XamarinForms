using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bolao_Lotofacil.Models
{
    [Table("Apostas")]
     public class Aposta
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public List<int> Numeros { get; set; }
    }
}
