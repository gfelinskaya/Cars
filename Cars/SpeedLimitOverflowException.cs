namespace Cars
{
    public class SpeedLimitOverflowException : Exception
    {
        public SpeedLimitOverflowException(uint currentSpeed)
            :base($"Speed limit overflow. Current speed: {currentSpeed}")
        {
            
        }
    }
}
