using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int NumberOfWay;
    public int[] NumberOfWayPoint = new int[100];
    public float[,] PositionOfPoints_x = new float[100, 100];
    public float[,] PositionOfPoints_y = new float[100, 100];
    public float[,] PositionOfPoints_z = new float[100, 100];

    public PlayerData (Player player)
    {
        NumberOfWay = player.ImageControllerScript.Index;

       for( int i =0; i <= NumberOfWay; i++)
        {
            NumberOfWayPoint[i] = player.ImageControllerScript.NumberOfWayPoint[i];
        }

        for (int i = 0; i <= NumberOfWay; i++)
        {
            for (int j = 0; j <= NumberOfWayPoint[i]; j++)
            {
                PositionOfPoints_x[i, j] = player.ImageControllerScript.PositionOfPoints_x[i, j];
                PositionOfPoints_y[i, j] = player.ImageControllerScript.PositionOfPoints_y[i, j];
                PositionOfPoints_z[i, j] = player.ImageControllerScript.PositionOfPoints_z[i, j];
            }
        }
    }
}
