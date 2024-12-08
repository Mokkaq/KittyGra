/*using UnityEngine;

public class ZachowaniePaskow : MonoBehaviour
{
    public static ZachowaniePaskow Instance; // Singleton

    public float poziomGlodu = 100f; // Poziom g³odu
    public float poziomSnu = 100f; // Poziom snu
    public float poziomPicia = 100f; // Poziom picia

    public float czasSpadku = 5f; // Co ile sekund potrzeby spadaj¹
    public float spadekGlodu = 5f; // Ile % g³odu spada co interwa³
    public float spadekSnu = 3f; // Ile % snu spada co interwa³
    public float spadekPicia = 4f; // Ile % picia spada co interwa³

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

