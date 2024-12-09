using UnityEngine;

public class zmianaSkina : MonoBehaviour
{
    public GameObject kotNormalny; // Obiekt reprezentuj¹cy normalnego kota (KotO)
    public GameObject kotGlodny;   // Obiekt reprezentuj¹cy g³odnego kota (KotGlodny)

    public float prógGlodu = 30f;  // Próg g³odu, poni¿ej którego zmienia siê kot

    private void Start()
    {
        // Sprawdzenie, czy obiekty s¹ przypisane
        if (kotNormalny == null || kotGlodny == null)
        {
            Debug.LogError("Nie przypisano obiektów KotNormalny lub KotGlodny!");
            return;
        }

        // Na pocz¹tku poka¿ normalnego kota
        kotNormalny.SetActive(true);
        kotGlodny.SetActive(false);
    }

    private void Update()
    {
        // SprawdŸ aktualny poziom g³odu
        float poziomGlodu = ZachowaniePaskow.Instance.poziomGlodu;

        // Zmieñ widocznoœæ obiektów w zale¿noœci od poziomu g³odu
        if (poziomGlodu < prógGlodu)
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
            Debug.Log("Pokazano g³odnego kota.");
        }
    }
}
