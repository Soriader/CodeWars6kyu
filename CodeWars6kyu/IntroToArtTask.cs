namespace CodeWars6kyu;

public class IntroToArtTask
{
    public static string[] GetW(int h)
    {
        if (h < 2)
        {
            return new string[] {};
        }
        
        List<string> result = new List<string>();
        
        result.Add(UpW(h));

        foreach (string center in CenterW(h))
        {
            result.Add(center);
        }
        
        result.Add(DownW(h));
        
        return result.ToArray();    
    }

    private static List<string> CenterW(int h)
    {
        int spaceOnLeftAndRight = 1;
        int spaceInW = (h - 2) * 2 - 1;  
        int spaceOnTheCenter = 1; 
    
        List<string> result = new List<string>();
    
        for (int i = 1; i < h - 1; i++)  
        {
            string line = new string(' ', spaceOnLeftAndRight)  
                          + "*" 
                          + new string(' ', spaceInW)           
                          + "*" 
                          + new string(' ', spaceOnTheCenter)    
                          + "*" 
                          + new string(' ', spaceInW)            
                          + "*" 
                          + new string(' ', spaceOnLeftAndRight);

            result.Add(line);
        
            spaceOnLeftAndRight++;      
            spaceInW -= 2;              
            spaceOnTheCenter += 2; 
        }

        return result;
    }

    private static string UpW(int h)
    {
        int spaceBetween  = h * 2 - 3;

        string upW = "*"
                     + string.Concat(Enumerable.Repeat(" ", spaceBetween ))
                     + "*"
                     + string.Concat(Enumerable.Repeat(" ", spaceBetween ))
                     + "*";
        
        return upW;
    }
    
    private static string DownW(int h)
    {
        int spaceInW = h * 2 - 3; 
        
        string downW = string.Concat(Enumerable.Repeat(" ", h - 1)) 
                       + "*" 
                       + string.Concat(Enumerable.Repeat(" ", spaceInW)) 
                       + "*" 
                       + string.Concat(Enumerable.Repeat(" ", h - 1));
        
        return downW;
    }
    
}
//https://www.codewars.com/kata/5d7d05d070a6f60015c436d1/train/csharp