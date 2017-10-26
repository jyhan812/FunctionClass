using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace FunctionClass
{
    public class FindMatch
    {
        public string MatchStringsByHashSet(string firstString, string secondString)
        {
            char[] firstCharArray = firstString.ToLower().ToCharArray();
            var firstHash = new HashSet<char>(firstCharArray); 

            char[] secondCharArray = secondString.ToLower().ToCharArray();
            var secondHash = new HashSet<char>(secondCharArray);

            StringBuilder sb = new StringBuilder();
            foreach(char achar in secondHash.ToArray())
            {
                if(firstHash.Contains(achar))
                {
                    sb.Append(achar);
                }
            }
         
            return String.Concat(sb.ToString().OrderBy(c => c));
        }

        public string MatchStringsByLINQ(string firstString, string secondString)
        {
            List<char> secondCharList = secondString.ToLower().ToList();

            var resultList = secondCharList.Distinct().Where(i => firstString.ToLower().Contains(i)).ToList();

            return string.Join("", resultList.ToArray().OrderBy(c =>c)); ;
        }
    }
}
