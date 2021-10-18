using System;
namespace ADF_2107_BradleyNatasha
{
    public class App
    {
        //fields
        private User _activeUser;
        private Boolean _loggedIn = false;
         

        public App()
        {
            //instantiate a menu class object
            //call menu object init and display

            Menu menu = new Menu();

            //Init needs an array of Main Menu, Login, About, and exit
            string[] array = new string[] {"Main Menu","Create User","Login", "About", "Exit"};

            menu.Init(array);

            menu.Display();

            //constructor then calls the slection method
            Selection();
        }

        private void Selection()
        {
    
            //catch the user response and validate
            string numchoice = Console.ReadLine();

            int Choice = Validation.NumberValidation(numchoice);

            //use a switch statement
            //menu must be different if they are logged in
            if (_loggedIn == true)
            {
                switch (Choice)
                {
                    case 1:
                        //display about
                        About();
                        break;

                    case 2:
                        //log out
                        LogOut();
                        break;

                    case 3:

                        Exit();
                        break;

                    default: //Do nothing
                        break;
                }
            }
            else
            {
                switch (Choice)
                {
                    case 1:
                        //call create user method
                        CreateUser();
                        break;

                    case 2:
                        //signin
                        SignIn();
                        break;

                    case 3:
                        About();
                        break;

                    case 4:
                        Exit();
                        break;

                    default: //do nothing
                        break;

                }
            }
        }

        private void CreateUser()
        {
            //clear the console
            Console.Clear();

            //prompt user for name, password and id
            Console.WriteLine("Please answer the following.\r\n");

            Console.WriteLine("Name:");

            string name = Console.ReadLine();

            //validate
            Validation.StringValidation(name);

            Console.WriteLine("ID[4 digit pin]:");

            String stringId = Console.ReadLine();

            //Validate
            int id = Validation.NumberValidation(stringId);

            Console.WriteLine("Password:");

            string password = Console.ReadLine();

            //validate
            Validation.StringValidation(password);

            //these values are used to create a new user
            _activeUser = new User(name, id, password);

            _loggedIn = true;

            Continue();
        }

        private void SignIn()
        {
            if (_activeUser == null)
            {
                //report to user that they need to create a user
                Console.WriteLine("Error: no User Created.");

                Continue();
            }
            else
            {

                //set bool value of the field
                _loggedIn = User.Login(_activeUser);

                //check to see if the user is logged in
                if (_loggedIn == true)
                {
                    //show menu of user logged in
                    Menu menu = new Menu();

                    //have a new array of menu options
                    string[] loggedIn = new string[] { $"Welcome {_activeUser.Name}!", "About", "Logout", "Exit" };

                    menu.Init(loggedIn);

                    Continue();
                }
                else
                {
                    //have menu options for when they are logged out
                    string[] loggedOut = new string[] { "Main Menu", "Create User", "Login", "About", "Exit" };

                    Menu menu = new Menu();
                    menu.Init(loggedOut);

                    Continue();
                }
            }
        }

        private void About()
        {
            //clear console
            Console.Clear();

            //report to the user
            Console.WriteLine("This is the about section");

            //continue
            Continue();
        }

        private void Exit()
        {
            //clear the console
            Console.Clear();

            //report ot user
            Console.WriteLine("Exiting");


        }

        private void Continue()
        {
            //report to user
            Console.WriteLine("\r\nPress any key to continue:");

            Console.ReadLine();

            //clear the console
            Console.Clear();

            Menu menu = new Menu();

            //the menu needs different options for loggedIn/loggedOut
            if (_activeUser != null)
            {
                string[] loggedIn = new string[] { $"Welcome {_activeUser.Name}!", "About", "Logout", "Exit" };

                //need init to show display
                menu.Init(loggedIn);
            }
            else
            {

                //Init needs an array of Main Menu, Login, About, and exit
                string[] array = new string[] { "Main Menu", "Create User", "Login", "About", "Exit" };

                //need init to show display
                menu.Init(array);
            }
      
            menu.Display();

            Selection();
        }

        private void LogOut()
        {
            //clear console
            Console.Clear();

            //report to the user
            Console.WriteLine("You have now been logged out.");

            Console.WriteLine("\r\nGoodBye");

            //set the field to false
            //have it display the logged out options
            _loggedIn = false;
            _activeUser = null;

            Continue();
        }
    }
}
