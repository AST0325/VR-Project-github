using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    Text text;
    public static int scoreAmount=0;
    ComboManager combo;

    // Start is called before the first frame update
    void Start()
    {
        combo=FindObjectOfType<ComboManager>();
        text = GetComponent<Text>();
        scoreAmount = 0;
    }

    public void IncreaseScore()
    {
        scoreAmount += 10;

        combo.IncreaseCombo();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        text.text = scoreAmount.ToString();
    }
}
