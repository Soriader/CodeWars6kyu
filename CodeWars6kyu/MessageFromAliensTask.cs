using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class MessageFromAliensTask
    {
        private static Dictionary<string, string> AlienLanguage = new Dictionary<string, string>() {
          { "/\\","a" }
         ,{ "]3","b" }
         ,{ "(","c" }
         ,{ "|)","d" }
         ,{ "[-","e"}
         ,{ "/=","f" }
         ,{ "(_,","g" }
         ,{ "|-|","h"}
         ,{ "|","i"}
         ,{ "_T","j"}
         ,{ "/<","k" }
         ,{ "|_","l"  }
         ,{ "|\\/|","m"}
         ,{ "|\\|","n" }
         ,{ "()","o"  }
         ,{ "|^","p"}
         ,{ "()_","q"}
         ,{ "/?","r"  }
         ,{ "_\\~","s"}
         ,{ "~|~","t"}
         ,{ "|_|","u" }
         ,{ "\\/","v"  }
         ,{ "\\/\\/","w"}
         ,{ "`/","y"}
         ,{ "><","x"}
         ,{ "~/_","z"}
         ,{ "__"," " }
  };
        public static string Decode(string m)
        {
            return string.Concat(m.Split(m[0]).Where(e => e.Length > 0).Select(c => AlienLanguage[c]).Reverse());

        }
    }
}
//https://www.codewars.com/kata/598980a41e55117d93000015/train/csharp