using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexIntro
{
    /// <summary>
    /// code used to demonstrate regex
    /// </summary>
    class RegexIntro
    {

        public string Pattern { get; set; }
        public string Subject { get; set; }
        public string Results { get; set; }
        private const string MatchSuccess = "{0}  @{1}:{2}";
        

        public string MatchTest(string comment)
        {
            var regex = new Regex(Pattern);
            var match = regex.Match(Subject);
            //if (match.Success)
            //{
            //    Console.WriteLine(MatchSuccess, match.Success, match.Index, match.Length);
            //}
            //else
            //{
            //    Console.WriteLine(match.Success);
            //}

            Results = string.Format(MatchSuccess, match.Success, match.Index, match.Length);

            Console.WriteLine("Executed MatchTest!\nComment: {3}\nPattern: {0}\nSubject: {1}\nResults: {2}\n", Pattern, Subject,Results,comment);

            return Results;
        }

        

    }
}
