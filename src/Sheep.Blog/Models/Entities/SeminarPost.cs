using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sheep.Blog.Models.Entities
{
    [Table(nameof(SeminarPost))]
    public class SeminarPost
    {
        //[Key]
        //public string Id { get; set; }

        [ForeignKey("Seminar_Id")]
        public int SeminarId { get; set; }

        [ForeignKey("Post_Id")]
        public int PostId { get; set; }

        public virtual Seminar Seminar { get; set; }

        public virtual Post Post { get; set; }
    }
}
