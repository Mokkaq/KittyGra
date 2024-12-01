package com.example.lightsensor;

import android.content.Context;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;

public class LightSensorHelper implements SensorEventListener {
    private SensorManager sensorManager;
    private Sensor lightSensor;
    private float lightLevel = 0f;

    public LightSensorHelper(Context context) {
        sensorManager = (SensorManager) context.getSystemService(Context.SENSOR_SERVICE);
        lightSensor = sensorManager.getDefaultSensor(Sensor.TYPE_LIGHT);
    }

    public void startSensor() {
        if (lightSensor != null) {
            sensorManager.registerListener(this, lightSensor, SensorManager.SENSOR_DELAY_NORMAL);
        }
    }

    public void stopSensor() {
        if (lightSensor != null) {
            sensorManager.unregisterListener(this);
        }
    }

    public float getLightLevel() {
        return lightLevel;
    }

    @Override
    public void onSensorChanged(SensorEvent event) {
        if (event.sensor.getType() == Sensor.TYPE_LIGHT) {
            lightLevel = event.values[0]; // Odczyt natężenia światła
        }
    }

    @Override
    public void onAccuracyChanged(Sensor sensor, int accuracy) {
        // Nie wymagane, można zostawić puste
    }
}
