using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPlaylist.Models
{
    public class M3UEntry
    {
        public TimeSpan Duration { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
    }
}
