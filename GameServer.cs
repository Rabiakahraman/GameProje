using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameServer
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);



    }
}
