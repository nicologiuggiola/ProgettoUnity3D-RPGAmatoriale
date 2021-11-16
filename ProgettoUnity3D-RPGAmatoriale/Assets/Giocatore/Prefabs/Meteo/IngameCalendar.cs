using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngameCalendar : MonoBehaviour
{
    public DaylightManager daylight;
    private const int SecondScale = 30;
    public Text hours;
    public Text years;
    public Text months;
    public Text daysText;

    public enum MonthName
    {
        JANUARY,
        FEBRUARY,
        MARCH,
        APRIL,
        MAY,
        JUNE,
        JULY,
        AUGUST,
        SEPTEMBER,
        OCTOBER,
        NOVEMBER,
        DECEMBER
    }

    public MonthName mNames;

    public bool isWinter;
    public bool isSpring;
    public bool isSummer;
    public bool isAutumn;

    public static double second, minute, hour, day, month, year;

    // Start is called before the first frame update
    void Start()
    {
        hour = 00;
        day = 18;
        month = 1;
        year = 1;
        //hours.text = "00:00";
        isWinter = false;
        isSpring = false;
        isSummer = false;
        isAutumn = false;
    }

    // Update is called once per frame
    void Update()
    {
        CalculateTime();

        switch (mNames)
        {
            case (MonthName.JANUARY):
                months.text = "January";
                if (month == 2)
                {
                    mNames = MonthName.FEBRUARY;
                }
                break;
            case (MonthName.FEBRUARY):
                months.text = "February";
                if (month == 3)
                {
                    mNames = MonthName.MARCH;
                }
                break;
            case (MonthName.MARCH):
                months.text = "March";
                if (month == 4)
                {
                    mNames = MonthName.APRIL;
                }
                break;
            case (MonthName.APRIL):
                months.text = "April";
                if (month == 5)
                {
                    mNames = MonthName.MAY;
                }
                break;
            case (MonthName.MAY):
                months.text = "May";
                if (month == 6)
                {
                    mNames = MonthName.JUNE;
                }
                break;
            case (MonthName.JUNE):
                months.text = "June";
                if (month == 7)
                {
                    mNames = MonthName.JULY;
                }
                break;
            case (MonthName.JULY):
                months.text = "July";
                if (month == 8)
                {
                    mNames = MonthName.AUGUST;
                }
                break;
            case (MonthName.AUGUST):
                months.text = "August";
                if (month == 9)
                {
                    mNames = MonthName.SEPTEMBER;
                }
                break;
            case (MonthName.SEPTEMBER):
                months.text = "September";
                if (month == 10)
                {
                    mNames = MonthName.OCTOBER;
                }
                break;
            case (MonthName.OCTOBER):
                months.text = "October";
                if (month == 11)
                {
                    mNames = MonthName.NOVEMBER;
                }
                break;
            case (MonthName.NOVEMBER):
                months.text = "November";
                if (month == 12)
                {
                    mNames = MonthName.DECEMBER;
                }
                break;
            case (MonthName.DECEMBER):
                months.text = "December";
                if (month == 1)
                {
                    mNames = MonthName.JANUARY;
                }
                break;
        }
    }

    void ToText()
    {
        hours.text = string.Format("{00:00} : {01:00}",hour, minute);
        daysText.text = "Day " + day;
        years.text = year + "°" + " year";

    }

    void Seasons()
    {
        if (month == 11 || month == 12 || month == 1)
        {
            isWinter = true;
        }

        if (month == 2 || month == 3 || month == 4)
        {
            isSpring = true;
        }

        if (month == 5 || month == 6 || month == 7)
        {
            isSummer = true;
        }

        if (month == 8 || month == 9 || month == 10)
        {
            isAutumn = true;
        }
    }

    void MonthsDays()
    {
        if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if(day>=32)
            {
                month++;
                day = 1;
                ToText();
                Seasons();
            }
        }

        if(month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day >= 31)
            {
                month++;
                day = 1;
                ToText();
                Seasons();
            }
        }

        if(month == 2)
        {
            if (day >= 29)
            {
                month++;
                day = 1;
                ToText();
                Seasons();
            }
        }
    }

    void CalculateTime()
    {
        second += Time.deltaTime * SecondScale;
        if (second >= 60)
        {
            minute++;
            second = 0;
            ToText();
        }
        else if (minute >= 60)    
        {
            hour++;
            minute = 0;
            ToText();
        }
        else if (hour >= 24)
        {
            day++;
            daylight.TimeOfDay = 0;
            hour = 0;
            ToText();
        }
        else if (day >= 28)
        {
            MonthsDays();
        }
        else if (month > 12)
        {
            year++;
            month = 1;
            ToText();
            Seasons();
        }
    }

    public void Rest()
    {
        hour++;
        ToText();
    }
}
