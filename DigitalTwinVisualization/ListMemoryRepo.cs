using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalTwinVisualization
{
    public class ListMemoryRepo : IRepo
    {
        private List<User> users = new List<User>();

        public void Create(User user)
        {
            users.Add(user);
        }

        public void DeleteByEmail(string email)
        {
            foreach (var user in users)
            {
                if (user.Email == email)
                {
                    users.Remove(user);
                    return;
                }
            }
        }

        public List<User> ReadAll()
        {
            return users;
        }

        public User ReadByEmail(string email)
        {
            foreach (var user in users)
            {
                if (user.Email == email)
                {
                    return (User)user;
                }
            }
            return null;


        }

        public void Update(string email, User user)
        {
            return;
        }
    }
}
