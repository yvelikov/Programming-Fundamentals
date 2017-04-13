namespace _03.UserDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserDatabase
    {
        public static void Main()
        {
            var registeredUsers = new Dictionary<string, User>();

            if (File.Exists("users.txt"))
            {
                var users = File.ReadAllLines("users.txt");

                foreach (var user in users)
                {
                    var currentUserParams = user.Split(' ');
                    var username = currentUserParams[0];
                    var password = currentUserParams[1];

                    var currentUser = new User
                    {
                        Username = username,
                        Password = password
                    };

                    registeredUsers.Add(username, currentUser);
                }
            }
            
            var inputLine = Console.ReadLine();

            bool isLogged = false;
            var loggedUser = string.Empty;

            while (inputLine != "exit")
            {
                var inputParams = inputLine.Split(' ');
                var command = inputParams[0];

                if (command == "register")
                {
                    var username = inputParams[1];
                    var passowrd = inputParams[2];
                    var confirmedPassword = inputParams[3];
                    if (passowrd == confirmedPassword)
                    {
                        try
                        {
                            var newUser = new User();

                            newUser.Username = username;
                            newUser.Password = passowrd;

                            registeredUsers.Add(newUser.Username, newUser);
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("The given username already exists.");
                        }
                    }
                    else Console.WriteLine("The two passwords must match.");
                }
                else if (command == "login")
                {
                    var userToLog = inputParams[1];
                    var password = inputParams[2];

                    if (!isLogged)
                    {
                        try
                        {
                            if (registeredUsers[userToLog].Password == password)
                            {
                                loggedUser = userToLog;
                                isLogged = true;
                            }
                            else Console.WriteLine("The password you entered is incorrect.");
                        }
                        catch (KeyNotFoundException)
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }

                    }
                    else Console.WriteLine("There is already a logged in user.");
                }
                else if (command == "logout")
                {
                    if (isLogged)
                    {
                        isLogged = false;
                        loggedUser = string.Empty;
                    }
                    else Console.WriteLine("There is no currently logged in user.");
                }

                inputLine = Console.ReadLine();
            }

            File.WriteAllLines("users.txt",registeredUsers.Select(x => x.Value).Select(x=> string.Format($"{x.Username} {x.Password}")).ToList());

        }
    }
}
