using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features { get; set; }
}

public class Feature
    {
        public Properties Properties {get; set;}

    }

public class Properties
{
    public double magnitude { get; set; }
    public string place { get; set; }
    public long time { get; set; }
}