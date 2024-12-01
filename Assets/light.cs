using UnityEngine;

public class LightSensorManager : MonoBehaviour
{
    private AndroidJavaObject lightSensorHelper; // Referencja do klasy Java
    public float lightLevel = 0f; // Aktualny poziom œwiat³a

    void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            // Utworzenie obiektu klasy Java
            lightSensorHelper = new AndroidJavaObject("com.example.lightsensor.LightSensorHelper", GetUnityActivity());
            lightSensorHelper.Call("startSensor");
        }
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android && lightSensorHelper != null)
        {
            // Pobranie poziomu œwiat³a
            lightLevel = lightSensorHelper.Call<float>("getLightLevel");

            // Dostosowanie jasnoœci ekranu (opcjonalnie)
            float brightness = Mathf.Clamp01(lightLevel / 1000f); // Normalizacja wartoœci
            Screen.brightness = brightness;
        }
    }

    void OnDestroy()
    {
        if (Application.platform == RuntimePlatform.Android && lightSensorHelper != null)
        {
            // Zatrzymanie sensora
            lightSensorHelper.Call("stopSensor");
        }
    }

    // Metoda do pobrania kontekstu aktywnoœci Unity
    private AndroidJavaObject GetUnityActivity()
    {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        return unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
    }
}
