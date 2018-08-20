using System;

namespace CG_6_5_Horosocope
{
    class Program
    {
        static void Main(string[] args)
        {
            //Have the user type in their birthday
            Console.WriteLine("Your Horoscope");
            Console.WriteLine("Please enter your birthday in the form MM/DD/YYYY");

            //Convert the string that the user has typed to a datetime
            //Display it to the console in the ToLongDateString format 
            //so that it displays the day of the week
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("You were born on " + birthday.ToLongDateString());
        
            //Create a datetime that has the same month and day as the user's birthday,
            //but is one year later
            birthday = new DateTime(DateTime.Now.Year + 1, birthday.Month, birthday.Day);
            Console.WriteLine("Your next birthday will be on " + birthday.ToLongDateString());
            
            //use a while loops to check the birthday month
            while (birthday.Month == 3)
            {
                // use if statements to check the birthday day
                // and assign the correct astrological sign and horoscope
                if (birthday.Day >= 21 && birthday.Day <= 31 )
                {
                    Console.WriteLine("You are an Aries.");
                    Console.WriteLine("You have the best astrological sign ever. " +
                        "You will rule the world someday!");
                }
               

                else if (birthday.Day >= 1 && birthday.Day <= 20)
                {
                    Console.WriteLine("You are Pisces");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            while (birthday.Month == 2)
            {
                if (birthday.Day >= 1 && birthday.Day <= 18)
                {
                    Console.WriteLine("You are an Aquarius");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }

                else if (birthday.Day >= 19 && birthday.Day <= 28)
                {
                    Console.WriteLine("You are a Pisces");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            while (birthday.Month == 1)
            {
                if (birthday.Day >= 20 && birthday.Day <= 31)
                {
                    Console.WriteLine("You are an Aquarius");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }

                else if (birthday.Day >= 1 && birthday.Day <= 19)
                {
                    Console.WriteLine("You are an Capricorn");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            while (birthday.Month == 4)
            {
                if (birthday.Day >= 1 && birthday.Day <= 19)
                {
                    Console.WriteLine("You are an Aries.");
                    Console.WriteLine("You have the best astrological sign ever. " +
                        "You will rule the world someday!");
                }

                else if (birthday.Day >= 20 && birthday.Day <= 30)
                {
                    Console.WriteLine("You are an Taurus");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            while (birthday.Month == 5)
            {
                if (birthday.Day >= 21 && birthday.Day <= 31)
                {
                    Console.WriteLine("You are a Gemini");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }

                else if (birthday.Day >= 1 && birthday.Day <= 20)
                {
                    Console.WriteLine("You are an Taurus");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            while (birthday.Month == 6)
            {
                if (birthday.Day >= 21 && birthday.Day <= 30)
                {
                    Console.WriteLine("You are a Cancer");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }

                else if (birthday.Day >= 1 && birthday.Day <= 20)
                {
                    Console.WriteLine("You are a Gemini");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            while (birthday.Month == 7)
            {
                if (birthday.Day >= 23 && birthday.Day <= 31)
                {
                    Console.WriteLine("You are a Leo");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }

                else if (birthday.Day >= 1 && birthday.Day <= 22)
                {
                    Console.WriteLine("You are a Cancer");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            while (birthday.Month == 8)
            {
                if (birthday.Day >= 23 && birthday.Day <= 31)
                {
                    Console.WriteLine("You are a Virgo");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }

                else if (birthday.Day >= 1 && birthday.Day <= 22)
                {
                    Console.WriteLine("You are a Leo");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            while (birthday.Month == 9)
            {
                if (birthday.Day >= 23 && birthday.Day <= 30)
                {
                    Console.WriteLine("You are a Libra");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }

                else if (birthday.Day >= 1 && birthday.Day <= 22)
                {
                    Console.WriteLine("You are a Virgo");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            while (birthday.Month == 10)
            {
                if (birthday.Day >= 23 && birthday.Day <= 31)
                {
                    Console.WriteLine("You are a Scorpio");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }

                else if (birthday.Day >= 1 && birthday.Day <= 22)
                {
                    Console.WriteLine("You are a Libra");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            while (birthday.Month == 11)
            {
                if (birthday.Day >= 22 && birthday.Day <= 30)
                {
                    Console.WriteLine("You are a Sagittarius");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }

                else if (birthday.Day >= 1 && birthday.Day <= 21)
                {
                    Console.WriteLine("You are a Scorpio");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            while (birthday.Month == 12)
            {
                if (birthday.Day >= 22 && birthday.Day <= 31)
                {
                    Console.WriteLine("You are a Capricorn");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }

                else if (birthday.Day >= 1 && birthday.Day <= 21)
                {
                    Console.WriteLine("You are a Sagittarius");
                    Console.WriteLine("You're not as cool as the Aries, but you're ok.");
                }
                break;
            }

            Console.ReadLine();



        }
    }
}
