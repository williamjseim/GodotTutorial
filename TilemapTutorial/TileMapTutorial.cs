using Godot;
using Godot.Collections;
using System;

public partial class TileMapTutorial : TileMap
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("Debug"))
		{
			Array<Vector2I> pos = new Array<Vector2I> { this.LocalToMap(GetGlobalMousePosition()), };
			this.SetCellsTerrainConnect(0, pos, 0, 0);
		}

	}


}
