using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        startGame();
    }

    void startGame()
    {
        nextGuess();
    }

    public void onPressHigher()
    {
        min = guess;
        nextGuess();
    }

    public void onPressLower()
    {
        max = guess;
        nextGuess();
    }

    void nextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
