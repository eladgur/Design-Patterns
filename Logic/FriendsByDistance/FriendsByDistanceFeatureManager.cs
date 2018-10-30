using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Logic.FriendsByDistance
{
    public static class FriendsByDistanceFeatureManager
    {
        public static List<User> GetFriendsInDistance(User i_LoggedInUser, int i_MaxDistance)
        {
            List<User> usersInDistance = new List<User>();

            try
            {
                double latitude = i_LoggedInUser.Location.Location.Latitude.Value;
                double longitude = i_LoggedInUser.Location.Location.Longitude.Value;
                Coordinates coordinate1 = new Coordinates(latitude, longitude);
                foreach (User user in i_LoggedInUser.Friends)
                {
                    Coordinates coordinate2 = new Coordinates((double)user.Location.Location.Latitude, (double)user.Location.Location.Longitude);
                    double distance = coordinate1.DistanceTo(coordinate2, UnitOfLength.s_Meters);
                    if (distance < i_MaxDistance)
                    {
                        usersInDistance.Add(user);
                    }
                }
            }
            catch (Exception)
            {
                // Always will throw an exception due to facebook permissions =]
            }

            return usersInDistance;
        }
    }
}
