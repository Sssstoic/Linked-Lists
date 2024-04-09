using System;
using NUnit.Framework;
using Assignment3.Utility;
using Assignment3;

namespace Assignment3.Tests
{
    [TestFixture]
    public class LinkedListTest
    {
        private ILinkedListADT linkedList;

        [SetUp]
        public void Setup()
        {
            linkedList = new SLL();
        }

        [Test]
        public void TestIsEmpty()
        {
            Assert.IsTrue(linkedList.IsEmpty());
        }

        [Test]
        public void TestPrepend()
        {
            User user = new User(1, "Alice", "alice@example.com", "password");
            linkedList.AddFirst(user);
            Assert.AreEqual(user, linkedList.GetValue(0));
        }

        [Test]
        public void TestAppend()
        {
            User user = new User(1, "Alice", "alice@example.com", "password");
            linkedList.AddLast(user);
            Assert.AreEqual(user, linkedList.GetValue(0));
        }

        [Test]
        public void TestInsertAtIndex()
        {
            User user1 = new User(1, "Alice", "alice@example.com", "password");
            User user2 = new User(2, "Bob", "bob@example.com", "password");
            linkedList.AddFirst(user1);
            linkedList.Add(user2, 1);
            Assert.AreEqual(user2, linkedList.GetValue(1));
        }

        [Test]
        public void TestReplace()
        {
            User user1 = new User(1, "Alice", "alice@example.com", "password");
            User user2 = new User(2, "Bob", "bob@example.com", "password");
            linkedList.AddFirst(user1);
            linkedList.Replace(user2, 0);
            Assert.AreEqual(user2, linkedList.GetValue(0));
        }

        [Test]
        public void TestDeleteFromBeginning()
        {
            User user1 = new User(1, "Alice", "alice@example.com", "password");
            User user2 = new User(2, "Bob", "bob@example.com", "password");
            linkedList.AddFirst(user1);
            linkedList.AddLast(user2);
            linkedList.RemoveFirst();
            Assert.AreEqual(user2, linkedList.GetValue(0));
        }

        [Test]
        public void TestDeleteFromEnd()
        {
            User user1 = new User(1, "Alice", "alice@example.com", "password");
            User user2 = new User(2, "Bob", "bob@example.com", "password");
            linkedList.AddFirst(user1);
            linkedList.AddLast(user2);
            linkedList.RemoveLast();
            Assert.AreEqual(user1, linkedList.GetValue(0));
        }

        [Test]
        public void TestDeleteFromMiddle()
        {
            User user1 = new User(1, "Alice", "alice@example.com", "password");
            User user2 = new User(2, "Bob", "bob@example.com", "password");
            User user3 = new User(3, "Charlie", "charlie@example.com", "password");
            linkedList.AddFirst(user1);
            linkedList.AddLast(user3);
            linkedList.Add(user2, 1);
            linkedList.Remove(1);
            Assert.AreEqual(user3, linkedList.GetValue(1));
        }

        [Test]
        public void TestFindAndRetrieve()
        {
            User user = new User(1, "Alice", "alice@example.com", "password");
            linkedList.AddLast(user);
            Assert.AreEqual(user, linkedList.GetValue(linkedList.IndexOf(user)));
        }

        [Test]
        public void TestAdditionalFunctionality_IndexOf()
        {
            User user1 = new User(1, "Alice", "alice@example.com", "password");
            User user2 = new User(2, "Bob", "bob@example.com", "password");
            User user3 = new User(3, "Charlie", "charlie@example.com", "password");

            linkedList.AddFirst(user1);
            linkedList.AddLast(user2);
            linkedList.AddLast(user3);

            Assert.AreEqual(1, linkedList.IndexOf(user2));
        }

        [TearDown]
        public void TearDown()
        {
            linkedList.Clear();
        }
    }
}
