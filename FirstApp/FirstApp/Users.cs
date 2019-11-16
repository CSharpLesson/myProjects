using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstApp
{
    public partial class Users 
    {
        //[Key]  //Для установки свойства в качестве первичного ключа с помощью аннотаций применяется атрибут [Key]:
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
