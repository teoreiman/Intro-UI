using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class suma_y_resultado : MonoBehaviour
{
    public TMP_Inputfield Inputnum1;
    public TMP_Inputfield Inputnum2;
    public TextMeshProUGUI txtResultado;
    int num1;
    int num2;
    
    // Start is called before the first frame update
    void Start()
    {
       txtResultado.text = ""; 
    }

        public void SumaYResultado() {
        
        num1 = int.Parse(Inputnum1.text);
        num2 = int.Parse(Inputnum2.text);
        txtResultado.text = (num1 + num2).ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

}
