using Logic;

namespace UnitTestProject.Helpers
{
    /// <summary>
    /// This is a class for testing purposes, exposing the methods in SomeProtectedLogicHelper. Make sure it is properly encapsulated!
    /// </summary>
    internal class ExposedSomeProtectedLogicHelper : SomeProtectedLogicHelper
    {
        /// <summary>
        /// The Exposed method for IsDenumenatorNonZero, make sure it is properly encapsulated.
        /// </summary>
        /// <param name="denumerator"></param>
        /// <returns></returns>
        internal new bool IsDenumenatorNonZero(double denumerator)
        {
            return base.IsDenumenatorNonZero(denumerator);
        }
    }
}
