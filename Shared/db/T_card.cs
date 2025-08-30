using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Shared.db
{
    public class T_card
    {
        [Column(TypeName = "int")]
        public string id { get; set; }
        [Column(TypeName = "text")]
        public string name { get; set; }
        [Column(TypeName = "text")]
        public int Path { get; set; }
    }
}
