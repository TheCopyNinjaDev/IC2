using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


public class ReactorGenerator : GridMaker
{
    [FormerlySerializedAs("Original Sprite")] public Sprite originalSprite;
    
    public void ClearReactor()
    {
        foreach (var socket in Sockets)
        {
            socket.GetComponent<Image>().sprite = originalSprite;
        }
    }
    
    protected override void GenerateGrid(int rows, int columns, float offset)
    {
        base.GenerateGrid(rows, columns, offset);

        for (var i = 0; i < Sockets.Count; i++)
        {
            Sockets[i].GetComponent<Socket>().SetPosition(new Vector2(i / numberOfRows, i % numberOfColumns));
        }
    }
}
