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


___
Another way to represent users and accounts in a system could be to use a text files or a database to store the information. This may not be as organized or easy to understand as using classes. For example, instead of having a User class with properties like username, password and an array of Account objects, the information for each user would be stored in a single text file or database record with multiple fields for username, password, account name, and balance. This would make it more difficult to understand the relationships between different users and their accounts, and would also make it more difficult to add new properties or functionality to the system in the future.

using class allows for the implementation of Object oriented programming like inheritance, encapsulation, and polymorphism, that can make the system more secuire. 

Summary:
___
this approach of using classes to create a simple bank system is a good choice because it allows for a clear and organized system that is easy to understand, implement, and maintain. Tt allows for the implementation of Object oriented programming concepts and security which is essential for a production ready system.

Is thier any other ways to do this ?
___

For sure thier are meny better ways do implement this project thas looks better and more profecinall. But as much i know today this way worked for this small project well. It maby whould good to use Jagged Array as well in this project but it would make it more complex to aandrestand.


## This is the road map of the system 
<img src="https://user-images.githubusercontent.com/113901667/212472744-5c6d82b7-1e7a-4a48-a478-4225dce93ff5.png" width="700" height="900">
## Here is an overview from the console
<img src="https://user-images.githubusercontent.com/113901667/212492142-17ee36fd-1fdf-478c-be35-0a1619f98329.png" width="1100" height="500">
