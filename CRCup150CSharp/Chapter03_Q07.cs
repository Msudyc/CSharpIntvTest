/* Question 3.7
 
An animal shelter holds only dogs and cats, and operates on a strictly "first in, first out" basis.
People must adopt either the oldest (based on arrival time) of all animals at the shelter, or they can 
select whether they would perfer a dog or a cat (and will receive the oldest animal of that type). They
cannot select which specific animal they would like. Create the data structures to maintain this system
and implement operations such as enqueue, dequeueAny, dequeueDog, dequeueCat. You may use the built-in
LinkedList data structure.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter03_Q07
    {
        public class AnimalQueue
        {
            //private LinkedList<Dog> dogs = new LinkedList<Dog>();
            //private LinkedList<Cat> cats = new LinkedList<Cat>();
            //private int order = int.MaxValue;

            public void Enqueue(Animal a)
            {
                throw new NotImplementedException();
            }

            public Animal DequeueAny()
            {
                throw new NotImplementedException();
            }

            public Dog DequeueDogs()
            {
                throw new NotImplementedException();
            }

            public Cat DequeueCats()
            {
                throw new NotImplementedException();
            }
        }

        public abstract class Animal
        {
            public int Older { get; set; }
            public string Name { get; set; }
            public Animal(string name)
            {
                this.Name = name;
            }

            public bool IsOlderThan(Animal a)
            {
                return this.Older > a.Older;
            }
        }

        public class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
            }
        }

        public class Cat : Animal
        {
            public Cat(string name) : base(name)
            {
            }
        }
    }
}
