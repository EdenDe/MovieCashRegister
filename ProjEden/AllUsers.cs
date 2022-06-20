using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjEden_and_Ofir
{
    class AllUsers 
    {
        List<User> userList = new List<User>();
        Dictionary<int, User> managerList = new Dictionary<int, User>();

        public AllUsers(User[] user)
        {
            AddNewUser(user);
        }


        public void AddNewUser(User[] users)
        {

            foreach (User item in users)
            {
                userList.Add(item);

                if (item is Manager)
                {
                    Manager user1 = item as Manager;
                    managerList.Add(user1.AccessCode, user1);
                }
            }

        }


        public bool RemovedUser(User userToRemove)
        {
            if (userToRemove is Manager)
            {
                Manager userToRemove1 = userToRemove as Manager;
               return managerList.Remove(userToRemove1.AccessCode) && userList.Remove(userToRemove);
            }

            return userList.Remove(userToRemove);
        }


        public bool this[string userName]
        {
            get {

                foreach (User item in userList)
                {
                    if (item.Username == userName)
                    {
                        return true;
                    }
                }

                return false;
            }          
        }

        public User this[int index]
        {
            get
            {
                if (userList.Count <= index)
                {
                    return null;
                }
                return userList[index];
            }
            
        }

        public bool this[int access,string name,int password]
        {
            get 
            {
                return managerList.ContainsKey(access);
            }
        }

        public User this[string userName,int password]
        {
            get
            {
                foreach (User item in userList)
                {
                    if (item.Username == userName && item.Password == password)
                    {
                        return item;
                    }
                }
                return null;
            }
        }
    }
}
