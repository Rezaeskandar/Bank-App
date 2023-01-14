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
