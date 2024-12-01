using UnityEngine;
using UnityEngine.UI;

public class ButtonTextChange : MonoBehaviour
{
    public Button myButton; // Referencja do przycisku

    public void ChangeButtonText()
    {
        // Pobierz komponent tekstowy z przycisku i zmieñ tekst
        myButton.GetComponentInChildren<Text>().text = "Naciœniêty!";
    }
}
