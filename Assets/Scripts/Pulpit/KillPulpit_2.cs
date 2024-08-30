using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPulpit_2 : MonoBehaviour
{
    public Transform target;

    public float x, y, z;
    public float rand;

    void Start()
    {
        var pulpdata = transform.GetComponent<DiaryReader>().info.pulpit_data;

        x = pulpdata.pulpit_spawn_time;
        y = pulpdata.min_pulpit_destroy_time;
        z = pulpdata.max_pulpit_destroy_time;

        rand = Random.Range(y, z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rand -= Time.deltaTime;

        if (rand <= 2.5)
        {
            if (target.GetComponent<Renderer>().enabled == false)
            {
                target.GetComponent<KillPulpit_2>().rand = Random.Range(y, z);
                target.GetComponent<ScoreTracker>().flag = false;
                target.GetComponent<Renderer>().enabled = true;
            }
        }

        if (target.GetComponent<KillPulpit_2>().rand <= 0)
        {
            target.GetComponent<Renderer>().enabled = false;
            target.GetComponent<ChangeLocation>().placed = false;
        }
        
    }
}
