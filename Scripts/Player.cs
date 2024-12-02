using Godot;
using System;

namespace Game;

public partial class Player : CharacterBody2D
{
	Vector2 position;
	[Export]
	public int Speed {get; set;} = 150;
	
	public void GetInput()
	{
		float _Direction = Input.GetAxis("Up","Down");
		Velocity = Transform.Y * _Direction * Speed;
	}
	
	public override void _Process(double delta)
	{
		GetInput();
		MoveAndSlide();
	}
	
	public Vector2 _Pos()
	{
		position = Position;
		return position;
	}
	
	public void _Move(Vector2 new_position)
	{
		position = new_position;
		Position = position;
	}
}
