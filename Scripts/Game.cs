using Godot;
using System;

public class Game : Node2D
{
    [Export]
    public NodePath platformPath;
    /// <summary>
    /// The platform controlled by the the player. Gets assigned at runtime when entering NodeTree from <see cref="platformPath"/> export
    /// </summary>
    private Platform platform;
    public override void _Process(float delta)
    {
        // Platform movement
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
        // Assign platform from platformPath export
        platform = GetNode(platformPath) as Platform;

        var ball = GetNode("Ball") as Ball;
        ball.Velocity = new Vector2(-250, -250);
    }
}
