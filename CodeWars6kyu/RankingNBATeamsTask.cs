using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class RankingNBATeamsTask
    {
        public static string NbaCup(string resultSheet, string toFind)
        {
            if (string.IsNullOrEmpty(toFind))
            {
                return "";
            }

            var matches = resultSheet.Split(',');

            int wins = 0, draws = 0, losses = 0, scored = 0, conceded = 0, points = 0;

            var regex = new Regex(@"(.*?) (\d+) (.*?) (\d+)$");

            foreach (var match in matches)
            {
                var trimmedMatch = match.Trim();
                var result = regex.Match(trimmedMatch);

                if (!result.Success)
                {
                    if (trimmedMatch.Any(c => c == '.'))
                    {
                        return $"Error(float number):{trimmedMatch}";
                    }
                    continue;
                }

                var team1 = result.Groups[1].Value.Trim();
                var score1 = int.Parse(result.Groups[2].Value);
                var team2 = result.Groups[3].Value.Trim();
                var score2 = int.Parse(result.Groups[4].Value);

                if (team1 == toFind || team2 == toFind)
                {
                    if (team1 == toFind)
                    {
                        scored += score1;
                        conceded += score2;
                        if (score1 > score2) { wins++; points += 3; }
                        else if (score1 == score2) { draws++; points += 1; }
                        else { losses++; }
                    }
                    else if (team2 == toFind)
                    {
                        scored += score2;
                        conceded += score1;
                        if (score2 > score1) { wins++; points += 3; }
                        else if (score2 == score1) { draws++; points += 1; }
                        else { losses++; }
                    }
                }
            }

            if (wins == 0 && draws == 0 && losses == 0)
            {
                return $"{toFind}:This team didn't play!";
            }

            return $"{toFind}:W={wins};D={draws};L={losses};Scored={scored};Conceded={conceded};Points={points}";
        }
    }
}
//https://www.codewars.com/kata/5a420163b6cfd7cde5000077/train/csharp