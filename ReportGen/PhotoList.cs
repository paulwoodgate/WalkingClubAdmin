using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGen
{
    public class PhotoList
    {
        public string Photographer { get; set; }
        public List<ReportPhoto> Photos { get; } = new List<ReportPhoto>();
        public string ToJson()
        {
            string json = $"{{\"photographer\": \"{Photographer}\", " +
                $"\"photos\": [{string.Join(", ", Photos.Select(p => p.ToJson()))}]}}";

            return json;
        }
    }
}
