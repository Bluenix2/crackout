using Godot;
using System;

/// <summary> The most basic brick. Deleted immediately on collision.
public class HealthBrick : StaticBody2D, IBrick
{
    [Export]
    private int health;
    /// <summary>
    /// Hit function for signalling when the ball has collided with the brick, instantly deleting it.
    /// </summary>
    public void Hit(Ball ball)
    {
        health -= 1;
        if (health == 0)
        {
            QueueFree();
        }
    }
}
