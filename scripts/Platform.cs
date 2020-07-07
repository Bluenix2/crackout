using Godot;
using System;

public class Platform : KinematicBody2D
{
    /// <summary> Internal variable for continuing movement </summary>
    private Vector2 velocity = new Vector2();
    /// <summary> The X direction at which we should move the next physics-frame </summary>
    public int Direction = 0;

    /// <summary> The chosen speed at which the ball should move </summary>
    [Export]
    public int Speed;

    // Process gets called every frame, this is also when input gets updated.
    // PhysicsProcess gets called at every physics frame, which is by default set to 60
    //     Therefor we update the direction each frame and move when all other objects moves which is during PhysicsProcess.
    //     Because they are unsynchronised.
    public override void _Process(float delta)
    {
        velocity.x = Speed * Direction;
    }
    public override void _PhysicsProcess(float delta)
    {
        velocity = MoveAndSlide(velocity);
    }
}
