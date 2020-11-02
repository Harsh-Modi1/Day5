using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEg2
{
    class InterviewRound1
    {
        //virtual or abstract method cant be private,it can be internal,protected,public,and protected internal
        internal virtual void Result()
        {
            Console.WriteLine("Round 1 -- Cleared : 7/10");

        }
        public int Score()
        {
            return 7;
        }
    }
    class InterviewRound2:InterviewRound1
    {
        //virtual or abstract method cant be private,it can be internal,protected,public,and protected internal
        internal override void Result()
        {
            base.Result();  //to execute round 1 result
            Console.WriteLine("Round 2 --Cleared : 9/10");

        }
        //Hiding method : new memory is created :we are not overriding here
        public new int Score()
        {
            return 8;
        }
    }
    class InterviewRound3 : InterviewRound2
    {
        //virtual or abstract method cant be private,it can be internal,protected,public,and protected internal
        internal override void Result()
        {
            base.Result();  //to execute round 2 result
            Console.WriteLine("Round 3 --Not Cleared : 4/10");

        }
    }
    class VirtualEg
    {
        static void Main()
        {
            InterviewRound1 r1 = new InterviewRound1();
            // r1.Result();
           Console.WriteLine("Round 1 score: {0}", r1.Score());

            InterviewRound2 r2 = new InterviewRound2();
            // r2.Result();*/
            Console.WriteLine("Round 2 score: {0}", r2.Score());

            InterviewRound3 r3 = new InterviewRound3();
            r3.Result();

            Console.Read();
        }
    }
}
