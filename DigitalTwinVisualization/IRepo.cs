using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalTwinVisualization
{
    public interface IRepo
    {
        void Create(User user);
        List<User> ReadAll();
        User ReadByEmail(string email);
        void Update(string email, User user);
        void DeleteByEmail(string email);


    }
}
