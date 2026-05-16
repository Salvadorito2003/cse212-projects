using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Try adding an Item
    // Expected Result: Item should be added
    // Defect(s) Found: No defects
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Computer", 203);
        var item = priorityQueue.Dequeue();
        Assert.AreEqual("Computer", item);
        
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
    // Expected Result: 
    // Defect(s) Found: 
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
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });
    }
}