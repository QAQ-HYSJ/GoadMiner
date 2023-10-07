using Godot;
using System;

[GlobalClass]
public partial class ItemProperties : Resource
{
    public enum ValueLevel { low, mid, high }
    public enum SizeLevel { small, big }
    [Export(PropertyHint.Range, "0, 100,")] public int Weight { get; set; }
    [Export] public int Value;

    /// <summary>
    /// 影响钩中时的音效
    /// </summary>
    [Export] public ValueLevel valueLevel;
    [Export] public Vector2 Offect;

    /// <summary>
    /// 影响钩中时的钩子形状
    /// </summary>
    [Export] public SizeLevel sizeLevel;
}
