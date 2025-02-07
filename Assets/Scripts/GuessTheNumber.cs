using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GuessTheNumber : MonoBehaviour
{
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField guessInputField;
    [SerializeField] Button submitButton;
    int numberToGuess;
    int attempts;

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
        attempts = 3;
        numberToGuess = Random.Range(1, 10 + 1);
        header.text = $"I'm thinking of a number between 1 and 10. You have {attempts} attempts to guess it...";
        guessInputField.text = "";
        guessInputField.enabled = true;
        submitButton.enabled = true;
    }

    public void SubmitGuess()
    {
        // Input validation
        if (guessInputField.text.Trim().Length == 0)
        {
            header.text = "Please type in a number.";
            return;
        }
        // Win condition
        if (numberToGuess == int.Parse(guessInputField.text))
        {
            header.text = $"You got it right with {attempts} attempts left! The number was {numberToGuess}.";
            guessInputField.enabled = false;
            submitButton.enabled = false;
        }
        else
        {
            attempts--;
            // Lose condition
            if (attempts == 0)
            {
                header.text = $"Game over. The number was {numberToGuess}.";
                guessInputField.enabled = false;
                submitButton.enabled = false;
            }
            else
            {
                header.text = $"Nope! You have {attempts} attempts left! Try again.";
            }
        }
    }
}
