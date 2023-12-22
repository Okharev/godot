using Godot;
using System;

public partial class PlayerCamera : Camera2D
{
	[Export] public const int MAX_DISTANCE = 48;
	[Export] public float TargetDistance = 0;
	[Export] public Vector2 CenterPos = Vector2.Zero;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var direction = CenterPos.DirectionTo(GetLocalMousePosition());
		var TargetPos = CenterPos + direction * TargetDistance;

		TargetPos = TargetPos.Clamp(
			CenterPos - new Vector2(MAX_DISTANCE, MAX_DISTANCE),
			CenterPos + new Vector2(MAX_DISTANCE, MAX_DISTANCE)
		);

		Position = TargetPos;
	}

	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventMouseMotion)
			TargetDistance = CenterPos.DistanceTo(GetLocalMousePosition()) / 3;
	}
}
