using Godot;
using System;

public class Game : Node2D
{
    public override void _Process(float delta)
    {
        // Platform movement
        var platform = GetNode("Platform") as Platform;
        if (platform != null)
        {
            if (Input.IsActionPressed("ui_right"))
            {
                platform.Direction = 1;
            }
            else if (Input.IsActionPressed("ui_left"))
            {
                platform.Direction = -1;
            }
            else
            {
                platform.Direction = 0;
            }
        }
    }
    public override void _Ready()
    {
        // Will load and instance bricks, and apply initial velocity on ball to start bounce.
    }
}
