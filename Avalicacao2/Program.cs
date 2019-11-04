using System;
using System.Collections.Generic;

namespace Avalicacao2
{
    /*
     * TODO
     * Implementar CanBeConnected para identificar se o Friend A pode se Conectar com o Friend C. Para isso, é necessário ter um friend em comum.
		- Caso sim, o método deverá retornar True
		- Caso não, o método deverá retornar False
     */
    class Friend
    {
        public string Email { get; private set; }

        public ICollection<Friend> Friends { get; private set; }

        public Friend(string email)
        {
            this.Email = email;
            this.Friends = new List<Friend>();
        }

        public void AddFriendship(Friend friend)
        {
            this.Friends.Add(friend);
        }

        public bool CanBeConnected(Friend friendC)
        {
            return false;
        }

        static void Main(string[] args)
        {
            Friend a = new Friend("A");
            Friend b = new Friend("B");
            Friend c = new Friend("C");

            a.AddFriendship(b);
            b.AddFriendship(c);
        }
    }
}
