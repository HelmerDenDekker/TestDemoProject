namespace Logic
{
    public class SomePrivateLogicHelper
    {
        /// <inheritdoc/>
        protected virtual bool Validate(double numerator, double denumerator)
        {
            if (!IsDenumenatorNonZero(denumerator))
            {
                return false;
            }

            // More validation....

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsDenumenatorNonZero(double denumerator)
        {
            if (denumerator == 0)
            {
                return false;
            }
            return true;
        }
    }
}
