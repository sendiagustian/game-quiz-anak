using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    public string[] quiz, answer;

    public Text textQuiz, textScore;

    public InputField inputAnswer;

    public GameObject feedTrue, feedFalse, bankQuiz, notification, btnReload, btnClose;

    int orderQuiz = -1, score = 0;

    // Start is called before the first frame update
    void Start()
    {
        showQuiz();
    }

    void showQuiz()
    {
        orderQuiz++;
        textQuiz.text = quiz[orderQuiz];
    }

    public void Answer()
    {
        if (inputAnswer.text == answer[orderQuiz])
        {
            feedTrue.gameObject.SetActive(false);
            feedTrue.gameObject.SetActive(true);
            feedFalse.gameObject.SetActive(false);
            score += 20;
        }
        else
        {
            feedTrue.gameObject.SetActive(false);
            feedFalse.gameObject.SetActive(false);
            feedFalse.gameObject.SetActive(true);
        }
        if (orderQuiz < quiz.Length - 1)
        {
            inputAnswer.text = "";
            showQuiz();
        }
        else
        {
            if (inputAnswer.text == answer[orderQuiz])
            {
                score += 20;
            }
            notification.gameObject.SetActive(true);
            bankQuiz.gameObject.SetActive(false);
            btnReload.gameObject.SetActive(true);
            btnClose.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = score.ToString();
    }
}
