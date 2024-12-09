/*

using UnityEngine;

public class ZachowaniePaskow : MonoBehaviour
{
    public static ZachowaniePaskow Instance; // Singleton

    public float poziomGlodu = 100f; // Poziom g³odu
    public float poziomSnu = 100f; // Poziom snu
    public float poziomPicia = 100f; // Poziom picia

    public float czasSpadku = 5f; // Czas, w którym pe³na wartoœæ wskaŸnika spada o spadekGlodu/spadekSnu/spadekPicia
    public float spadekGlodu = 5f; // Ile % g³odu spada w ci¹gu `czasSpadku`
    public float spadekSnu = 3f; // Ile % snu spada w ci¹gu `czasSpadku`
    public float spadekPicia = 4f; // Ile % picia spada w ci¹gu `czasSpadku`

    private const float MAX_POZIOM = 100f; // Maksymalna wartoœæ wskaŸników

    private void Awake()
    {
        // Upewnij siê, ¿e istnieje tylko jedna instancja
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Nie niszcz obiektu podczas zmiany sceny
        }
        else
        {
            Destroy(gameObject); // Usuñ drug¹ instancjê, jeœli ju¿ istnieje
        }
    }

    private void Update()
    {
        // Aktualizuj wskaŸniki w czasie rzeczywistym
        AktualizujPoziomy();
    }

    public void AktualizujPoziomy()
    {
        // P³ynne zmniejszanie poziomów na podstawie Time.deltaTime
        poziomGlodu -= (spadekGlodu / czasSpadku) * Time.deltaTime;
        poziomSnu -= (spadekSnu / czasSpadku) * Time.deltaTime;
        poziomPicia -= (spadekPicia / czasSpadku) * Time.deltaTime;

        // Zapewnij, ¿e wartoœci nie spadn¹ poni¿ej 0
        poziomGlodu = Mathf.Clamp(poziomGlodu, 0f, MAX_POZIOM);
        poziomSnu = Mathf.Clamp(poziomSnu, 0f, MAX_POZIOM);
        poziomPicia = Mathf.Clamp(poziomPicia, 0f, MAX_POZIOM);

        // Debugging, aby zobaczyæ wartoœci w konsoli
        Debug.Log($"G³ód: {poziomGlodu}, Sen: {poziomSnu}, Picie: {poziomPicia}");
    }

    // Metody do odnawiania wskaŸników
    public void OdnówGlod(float ile)
    {
        poziomGlodu = Mathf.Clamp(poziomGlodu + ile, 0f, MAX_POZIOM); // Ograniczenie do zakresu 0-100
    }

    public void OdnówSen(float ile)
    {
        poziomSnu = Mathf.Clamp(poziomSnu + ile, 0f, MAX_POZIOM); // Ograniczenie do zakresu 0-100
    }

    public void OdnówPicie(float ile)
    {
        poziomPicia = Mathf.Clamp(poziomPicia + ile, 0f, MAX_POZIOM); // Ograniczenie do zakresu 0-100
    }
}

*/

using UnityEngine;

public class ZachowaniePaskow : MonoBehaviour
{
    public static ZachowaniePaskow Instance; // Singleton

    public float poziomGlodu = 100f; // Poziom g³odu
    public float poziomSnu = 100f; // Poziom snu
    public float poziomPicia = 100f; // Poziom picia

    public float czasSpadku = 5f; // Czas, w którym pe³na wartoœæ wskaŸnika spada o spadekGlodu/spadekSnu/spadekPicia
    public float spadekGlodu = 5f; // Ile % g³odu spada w ci¹gu `czasSpadku`
    public float spadekSnu = 3f; // Ile % snu spada w ci¹gu `czasSpadku`
    public float spadekPicia = 4f; // Ile % picia spada w ci¹gu `czasSpadku`

    private const float MAX_POZIOM = 100f; // Maksymalna wartoœæ wskaŸników

    private float poprzedniGlod = 100f;
    private float poprzedniSen = 100f;
    private float poprzedniePicie = 100f;

    private void Awake()
    {
        // Upewnij siê, ¿e istnieje tylko jedna instancja
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Nie niszcz obiektu podczas zmiany sceny
        }
        else
        {
            Destroy(gameObject); // Usuñ drug¹ instancjê, jeœli ju¿ istnieje
        }
    }

    private void Update()
    {
        // Aktualizuj wskaŸniki w czasie rzeczywistym
        AktualizujPoziomy();
    }

    public void AktualizujPoziomy()
    {
        // P³ynne zmniejszanie poziomów na podstawie Time.deltaTime
        poziomGlodu -= (spadekGlodu / czasSpadku) * Time.deltaTime;
        poziomSnu -= (spadekSnu / czasSpadku) * Time.deltaTime;
        poziomPicia -= (spadekPicia / czasSpadku) * Time.deltaTime;

        // Zapewnij, ¿e wartoœci nie spadn¹ poni¿ej 0
        poziomGlodu = Mathf.Clamp(poziomGlodu, 0f, MAX_POZIOM);
        poziomSnu = Mathf.Clamp(poziomSnu, 0f, MAX_POZIOM);
        poziomPicia = Mathf.Clamp(poziomPicia, 0f, MAX_POZIOM);

        // Wyœwietl w Konsoli co 5% zmiany
        SprawdzZmiane();
    }

    private void SprawdzZmiane()
    {
        if (Mathf.Abs(poprzedniGlod - poziomGlodu) >= 1f)
        {
            Debug.Log($"G³ód: {poziomGlodu}");
            poprzedniGlod = poziomGlodu;
        }

        if (Mathf.Abs(poprzedniSen - poziomSnu) >= 30f)
        {
            Debug.Log($"Sen: {poziomSnu}");
            poprzedniSen = poziomSnu;
        }

        if (Mathf.Abs(poprzedniePicie - poziomPicia) >= 30f)
        {
            Debug.Log($"Picie: {poziomPicia}");
            poprzedniePicie = poziomPicia;
        }
    }

    // Metody do odnawiania wskaŸników
    public void OdnówGlod(float ile)
    {
        poziomGlodu = Mathf.Clamp(poziomGlodu + ile, 0f, MAX_POZIOM);
    }

    public void OdnówSen(float ile)
    {
        poziomSnu = Mathf.Clamp(poziomSnu + ile, 0f, MAX_POZIOM);
    }

    public void OdnówPicie(float ile)
    {
        poziomPicia = Mathf.Clamp(poziomPicia + ile, 0f, MAX_POZIOM);
    }
}
