using PdpB27_Darslar.Lesson7.Collections;
using PdpB27_Darslar.Lesson7.Collections.MyCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdpB27_Darslar.Collections
{
    internal class Startup
    {
        public static void Start()
        {
            MyCollection<int> myCollection = new();

            myCollection.Add(1);
            myCollection.Add(2);

            Console.WriteLine(myCollection[0]);

            myCollection[1]=99;
            Console.WriteLine(myCollection[1]);

            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }
            //MyCollectionStart.Start();
            //ListNode l1 = new(-9)
            //{
            //    next = new ListNode(3)
            //};

            //ListNode l2 = new ListNode(5)
            //{
            //    next = new ListNode(7)
            //};
            //LinkedListExamples.MergeTwoLists(l1, l2);
            //HashStart();
            //MyArrayList.ArrayListStart();
            //MyArrayList.ListStart();
            //MyArrayList.QueueStart();
            //MyArrayList.StackStart();
            //CollectionsExamples.CallCustomCollections();
        }
        public static void HashStart()
        {
            HashExamples.Do();
        }
        
    }
}
