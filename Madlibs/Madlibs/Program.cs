using System;

namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string adj1 = "crazy";
            string adj2 = "angry";
            string adj3 = "sweet";
            string adj4 = "cheesy";
            string noun1 = "monkey";
            string noun2 = "Michigan";
            string noun3 = "ball";
            string verb1Past = "ran";
            string verb2 = "whining";
            string verb3Past = "drove";
            string adverb1 = "shortly";
            string adverb2 = "hopefully";
          
            Console.WriteLine($"Today I went to the zoo. I saw a {adj1} {noun1} jumping up and down in its tree.\nHe {verb1Past} {adverb1} through the large tunnel that led to its {adj2} " +
                $"{noun2}.\nI got some peanuts and passed them through the cage to a gigantic gray {noun3} towering\nabove my head. Feeding that animal made me hungry. I went to get a " +
                $"{adj3} scoop of ice cream.\nIt filled my stomach. Afterwards I had to {verb2} {adverb2} to catch our bus.\nWhen I got home I {verb3Past} my mom for a {adj4} day at the zoo.");

        }
    }
}
