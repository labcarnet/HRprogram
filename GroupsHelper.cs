using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRprogram
{
    class GroupsHelper
    {
        public static List<Group> GetGroups(string defaultGroup)
        {
            return new List<Group>
            {
                new Group { Id = 0, Name = defaultGroup },
                new Group { Id = 1, Name = "Obecnie zatrudnieni" },
                new Group { Id = 2, Name = "Byli pracownicy " }
            };
        }
    }
}
