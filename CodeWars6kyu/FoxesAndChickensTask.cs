namespace CodeWars6kyu;

public class FoxesAndChickensTask
{
    public static string HungryFoxes(string farm)
    {
        string result = "";
        bool cage = false;
        bool foxOutside = false;
        string boxForChicken = "";

        for (int i = 0; i < farm.Length; i++)
        {
            if (farm[i] == '[')
            {
                cage = true;
            }
            else if (farm[i] == ']')
            {
                cage = false;
            }
            else if (!cage && farm[i] == 'F')
            {
                foxOutside = true;
            }
        }

        cage = false; 
        
        for (int i = 0; i < farm.Length; i++)
        {
            if (farm[i] == '[')
            {
                cage = true;
                result += "[";
                boxForChicken = ""; 
            }
            else if (farm[i] == ']')
            {
                cage = false;
                if (boxForChicken.Contains('F'))
                {
                    boxForChicken = boxForChicken.Replace('C', '.');
                }
                result += boxForChicken + "]";
            }
            else if (cage)
            {
                boxForChicken += farm[i];
            }
            else if (foxOutside && farm[i] == 'C')
            {
                result += ".";
            }
            else
            {
                result += farm[i];
            }
        }

        return result;
    }

}
//https://www.codewars.com/kata/591144f42e6009675300001f/train/csharp