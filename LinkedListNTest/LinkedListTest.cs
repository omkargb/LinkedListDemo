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

            //Act or return
            Assert.AreEqual(30, node.data);
            Assert.Pass();
        }
    }
}