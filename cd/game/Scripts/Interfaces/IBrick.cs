using Godot;
using System;

/// <summary>
/// Interface for an in-game brick.
/// All forms of game bricks should extend this interface and override the Hit function.
/// This is called by a Ball upon collision.
/// </summary>
public interface IBrick
{
    /// <summary>
    /// Hit function for signalling when the ball has collided with the object.
    /// </summary>
    void Hit(Ball ball);
}