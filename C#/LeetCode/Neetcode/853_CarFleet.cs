namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/car-fleet/description/ */
public class CarFleet
{
    public int Solution(int target, int[] position, int[] speed)
    {
        var fleetSize = position.Length;
        var car = 0;
        var frontCar = 1;

        while (frontCar < position.Length)
        {
            var relativeSpeed = speed[frontCar] - speed[car];
            var distance = position[frontCar] - position[car];

            var timeToReach = (float)distance / relativeSpeed;
            var timeToTarget = (float)(target - position[frontCar]) / speed[frontCar];

            if (timeToReach <= timeToTarget)
            {
                fleetSize--;
            }

            car = frontCar;
            frontCar++;
        }
        return fleetSize;
    }    
}
