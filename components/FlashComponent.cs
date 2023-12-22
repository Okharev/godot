using Godot;
using Godot.Collections;
using HD2D.Resources;
using System;

namespace HD2D.Components;

[GlobalClass]
public partial class FlashComponent : Node2D
{
    [Export] public Node2D Sprite { get; set; }
    [Export] public Vector2 ScaleRatio { get; set; } = new Vector2(1.5f, 1.5f);
    [Export] public double ScaleDuration { get; set; } = 0.3;

    public void TweenScale()
    {
        var tween = CreateTween().SetTrans(Tween.TransitionType.Expo).SetEase(Tween.EaseType.Out);

        tween.TweenProperty(Sprite, "scale", ScaleRatio, ScaleDuration * 0.1).FromCurrent();
        tween.TweenProperty(Sprite, "scale", Vector2.One, ScaleDuration * 0.9).From(ScaleRatio);
    }
}
