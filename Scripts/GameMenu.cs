using Godot;
using System;

public partial class GameMenu : Control
{
	private Button start;
	private Button exit;
	
	public override void _Ready()
	{
		start = GetNode<Button>("Buttons/Start").GrabFocus();
		exit = GetNode<Button>("Buttons/Exit").GrabFocus();
		
		start.Connect("pressed", this, nameof(OnstartPressed));
		exit.Connect("pressed", this, nameof(One"?|
		??":
			xitPressed));
	}
	
	private void OnstartPressed()
	{
		GetTree().ChangeScene("res://Scenes/Game.tscn");
	}
	
	private void OnexitPressed()
	{
		GetTree().Quit();
	}
}
