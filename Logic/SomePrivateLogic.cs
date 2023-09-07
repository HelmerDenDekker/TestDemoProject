namespace Logic
{
    /// <summary>
    /// Having logic in a Helper makes your class lok clean, but it also hides part of the logic.
    /// </summary>
    public class SomePrivateLogic : SomePrivateLogicHelper, ISomePrivateLogic
    {
        /// <summary>
        /// Divides the numerator by the denumerator
        /// </summary>
        /// <param name="numerator">numerator (top)</param>
        /// <param name="denumerator">denumerator (bottom)</param>
        /// <returns>The division result</returns>
        public double Divide(double numerator, double denumerator)
        {
            if (!Validate(numerator, denumerator))
            {
                return double.NaN;
            }

            return numerator / denumerator;
        }


    }
}
