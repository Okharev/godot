using Godot;
using Godot.Collections;
using System;

namespace HD2D.Components;

[GlobalClass]
public partial class MoveComponent : Node2D
{
	[Export] public Node2D Actor { get; set; }
	[Export] public Vector2 Velocity { get; set; }

	public override void _Process(double delta) => Actor.Translate(Velocity);
}
