using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetALL()
        {
            yield return new Friend { FirstName = "Ryu", LastName = "Bloodfist" };
            yield return new Friend { FirstName = "Drisse", LastName = "Silverwind" };
            yield return new Friend { FirstName = "Raiko",  LastName = "Earthshaker" };
            yield return new Friend { FirstName = "Bhissy", LastName = "Stormtotem" };
        }
    }
}
