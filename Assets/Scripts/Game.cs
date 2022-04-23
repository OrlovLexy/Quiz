using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour 
{
    public QuestionList[] questions;
    public Text[] answersText;
    public Text qText;
    public GameObject pGame;

    List<object> qList;
    int randQ;

    public void OnClickPlay()
    {
        qList = new List<object>(questions);
        qustionGenerate();
        RectTransform pGameRectTransform = pGame.GetComponent<RectTransform>();
        pGameRectTransform.SetPositionAndRotation(new Vector3(0, 0, 0), new Quaternion());
        //qText.text = questions[Random.Range(0, questions.Length - 1)].question;
    }
    void qustionGenerate()
    {
        randQ = Random.Range(0, qList.Count);
        QuestionList crntQ = qList[randQ] as QuestionList;
        qText.text = crntQ.question;

        for (int i = 0; i < crntQ.answers.Length; i++) answersText[i].text = crntQ.answers[i];
    }
    public void answersBttn()
    {
        qList.RemoveAt(randQ);
        qustionGenerate();
    }
}
[System.Serializable]
public class QuestionList
{
    public string question;
    public string[] answers = new string[3];
}
