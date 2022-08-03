using System;

[Serializable]
public class HighScoreElement {
    public string personName;
    public string personTime;
    public int personScore;

    public HighScoreElement(string name, string time, int score)
    {
        this.personName = name;
        this.personTime = time;
        this.personScore = score;
    }
}
