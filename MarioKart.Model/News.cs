using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioKart.Model
{
    public class News
    {
        public int ID { get; set; }
        public DateTime? DateEntered { get; set; }
        [MaxLength(140)]
        public string NewsTitle { get; set; }
        [MaxLength(16000)]
        public string NewsStory { get; set; }
    }
}
