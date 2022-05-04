using System;

public sealed class Singleton
{
    public (int, int) mousePosition = (-1, -1);
    public static Singleton instance = new Singleton();
}