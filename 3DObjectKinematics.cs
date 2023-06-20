using System;
/**
In this code, we have an enhanced Particle class that includes properties for the position (X, Y, and Z) and velocity (X, Y, and Z) in 3D space. 
The UpdatePosition method is modified to consider the additional velocity component.

The Main method creates a Particle object, sets its initial position and velocity, and updates the position for a given time. 
You can modify the time variable to observe how the position changes over time.
*/
public class Particle
{
    public double PositionX { get; set; }
    public double PositionY { get; set; }
    public double PositionZ { get; set; }
    public double VelocityX { get; set; }
    public double VelocityY { get; set; }
    public double VelocityZ { get; set; }

    public void UpdatePosition(double time)
    {
        PositionX += VelocityX * time;
        PositionY += VelocityY * time;
        PositionZ += VelocityZ * time;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Particle particle = new Particle();
        particle.PositionX = 0.0;
        particle.PositionY = 0.0;
        particle.PositionZ = 0.0;
        particle.VelocityX = 1.5;
        particle.VelocityY = 2.0;
        particle.VelocityZ = 0.5;

        double time = 2.5; // Change this value to update position for a different time

        Console.WriteLine($"Initial Position: ({particle.PositionX}, {particle.PositionY}, {particle.PositionZ})");
        particle.UpdatePosition(time);
        Console.WriteLine($"Updated Position: ({particle.PositionX}, {particle.PositionY}, {particle.PositionZ})");
    }
}
