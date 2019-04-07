using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class JDNConverter : MonoBehaviour
{
    public int _year;
    public int _month;
    public int _day;
    // Start is called before the first frame update
  
    public void setTodaysParams()
    {
        _year = DateTime.Now.Year;
        _month = DateTime.Now.Month;
        _day = DateTime.Now.Day;
    }
    public double getJulianDayNumber(int year,int month,int day)
    {
        double JDN = (1461 * (year + 4800 + (month-14)/12))/4 + (367 * (month - 2 - 12 * ((month - 14)/ 12)))/ 12 - (3 * ((year + 4900 + (month - 14) / 12) / 100))/ 4 + day - 32075;
        return JDN;
    }
    public double getJulianDayNumberToday()
    {
        setTodaysParams();
        double JDN = (1461 * (_year + 4800 + (_month - 14) / 12)) / 4 + (367 * (_month - 2 - 12 * ((_month - 14) / 12))) / 12 - (3 * ((_year + 4900 + (_month - 14) / 12) / 100)) / 4 + _day - 32075;
        return JDN;
    }

}
