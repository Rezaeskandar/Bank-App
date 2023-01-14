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


## Reflection
- In building this bank system project, I made several mistake that made the structure and functionality of the system was not correct! but this versin is the final one.
- This code structure is used to create a simple bank system, where User objects are created with a username, password and an array of Account objects. Each Account object has a name and a balance. With this structure, it is possible to create multiple User objects with different usernames, passwords and accounts, which can be used to represent different customers in a banking system. The use of properties with public getters and setters allows for easy access of the properties from outside the class. The nested Account class represents the accounts that a user has.



Why this way of creating a bank system using User and Account classes is a good ?
___

1- Object-oriented design: Using classes to represent users and accounts allows for a clear and organized structure of the system. It makes it easy to understand the different components of the system and how they relate to each other.

2- Reusability: The User and Account classes can be reused and create multiple object of that, allowing for the representation of multiple users and accounts in the system.

3- The use of properties with public getters and setters makes it easy to access the properties of the objects. It also makes it easy to add or remove properties in the future without affecting the rest of the system.

4- The nested Account class within the User class is logical and easy to understand, it represents the accounts that a user has.

5-The structure uses basic concepts of Object-oriented programming, which makes it easy to implement and understand.


