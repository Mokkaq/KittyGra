using UnityEngine;

public class zmianaSkina : MonoBehaviour
{
    public GameObject kotNormalny; // Obiekt reprezentuj�cy normalnego kota (KotO)
    public GameObject kotGlodny;   // Obiekt reprezentuj�cy g�odnego kota (KotGlodny)

    public float pr�gGlodu = 30f;  // Pr�g g�odu, poni�ej kt�rego zmienia si� kot

    private void Start()
    {
        // Sprawdzenie, czy obiekty s� przypisane
        if (kotNormalny == null || kotGlodny == null)
        {
            Debug.LogError("Nie przypisano obiekt�w KotNormalny lub KotGlodny!");
            return;
        }

        // Na pocz�tku poka� normalnego kota
        kotNormalny.SetActive(true);
        kotGlodny.SetActive(false);
    }

    private void Update()
    {
        // Sprawd� aktualny poziom g�odu
        float poziomGlodu = ZachowaniePaskow.Instance.poziomGlodu;

        // Zmie� widoczno�� obiekt�w w zale�no�ci od poziomu g�odu
        if (poziomGlodu < pr�gGlodu)
        {
            PokazGlodnegoKota();
        }
        else
        {
            PokazNormalnegoKota();
        }
    }

    private void PokazNormalnegoKota()
    {
        if (!kotNormalny.activeSelf)
        {
            kotNormalny.SetActive(true);
            kotGlodny.SetActive(false);
            Debug.Log("Pokazano normalnego kota.");
        }
    }

    private void PokazGlodnegoKota()
    {
        if (!kotGlodny.activeSelf)
        {
            kotNormalny.SetActive(false);
            kotGlodny.SetActive(true);
            Debug.Log("Pokazano g�odnego kota.");
        }
    }
}
