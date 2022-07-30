using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button btnStart;
    public InputField nickname;

    // Start is called before the first frame update
    void Start()
    {
        GameStatus.Name = nickname.text;
    }

    public void SaveNickname()
    {
        Debug.Log("NickName = " + nickname.text);
    }
}
