using Godot;
using System;

public class GridContainer : Godot.GridContainer
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    public void _on_GridContainer_mouse_exited()
    {
        Singleton.instance.mousePosition = (-1, -1);
        GD.Print("Out");
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                var scene = ResourceLoader.Load("res://BoardLane.tscn") as PackedScene;
                var square = scene.Instance() as BoardLane;
                square.index = (x, y);
                if (scene != null)
                    AddChild(square);
                else
                    GD.Print("Not of type PackedScene");
            }
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
