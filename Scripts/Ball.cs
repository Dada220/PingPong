using Godot;
using System;

namespace Game;

public partial class Ball : CharacterBody2D
{
	Vector2 position;
	
	public override void _Ready()
	{
		Vector2 position = Position;
	}

	public void _Move(Vector2 new_position)
	{
		position = new_position;
		Position = position;
	}
	
	public Vector2 _Pos()
	{
		position = Position;
		return position;
	}
}
