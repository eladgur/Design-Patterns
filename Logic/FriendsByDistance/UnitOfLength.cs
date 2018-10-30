namespace Logic
{
    public class UnitOfLength
    {
        private readonly double r_fromMilesFactor;
        public static UnitOfLength s_Meters = new UnitOfLength(1609.34);

        private UnitOfLength(double i_FromMilesFactor)
        {
            r_fromMilesFactor = i_FromMilesFactor;
        }

        public double ConvertFromMiles(double i_Input)
        {
            return i_Input * r_fromMilesFactor;
        }
    }
}
