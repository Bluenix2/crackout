using Godot;
using System;

public class Ball : KinematicBody2D
{
    private int screenHeight = (int)ProjectSettings.GetSetting("display/window/size/height");
    /// <summary> Internal variable for continuing movement </summary>
    private Vector2 velocity = new Vector2();

    /// <summary> The chosen speed at which the ball should move </summary>
    [Export]
    public int Speed;

    public override void _PhysicsProcess(float delta)
    {
        var collisionInfo = MoveAndCollide(velocity * delta);
        if (collisionInfo != null)
        {
            if (collisionInfo.Collider is Brick brick)
            {
                brick.Hit();
            }
            
            // Bounce ball, will keep moving if not executed
            velocity = velocity.Bounce(collisionInfo.Normal);
        }
        // Ball is under screen. Sprite should be added to the calculation in the future.
        if (Position.y > screenHeight)
        {
            QueueFree();
        }
    }
}
