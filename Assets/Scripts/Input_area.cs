using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Input_area : MonoBehaviour
{
    [SerializeField] 
    public TMP_Text Answer;
    public int maxCharacterLimit = 6;
    public string pin = "5";
    
    [SerializeField] 
    private Animator animation;

    public void Number(int number)
    {
        Debug.Log("Number() wurde aufgerufen mit: " + number);
         // Text hinzufügen
        Answer.text += number.ToString();

        // Überprüfen, ob die maximale Zeichenanzahl überschritten wurde
        if (Answer.text.Length > maxCharacterLimit)
        {
            // Die erste Ziffer entfernen, um Platz für die neue hinzugefügte Ziffer zu machen
            Answer.text = Answer.text.Substring(1);
        }
    }

    public void Confirm(){
        if(Answer.text == pin){
            Answer.text = "Richtig!";
            animation.SetBool("isOpen", true);
        }
        else
        {
            Answer.text = "Falsch!";
            StartCoroutine(ResetAnswerText());
        }
    }
    IEnumerator ResetAnswerText(){
        yield return new WaitForSeconds(2f);
        Answer.text = "";
    }    
}
