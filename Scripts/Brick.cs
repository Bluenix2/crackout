using Godot;
using System;

/// <summary> The most basic brick. Deleted immediately on collision.
public class Brick : StaticBody2D, IBrick
{
    /// <summary>
    /// Hit function for signalling when the ball has collided with the brick, instantly deleting it.
    /// </summary>
    public void Hit(Ball ball)
    {
        // Safely delete
        QueueFree();
    }
}
