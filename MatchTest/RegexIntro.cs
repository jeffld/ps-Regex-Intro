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
        //private const string MatchSuccess = "{0}  @{1}:{2}";

        public bool MatchTest()
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
            return match.Success;
        }

        

    }
}
