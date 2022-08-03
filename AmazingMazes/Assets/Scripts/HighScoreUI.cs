using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUI : MonoBehaviour
{
    ///[SerializeField] 
    public GameObject panel;
    public GameObject highscoreUIElementPrefab;
    public Transform elementWrapper;

    List<HighScoreElement> highScoreList = new List<HighScoreElement>();

    List<GameObject> uiElements = new List<GameObject>();

    //private void OnEnable()
    // {
    //     HighScoreHandler.onHighScoreListChanged += UpdateUI; 
    // }

    // private void OnDisable()
    // {
    //     HighScoreHandler.onHighScoreListChanged -= UpdateUI;
    // }
    private void Start()
    {
        highScoreList.Add(new HighScoreElement("made", "100.5", 4));
        highScoreList.Add(new HighScoreElement("pablo", "26.6", 3));
        UpdateUI();
    }

    public void UpdateUI ()
    {
        /*foreach (var p in list)
        {
            Debug.Log("Person = " + p.personTime);
        }*/

        for (int i=0; i < highScoreList.Count; i++)
        {
            HighScoreElement el = highScoreList[i]; 
            /*el.personName = "made2";
            el.personTime = "0.0";
            el.personScore = 30;*/
            //el.personName = list[i].personName;
             
            if(i >= uiElements.Count)
            {
                //highscoreUIElementPrefab = Resources.Load<GameObject>("HighScoreElement") as GameObject;
                var inst = Instantiate(highscoreUIElementPrefab, Vector3.zero, Quaternion.identity);
                inst.transform.SetParent (elementWrapper, false);
                uiElements.Add(inst);
            }

            var texts = uiElements[i].GetComponentsInChildren<Text> ();
            texts[0].text = el.personName;
            texts[1].text = el.personScore.ToString();
            texts[2].text = el.personTime;
        }
    }
}
