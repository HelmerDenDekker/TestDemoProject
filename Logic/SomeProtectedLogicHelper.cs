namespace Logic
{
    public class SomeProtectedLogicHelper
    {
        /// <summary>
        /// Validates if the denumerator is zero
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsDenumenatorNonZero(double denumerator)
        {
            if (denumerator == 0)
            {
                return false;
            }
            return true;
        }
    }
}
