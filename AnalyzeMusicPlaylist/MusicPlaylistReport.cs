using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnalyzeMusicPlaylist
{
    public static class MusicStatsReport
    {
        public static string GenerateText(List<MusicStats> musicStatsList)
        {
            string report = "Music Analyzer Report\n\n";

            if (musicStatsList.Count() < 1)
            {
                report += "No data is available.\n";

                return report;
            }



            // How many songs received 200 or more plays?
            report += "Songs that received 200 or more plays:\n";
            var song200Plays = from music in musicStatsList where music.Plays > 200 select music;
            if (song200Plays.Count() > 0)
            {
                foreach (MusicStats songs in song200Plays)
                {
                    report += songs.ToString();
                    report.TrimEnd(',');
                    report += "\n";
                }

            }
            else
            {
                report += "not available\n";
            }
            report += "\n\n";



            // How many songs are in the playlist with the Genre of “Alternative”?
            report += "Number of Alternative songs: ";
            var alternativeCount = from music in musicStatsList where music.Genre == "Alternative" select music;
            int altCounter = 0;
            if (alternativeCount.Count() > 0)
            {
                foreach (var song in alternativeCount)
                {
                    ++altCounter;
                }
                report += altCounter;
                report += "\n\n\n";
            }
            else
            {
                report += "Not Available\n";
            }


            // How many songs are in the playlist with the Genre of “Hip-Hop/Rap”?
            report += "Number of Hip-Hop/Rap songs: ";
            var hiphopCount = from music in musicStatsList where music.Genre == "Hip-Hop/Rap" select music.Name;
            int totalRap = 0;
            if (hiphopCount.Count() > 0)
            {
                foreach (var song in hiphopCount)
                {
                    ++totalRap;
                }
                report += totalRap;
                report += "\n\n\n";
            }
            else
            {
                report += "Not Available\n";
            }


            // What songs are in the playlist from the album “Welcome to the Fishbowl?”
            report += "Songs from the album Welcome to the Fishbowl: \n";
            var fishbowl = from music in musicStatsList where music.Album == "Welcome to the Fishbowl" select music;
            if (fishbowl.Count() > 0)
            {
                foreach (MusicStats music in fishbowl)
                {
                    report += music.ToString();
                    report += "\n";
                }
                report += "\n\n";
            }
            else
            {
                report += "not available\n";
            }


            // What are the songs in the playlist from before 1970?
            report += "Songs from before 1970:\n";
            var before1970 = from music in musicStatsList where music.Year <= 1970 select music;
            if (before1970.Count() > 0)
            {
                foreach (MusicStats music in before1970)
                {
                    report += music.ToString();
                    report += "\n";
                }
                report += "\n\n";
            }
            else
            {
                report += "not available\n";
            }


            // What are the song names that are more than 85 characters long?
            report += "Song names longer than 85 characters:\n";
            var character85 = from music in musicStatsList where music.Name.Length > 85 select music.Name;
            if (character85.Count() > 0)
            {
                foreach (var music in character85)
                {
                    report += music;
                    report += "\n";
                }
                report += "\n\n";
            }
            else
            {
                report += "Not Available\n";
            }

            // What is the longest song? (longest in Time)
            report += "Longest song: ";
            var longestSong = (from music in musicStatsList orderby music.Time descending select music).First();

            report += longestSong.ToString();
            report += "\n\n\n";

            // What are the unique Genres in the playlist?
            report += @"*\*/*\*/*\*/*\*";
            report += "\nUnique Genres:\n";
            var uniqueGenre = (from music in musicStatsList select music.Genre).Distinct();
            if (uniqueGenre.Count() > 0)
            {
                foreach (var genre in uniqueGenre)
                {
                    report += genre;
                    report += "\n";
                }
                report += "\n\n";
            }
            else
            {
                report += "not available\n";
            }


            // How many songs were produced each year in the playlist?
            report += @"*\*/*\*/*\*/*\*";
            report += "\nYearly Number of Songs in Playlist:\n";
            var producedByYear = from music in musicStatsList group music by music.Year into songsYear orderby songsYear.Key descending select songsYear;
            if (producedByYear.Count() > 0)
            {
                foreach (var year in producedByYear)
                {
                    report += $"{year.Key}: {year.Count()}";
                    report += "\n";
                }
                report += "\n\n";
            }
            else
            {
                report += "not available\n";
            }



            // What are the total plays per year in the playlist?
            // report += @"*\*/*\*/*\*/*\*";
            // report += "\nTotal Plays Per Year:\n";
            // var playsPerYear = from music in musicStatsList group music by music.Year into songsYear orderby songsYear.Key descending select songsYear;
            // if (playsPerYear.Count() > 0)
            // {
            //     foreach (var year in playsPerYear)
            //     {
            //         report += $"{year.Key}: {year.Plays}";
            //         report += "\n";
            //     }
            //     report += "\n\n";
            // }
            // else
            // {
            //     report += "not available\n";
            // }
            /*I can't figure out how to do this part*/



            // Print a list of the unique artists in the playlist.
            report += @"*\*/*\*/*\*/*\*";
            report += "\nUnique Artists:\n";
            var uniqueArtists = (from music in musicStatsList select music.Artist).Distinct();
            if (uniqueArtists.Count() > 0)
            {
                foreach (var artist in uniqueArtists)
                {
                    report += artist;
                    report += "\n";
                }
            }
            else
            {
                report += "not available\n";
            }



            return report;
        }
    }
}