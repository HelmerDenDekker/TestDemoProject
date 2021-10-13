using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class ProtectedLogic
    {
        /// <summary>
        /// Divides the numerator by the denumerator
        /// </summary>
        /// <param name="numerator">numerator (top)</param>
        /// <param name="denumerator">denumerator (bottom)</param>
        /// <returns>The division result</returns>
        public double Divide(double numerator, double denumerator)
        {
            if(!IsDenumenatorNonZero(denumerator))
            {
                return double.NaN;
            }
            return numerator / denumerator;
        }

        /// <summary>
        /// 
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
