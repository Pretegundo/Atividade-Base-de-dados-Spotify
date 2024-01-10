using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_Dados_Spotify
{
    public class Dataset
    {
        public string TrackName { get; set; }
        public string ArtistsName { get; set; }
        public int ArtistCount { get; set; }
        public int ReleasedYear { get; set; }
        public int ReleasedMonth { get; set; }
        public int ReleasedDay { get; set; }
        public int InSpotifyPlaylists { get; set; }
        public string InSpotifyCharts { get; set; }
        public string Streams { get; set; }
        public int InApplePlaylists { get; set; }
        public int InAppleCharts { get; set; }
        public string InDeezerPlaylists { get; set; }
        public int InDeezerCharts { get; set; }
        public string InShazamCharts { get; set; }
        public int BPM { get; set; }
        public string Key { get; set; }
        public string Mode { get; set; }
        public int Danceability { get; set; }
        public int Valence { get; set; }
        public int Energy { get; set; }
        public int Acousticness { get; set; }
        public int Instrumentalness { get; set; }
        public int Liveness { get; set; }
        public int Speechiness { get; set; }
    }
}
