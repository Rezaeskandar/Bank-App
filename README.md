## Bank-App
> *Welcome to my simple banking application! This banking application is a simple project in C#. It is done using Array of Objects in C#. It is a simple project made using console application of C#. This means, no graphics component are added. The main target user of this project are the C# beginners who want to make the project in C# and especially those who are interested in lerning Arrays of object and they way they uses. This project is a complete package to learning basic c#.*
## The codebase is structured:

### ```UserLogin and Acounts:```
```sh
 class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Account[] Accounts { get; set; }
    }
```

### ```Acounts Name And Balances:```
```sh
 class User
    
         class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }
    }
    
```

### ```Creating mutiplel users:```
```sh
 // Creat array of Users object
            User[] users = new User[]
            {
                new User
                {
                    Username = "user1",
                    Password = "1234a",
                    Accounts = new Account[]
                    {
                        new Account{Name = "Account1",Balance = 1000},
                        new Account{Name = "Account2",Balance = 2000}
                    }
                },
                new User
                {
                    Username = "user2",
                    Password = "1234b",
                    Accounts = new Account[]
                    {
                        new Account{Name = "Account1",Balance = 500},
                        new Account{Name = "Account2",Balance =1000},
                        new Account{Name = "Account3",Balance = 1500}
                    }
                },
```
## Features:

- Deposit funds into your accounts
- Withdraw funds from your accounts
- Check your accounts balances

## Tech stack:
- C#
- Using Visual Stadio  

## Getting Started
To get started with the project, you will need to clone the repository to your local machine. Once the repository is cloned, you can navigate to the project directory and run the project using your preferred visual stadio environment.


Reflection
In building this bank system project, I made several mistake that made the structure and functionality of the system was not correct! but this versin is the final one.


Firstly, I chosed to create tre separated classes. I considered if I do this my code lookes more cleane and good structured. This is more for people who will read the code and undrestand it easyer. I have na Account class and a User class. Account class have properties 'Accounts name' and 'Balances'. And  Users class have  'username' , 'password', and array of users 'Account' properties.  

Thirdly, we chose to build the system using an object-oriented approach. We believe that this approach allows for a more organized and maintainable codebase and also helped to model the real-world bank system.

While we believe that the choices we made in building this project were appropriate, there are always opportunities for improvement. For example, in the future, we may consider using a distributed system for better performance and scalability. Additionally, we may investigate the use of other technologies such as blockchain for added security and transparency in financial transactions.

Overall, we are confident that the design choices we made in this project have resulted in a robust and functional bank system that can be easily maintained and scaled in the future.
