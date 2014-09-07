/* Question 11.7
 
A circus is designing a tower routine consisting of people standing atop one another's shoulders.
For practical and aesthetic reasons, each person must be both shorter and lighter than the person
below him or her. Given the heights and weights of each person in the circus, write a method to 
compute the largest possible number of people in such a tower.
Example:
Input (ht, wt): (65, 100) (70, 150), (56, 90), (75, 190), (60, 95), (68, 110)
Output: (56, 90), (60, 95), (65, 100), (68, 110), (70, 150), 75, 190)
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter11_Q07
    {
        public static List<Person> CreateStackDP(List<Person> people)
        {
            throw new NotImplementedException();
        }

        public class Person
        {
            public Person(int h, int w)
            {
                this.Weight = w;
                this.Height = h;
            }

            public int Weight { get; set; }
            public int Height { get; set; }

            public bool CanBeAbove(Person person)
            {
                if (person == null)
                    return true;

                return this.Height < person.Height &&
                    this.Weight < person.Weight;
            }
        }
    }
}
