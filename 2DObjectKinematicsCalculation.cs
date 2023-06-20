using System;

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

        double time = 2.5; // Change this value to update position for a different time

        Console.WriteLine($"Initial Position: ({particle.PositionX}, {particle.PositionY})");
        particle.UpdatePosition(time);
        Console.WriteLine($"Updated Position: ({particle.PositionX}, {particle.PositionY})");
    }
}
