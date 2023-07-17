using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public static float score;
    private TextMeshProUGUI score_Text;
    void Start()
    {
        score = 0;
        score_Text = GetComponent<TextMeshProUGUI>();
        score_Text.textStyle = TMP_Style.NormalStyle;
        score_Text.fontStyle = FontStyles.Bold;
        score_Text.color = Color.red;

    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        score_Text.text = "Time\n" + (int)score;
    }
}

