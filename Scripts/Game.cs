using Godot;
using System;

namespace Game;

public partial class Game : Node
{
	[Export]
	public CharacterBody2D player;
	[Export]
	public CharacterBody2D enemy;
	[Export]
	public CharacterBody2D ball;
	
	Vector2 BallCords = new Vector2(640,360);
	Vector2 EnemyCords = new Vector2(1230, 360);
	Vector2 PlayerCords = new Vector2(50, 360);
	
	public override void _Ready()
	{
		ball.Position = BallCords;
		player.Position = PlayerCords;
		enemy.Position = EnemyCords;
	}
}
