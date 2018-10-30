using System;

namespace Logic.FriendsByDistance
{
    public class Coordinates
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Coordinates(double i_Latitude, double i_Longitude)
        {
            Latitude = i_Latitude;
            Longitude = i_Longitude;
        }

        public double DistanceTo(Coordinates i_TargetCoordinates, UnitOfLength i_UnitOfLength)
        {
            var baseRad = Math.PI * Latitude / 180;
            var targetRad = Math.PI * i_TargetCoordinates.Latitude / 180;
            var theta = Longitude - i_TargetCoordinates.Longitude;
            var thetaRad = Math.PI * theta / 180;
            double dist =
                (Math.Sin(baseRad) * Math.Sin(targetRad)) + (Math.Cos(baseRad) *
                Math.Cos(targetRad) * Math.Cos(thetaRad));

            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return i_UnitOfLength.ConvertFromMiles(dist);
        }
    }
}
