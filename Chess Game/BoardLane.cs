using Godot;
using System;

public class BoardLane : Control
{
    public (int, int) index = (0, 0);

    public void _on_Lane_mouse_entered()
    {
        Singleton.instance.mousePosition = index;
        GD.Print(index);
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
