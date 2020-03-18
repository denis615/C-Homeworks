using System;

namespace Heroes_Journey
{
    class Program
    {


        static void Main(string[] args)
        {
            
            int health = 0;

            int winningScore = 0;
        //Create Arrays to keep the passwords and emails:

        startCode:

            string[] arrayEmails = new string[2];
            arrayEmails[0] = "denis615@gmail.com";
            arrayEmails[1] = "bobbobsky@gmail.com";
            string[] arrayPasswords = new string[2];
            arrayPasswords[0] = "helloSedc123";
            arrayPasswords[1] = "helloFromBob";
            string emailCheck;
            string passwordCheck;
            //Request Email and Pasword from the User
            Console.WriteLine("Please Enter Email");
            emailCheck = Console.ReadLine();
            Console.WriteLine("Please enter Password");
            passwordCheck = Console.ReadLine();
            //Create a initializer for the loops
            int i = 0;



            //Function to check wheter the emails and passwords are correct
            bool PasswordEMailCheck1(string email, string password)
            {
                if (email == "denis615@gmail.com" && password == "helloSedc123")
                {
                    return true;
                }
                else if (email == "bobbobsky@gmail.com" && password == "helloFromBob")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            //If the email/pasword is wrong
            if (PasswordEMailCheck1(emailCheck, passwordCheck) == false)
            {
                while (i <= 5)
                {
                    Console.Clear();

                    Console.WriteLine("Wrong Email please enter Email again");
                    emailCheck = Console.ReadLine();
                    Console.WriteLine("Please Enter Password Again");
                    passwordCheck = Console.ReadLine();


                    if (i == 5)
                    {
                        Console.WriteLine("You entered the Wrong Email/Password too many times Goodbye");
                        Environment.Exit(0);
                    }
                }
            }
            //If the email/password is correct
            if (PasswordEMailCheck1(emailCheck, passwordCheck) == true)
            {
                Console.Clear();

                Console.WriteLine("Welcome to The Mighty Journey of the Heroes");
                Console.WriteLine("In order to prevail on this mighty journey, please enter your name:");
                string charName = Console.ReadLine();
                //Checking the length of the String
                bool charCheck(string player)
                {
                    if (player.Length <= 1)
                    {
                        return false;
                    }
                    if (player.Length >= 20)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                int secondInitialiser = 0;

                //If the Length of the String is not what we want then the program should do this-->
                while (charCheck(charName) == false)
                {

                    {
                        Console.Clear();

                        Console.WriteLine("The Name of the player is either to short or too long");
                        Console.WriteLine("Please Enter your name again");
                        charName = Console.ReadLine();
                        secondInitialiser++;
                    }
                    if (secondInitialiser == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("We don't have time for your tricks Goodbye");
                        Environment.Exit(0);
                    }
                }
                //If we are satisfied from the length then-->









                if (charCheck(charName) == true)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome o mighty " + charName);
                    Console.WriteLine("Please Choose your Race");
                    Console.WriteLine("1) " + Dwarf.Description);
                    Console.WriteLine("2) " + Human.Description);
                    Console.WriteLine("3) " + Elf.Description);
                    string raceChosen = Console.ReadLine();


                    bool raceCheck(string race)
                    {
                        if (race == "1")
                        {
                            return true;
                        }
                        if (race == "2")
                        {
                            return true;
                        }
                        if (race == "3")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }



                    int thirdInitialiser = 0;
                    if (raceCheck(raceChosen) == false)
                    {
                        while (raceCheck(raceChosen) == false)
                        {
                            Console.Clear();
                            Console.WriteLine("You have Entered a wrong number or Character Please try again");
                            Console.WriteLine("Please Choose your Race");
                            Console.WriteLine("1) " + Dwarf.Description);
                            Console.WriteLine("2) " + Human.Description);
                            Console.WriteLine("3) " + Elf.Description);
                            raceChosen = Console.ReadLine();
                            thirdInitialiser++;


                            if (thirdInitialiser == 5)
                            {

                                Console.WriteLine("We don't have time for your games bye bye");
                                Environment.Exit(0);
                            }
                        }
                    }
                    if (raceCheck(raceChosen) == true)
                    {
                        if (raceChosen == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You have Chosen the Race of the " + Dwarf.Description);



                        }

                        if (raceChosen == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("You Have Chosen The Race of the " + Human.Description);

                        }

                        if (raceChosen == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("You Have Chosen the Race of the " + Elf.Description);

                        }
                        Console.Clear();
                        Console.WriteLine("Now You Need to Choose your Class");
                        Console.WriteLine("1) Warrior");
                        Console.WriteLine("+20 Health -1 Agility");
                        Console.WriteLine("2) Rogue ");
                        Console.WriteLine("-20 Health +1 Agility");
                        Console.WriteLine("3) Mage");
                        Console.WriteLine("+20 Health -1Strength");


                        string typeofWarrior = Console.ReadLine();

                        bool CheckWarrior(String warrior)
                        {
                            if (warrior == "1")
                            {
                                return true;
                            }
                            if (warrior == "2")
                            {
                                return true;
                            }
                            if (warrior == "3")
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                        if (CheckWarrior(typeofWarrior) == false)
                        {
                            int warriorinitialiser = 0;
                            while (warriorinitialiser < 5)
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong Warrior Selected Please choose again");
                                Console.WriteLine("1) Warrior");
                                Console.WriteLine("+20 Health -1 Agility");
                                Console.WriteLine("2) Rogue ");
                                Console.WriteLine("-20 Health +1 Agility");
                                Console.WriteLine("3) Mage");
                                Console.WriteLine("+20 Health -1Strength");


                                typeofWarrior = Console.ReadLine();

                                warriorinitialiser++;
                            }
                        }

                        string[] warriors = new string[3];
                        warriors[0] = "Warrior";
                        warriors[1] = "Rogue";
                        warriors[2] = "Mage";


                        if (CheckWarrior(typeofWarrior) == true)
                        {


                            if (typeofWarrior == "1")
                            {
                                Dwarf.Health += 20;
                                Dwarf.Agility += -1;
                                Elf.Health += 20;
                                Elf.Agility += -1;
                                Human.Health += 20;
                                Human.Agility += -1;
                            }
                            if (typeofWarrior == "2")
                            {
                                Dwarf.Health += -20;
                                Dwarf.Agility += 61;
                                Elf.Health += -20;
                                Elf.Agility += +1;
                                Human.Health += -20;
                                Human.Agility += +1;
                            }
                            if (typeofWarrior == "3")
                            {
                                Dwarf.Health += 20;
                                Dwarf.Strength += -1;
                                Elf.Health += 20;
                                Elf.Strength += -1;
                                Human.Health += 20;
                                Human.Strength += -1;
                            }


                            Console.WriteLine("Successfuly Created  Character");
                            if (raceChosen == "1")
                            {
                                if (typeofWarrior == "1")
                                {
                                    Console.Clear();
                                    Console.Write(charName + " ");
                                    Console.Write(warriors[0] + " ");
                                    Console.Write(Dwarf.Name);
                                    Console.WriteLine();
                                    Console.Write(Dwarf.Health + " HP");
                                    Console.Write(" " + Dwarf.Strength + " STR");
                                    Console.Write(" " + Dwarf.Agility + " AGI");
                                    Console.ReadLine();
                                    CharacterBuilt.Health = Dwarf.Health;
                                    CharacterBuilt.Strength = Dwarf.Strength;
                                    CharacterBuilt.Agility = Dwarf.Agility;


                                }
                                if (typeofWarrior == "2")
                                {
                                    Console.Clear();
                                    Console.Write(charName + " ");
                                    Console.Write(warriors[1] + " ");
                                    Console.Write(Dwarf.Name);
                                    Console.WriteLine();
                                    Console.Write(Dwarf.Health + " HP");
                                    Console.Write(" " + Dwarf.Strength + " STR");
                                    Console.Write(" " + Dwarf.Agility + " AGI");
                                    Console.ReadLine();
                                    CharacterBuilt.Health = Dwarf.Health;
                                    CharacterBuilt.Strength = Dwarf.Strength;
                                    CharacterBuilt.Agility = Dwarf.Agility;


                                }
                                if (typeofWarrior == "3")
                                {
                                    Console.Clear();
                                    Console.Write(charName + " ");
                                    Console.Write(warriors[2] + " ");
                                    Console.Write(Dwarf.Name);
                                    Console.WriteLine();
                                    Console.Write(Dwarf.Health + " HP");
                                    Console.Write(" " + Dwarf.Strength + " STR");
                                    Console.Write(" " + Dwarf.Agility + " AGI");
                                    Console.ReadLine();
                                    CharacterBuilt.Health = Dwarf.Health;
                                    CharacterBuilt.Strength = Dwarf.Strength;
                                    CharacterBuilt.Agility = Dwarf.Agility;


                                }


                            }
                            if (raceChosen == "2")
                            {
                                if (typeofWarrior == "1")
                                {
                                    Console.Clear();
                                    Console.Write(charName + " ");
                                    Console.Write(warriors[0] + " ");
                                    Console.Write(Human.Name);
                                    Console.WriteLine();
                                    Console.Write(Human.Health + " HP");
                                    Console.Write(" " + Human.Strength + " STR");
                                    Console.Write(" " + Human.Agility + " AGI");
                                    Console.ReadLine();
                                    CharacterBuilt.Health = Human.Health;
                                    CharacterBuilt.Strength = Human.Strength;
                                    CharacterBuilt.Agility = Human.Agility;


                                }
                                if (typeofWarrior == "2")
                                {
                                    Console.Clear();
                                    Console.Write(charName + " ");
                                    Console.Write(warriors[1] + " ");
                                    Console.Write(Human.Name);
                                    Console.WriteLine();
                                    Console.Write(Human.Health + " HP");
                                    Console.Write(" " + Human.Strength + " STR");
                                    Console.Write(" " + Human.Agility + " AGI");
                                    Console.ReadLine();
                                    CharacterBuilt.Health = Human.Health;
                                    CharacterBuilt.Strength = Human.Strength;
                                    CharacterBuilt.Agility = Human.Agility;


                                }
                                if (typeofWarrior == "3")
                                {
                                    Console.Clear();
                                    Console.Write(charName + " ");
                                    Console.Write(warriors[2] + " ");
                                    Console.Write(Human.Name);
                                    Console.WriteLine();
                                    Console.Write(Human.Health + " HP");
                                    Console.Write(" " + Human.Strength + " STR");
                                    Console.Write(" " + Human.Agility + " AGI");
                                    Console.ReadLine();
                                    CharacterBuilt.Health = Human.Health;
                                    CharacterBuilt.Strength = Human.Strength;
                                    CharacterBuilt.Agility = Human.Agility;


                                }


                            }
                            if (raceChosen == "3")
                            {
                                if (typeofWarrior == "1")
                                {
                                    Console.Clear();
                                    Console.Write(charName + " ");
                                    Console.Write(warriors[0] + " ");
                                    Console.Write(Elf.Name);
                                    Console.WriteLine();
                                    Console.Write(Elf.Health + " HP");
                                    Console.Write(" " + Elf.Strength + " STR");
                                    Console.Write(" " + Elf.Agility + " AGI");
                                    CharacterBuilt.Health = Elf.Health;
                                    CharacterBuilt.Strength = Elf.Strength;
                                    CharacterBuilt.Agility = Elf.Agility;



                                }
                                if (typeofWarrior == "2")
                                {
                                    Console.Clear();
                                    Console.Write(charName + " ");
                                    Console.Write(warriors[1] + " ");
                                    Console.Write(Elf.Name);
                                    Console.WriteLine();
                                    Console.Write(Elf.Health + " HP");
                                    Console.Write(" " + Elf.Strength + " STR");
                                    Console.Write(" " + Elf.Agility + " AGI");
                                    CharacterBuilt.Health = Elf.Health;
                                    CharacterBuilt.Strength = Elf.Strength;
                                    CharacterBuilt.Agility = Elf.Agility;

                                }
                                if (typeofWarrior == "3")
                                {
                                    Console.Clear();
                                    Console.Write(charName + " ");
                                    Console.Write(warriors[2] + " ");
                                    Console.Write(Elf.Name);
                                    Console.WriteLine();
                                    Console.Write(Elf.Health + " HP");
                                    Console.Write(" " + Elf.Strength + " STR");
                                    Console.Write(" " + Elf.Agility + " AGI");
                                    CharacterBuilt.Health = Elf.Health;
                                    CharacterBuilt.Strength = Elf.Strength;
                                    CharacterBuilt.Agility = Elf.Agility;


                                }




                            }

                            Random r = new Random();
                            _ = r.Next();
                            int eventRand = r.Next();
                            string answer;
                            bool answerCheck(string smth)
                            {
                                if (smth == "1")
                                {
                                    return true;
                                }
                                if (smth == "2")
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }

                            }


                            health = CharacterBuilt.Health;


                            Console.Clear();
                            while (health >= 1)
                            {
                                eventRand = r.Next(0, 5);

                                int genRand = r.Next(0, 10);
                                if (eventRand == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(Event1.Description);
                                    Console.WriteLine("Press 1 to Fight, or Press 2 to run away");
                                    answer = Console.ReadLine();
                                    while (answerCheck(answer) == false)
                                    {

                                        Console.Clear();
                                        Console.WriteLine("Wrong Number or key pressed try again");
                                        Console.WriteLine(Event1.Description);
                                        Console.WriteLine("Press 1 to Fight, or Press 2 to run away");
                                        answer = Console.ReadLine();


                                    }
                                    if (answerCheck(answer) == true)
                                    {

                                        if (answer == "1")
                                        {

                                            if (genRand <= CharacterBuilt.Strength)
                                            {
                                                Console.WriteLine("You won the fight");
                                                winningScore++;
                                            }
                                            else if(genRand>CharacterBuilt.Strength)
                                            {
                                                health = health - Event1.HealthEvent;
                                                Console.WriteLine("You lost the fight now your health is" + health);
                                            }
                                            if (answer == "2")
                                            {
                                                if (genRand <= CharacterBuilt.Agility)
                                                {
                                                    Console.WriteLine("You Successfully Evaded Them");
                                                    winningScore++;
                                                }
                                                else
                                                {
                                                    health = health - Event1.HealthEvent;
                                                    Console.WriteLine("You lost the fight now your health is" + health);
                                                }

                                            }

                                        }
                                    }
                                }
                                if (eventRand == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine(Event2.Description);
                                    Console.WriteLine("Press 1 to Fight, or Press 2 to run away");
                                    answer = Console.ReadLine();
                                    while (answerCheck(answer) == false)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Wrong Number or key pressed try again");
                                        Console.WriteLine(Event2.Description);
                                        Console.WriteLine("Press 1 to Fight, or Press 2 to run away");
                                        answer = Console.ReadLine();
                                    }
                                    if (answerCheck(answer) == true)
                                    {

                                        if (answer == "1")
                                        {
                                            if (genRand <= CharacterBuilt.Strength)
                                            {
                                                Console.WriteLine("You won the fight");
                                                winningScore++;
                                            }
                                            else
                                            {
                                                health = health - Event2.HealthEvent;
                                                Console.WriteLine("You lost the fight now your health is" + health);
                                            }
                                            if (answer == "2")
                                            {
                                                if (genRand <= CharacterBuilt.Agility)
                                                {
                                                    Console.WriteLine("You Successfully Evaded Them");
                                                    winningScore++;
                                                }
                                                else
                                                {
                                                    health = health - Event2.HealthEvent;
                                                    Console.WriteLine("You lost the fight now your health is" + health);
                                                }

                                            }

                                        }
                                    }


                                }
                               

                                if (eventRand == 3)
                                {
                                    Console.Clear();

                                    Console.WriteLine(Event3.Description);
                                    Console.WriteLine("Press 1 to Fight, or Press 2 to run away");
                                    answer = Console.ReadLine();
                                    while (answerCheck(answer) == false)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Wrong Number or key pressed try again");
                                        Console.WriteLine(Event3.Description);
                                        Console.WriteLine("Press 1 to Fight, or Press 2 to run away");
                                        answer = Console.ReadLine();
                                    }
                                    if (answerCheck(answer) == true)
                                    {

                                        if (answer == "1")
                                        {
                                            if (genRand <= CharacterBuilt.Strength)
                                            {
                                                Console.WriteLine("You won the fight");
                                                winningScore++;
                                            }
                                            else
                                            {
                                                health = health - Event3.HealthEvent;
                                                Console.WriteLine("You lost the fight now your health is" + health);
                                            }
                                            if (answer == "2")
                                            {
                                                if (genRand <= CharacterBuilt.Agility)
                                                {
                                                    Console.WriteLine("You Successfully Evaded Them");
                                                    winningScore++;
                                                }
                                                else
                                                {
                                                    health = health - Event3.HealthEvent;
                                                    Console.WriteLine("You lost the fight now your health is" + health);
                                                }

                                            }

                                        }
                                    }


                                }

                                if (eventRand == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine(Event4.Description);
                                    Console.WriteLine("Press 1 to Fight, or Press 2 to run away");
                                    answer = Console.ReadLine();
                                    while (answerCheck(answer) == false)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Wrong Number or key pressed try again");
                                        Console.WriteLine(Event4.Description);
                                        Console.WriteLine("Press 1 to Fight, or Press 2 to run away");
                                        answer = Console.ReadLine();
                                    };
                                    if (answerCheck(answer) == true)
                                    {

                                        if (answer == "1")
                                        {
                                            if (genRand <= CharacterBuilt.Strength)
                                            {
                                                Console.WriteLine("You won the fight");
                                                winningScore++;
                                            }
                                            else
                                            {
                                                health = health - Event4.HealthEvent;
                                                Console.WriteLine("You lost the fight now your health is" + health);
                                            };
                                            if (answer == "2")
                                            {
                                                if (genRand <= CharacterBuilt.Agility)
                                                {
                                                    Console.WriteLine("You Successfully Evaded Them");
                                                }
                                                else
                                                {
                                                    health = health - Event4.HealthEvent;
                                                    Console.WriteLine("You lost the fight now your health is" + health);
                                                    winningScore++;
                                                };

                                            };

                                        };
                                    };

                                    
                                };

                                if (eventRand == 5)
                                {
                                    Console.Clear();
                                    genRand = r.Next(1, 10);
                                    Console.WriteLine(Event5.Description);
                                    Console.WriteLine("Press 1 to Fight, or Press 2 to run away");
                                    answer = Console.ReadLine();
                                    while (answerCheck(answer) == false)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Wrong Number or key pressed try again");
                                        Console.WriteLine(Event5.Description);
                                        Console.WriteLine("Press 1 to Fight, or Press 2 to run away");
                                        answer = Console.ReadLine();
                                    };
                                    if (answerCheck(answer) == true)
                                    {

                                        if (answer == "1")
                                        {
                                            if (genRand <= CharacterBuilt.Strength)
                                            {
                                                Console.WriteLine("You won the fight");
                                                winningScore++;
                                            }
                                            else
                                            {
                                                health = health - Event5.HealthEvent;
                                                Console.WriteLine("You lost the fight now your health is" + health);
                                            };
                                            if (answer == "2")
                                            {
                                                if (genRand <= CharacterBuilt.Agility)
                                                {
                                                    Console.WriteLine("You Successfully Evaded Them");
                                                    winningScore++;
                                                }
                                                else
                                                {
                                                    health = health - Event5.HealthEvent;
                                                    Console.WriteLine("You lost the fight now your health is" + health);
                                                };

                                            };

                                        };
                                    };


                                };
                            };
                        };
                    };
                };
                if (health <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("YOU LOST");

                    Console.WriteLine("Press 1 to restart the game or 2 to quit!");
                    string restartOrNot = Console.ReadLine();

                    if (restartOrNot == "1")
                    {

                        goto startCode;
                    };

                    if (restartOrNot == "2")
                    {
                        Environment.Exit(0);
                    };


                };



                if (winningScore == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Yaaaaay You Won the Game");
                    Console.WriteLine("Press 1 to restart the game or 2 to quit!");
                    string restartOrNot1 = Console.ReadLine();
                    if (restartOrNot1 == "1")
                    {

                        goto startCode;
                    };

                    if (restartOrNot1 == "2")
                    {
                        Environment.Exit(0);
                    };
                };

            };
        }




    }
}