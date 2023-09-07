namespace Logic
{
    public interface ISomeProtectedLogic
    {
        /// <summary>
        /// Divides the numerator by the denumerator
        /// </summary>
        /// <param name="numerator">numerator (top)</param>
        /// <param name="denumerator">denumerator (bottom)</param>
        /// <returns>The division result</returns>
        public double Divide(double numerator, double denumerator);
    }
}