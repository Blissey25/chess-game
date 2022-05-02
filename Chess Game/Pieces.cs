using Godot;
using System;

public class Pieces : Node2D
{
    enum Piece
    {
        whitePawn,
        whiteRook,
        whiteBish,
        whiteKnight,
        whiteQueen,
        whiteKing,
        blackPawn,
        blackRook,
        blackBish,
        blackKnight,
        blackQueen,
        blackKing,

    }
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

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
