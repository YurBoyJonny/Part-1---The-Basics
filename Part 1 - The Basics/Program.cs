using System;

namespace Part1Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jonathan Cheung-Budd
            string firstName = "Jonathan";
            string favMovie = "THE MATRIX";
            Console.WriteLine("Hello " + firstName.ToLower() + ", your favorite movie is " + favMovie.ToLower());
            Console.WriteLine(favMovie.Contains("THE"));
            Console.WriteLine(favMovie.Replace("E", "3").Replace("A", "@"));

            string movieQuote = "There are simply too many notes.";
            Console.WriteLine(movieQuote.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("y", "").ToUpper());

            Console.WriteLine(@"
___.-''''-.
/___  @    |
',,,,.     |         _.'''''''._");
            Console.Write(@"     '     |        /           \                                 .--._.--.            
     |     \    _.- '             \                              ( O     O )
     |      '.-'                  '-.                            /   . .   \
     |                               ',                         .`._______.'.
     |                                '',                      / (           )\
      ',,-,                           ':;                     _/  \  \   /  /  \_
           ',,| ;,,                 ,' ; ;                 .~   `  \  \ /  / '   ~.
               ! ; !'',,,',',,,,'!  ;   ;:                {    -.   \  V  /   .-    }
             : ;  ! !       ! ! ;  ;   :;               _ _`.    \  |  |  |  /    .'_ _
             ; ;   ! !      ! !  ; ;   ;,              > _       _} |  |  | {_ _<
            ; ;    ! !     ! !   ; ;                     /. - ~ ,_-'  .^.  `-_, ~ - .\
            ; ;    ! !    ! !     ; ;                            '-'|/   \|`-`
            ;,,      !,!   !,!     ;,;
           /_I      L_I   L_I     /_I");

            Console.ReadLine();
        }
    }
}