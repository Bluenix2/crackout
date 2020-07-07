using Godot;
using System;

/// <summary>
/// Base brick class, extends StaticBody2D.
/// All forms of game bricks should extend this class and override the Hit function.
/// </summary>
public class Brick : StaticBody2D
{
    /// <summary>
    /// Hit function for signalling when the object has collided and thus hit by the ball.
    /// </summary>
    public void Hit()
    {
        // Safely delete
        QueueFree();
    }
}
