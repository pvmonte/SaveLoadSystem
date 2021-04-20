using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UgglaGames.SaveLoadSystem;

public class SaveLoadTest : MonoBehaviour
{
    [SerializeField] PlayerData player;
    [SerializeField] PlayerTransform playerTransform;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            ISaver saver = new SaverAsJson();
            //saver.Save(new PlayerData("Mioshi", 5), "playerData");
            saver.Save(new PlayerTransform(transform.position, transform.rotation, transform.localScale), "PlayerTransform");
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            ILoader loader = new LoaderFromJson();
            //player = loader.Load<PlayerData>("playerData");
            playerTransform = loader.Load<PlayerTransform>("PlayerTransform");
            transform.position = playerTransform.Position;
            transform.rotation = playerTransform.Rotation;
            transform.localScale = playerTransform.Scale;
        }
    }
}

[System.Serializable]
public class PlayerData
{
    [SerializeField] string name;
    [SerializeField] int level;

    public PlayerData(string name, int level)
    {
        this.name = name;
        this.level = level;
    }
}

[System.Serializable]
public class PlayerTransform
{
    [SerializeField] Vector3 position;
    [SerializeField] Quaternion rotation;
    [SerializeField] Vector3 scale;

    public PlayerTransform(Vector3 position, Quaternion rotation, Vector3 scale)
    {
        this.Position = position;
        this.Rotation = rotation;
        this.Scale = scale;
    }

    public Vector3 Position { get => position; set => position = value; }
    public Quaternion Rotation { get => rotation; set => rotation = value; }
    public Vector3 Scale { get => scale; set => scale = value; }
}
