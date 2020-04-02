using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Chernavik
{
    [Table("auth_roles")]
    public class AuthRoles 
    {


        /// <summary>
        /// Primary Key
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Номи
        /// </summary>
        [Column("name")]
        public string Name { get; set; }


        /// <summary>
        /// Изоҳ
        /// </summary>
        [Column("comment")]
        public string Comment { get; set; }


        /// <summary>
        /// Яратган фойдаланувчи
        /// </summary>
        [Column("createdby")]
        public int CreatedBy { get; set; }




        /// <summary>
        /// Яратилган сана
        /// </summary>
        [Column("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Ташкилот коди
        /// </summary>
        [Column("structure_id")]
        public int StructureId { get; set; }
    }
}
