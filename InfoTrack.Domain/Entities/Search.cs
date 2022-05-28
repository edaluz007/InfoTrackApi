using System;

namespace InfoTrack.Domain.Entities {
    public class Search {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Keywords { get; set; }
        public string Ranking { get; set; }
        public DateTime SearchDate { get; set; }
        public int Occurrences { get; set; }
    }
}
