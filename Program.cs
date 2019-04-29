using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<string> { "Adam", "Carly", "Aaron", "Rachel", "Jack" };
            var hometown = new List<string> { "Santa Monica", "Albany", "Burlington", "Detroit", "Austin" };
            var favoritefood = new List<string> { "Tacos", "Pizza", "Steak", "Pasta", "Chicken" };
            var favoritecolor = new List<string> { "Red", "Orange", "Yellow", "Green", "Purple" };

            while (true)
            {

                Console.WriteLine($"Welcome to our C# Class. Which student would you like to learn more about? Enter a number between 1 and {students.Count}.");
                var studentnumber = Console.ReadLine();
                if (int.TryParse(studentnumber, out var ParsedStudentNumber))
                {
                    var index = int.Parse(studentnumber) - 1;
                    if (ParsedStudentNumber >= 1 && ParsedStudentNumber <= (students.Count))
                    {
                        Console.WriteLine($"Student {studentnumber} is {students[index]}. Would you like to know their hometown, favorite food or favorite color? Press 1 for hometown, 2 for favorite food or 3 for favorite color.");
                        string HometownFavoriteFoodOrFavoriteColor = Console.ReadLine();
                        if (HometownFavoriteFoodOrFavoriteColor == "1")
                        {
                            Console.WriteLine($"{students[index]}'s is from {hometown[index]}.");
                        }
                        else if (HometownFavoriteFoodOrFavoriteColor == "2")
                        {
                            Console.WriteLine($"{students[index]}'s favorite food is {favoritefood[index]}.");
                        }
                        else if (HometownFavoriteFoodOrFavoriteColor == "3")
                        {
                            Console.WriteLine($"{students[index]}'s favorite color is {favoritecolor[index]}.");
                        }
                        else
                        {
                            Console.WriteLine("That input is not valid. Please select a valid input.");
                        }
                        Console.WriteLine("Would you like to add another student? Press y for yes and n for no");
                        var a = Console.ReadLine();
                        if (a.Equals("y",StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Enter a student's name.");
                            var newname = Console.ReadLine();
                            students.Add(newname);

                            if (string.IsNullOrWhiteSpace(newname))
                            {
                                Console.WriteLine("Entry cannot be blank. Please try again.");
                                break;
                            }

                            Console.WriteLine("Enter their hometown.");
                            var newhometown = Console.ReadLine();
                            hometown.Add(newhometown);

                            if (string.IsNullOrWhiteSpace(newhometown))
                            {
                                Console.WriteLine("Entry cannot be blank. Please try again.");
                                break;
                            }

                            Console.WriteLine("Enter their favorite food.");
                            var newfavoritefood = Console.ReadLine();
                            favoritefood.Add(newfavoritefood);

                            if (string.IsNullOrWhiteSpace(newfavoritefood))
                            {
                                Console.WriteLine("Entry cannot be blank. Please try again.");
                                break;
                            }

                            Console.WriteLine("Enter their favorite color.");
                            var newfavoritecolor = Console.ReadLine();
                            favoritecolor.Add(newfavoritecolor);

                            if (string.IsNullOrWhiteSpace(newfavoritecolor))
                            {
                                Console.WriteLine("Entry cannot be blank. Please try again.");
                                break;
                            }
                        }
                        Console.WriteLine("Would you like to learn about another student? Press y for yes and n for no");
                        var b = Console.ReadLine();
                        var result = TryContinue(b);

                        if (!result)
                        {
                            break;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"That is not a valid input. Please input a number between 1 and {students.Count}.");
                    }
                }
                else
                {
                    Console.WriteLine("You did not enter a valid input. Please try again");
                }
            }
            Console.WriteLine("Goodbye!");

        }
        static bool TryContinue(string a)
        {
            if (a.Equals("y",StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
