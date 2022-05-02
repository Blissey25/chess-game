using Godot;
using System;

public class BoardLane : Control
{
    [Export]
    int index = 0;

    [Export]
    bool isRow = false;

    (int, int) globalPosition = (-1, -1);

    public void _on_Lane_mouse_entered()
    {
        if (isRow) {
            (int previousX, int _) = globalPosition;
            globalPosition = (previousX, index);
        } else
        {
            (int _, int previousY) = globalPosition;
            globalPosition = (index, previousY);
        }
        GD.Print(globalPosition);
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(isRow);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
