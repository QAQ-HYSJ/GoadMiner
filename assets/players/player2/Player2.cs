using Godot;
using System;

public partial class Player2 : AnimatedSprite2D
{
	public int Money { get; set; }
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("player2Go"))
		{
			GetNode<SpacePlayer2.Hook>("Hook").GoHook();
		}
		QueueRedraw();
	}
	public override void _Draw()
	{
		DrawLine(new Vector2(-7, 11), GetNode<SpacePlayer2.Hook>("Hook").Position, new Color(0.2f, 0.2f, 0.2f), 1.0f);
	}
}
