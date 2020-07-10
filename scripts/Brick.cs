using Godot;
using System;

/// <summary>
public class Brick : StaticBody2D, IBrick
{
    /// <summary>
    /// Hit function for signalling when the object has collided and thus hit by the ball.
    /// </summary>
    public void Hit(Ball ball)
    {
        // Safely delete
        QueueFree();
    }
}
