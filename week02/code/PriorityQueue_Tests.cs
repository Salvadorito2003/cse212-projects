using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Try adding an item to the Queue.
    // Expected Result: Phone, Laptop, Computer
    // Defect(s) Found: Dequeue does not remove the item from the list. It only returns it
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Computer", 203);
        priorityQueue.Enqueue("Phone", 223);
        priorityQueue.Enqueue("Laptop", 213);
        List<string> expectedResult = ["Phone", "Laptop", "Computer"];
        for (int i = 0; i < 3; ++i)
        {
            var item = priorityQueue.Dequeue();
            
            var expectedItem = expectedResult[i];
            Assert.AreEqual(expectedItem, item);
        }
        
        
    }

    [TestMethod]
    // Scenario: Check to see if Dequeue gets the higher priority item
    // Expected Result: Phone gets dequeued
    // Defect(s) Found: Phone expected but is Computer
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Computer", 203);
        priorityQueue.Enqueue("Phone", 333);
        var item = priorityQueue.Dequeue();
        Assert.AreEqual("Phone", item);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: If there are more than 1 item with the same priority, the first one gets dequeued
    // Expected Result: Phone
    // Defect(s) Found: Item did not get dequeued from the queue.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Computer", 203);
        priorityQueue.Enqueue("Phone", 333);
        priorityQueue.Enqueue("Ipad", 333);
        var item = priorityQueue.Dequeue();
        Assert.AreEqual("Phone", item);
    }

    [TestMethod]
    // Scenario: If the queue is empty, then an error exception shall be thrown. 
    // Expected Result: The queue is empty
    // Defect(s) Found: No defects found
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });
    }
}