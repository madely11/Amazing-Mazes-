using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Newtonsoft.Json;

public class PersonVO : MonoBehaviour
{
    public PersonVO(string nickName, int score, string time)
    {
        this.nickName = nickName;
        this.score = score;
        this.time = time;
    }

    public string nickName { get; set; }
    public int score { get; set; }
    public string time { get; set; }

    public string serialize()
    {
        string json = "{\"nickName\":\"" + nickName + "\",\"score\":" + score + ",\"time\":\"" + time + "\"}";
        return json;
    }


    public string sayHi()
    {
        return "hi";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
