using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveAnchor : MonoBehaviour
{
    private Button Button;

    private ImageController ImageControllerScript;

    void Start()
    {
        ImageControllerScript = FindObjectOfType<ImageController>();

        Button = GetComponent<Button>();
        Button.onClick.AddListener(AnchorEnables);
    }

    // Данный скрипт отвечает за сохранение положения гизмо
    private void AnchorEnables()
    {
        ImageControllerScript.SaveAnchor = true;
    }
     public static PlayerData LoadPlayer(Player player)
    {
        var data = new PlayerData(player);
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            stream.Close();
            
            /*путь 1*/
            data.PositionOfPoints_x[0,0] = -1f;
            data.PositionOfPoints_y[0, 0] = -0.5f;
            data.PositionOfPoints_z[0, 0] = -1f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0,1] = -1f;
            data.PositionOfPoints_y[0, 1] = -0.5f;
            data.PositionOfPoints_z[0, 1] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0,2] = -1f;
            data.PositionOfPoints_y[0, 2] = -0.5f;
            data.PositionOfPoints_z[0, 2] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0,3] = -2f;
            data.PositionOfPoints_y[0, 3] = -0.5f;
            data.PositionOfPoints_z[0, 3] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0,4] = -3f;
            data.PositionOfPoints_y[0, 4] = -0.5f;
            data.PositionOfPoints_z[0, 4] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0,5] = -4f;
            data.PositionOfPoints_y[0, 5] = -0.5f;
            data.PositionOfPoints_z[0, 5] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 6] = -5f;
            data.PositionOfPoints_y[0, 6] = -0.5f;
            data.PositionOfPoints_z[0, 6] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 7] = -6f;
            data.PositionOfPoints_y[0, 7] = -0.5f;
            data.PositionOfPoints_z[0, 7] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 8] = -7f;
            data.PositionOfPoints_y[0, 8] = -0.5f;
            data.PositionOfPoints_z[0, 8] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 9] = -8f;
            data.PositionOfPoints_y[0, 9] = -0.5f;
            data.PositionOfPoints_z[0, 9] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 10] = -9f;
            data.PositionOfPoints_y[0, 10] = -0.5f;
            data.PositionOfPoints_z[0, 10] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 12] = -10f;
            data.PositionOfPoints_y[0, 12] = -0.5f;
            data.PositionOfPoints_z[0, 12] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 13] = -11f;
            data.PositionOfPoints_y[0, 13] = -0.5f;
            data.PositionOfPoints_z[0, 13] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 14] = -12f;
            data.PositionOfPoints_y[0, 14] = -0.5f;
            data.PositionOfPoints_z[0, 14] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 15] = -13f;
            data.PositionOfPoints_y[0, 15] = -0.5f;
            data.PositionOfPoints_z[0, 15] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 16] = -14f;
            data.PositionOfPoints_y[0, 16] = -0.5f;
            data.PositionOfPoints_z[0, 16] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 17] = -15f;
            data.PositionOfPoints_y[0, 17] = -0.5f;
            data.PositionOfPoints_z[0, 17] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 18] = -16f;
            data.PositionOfPoints_y[0, 18] = -0.5f;
            data.PositionOfPoints_z[0, 18] = -2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 19] = -16f;
            data.PositionOfPoints_y[0, 19] = -0.5f;
            data.PositionOfPoints_z[0, 19] = -1f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 20] = -16f;
            data.PositionOfPoints_y[0, 20] = -0.5f;
            data.PositionOfPoints_z[0, 20] = 0;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 21] = -16f;
            data.PositionOfPoints_y[0, 21] = -0.5f;
            data.PositionOfPoints_z[0, 21] = 1f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 22] = -16f;
            data.PositionOfPoints_y[0, 22] = 0;
            data.PositionOfPoints_z[0, 22] = 2f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 23] = -16f;
            data.PositionOfPoints_y[0, 23] = 0;
            data.PositionOfPoints_z[0, 23] = 3f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 24] = -16f;
            data.PositionOfPoints_y[0, 24] = 0;
            data.PositionOfPoints_z[0, 24] = 4f;
            data.NumberOfWayPoint[0]++;
            data.PositionOfPoints_x[0, 25] = -16f;
            data.PositionOfPoints_y[0, 25] = 0;
            data.PositionOfPoints_z[0, 25] = 5f;
            data.NumberOfWayPoint[0]++;
            data.NumberOfWay++;
            
            /*part 2*/
            data.PositionOfPoints_x[1,0] = -1f;
            data.PositionOfPoints_y[1, 0] = -0.5f;
            data.PositionOfPoints_z[1, 0] = -1f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1,1] = -1f;
            data.PositionOfPoints_y[1, 1] = -0.5f;
            data.PositionOfPoints_z[1, 1] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1,2] = -1f;
            data.PositionOfPoints_y[1, 2] = -0.5f;
            data.PositionOfPoints_z[1, 2] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1,3] = -2f;
            data.PositionOfPoints_y[1, 3] = -0.5f;
            data.PositionOfPoints_z[1, 3] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1,4] = -3f;
            data.PositionOfPoints_y[1, 4] = -0.5f;
            data.PositionOfPoints_z[1, 4] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1,5] = -4f;
            data.PositionOfPoints_y[1, 5] = -0.5f;
            data.PositionOfPoints_z[1, 5] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 6] = -5f;
            data.PositionOfPoints_y[1, 6] = -0.5f;
            data.PositionOfPoints_z[1, 6] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 7] = -6f;
            data.PositionOfPoints_y[1, 7] = -0.5f;
            data.PositionOfPoints_z[1, 7] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 8] = -7f;
            data.PositionOfPoints_y[1, 8] = -0.5f;
            data.PositionOfPoints_z[1, 8] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 9] = -8f;
            data.PositionOfPoints_y[1, 9] = -0.5f;
            data.PositionOfPoints_z[1, 9] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 10] = -9f;
            data.PositionOfPoints_y[1, 10] = -0.5f;
            data.PositionOfPoints_z[1, 10] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 12] = -10f;
            data.PositionOfPoints_y[1, 12] = -0.5f;
            data.PositionOfPoints_z[1, 12] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 13] = -11f;
            data.PositionOfPoints_y[1, 13] = -0.5f;
            data.PositionOfPoints_z[1, 13] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 14] = -12f;
            data.PositionOfPoints_y[1, 14] = -0.5f;
            data.PositionOfPoints_z[1, 14] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 15] = -13f;
            data.PositionOfPoints_y[1, 15] = -0.5f;
            data.PositionOfPoints_z[1, 15] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 16] = -14f;
            data.PositionOfPoints_y[1, 16] = -0.5f;
            data.PositionOfPoints_z[1, 16] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 17] = -15f;
            data.PositionOfPoints_y[1, 17] = -0.5f;
            data.PositionOfPoints_z[1, 17] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 18] = -16f;
            data.PositionOfPoints_y[1, 18] = -0.5f;
            data.PositionOfPoints_z[1, 18] = -2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 19] = -16f;
            data.PositionOfPoints_y[1, 19] = -0.5f;
            data.PositionOfPoints_z[1, 19] = -1f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 20] = -16f;
            data.PositionOfPoints_y[1, 20] = -0.5f;
            data.PositionOfPoints_z[1, 20] = 0;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 21] = -16f;
            data.PositionOfPoints_y[1, 21] = -0.5f;
            data.PositionOfPoints_z[1, 21] = 1f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 22] = -16f;
            data.PositionOfPoints_y[1, 22] = 0;
            data.PositionOfPoints_z[1, 22] = 2f;
            data.NumberOfWayPoint[1]++;
            data.PositionOfPoints_x[1, 23] = -16f;
            data.PositionOfPoints_y[1, 23] = 0;
            data.PositionOfPoints_z[1, 23] = 3f;
            data.NumberOfWayPoint[1]++;
            data.NumberOfWay++;
            return data;
        }
        else
        {
            Debug.LogError("Save file is not found in " + path);
            return null;
        }
    }
}
