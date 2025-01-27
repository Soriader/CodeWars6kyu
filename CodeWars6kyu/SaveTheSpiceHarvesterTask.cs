namespace CodeWars6kyu;

public class SaveTheSpiceHarvesterTask
{
    public static string HarvesterRescue(int[][] data)
    {
        int harvesterX = data[0][0];
        int harvesterY = data[0][1];

        int wormX = data[1][0];
        int wormY = data[1][1];
        int wormSpeed = data[1][2];

        int carryallX = data[2][0];
        int carryallY = data[2][1];
        int carryallSpeed = data[2][2];

        var distanceWormHarvester = Math.Sqrt(Math.Pow(wormX - harvesterX, 2) + Math.Pow(wormY - harvesterY, 2));
        var distanceCarryallaHarvester = Math.Sqrt(Math.Pow(carryallX - harvesterX, 2) + Math.Pow(carryallY - harvesterY, 2));

        var wormTime = distanceWormHarvester / wormSpeed;
        var carryallTime = distanceCarryallaHarvester / carryallSpeed + 1;
        

        if (carryallTime < wormTime)
        {
            return "The spice must flow! Rescue the harvester!";
        }

        return "Damn the spice! I'll rescue the miners!";
    }
}
//https://www.codewars.com/kata/587d7544f1be39c48c000109/train/csharp