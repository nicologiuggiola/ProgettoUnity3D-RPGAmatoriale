using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer (PlayerOne playerone)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerOneData oneData = new PlayerOneData(playerone);

        formatter.Serialize(stream, oneData);
        stream.Close();
    }

    public static PlayerOneData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerOneData oneData = formatter.Deserialize(stream) as PlayerOneData;
            stream.Close();

            return oneData;
        }
        else
        {
            Debug.LogError("Not Found" + path);
            return null;
        }
    }
}
