using Godot;
using HD2D.Components;
using System;

namespace HD2D;

public partial class Player : Node2D
{
	private SpawnerComponent MuzzleLeft;
	private SpawnerComponent MuzzleRight;
	private Timer FireTimer;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		MuzzleLeft = GetNode<SpawnerComponent>("MuzzleLeft");
		MuzzleRight = GetNode<SpawnerComponent>("MuzzleRight");
		FireTimer = GetNode<Timer>("FireTimer");

		FireTimer.Timeout += FireLasers;
	}

	private void FireLasers()
	{
		MuzzleLeft.Spawn();
		MuzzleRight.Spawn();
	}
}
