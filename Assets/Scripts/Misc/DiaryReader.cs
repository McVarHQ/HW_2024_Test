using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryReader : MonoBehaviour
{
    [System.Serializable]
    public class PlayerData
    {
        public int speed;
    }

    [System.Serializable]
    public class PulpitData
    {
        public float min_pulpit_destroy_time;
        public float max_pulpit_destroy_time;
        public float pulpit_spawn_time;
    }

    [System.Serializable]
    public class InfoContainer
    {
        public PlayerData player_data;
        public PulpitData pulpit_data;
    }

    public TextAsset jsonFile;
    public InfoContainer info = new InfoContainer();

    void Awake()
    {
        info = JsonUtility.FromJson<InfoContainer>(jsonFile.text);
    }

}
