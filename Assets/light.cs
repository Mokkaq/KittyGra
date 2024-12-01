using UnityEngine;
using UnityEngine.InputSystem;

public class LightSensorHandler : MonoBehaviour
{
    void Start()
    {
        // W��cz czujnik �wiat�a
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
        // Sprawd�, czy czujnik dzia�a, i odczytaj warto�� nat�enia �wiat�a
        if (LightSensor.current != null)
        {
            float lightLevel = LightSensor.current.lightLevel.ReadValue();
            Debug.Log("Light Level: " + lightLevel);
        }
    }
}
