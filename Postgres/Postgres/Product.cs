using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Postgres
{
    
        [Table("ent_products", Schema = "public")]
        public class Product
        {

            
            [Key]
            [Column("id")]
            public int Id { get; set; }

            /// <summary>
            /// Номи
            /// </summary>
            [Column("name")]
            [Required]
            public string Name { get; set; }

            /// <summary>
            /// Қисқача тавсиф
            /// </summary>
            [Column("description")]
            public string Description { get; set; }

            /// <summary>
            /// Сарлавха
            /// </summary>
            [Column("meta_title")]
            public string MetaTitle { get; set; }

            /// <summary>
            /// Калит сузлар
            /// </summary>
            [Column("meta_keywords")]
            public string MetaKeywords { get; set; }

            /// <summary>
            /// Изоҳ
            /// </summary>
            [Column("meta_description")]
            public string Remark { get; set; }

            /// <summary>
            /// Махсус шартлар
            /// </summary>
            [Column("special_conditions")]
            public string SpecialConditions { get; set; }

            /// <summary>
            /// Товар ишлаб чиқарувчи
            /// </summary>
            [Column("manufacturer")]
            public string Manufacturer { get; set; }

            /// <summary>
            /// Расмлар
            /// </summary>
            [Column("photos")]
            public string Photos { get; set; }

            /// <summary>
            /// Улчов бирлиги
            /// </summary>
            [Column("measure_id")]
            public int MeasureID { get; set; }

            /// <summary>
            /// Минимум сотилиши
            /// </summary>
            [Column("quantity_min")]
            public int? QuantityMin { get; set; }

            /// <summary>
            /// Максимум сотилиши
            /// </summary>
            [Column("quantity_max")]
            public int? QuantityMax { get; set; }

            /// <summary>
            /// Нархи
            /// </summary>
            [Column("price")]
            public decimal Price { get; set; }

            /// <summary>
            /// Эски нархи
            /// </summary>
            [Column("price_old")]
            public decimal? PriceOld { get; set; }

            /// <summary>
            ///Товар активлик ҳолати
            /// </summary>
            [Column("is_active")]
            public bool IsActive { get; set; }

            /// <summary>
            /// Товар фақат буюртма учун
            /// </summary>
            [Column("for_order")]
            public bool ForOrder { get; set; }

            /// <summary>
            ///Яратилган сана
            /// </summary>
            [Column("created")]
            public DateTime CreateDate { get; set; }

            /// <summary>
            /// ўзгартирилган сана
            /// </summary>
            [Column("updated")]
            public DateTime? EditDate { get; set; }
            [NotMapped]
            public string MeasureText { get; set; }

            /// <summary>
            ///Ўчирилган сана
            /// </summary>
            [Column("deleted")]
            public DateTime? DeleteDate { get; set; }

            [Column("create_user_id")]
            public int CreateUser { get; set; }



            /// <summary>
            /// ўзгартирган фойдаланувчи
            /// </summary>
            [Column("update_user_id")]
            public int? EditUser { get; set; }



            /// <summary>
            /// Ўчирган фойдаланувчи
            /// </summary>
            [Column("delete_user_id")]
            public int? DeleteUser { get; set; }



            /// <summary>
            /// Категория коди
            /// </summary>
            [Column("category_id")]
            public int CategoryID { get; set; }



            /// <summary>
            /// Компания коди
            /// </summary>
            [Column("company_id")]

            public int CompanyId { get; set; }

            /// <summary>
            /// Товар рейтинги
            /// </summary>
            [Column("rating_avg")]
            public double RatingAVG { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("send_to_director")]
            public bool SendToDirector { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("checked_direсtor")]
            public bool? CheckedDirector { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("failure_message_director")]
            public string FailureMessageDirector { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("checked_moderator")]
            public bool? CheckedModerator { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("failure_message_moderator")]
            public string FailureMessageModerator { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("certificates")]
            public string Certificates { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("files")]
            public string Files { get; set; }
            [Column("made_country_description")]
            public string MadeDescription { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("made_country_id")]

            public int MadeCountryId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [Column("expire_garand")]
            public int? ExpireGarand { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("expire_date")]
            public DateTime? ExpiryDate { get; set; }

            /// <summary>
            /// Товар ишлаб чиқарилган сана 
            /// </summary>
            [Column("manufacture_date")]
            public DateTime? ManufactureDate { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("tnved_code")]
            public string TNVED { get; set; }

            /// <summary>
            /// Пока не используется (Доставка дней)
            /// </summary>
            [Column("delivery_day")]
            public int? DeliveryDay { get; set; }


            [Column("attributes", TypeName = "json")]
            public string Attributes { get; set; }

            /// <summary>
            /// sp productId
            /// </summary>
            [Column("sp_product_id")]

            public int? SpProductId { get; set; }



            /// <summary>
            /// Товарлар йиғиндиси
            /// </summary>
            [Column("product_count")]
            public int ProductCount { get; set; }

            /// <summary>
            /// Сотлиган товарлар йиғиндиси
            /// </summary>
            [Column("product_order_count")]
            public int ProductOrderCount { get; set; }

            /// <summary>
            /// Пока не используется (Доставка дней)
            /// </summary>
            [Column("product_hold_count")]
            public int ProductHoldCount { get; set; }




            //[NotMapped]
            //public string CompanyName { get; set; }

            //[Column("")]
            //public string MadeCountryName { get; set; }


            /// <summary>
            /// Is Concurently
            /// </summary>
            [Column("is_concurently")]
            public bool IsConcurently { get; set; }


            /// <summary>
            /// Concurently end Date
            /// </summary>
            [Column("concurently_end_date")]
            public DateTime? ConcurentlyEndDate { get; set; }

            [Column("unique_product_id")]
            public string UniqueProductId { get; set; }

            /// <summary>
            /// NDS
            /// </summary>
            [Column("vat")]
            public double Vat { get; set; }

            /// <summary>
            ///Товар активлик ҳолати
            /// </summary>
            [Column("is_send_push_concurent_date")]
            public bool IsSendPushConcurentDate { get; set; }
            /// <summary>
            /// For ViewModel
            /// </summary>
           [Column("slug")]
            public string Slug { get; set; }

        
    }
}
