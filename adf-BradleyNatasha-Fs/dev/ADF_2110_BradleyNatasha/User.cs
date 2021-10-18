using System;
namespace ADF_2107_BradleyNatasha
{
    public class User
    {
        //properies
        public string Name { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }

        //methods
        public User(string name = "bob", int id = 1998, string password = "password1234")
        {
            //this project uses default parameter
            Name = name;
            Id = id;
            Password = password;
        }

        //method takes one argument of data type user
        public static bool Login(User user)
        {
            //clear the console
            Console.Clear();

            //ask user for their ID
            Console.WriteLine("ID:");

            //catch the users response
            string stringID = Console.ReadLine();

            //valiadte
            int intID = Validation.NumberValidation(stringID);

            //ask for the password
            Console.WriteLine("Password:");

            //catch the user response
            string stringPassword = Console.ReadLine();

            //valiadte
            stringPassword = Validation.StringValidation(stringPassword);

            //make a conditional
            //if the id and password match - userfound
            if (intID == user.Id && stringPassword == user.Password)
            {
                //report back to user
                Console.WriteLine("User Found!");

                bool signIn = true;

                return signIn;
            }
            else
            {
                //report back to user
                Console.WriteLine("User Login Not Recognized!");

                bool signIn = false;

                return signIn;
            }

            
        }

    }
}
