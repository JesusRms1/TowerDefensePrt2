using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
public class LivesUI : MonoBehaviour
{

    public TextMeshProUGUI livesText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = PlayerStats.Lives + "Lives";
    }
}
