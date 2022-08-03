using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using Newtonsoft.Json;

using System.Linq;
using System.Collections.Generic;

public class PersonBO
{
    private List<PersonVO> topTenPlayers;

    public List<PersonVO> TopTenPlayers { get => topTenPlayers; set => topTenPlayers = value; }

    public PersonBO()
    {
        topTenPlayers = new List<PersonVO>();
    }

    public void readTopTen()
    {
        PersonVO person;

        StreamReader r = new StreamReader("Resources/myHighScores.json");
        string jsonString = r.ReadLine();
        while (jsonString != null)
        {
            //Debug.Log("el json> " + jsonString);
            person = JsonConvert.DeserializeObject<PersonVO>(jsonString);
            TopTenPlayers.Add(person);
            jsonString = r.ReadLine();
        }
        r.Close();
    }

    public void printTop()
    {
        for (int i = 0; i < TopTenPlayers.Count; i++)
        {
            Debug.Log("el player " + topTenPlayers[i].score);
        }
    }

    public void writeFile()
    {
        readTopTen();
        PersonVO person = new PersonVO(GameStatus.Name, GameStatus.Score, GameStatus.Time.ToString());
        TopTenPlayers.Add(person);
        //ordenar el arreglo
        topTenPlayers = topTenPlayers.OrderByDescending(x => x.score).ToList();
        printTop();
        //escribir 10 mejores
        string path = "Resources/myHighScores.json";
        string line = "";
        
        int limit = topTenPlayers.Count > 10 ? 10 : topTenPlayers.Count;
        Debug.Log("el limit> " + limit);
        Debug.Log("el path> " + path);
        for (int i = 0; i < limit; i++)
        {
            line += topTenPlayers[i].serialize();
            if (i != limit - 1) { line += '\n'; }
            
        }
        System.IO.File.WriteAllText(path, line);
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
