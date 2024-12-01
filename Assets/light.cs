using UnityEngine;
using UnityEngine.InputSystem;

public class LightSensorHandler : MonoBehaviour
{
    void Start()
    {
        // W³¹cz czujnik œwiat³a
        if (LightSensor.current != null)
        {
            InputSystem.EnableDevice(LightSensor.current);
            Debug.Log("Light Sensor Enabled");
        }
        else
        {
            Debug.LogWarning("Light Sensor not available on this device.");
        }
    }

    void Update()
    {
        // SprawdŸ, czy czujnik dzia³a, i odczytaj wartoœæ natê¿enia œwiat³a
        if (LightSensor.current != null)
        {
            float lightLevel = LightSensor.current.lightLevel.ReadValue();
            Debug.Log("Light Level: " + lightLevel);
        }
    }
}
