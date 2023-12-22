using Godot;
using System;

namespace HD2D;

public partial class Projectile : Node2D
{
	private VisibleOnScreenNotifier2D OffScreenNotifier;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		OffScreenNotifier = GetNode<VisibleOnScreenNotifier2D>("VisibleOnScreenNotifier2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (!OffScreenNotifier.IsOnScreen()) {
			QueueFree();
		}
	}
}
