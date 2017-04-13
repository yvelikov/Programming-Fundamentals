namespace _06.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class User
    {
        public string Username { get; set; }
        public List<Message> ReceivedMessages { get; set; }
    }

    public class Message
    {
        public string Content { get; set; }
        public User Sender { get; set; }
    }

    public class Messages
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            var listOfUsers = new HashSet<User>();

            while (entry != "exit")
            {
                var entryParms = entry.Split(' ');

                if (entryParms[0] == "register")
                {
                    var currentUser = RegisterUser(entryParms[1]);
                    listOfUsers.Add(currentUser);
                }
                else
                {
                    var senderUsername = entryParms[0];
                    var recipientUsername = entryParms[2];
                    var content = entryParms[3];

                    bool senderExists = false;
                    bool recipientExists = false;
                    User sender = null;
                    User recipient = null;

                    foreach (var user in listOfUsers)
                    {
                        if (user.Username == senderUsername )
                        {
                            senderExists = true;
                            sender = user;
                        }

                        if (user.Username == recipientUsername)
                        {
                            recipientExists = true;
                            recipient = user;
                        }
                    }

                    if (senderExists && recipientExists)
                    {
                        var currentMessage = SendMessage(content,sender);
                        recipient.ReceivedMessages.Add(currentMessage);
                    }
                }

                entry = Console.ReadLine();
            }
            
            var usersToPrint = Console.ReadLine().Split(' ');
            var firstUserUsername = usersToPrint[0];
            var secondUserUsername = usersToPrint[1];
            User firstUser = null;
            User secondUser = null;

            foreach (var user in listOfUsers)
            {
                if (firstUserUsername == user.Username) firstUser = user;
                if (secondUserUsername == user.Username) secondUser = user;
            }

            var firstUserMessagesList = listOfUsers.Where(x => x == firstUser).SelectMany(x=>x.ReceivedMessages).Where(x=>x.Sender==secondUser).ToList();
            var secondUserMessagesList = listOfUsers.Where(x => x == secondUser).SelectMany(x => x.ReceivedMessages).Where(x => x.Sender == firstUser).ToList();

            if (firstUserMessagesList.Count>=1 || secondUserMessagesList.Count>=1)
            {
                for (int i = 0; i < Math.Max(firstUserMessagesList.Count, secondUserMessagesList.Count); i++)
                {
                    if (i < secondUserMessagesList.Count)
                        Console.WriteLine($"{secondUserMessagesList[i].Sender.Username}: {secondUserMessagesList[i].Content}");
                    if (i < firstUserMessagesList.Count)
                        Console.WriteLine($"{firstUserMessagesList[i].Content} :{firstUserMessagesList[i].Sender.Username}");
                }
            }
            else Console.WriteLine("No messages");
        }

        public static Message SendMessage(string content,User sender)
        {
            return new Message
            {
                Content = content,
                Sender = sender
            };
        }

        public static User RegisterUser(string username)
        {
            return new User
            {
                Username = username,
                ReceivedMessages = new List<Message>()
            };
        }
    }
}
