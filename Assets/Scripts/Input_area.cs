using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_area : MonoBehaviour
{
    [SerializeField] 
    private Text Answer;

    public void Number(int number)
    {
        Answer.text += number.ToString();
    }
}
