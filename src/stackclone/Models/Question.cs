using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace stackclone.Models
{
    [Table("Questions")]
    public class Question
    {
        public Question()
        {
            this.comments = new HashSet<Comment>();
        }

        [Key]
        public int id { get; set; }
        public string content { get; set; }
        public virtual User user { get; set; }
        public ICollection<Comment> comments { get; set; }
    }
}
