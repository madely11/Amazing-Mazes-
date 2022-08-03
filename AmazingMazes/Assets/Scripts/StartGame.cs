using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button btnStart;
    public Button btnHighScores;
    public InputField nickname;

    // Start is called before the first frame update
    void Start()
    {
        //GameStatus.Name = nickname.text;
        btnStart.onClick.AddListener(SaveNickname);
        btnHighScores.onClick.AddListener(OpenHighScores);
    }

    public void SaveNickname()
    {
        Debug.Log("NickName = " + nickname.text);
        GameStatus.Name = nickname.text;
        SceneManager.LoadScene("Scene1");
    }

    public void OpenHighScores()
    {
        SceneManager.LoadScene("HighScoreScene");
    }
}
