using Godot;
using GodotUtilities;
using Godot.Collections;
using System;

namespace HD2D.Components;

[GlobalClass]
public partial class SpawnerComponent : Node2D
{
	[Export] public PackedScene Scene { get; set; }

	public Node Spawn()
	{
		var instance = Scene.Instantiate();

		GetTree().CurrentScene.AddChild(instance);
		instance.Set(PropertyName.GlobalPosition, GlobalPosition);

		return instance;
	}
}
