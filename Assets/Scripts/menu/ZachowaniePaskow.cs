/*

using UnityEngine;

public class ZachowaniePaskow : MonoBehaviour
{
    public static ZachowaniePaskow Instance; // Singleton

    public float poziomGlodu = 100f; // Poziom g�odu
    public float poziomSnu = 100f; // Poziom snu
    public float poziomPicia = 100f; // Poziom picia

    public float czasSpadku = 5f; // Czas, w kt�rym pe�na warto�� wska�nika spada o spadekGlodu/spadekSnu/spadekPicia
    public float spadekGlodu = 5f; // Ile % g�odu spada w ci�gu `czasSpadku`
    public float spadekSnu = 3f; // Ile % snu spada w ci�gu `czasSpadku`
    public float spadekPicia = 4f; // Ile % picia spada w ci�gu `czasSpadku`

    private const float MAX_POZIOM = 100f; // Maksymalna warto�� wska�nik�w

    private void Awake()
    {
        // Upewnij si�, �e istnieje tylko jedna instancja
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Nie niszcz obiektu podczas zmiany sceny
        }
        else
        {
            Destroy(gameObject); // Usu� drug� instancj�, je�li ju� istnieje
        }
    }

    private void Update()
    {
        // Aktualizuj wska�niki w czasie rzeczywistym
        AktualizujPoziomy();
    }

    public void AktualizujPoziomy()
    {
        // P�ynne zmniejszanie poziom�w na podstawie Time.deltaTime
        poziomGlodu -= (spadekGlodu / czasSpadku) * Time.deltaTime;
        poziomSnu -= (spadekSnu / czasSpadku) * Time.deltaTime;
        poziomPicia -= (spadekPicia / czasSpadku) * Time.deltaTime;

        // Zapewnij, �e warto�ci nie spadn� poni�ej 0
        poziomGlodu = Mathf.Clamp(poziomGlodu, 0f, MAX_POZIOM);
        poziomSnu = Mathf.Clamp(poziomSnu, 0f, MAX_POZIOM);
        poziomPicia = Mathf.Clamp(poziomPicia, 0f, MAX_POZIOM);

        // Debugging, aby zobaczy� warto�ci w konsoli
        Debug.Log($"G��d: {poziomGlodu}, Sen: {poziomSnu}, Picie: {poziomPicia}");
    }

    // Metody do odnawiania wska�nik�w
    public void Odn�wGlod(float ile)
    {
        poziomGlodu = Mathf.Clamp(poziomGlodu + ile, 0f, MAX_POZIOM); // Ograniczenie do zakresu 0-100
    }

    public void Odn�wSen(float ile)
    {
        poziomSnu = Mathf.Clamp(poziomSnu + ile, 0f, MAX_POZIOM); // Ograniczenie do zakresu 0-100
    }

    public void Odn�wPicie(float ile)
    {
        poziomPicia = Mathf.Clamp(poziomPicia + ile, 0f, MAX_POZIOM); // Ograniczenie do zakresu 0-100
    }
}

*/

using UnityEngine;

public class ZachowaniePaskow : MonoBehaviour
{
    public static ZachowaniePaskow Instance; // Singleton

    public float poziomGlodu = 100f; // Poziom g�odu
    public float poziomSnu = 100f; // Poziom snu
    public float poziomPicia = 100f; // Poziom picia

    public float czasSpadku = 5f; // Czas, w kt�rym pe�na warto�� wska�nika spada o spadekGlodu/spadekSnu/spadekPicia
    public float spadekGlodu = 5f; // Ile % g�odu spada w ci�gu `czasSpadku`
    public float spadekSnu = 3f; // Ile % snu spada w ci�gu `czasSpadku`
    public float spadekPicia = 4f; // Ile % picia spada w ci�gu `czasSpadku`

    private const float MAX_POZIOM = 100f; // Maksymalna warto�� wska�nik�w

    private float poprzedniGlod = 100f;
    private float poprzedniSen = 100f;
    private float poprzedniePicie = 100f;

    private void Awake()
    {
        // Upewnij si�, �e istnieje tylko jedna instancja
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Nie niszcz obiektu podczas zmiany sceny
        }
        else
        {
            Destroy(gameObject); // Usu� drug� instancj�, je�li ju� istnieje
        }
    }

    private void Update()
    {
        // Aktualizuj wska�niki w czasie rzeczywistym
        AktualizujPoziomy();
    }

    public void AktualizujPoziomy()
    {
        // P�ynne zmniejszanie poziom�w na podstawie Time.deltaTime
        poziomGlodu -= (spadekGlodu / czasSpadku) * Time.deltaTime;
        poziomSnu -= (spadekSnu / czasSpadku) * Time.deltaTime;
        poziomPicia -= (spadekPicia / czasSpadku) * Time.deltaTime;

        // Zapewnij, �e warto�ci nie spadn� poni�ej 0
        poziomGlodu = Mathf.Clamp(poziomGlodu, 0f, MAX_POZIOM);
        poziomSnu = Mathf.Clamp(poziomSnu, 0f, MAX_POZIOM);
        poziomPicia = Mathf.Clamp(poziomPicia, 0f, MAX_POZIOM);

        // Wy�wietl w Konsoli co 5% zmiany
        SprawdzZmiane();
    }

    private void SprawdzZmiane()
    {
        if (Mathf.Abs(poprzedniGlod - poziomGlodu) >= 1f)
        {
            Debug.Log($"G��d: {poziomGlodu}");
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

    // Metody do odnawiania wska�nik�w
    public void Odn�wGlod(float ile)
    {
        poziomGlodu = Mathf.Clamp(poziomGlodu + ile, 0f, MAX_POZIOM);
    }

    public void Odn�wSen(float ile)
    {
        poziomSnu = Mathf.Clamp(poziomSnu + ile, 0f, MAX_POZIOM);
    }

    public void Odn�wPicie(float ile)
    {
        poziomPicia = Mathf.Clamp(poziomPicia + ile, 0f, MAX_POZIOM);
    }
}
