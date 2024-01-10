using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_Dados_Spotify
{
    public class DatasetMap : ClassMap<Dataset>
    {
        public DatasetMap()
        {
            Map(m => m.TrackName).Name("track_name");
            Map(m => m.ArtistsName).Name("artist(s)_name");
            Map(m => m.ArtistCount).Name("artist_count");
            Map(m => m.ReleasedYear).Name("released_year");
            Map(m => m.ReleasedMonth).Name("released_month");
            Map(m => m.ReleasedDay).Name("released_day");
            Map(m => m.InSpotifyPlaylists).Name("in_spotify_playlists");
            Map(m => m.InSpotifyCharts).Name("in_spotify_charts");
            Map(m => m.Streams).Name("streams");
            Map(m => m.InApplePlaylists).Name("in_apple_playlists");
            Map(m => m.InAppleCharts).Name("in_apple_charts");
            Map(m => m.InDeezerPlaylists).Name("in_deezer_playlists");
            Map(m => m.InDeezerCharts).Name("in_deezer_charts");
            Map(m => m.InShazamCharts).Name("in_shazam_charts");
            Map(m => m.BPM).Name("bpm");
            Map(m => m.Key).Name("key");
            Map(m => m.Mode).Name("mode");
            Map(m => m.Danceability).Name("danceability_%");
            Map(m => m.Valence).Name("valence_%");
            Map(m => m.Energy).Name("energy_%");
            Map(m => m.Acousticness).Name("acousticness_%");
            Map(m => m.Instrumentalness).Name("instrumentalness_%");
            Map(m => m.Liveness).Name("liveness_%");
            Map(m => m.Speechiness).Name("speechiness_%");
        }
    }
}
