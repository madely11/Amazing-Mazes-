using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreHandler : MonoBehaviour
{
    List<HighScoreElement> highScoreList = new List<HighScoreElement>();
    //[SerializeField] int maxCount = 10;
    //[SerializeField] string filename;

    //public delegate void OnHighScoreListChanged(List<HighScoreElement> list);
   // public static event OnHighScoreListChanged onHighScoreListChanged;

    private void Start()
    {
        //LoadHighScores();
    }

    //private void LoadHighScores()
    //{
    //    //highScoreList = FileHandler.ReadListFromJSON<HighScoreElement>(filename);

    //    /* while(highScoreList.Count > maxCount)
    //     {
    //         highScoreList.RemoveAt(maxCount);
    //     }*/
    //    highScoreList.Add(new HighScoreElement("made", "100.5", 4));
    //    highScoreList.Add(new HighScoreElement("pablo", "26.6", 3));
    //    foreach (var p in highScoreList)
    //    {
    //        Debug.Log("Person = " + p.personName);
    //    }
        
    //    /*if (OnHighScoreListChanged != null)
    //    {
    //        OnHighScoreListChanged.Invoke(highScoreList);
    //    }*/

    //    HighScoreUI objUI = new HighScoreUI();
    //    objUI.UpdateUI(highScoreList);

    //}

    private void SaveHighScore()
    {

    }

    
}
