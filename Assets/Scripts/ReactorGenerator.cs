using UnityEngine;


public class ReactorGenerator : GridMaker
{
    protected override void GenerateGrid(int rows, int columns, float offset)
    {
        base.GenerateGrid(rows, columns, offset);

        for (var i = 0; i < Sockets.Count; i++)
        {
            Sockets[i].GetComponent<Socket>().SetPosition(new Vector2(i / numberOfRows, i % numberOfColumns));
        }
    }
}
