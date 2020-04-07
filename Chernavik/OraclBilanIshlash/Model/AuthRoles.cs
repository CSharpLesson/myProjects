using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace OraclBilanIshlash.Model
{
    [Table("auth_roles")]
    public class AuthRoles
    {
        private int id;
        private string name;
        private string comment;
        private int createdBy;
        private DateTime created;
        private int structureId;

        public AuthRoles(int id, string name, string comment, int createdBy, DateTime created, int structureId)
        {
            this.id = id;
            this.name = name;
            this.comment = comment;
            this.createdBy = createdBy;
            this.created = created;
            this.structureId = structureId;
        }




        /// <summary>
        /// Primary Key
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Номи
        /// </summary>
        [Column("name")]
       

        public string Name
        {
            get
            {
                if(name!= "hfdfhdf")
                    return name;
                return null;
            }

            private set
            {
                name = value;
            }
        }


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
