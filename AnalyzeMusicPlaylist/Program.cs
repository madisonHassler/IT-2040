using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnalyzeMusicPlaylist
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2) {
                Console.WriteLine("AnalyzeMusicPlaylist <music_playlist_file_path> <report_file_path>");
                Environment.Exit(1);
            }

            string musicPlaylistFilePath = args[0];
            string reportFilePath = args[1];

            List<MusicStats> musicStatsList = null;
            try
            {
                musicStatsList = MusicPlaylistLoader.Load(musicPlaylistFilePath);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Environment.Exit(2);
            }

            var report = MusicStatsReport.GenerateText(musicStatsList);

            try
            {
                System.IO.File.WriteAllText(reportFilePath, report);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Environment.Exit(3);
            }
        }
    }
}