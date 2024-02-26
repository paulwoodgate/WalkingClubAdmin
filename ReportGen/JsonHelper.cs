using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReportGen
{
    public static class JsonHelper
    {
        public static List<PhotoList> CreatePhotoSets(string json)
        {
            var photoSets = new List<PhotoList>();
            var setJson = FindArray("photoSets", json);

            if (setJson ==  null)
            {
                return photoSets;
            }

            foreach (var photoSet in setJson)
            {
                var photosList = new PhotoList { Photographer = FindString("\"photographer\"", photoSet) };
                var photosJson = FindArray("\"photos\"", photoSet);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                foreach (var photo in photosJson)
                {
                    var photoDets = photo.Replace("\"file\"", "\"filename\"");
                    photosList.Photos.Add(JsonSerializer.Deserialize<ReportPhoto>(photoDets, options));
                }
                photoSets.Add(photosList);
            }

            return photoSets;
        }

        public static string FindString(string key, string json)
        {
            var pos = json.IndexOf(key);
            if (pos == -1)
            {
                return null;
            }

            var start = json.IndexOf('"', pos + key.Length) + 1;
            var end = json.IndexOf('"', start);
            return json[start..end];
        }

        public static DateTime? FindDate(string key, string json)
        {
            var pos = json.IndexOf(key);
            if (pos == -1)
            {
                return null;
            }

            var start = pos + key.Length + 12;
            var dateValue = json.Substring(start, 10);
            return Convert.ToDateTime(dateValue);
        }

        public static string[] FindArray(string key, string json)
        {
            var pos = json.IndexOf(key);
            if (pos == -1)
            {
                return Array.Empty<string>();
            }

            json = json.Replace("\r\n", "");
            var start = json.IndexOf('[', pos + key.Length) + 1;
            var end = FindEndOfObject(json, start, '[', ']') - 1;
            List<string> temp = FindObjects(json[start..end]);

            for (var i = 0; i < temp.Count; i++)
            {
                var t = temp[i].Trim();
                if (t.StartsWith('"'))
                {
                    t = t[1..];
                }

                if (t.EndsWith('"'))
                {
                    t = t[..^1];
                }

                temp[i] = t;
            }

            return temp.ToArray();
        }

        private static int FindEndOfObject(string json, int startPos, char startCh, char endCh)
        {
            var levels = 1;
            int i;

            for (i = startPos + 1; i < json.Length && levels > 0; i++)
            {
                var ch = json[i];
                if (ch == startCh)
                {
                    levels++;
                }
                else if (ch == endCh)
                {
                    levels--;
                }
            }

            return i;
        }

        private static List<string> FindObjects(string json)
        {
            var objects = new List<string>();
            json = json.Trim();
            var startDelimiter = json[0];
            var endDelimiter = '}';
            var split = 0;
            if (startDelimiter == '"')
            {
                return json.Split("\",").ToList();
            }

            var delimiterCount = 0;
            var pos = 0;

            while (pos < json.Length)
            {

                var ch = json[pos];
                if (ch == startDelimiter)
                {
                    if (delimiterCount == 0)
                    {
                        split = pos;
                    }
                    delimiterCount++;
                }
                else if (ch == endDelimiter)
                {
                    delimiterCount--;
                    if (delimiterCount == 0)
                    {
                        objects.Add(json[split..(pos+1)]);
                        split = pos + 1;
                    }
                }
                pos++;

            }

            return objects;
        }
    }
}
