using Godot;
using Godot.Collections;
using HD2D.Resources;
using System;

namespace HD2D.Components;

[Tool]
[GlobalClass]
public partial class InputComponent : Node2D
{
    [Export] public MoveComponent MoveComponent { get; set; }

    [Export] public MoveStatsResource StatsResource { get; set; }

    public override void _Process(double delta)
    {
        var velocity = Vector2.Zero;

        if (Input.IsKeyPressed(Key.D))
            velocity.X += (float)(StatsResource.Speed * delta);

        if (Input.IsKeyPressed(Key.Q))
            velocity.X -= (float)(StatsResource.Speed * delta);

        if (Input.IsKeyPressed(Key.S))
            velocity.Y += (float)(StatsResource.Speed * delta);

        if (Input.IsKeyPressed(Key.Z))
            velocity.Y -= (float)(StatsResource.Speed * delta);

        MoveComponent.Velocity = velocity.Normalized();
    }
}
