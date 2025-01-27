using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu;

public class GA_DE_RY_PO_LU_KICypherVol3MissingKeyTask
{
    public static string FindTheKey(string[] messages, string[] secrets)
    {
        List<string> cipher = new();
        
        for(int i  = 0; i < messages.Length; i++)
        {
            for ( int j = 0; j < messages[i].Length; j++ )
            {
                if ( messages[i][j] != secrets[i][j] )
                {
                    if( secrets[i][j] < messages[i][j] )
                    {
                        cipher.Add(secrets[i][j].ToString() + messages[i][j].ToString());
                    }
                    else
                    {
                        cipher.Add(messages[i][j].ToString() + secrets[i][j].ToString());
                    }
                }
            }
        }

        cipher.Sort();
        HashSet<string> result = new(cipher);
        
        return string.Join("", result);
    }
}
//https://www.codewars.com/kata/592bdf59912f2209710000e9/train/csharp