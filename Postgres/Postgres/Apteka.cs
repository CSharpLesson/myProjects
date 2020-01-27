using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Postgres
{
    [Table("apteka",Schema ="public")]
    public class Apteka
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("tuman")]
        public string Tuman { get; set; }
        [Column("company_id")]
        public int CompanyId { get; set; }
    }
}
