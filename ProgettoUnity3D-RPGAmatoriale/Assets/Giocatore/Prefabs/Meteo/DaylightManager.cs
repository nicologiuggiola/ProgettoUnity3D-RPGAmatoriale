using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DaylightManager : MonoBehaviour
{
    [SerializeField] private Light DirectionalLight;
    [SerializeField] private ScriptableDayNight Preset;
    [SerializeField, Range(0,2880)] public float TimeOfDay;
    public bool isNight;
    public bool isDay;
    public Text hours;
    public IngameCalendar calendar;

    private void Update()
    {
        if (Preset == null)
            return;

        if (Application.isPlaying)
        {
            TimeOfDay += Time.deltaTime;
            TimeOfDay %= 2880;
            UpdateLighting(TimeOfDay / 2880);
        }
        else
        {
            UpdateLighting(TimeOfDay / 2880);
        }

        if (TimeOfDay >= 680 && TimeOfDay <= 2189)
        {
            isDay = true;
            isNight = false;
        }
        else if (TimeOfDay <=679)
        {
            isDay = false;
            isNight = true;
        }
        else if (TimeOfDay >=2190)
        {
            isDay = false;
            isNight = true;
        }

        if (isNight == true)
        {
            RenderSettings.fog = true;
        }
        else if (isDay == true)
        {
            RenderSettings.fog = false;
        }

        //if (calendar.hours.text == "{00:00}")
        //{
            //TimeOfDay = 0;
        //}
        //if (hours.text == "00:00")
        //{
        //TimeOfDay = 0;
        //}
    }


    private void UpdateLighting(float timePercent)
    {
        //Set ambient and fog
        RenderSettings.ambientLight = Preset.Ambient.Evaluate(timePercent);
        RenderSettings.fogColor = Preset.Fog.Evaluate(timePercent);

        //If the directional light is set then rotate and set it's color, I actually rarely use the rotation because it casts tall shadows unless you clamp the value
        if (DirectionalLight != null)
        {
            DirectionalLight.color = Preset.Direction.Evaluate(timePercent);

            DirectionalLight.transform.localRotation = Quaternion.Euler(new Vector3((timePercent * 360f) - 90f, 80f, 300));
        }

    }

    //Try to find a directional light to use if we haven't set one
    private void OnValidate()
    {
        if (DirectionalLight != null)
            return;

        //Search for lighting tab sun
        if (RenderSettings.sun != null)
        {
            DirectionalLight = RenderSettings.sun;
        }
        //Search scene for light that fits criteria (directional)
        else
        {
            Light[] lights = GameObject.FindObjectsOfType<Light>();
            foreach (Light light in lights)
            {
                if (light.type == LightType.Directional)
                {
                    DirectionalLight = light;
                    return;
                }
            }
        }
    }
}
