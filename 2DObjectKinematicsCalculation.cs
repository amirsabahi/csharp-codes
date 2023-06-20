using System;
/**
In this code, we define a Particle class that represents a particle in 2D space. It has properties for position (X and Y) and velocity (X and Y). 
The UpdatePosition method calculates the new position of the particle based on its velocity and the given time.

In the Main method, we create an instance of the Particle class, set its initial position and velocity, and then update its position for a specific time. 
You can modify the time variable to see how the position changes over time.
*/
public class Particle
{
    public double PositionX { get; set; }
    public double PositionY { get; set; }
    public double VelocityX { get; set; }
    public double VelocityY { get; set; }

    public void UpdatePosition(double time)
    {
        PositionX += VelocityX * time;
        PositionY += VelocityY * time;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Particle particle = new Particle();
        particle.PositionX = 0.0;
        particle.PositionY = 0.0;
        particle.VelocityX = 1.5;
        particle.VelocityY = 2.0;

        double time = 2.5; // Change this value to update the position for a different time

        Console.WriteLine($"Initial Position: ({particle.PositionX}, {particle.PositionY})");
        particle.UpdatePosition(time);
        Console.WriteLine($"Updated Position: ({particle.PositionX}, {particle.PositionY})");
    }
}
