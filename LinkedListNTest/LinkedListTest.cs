using LinkedListDemo;
using NUnit.Framework;

namespace LinkedListNTest
{
    public class Tests
    {
        LinkedList list = new LinkedList();

        [Test]
        //By this test case we can search the element
        public void SearchLinkedListToFindNode_ReturnsTrueIfPresent()
        {
            //Add values to list 
            list.Add(56);
            list.Add(30);
            list.Add(70);

            //search element
            Node node = list.Search(30);

            //Act or return result
            Assert.AreEqual(30, node.data);
            Assert.Pass();
        }

        [Test]
        public void InsertElementInLinkedList_ReturnsTrueIfPresent()
        {
            //Add values to list 
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertAtParticularPosition(2, 40);

            Node node = list.Search(40);
            
            //Act or return result
            Assert.AreEqual(40, node.data);
            Assert.Pass();
        }
    }
}