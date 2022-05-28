using System;

namespace InfoTrack.Domain.Entities {
    public class HistorySearch {
        public int Id { get; set; }
        public string Url { get; set; }

        public string KeyWords { get; set; }

        public string Ranking { get; set; }

        public DateTime SearchDate { get; set; }

    }
}
