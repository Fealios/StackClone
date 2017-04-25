using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stackclone.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int id { get; set; }
        public string content { get; set; }
        public int user_id { get; set; }
        public int question_id { get; set; }
        public virtual User user { get; set; }
        public virtual Question Question { get; set; }
    }
}
