namespace CodeWars6kyu;

public class CalculatePyramidHeightTask
{
    public static int PyramidHeight (int n)
    {
        var a = 1;
        int result = 0;
        int valueOfBox = 0;

        while (valueOfBox < n)
        {
            valueOfBox += a * a;
            
            if (valueOfBox > n)
            {
                break;
            }

            a++; 
            
            result++;
        }

        return result;
    }
}
//https://www.codewars.com/kata/56968ce7753513604b000055/train/csharp