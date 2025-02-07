using UnityEngine;
using TMPro;

public class GuessTheNumber : MonoBehaviour
{
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField guessInputField;
    int numberToGuess;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameSetup()
    {
        numberToGuess = Random.Range(int.MinValue, int.MaxValue);
        header.text = "I'm thinking of a number between 1 and 10. You have 3 attempts to guess it...";
        guessInputField.text = "";
    }
}
