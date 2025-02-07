using UnityEngine;
using TMPro;

public class GuessTheNumber : MonoBehaviour
{
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField guessInputField;
    int numberToGuess;
    int lives;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameSetup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameSetup()
    {
        lives = 3;
        numberToGuess = Random.Range(1, 10 + 1);
        header.text = $"I'm thinking of a number between 1 and 10. You have {lives} attempts to guess it...";
        guessInputField.text = "";
    }
}
