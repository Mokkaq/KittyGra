using UnityEngine;

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
}
