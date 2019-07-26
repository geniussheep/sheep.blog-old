using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sheep.Blog.Models.Entities
{
    [Table(nameof(SeminarPostHistoryVersion))]
    public class SeminarPostHistoryVersion
    {
        //[Key]
        //public string Id { get; set; }

        [ForeignKey("Seminar_Id")]
        public int SeminarId { get; set; }

        [ForeignKey("PostHistoryVersion_Id")]
        public int PostHistoryVersionId { get; set; }

        public virtual Seminar Seminar { get; set; }

        public virtual PostHistoryVersion PostHistoryVersion { get; set; }
    }
}
