using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboManager : MonoBehaviour
{
    [SerializeField] Text txtCombo = null;

    public static int currentCombo = 0;
    public static int maxCombo = 0;
    
    private void Start()
    {
        txtCombo.gameObject.SetActive(true);
    }

    public void IncreaseCombo(int p_num = 1)
    {
        currentCombo += p_num;
        txtCombo.text = string.Format("{0:#,##0}", currentCombo);
        if (currentCombo > maxCombo)
        {
            maxCombo = currentCombo;
        }
    }

    public void ResetCombo()
    {
        currentCombo = 0;
        txtCombo.text = "0";
    }

    public int GetCurrentCombo()
    {
        return currentCombo;
    }

    public int GetMaxCombo()
    {
        return maxCombo;
    }
}