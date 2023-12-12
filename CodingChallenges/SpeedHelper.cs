using System;
namespace CodingChallenges
{
    public enum SpeedTypeEnum
    {
        MPH,
        KPH
    }

    public static class SpeedHelper
    {
        public static decimal ConvertSpeed(decimal speed, SpeedTypeEnum convertToSpeedType)
        {
            switch (convertToSpeedType)
            {
                case SpeedTypeEnum.KPH:
                    return speed * 1.6093m;
                case SpeedTypeEnum.MPH:
                    return speed / 1.6093m;
                default:
                    throw new Exception("Sorry!Unable to Convert Speed!");
            }
            throw new NotImplementedException();
        }
    }
}

