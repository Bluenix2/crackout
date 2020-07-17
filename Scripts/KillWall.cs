using Godot;
using System;

public class KillWall : Area2D
{
    public void _On_Body_Entered(Node body)
    {
        // Immediately mark for safe deletion
        body.QueueFree();
    }
}
