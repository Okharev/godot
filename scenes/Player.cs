using Godot;
using GodotUtilities;
using HD2D.Components;
using System;

namespace HD2D;

public partial class Player : Node2D
{
	private AnimatedSprite2D PlayerSprite;
	private MoveComponent MovePlayer;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		MovePlayer = GetNode<MoveComponent>("MoveComponent");
		PlayerSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	public override void _Process(double delta)
	{
		// move animation logik
		if (MovePlayer.Velocity.Y < 0)
			PlayerSprite.Play("walk_back");

		if (MovePlayer.Velocity.Y > 0)
			PlayerSprite.Play("walk_front");

		if (MovePlayer.Velocity.X < 0)
			PlayerSprite.Play("walk_left");

		if (MovePlayer.Velocity.X > 0)
			PlayerSprite.Play("walk_right");

		// idle animation logitik
		if (MovePlayer.Velocity == Vector2.Zero)
			PlayerSprite.Play("idle_front");
	}
}
