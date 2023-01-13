using System;
using System.Collections.Generic;
using System.IO;
namespace BnakApp
{
    class Program
    {
        static void Main(string[] args)
        {

            

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
                 new User
                {
                    Username = "user3",
                    Password = "1234c",
                    Accounts = new Account[]
                    {
                        new Account{Name = "Account1",Balance = 500},
                        new Account{Name ="Account2",Balance= 10000},
                        new Account{Name ="Account4",Balance = 15000},
                        new Account{Name ="Account5",Balance= 250000}
                    }
                },
                  new User
                   {
                    Username ="user4",
                    Password ="1234d",
                    Accounts = new Account[]
                    {
                        new Account{Name= "Account1",Balance = 500},
                        new Account{Name ="Account2",Balance = 1000},
                        new Account{Name= "Account3",Balance =1500},
                        new Account{Name ="Account4",Balance = 15050},
                        new Account{Name ="Account5",Balance = 15020}
                    }
                  },
                   new User
                  {
                    Username = "user5",
                    Password = "1234e",
                    Accounts = new Account[]
                    {
                        new Account{Name = "Account1",Balance= 500},
                        new Account{Name = "Account2",Balance =1000},
                        new Account{Name ="Account3",Balance = 15200},
                        new Account{Name = "Account4",Balance= 15700},
                        new Account{Name= "Account5",Balance = 15600},
                        new Account{Name = "Account6",Balance= 15040}
                    }
                   }
            };
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n              -----------------------------------------Wellcome TO ATM---------------------------------------- \n\n          ");
            Console.ResetColor();
            Console.WriteLine("Press Enter to continue ....");
            Console.ReadKey();
            Console.Clear();
            int tryy = 3;
            int count = 0;
        start:
            tryy -= 1;
            //Check if the entered login information is corect

            string enterUsername;
            string enterPin;
           
            User currentUser = null;
            Console.WriteLine("\n\n Enter your username:");
            enterUsername = Console.ReadLine();
            Console.WriteLine("\n Enter your Pin:");
            enterPin = Console.ReadLine();
            foreach (User user in users)
            {
             
               
                    if (user.Username == enterUsername && user.Password == enterPin)
                    {
                        currentUser = user;
                      
                        break;
                    }
                    
                        
            }

           
           
           //bool lopping = true;
            if (currentUser ==null)
            {
                //if the user tries 5 times login with wrong user and password
                if (count >5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYour acout is expired, go to the nearesr bank to get help!\n");
                    Console.ResetColor();
                    return;

                }


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nFel Username or Pin. You have {0} tries more\n", tryy);
                Console.ResetColor();
                    
                if (tryy == 0)
                    {

                  timer.timmer();
                  tryy = 3;
                  goto start;
                        
                        
                }
                count++;
                goto start;

                //lopping = true;
                // }
            }
           
            string choice;
            if (currentUser != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nLogin successfully!");
                Console.ResetColor();
                Console.WriteLine("\nWellcome {0} ", currentUser.Username);
            start2:
                //display the menu and get the users input
                while (true)
                {

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n\n\n        ----------------Menu----------------- \n");
                    Console.ResetColor();
                    Console.WriteLine("1. See your accounts");
                    Console.WriteLine("2. Transfer money between your accounts");
                    Console.WriteLine("3. Withdraw money");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice:");

               
                    choice = Console.ReadLine();
                    string sek = "SEK";
                    switch (choice)
                    {
                        case "1":
                            //display the users accounts
                            Console.WriteLine("Your accounts:");
                            foreach (Account account in currentUser.Accounts)
                            {
                                Console.WriteLine("{0}: {1:N2}:{2}", account.Name, account.Balance,sek);
                            }
                            //press enter to get back to menu
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n\nPress Enteto get back to main Menu. \n");
                            Console.ReadKey();
                            Console.ResetColor();
                          
                            goto start2;

                        case "2":
                            //Transfer money betwen the user dacounts
                            
                            transforMoney();

                            //press enter to get back to menu
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n\nPress Enteto get back to main Menu. \n");
                            Console.ReadKey();
                            Console.ResetColor();
                            goto start2;

                        case "3":
                            //Withdraw money
                            withdraMoney();
                            //press enter to get back to menu
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n\nPress Enteto get back to main Menu. \n");
                            Console.ReadKey();
                            Console.ResetColor();

                            goto start2;
                            
                        case "4":
                            exit();
                            goto start;
                            
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid input. Please try again\n");
                            Console.ResetColor();
                           
                            break;
                    }

                   
                    //select users acount and transfore between dem
                     void transforMoney()
                    {
                        DateTime transforeTime = DateTime.Now;
                        //transfer money between the user account
                        Console.WriteLine("\n\n Enter account name transfor money from: ");
                        string sourceAccountName = Console.ReadLine();
                        Console.WriteLine("\n Enter the name of the destination account:");
                        string destinationAccountName = Console.ReadLine();
                        Console.WriteLine("\nEnter amount you want to transfore:");
                        double amount = double.Parse(Console.ReadLine());

                        //find the sorce and destination accounts
                        Account sourceAccount = null;
                        Account distinationAccount = null;
                        foreach (Account acount in currentUser.Accounts)
                        {
                            if (acount.Name == sourceAccountName)
                            {
                                sourceAccount = acount;
                            }
                            if (acount.Name == destinationAccountName)
                            {
                                distinationAccount = acount;
                            }
                        }

                        //chek if accounts were found
                        if (sourceAccount == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nSource acount not found!\n");
                            Console.ResetColor();
                            
                            return;
                        }
                        if (distinationAccount == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDistination acount not found.!\n");
                            Console.ResetColor();
                           
                            return;
                        }

                        // Transfer the money
                        if (sourceAccount.Balance >= amount)
                        {
                            sourceAccount.Balance -= amount;
                            distinationAccount.Balance += amount;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n Money transferred successfully.\n");
                            Console.ResetColor();


                            // after tsransfered
                            distinationAccount.Balance += amount;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You transfered: {0} {1}    date and Time: {2} \n", amount, sek, transforeTime);
                            Console.ResetColor();
                            Console.WriteLine("Source Acount: {0:N2}", sourceAccount.Balance);
                            Console.WriteLine("Distination Acount: {0:N2}\n", distinationAccount.Balance);

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n Somthing went wrong please try again!\n");
                            Console.ResetColor();
                        }
                    }

                    void withdraMoney()
                    {
                       
                            //Withdra money from user accounts
                            Console.WriteLine("\n\n Enter account name to withdraw money from: ");
                            string sourceAccountName = Console.ReadLine();

                            Console.WriteLine("\nEnter amount you want to withdraw:");

                            double amount = double.Parse(Console.ReadLine());
                        
                            //Find the source and destination accounts
                            Account sourceAccount = null;
                        
                            foreach (Account acount in currentUser.Accounts)
                            {
                                if (acount.Name == sourceAccountName)
                                {
                                    sourceAccount = acount;
                                }
                              
                            }

                            //Check if the accounts were found
                            if (sourceAccount == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nSource acount not found!\n");
                                Console.ResetColor();

                                return;
                            }
                            //show dat and time 
                             DateTime today = DateTime.Now;

                        //pincod before withdra money


                        int tries = 3;
                        int pincount = 2;
                        startPin:
                       
                        string pin;
                        if (currentUser != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\nUse your Pin to complite the prosses.");
                            Console.ResetColor();
                           
                            pin = Console.ReadLine();
                            if (pin == currentUser.Password)
                            {
                              
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nNot correct pin please Try again. You have {0} tries more. ",tries);
                                Console.ResetColor();
                                tries--;

                                if (pincount == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n\nYou waiting time is 3 min before you can continiue.");
                                    Console.ResetColor();
                                    
                                    timer.timmer();
                                    goto startPin;
                                }
                               
                                pincount--;
                                goto startPin;
                            }
                            
                        }
                        //Withdraw the money
                         if (sourceAccount.Balance >= amount)
                        {
                                sourceAccount.Balance -= amount;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n Money Withdrawn successfully.\n");
                                Console.ResetColor();
                                Console.WriteLine("You withdrawn from: {0} {1:N2} {2}       -- Date andTime: {3}", sourceAccount.Name, amount,sek,today);
                         Console.WriteLine(" your new balance: {0:N2} {1} ", sourceAccount.Balance, sek);


                         }
                         else
                         {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n You dont have enough money. Please try agian your current blance is-----> : {0:N2} {1}! \n", sourceAccount.Balance, sek);
                                Console.ResetColor();
                         }
                        
                    }
                    
                    // choice 4
                    void exit()
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n Thank you that you using our service. you are wellcome back. (:\n");
                        Console.ResetColor();
                    }
                   

                }
            }
        }
    }
 }
 
