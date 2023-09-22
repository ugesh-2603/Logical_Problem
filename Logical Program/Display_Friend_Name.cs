using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    class FriendList
    {
        private string[] friends = new string[5];

        public FriendList()
        {
            // Initialize the friend names
            friends[0] = "Ugesh";
            friends[1] = "JP";
            friends[2] = "Chandu";
            friends[3] = "Kiruba";
            friends[4] = "Prahalathan";
        }

        public string[] GetFriends()
        {
            return friends;
        }
    }
}