/*using UnityEngine;

public class ZachowaniePaskow : MonoBehaviour
{
    public static ZachowaniePaskow Instance; // Singleton

    public float poziomGlodu = 100f; // Poziom g�odu
    public float poziomSnu = 100f; // Poziom snu
    public float poziomPicia = 100f; // Poziom picia

    public float czasSpadku = 5f; // Co ile sekund potrzeby spadaj�
    public float spadekGlodu = 5f; // Ile % g�odu spada co interwa�
    public float spadekSnu = 3f; // Ile % snu spada co interwa�
    public float spadekPicia = 4f; // Ile % picia spada co interwa�

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
        // Aktualizuj poziomy
        AktualizujPoziomy();
    }

    public void AktualizujPoziomy()
    {
        poziomGlodu -= spadekGlodu * Time.deltaTime / czasSpadku;
        if (poziomGlodu < 0f) poziomGlodu = 0f;

        poziomSnu -= spadekSnu * Time.deltaTime / czasSpadku;
        if (poziomSnu < 0f) poziomSnu = 0f;

        poziomPicia -= spadekPicia * Time.deltaTime / czasSpadku;
        if (poziomPicia < 0f) poziomPicia = 0f;
    }
}*/

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

