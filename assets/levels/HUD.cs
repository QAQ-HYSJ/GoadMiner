using Godot;
using System;

public partial class HUD : CanvasLayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetNode<Label>("Level").Text = "第" + Global.CurrentLevel + "关";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GetNode<Label>("Label").Text = "剩余时间：" + (int)GetParent<Timer>().TimeLeft;
	}
}
