using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Cell
{
// coordinate represented x and y
private Vector2 position;

private bool isFree;

public bool IsFree
{
    get 
    {
return isFree;
    }
    set 
    {
        isFree = value;
    }
}
    public int x
    {
        get {return (int)position.x; }
    }

        public int y
    {
        get {return (int)position.y; }
    }

    public Cell(int x, int y, bool isFree)
    {
        position = new Vector2(x, y);
        IsFree = isFree;
    }
}