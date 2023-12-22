using Godot;
using Godot.Collections;
using System;

namespace HD2D.Resources;

[GlobalClass]
public partial class MoveStatsResource : Resource
{
    [Export] public int Speed { get; set; } = 5;
}
