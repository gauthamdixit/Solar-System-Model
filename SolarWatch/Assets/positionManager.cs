using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AASharp;


public class positionManager : MonoBehaviour
{
    JDNConverter JDNConv;
    public GameObject sphere;
    public GameObject Sun;
    public int distanceFactor;

    // Start is called before the first frame update
    void Start()
    {
        JDNConv = new JDNConverter();
        distanceFactor = 200;
        CreateSun();
    }
    public void CreateSun()
    {
        Instantiate(Sun, Vector3.zero, new Quaternion(0,0,0,0));
    }
    public float getDistMercury()
    {
        float ret = distanceFactor * (float)AASMercury.RadiusVector(JDNConv.getJulianDayNumberToday(), true);
        return ret;
    }
    public void CreateMercury()
    {
        float x = Mathf.Cos((float)AASMercury.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASMercury.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float y = Mathf.Sin((float)AASMercury.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASMercury.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float z = Mathf.Sin((float)AASMercury.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        Vector3 forward = transform.TransformDirection(new Vector3(x, y, z)) * getDistMercury();
        GameObject Mercury = Instantiate(sphere, forward, Sun.transform.rotation);
        Mercury.name = "Mercury";
        
    }
    public float getDistVenus()
    {
        float ret = distanceFactor * (float)AASVenus.RadiusVector(JDNConv.getJulianDayNumberToday(), true);
        return ret;
    }
    public void CreateVenus()
    {
        float x = Mathf.Cos((float)AASVenus.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASVenus.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float y = Mathf.Sin((float)AASVenus.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASVenus.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float z = Mathf.Sin((float)AASVenus.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        Vector3 forward = transform.TransformDirection(new Vector3(x, y, z)) * getDistVenus();
        GameObject Venus = Instantiate(sphere, forward, Sun.transform.rotation);
        Venus.name = "Venus";
    }
    public float getDistEarth()
    {
        float ret = distanceFactor * (float)AASEarth.RadiusVector(JDNConv.getJulianDayNumberToday(), true);
        return ret;
    }
    public void CreateEarth()
    {
        float x = Mathf.Cos((float)AASEarth.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASEarth.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float y = Mathf.Sin((float)AASEarth.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASEarth.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float z = Mathf.Sin((float)AASEarth.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        Vector3 forward = transform.TransformDirection(new Vector3(x, y, z)) * getDistEarth();
        GameObject Earth = Instantiate(sphere, forward, Sun.transform.rotation);
        Earth.name = "Earth";
    }
    public float getDistMars()
    {
        float ret = distanceFactor * (float)AASMars.RadiusVector(JDNConv.getJulianDayNumberToday(), true);
        return ret;
    }
    public void CreateMars()
    {
        float x = Mathf.Cos((float)AASMars.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASMars.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float y = Mathf.Sin((float)AASMars.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASMars.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float z = Mathf.Sin((float)AASMars.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        Vector3 forward = transform.TransformDirection(new Vector3(x, y, z)) * getDistMars();
        GameObject Mars = Instantiate(sphere, forward, Sun.transform.rotation);
        Mars.name = "Mars";
    }
    public float getDistJupiter()
    {
        float ret = distanceFactor * (float)AASJupiter.RadiusVector(JDNConv.getJulianDayNumberToday(), true);
        return ret;
    }
    public void CreateJupiter()
    {
        float x = Mathf.Cos((float)AASJupiter.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASJupiter.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float y = Mathf.Sin((float)AASJupiter.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASJupiter.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float z = Mathf.Sin((float)AASJupiter.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        Vector3 forward = transform.TransformDirection(new Vector3(x, y, z)) * getDistJupiter();
        GameObject Jupiter = Instantiate(sphere, forward, Sun.transform.rotation);
        Jupiter.name = "Jupiter";
    }
    public float getDistSaturn()
    {
        float ret = distanceFactor * (float)AASSaturn.RadiusVector(JDNConv.getJulianDayNumberToday(), true);
        return ret;
    }
    public void CreateSaturn()
    {
        float x = Mathf.Cos((float)AASSaturn.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASSaturn.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float y = Mathf.Sin((float)AASSaturn.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASSaturn.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float z = Mathf.Sin((float)AASSaturn.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        Vector3 forward = transform.TransformDirection(new Vector3(x, y, z)) * getDistSaturn();
        GameObject Saturn = Instantiate(sphere, forward, Sun.transform.rotation);
        Saturn.name = "Saturn";
    }
    public float getDistUranus()
    {
        float ret = distanceFactor * (float)AASUranus.RadiusVector(JDNConv.getJulianDayNumberToday(), true);
        return ret;
    }
    public void CreateUranus()
    {
        float x = Mathf.Cos((float)AASUranus.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASUranus.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float y = Mathf.Sin((float)AASUranus.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASUranus.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float z = Mathf.Sin((float)AASUranus.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        Vector3 forward = transform.TransformDirection(new Vector3(x, y, z)) * getDistUranus();
        GameObject Uranus = Instantiate(sphere, forward, Sun.transform.rotation);
        Uranus.name = "Uranus";
    }
    public float getDistNeptune()
    {
        float ret = distanceFactor * (float)AASNeptune.RadiusVector(JDNConv.getJulianDayNumberToday(), true);
        return ret;
    }
    public void CreateNeptune()
    {
        float x = Mathf.Cos((float)AASNeptune.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASNeptune.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float y = Mathf.Sin((float)AASNeptune.EclipticLatitude(JDNConv.getJulianDayNumberToday(), true)) * Mathf.Cos((float)AASNeptune.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        float z = Mathf.Sin((float)AASNeptune.EclipticLongitude(JDNConv.getJulianDayNumberToday(), true));
        Vector3 forward = transform.TransformDirection(new Vector3(x, y, z)) * getDistNeptune();
        GameObject Neptune = Instantiate(sphere, forward, Sun.transform.rotation);
        Neptune.name = "Neptune";
    }
    public float getDistPluto()
    {
        float ret = distanceFactor * (float)AASPluto.RadiusVector(JDNConv.getJulianDayNumberToday());
        return ret;
    }
    public void CreatePluto()
    {
        float x = Mathf.Cos((float)AASPluto.EclipticLatitude(JDNConv.getJulianDayNumberToday())) * Mathf.Cos((float)AASPluto.EclipticLongitude(JDNConv.getJulianDayNumberToday()));
        float y = Mathf.Sin((float)AASPluto.EclipticLatitude(JDNConv.getJulianDayNumberToday())) * Mathf.Cos((float)AASPluto.EclipticLongitude(JDNConv.getJulianDayNumberToday()));
        float z = Mathf.Sin((float)AASPluto.EclipticLongitude(JDNConv.getJulianDayNumberToday()));
        Vector3 forward = transform.TransformDirection(new Vector3(x, y, z)) * getDistPluto();
        GameObject Pluto = Instantiate(sphere, forward, Sun.transform.rotation);
        Pluto.name = "Pluto";
    }
    public void CreatePlanets()
    {
        CreateMercury();
        CreateVenus();
        CreateEarth();
        CreateMars();
        CreateJupiter();
        CreateSaturn();
        CreateUranus();
        CreateNeptune();
        CreatePluto();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            Debug.Log("creating planets");
            CreatePlanets();

        }
    }
}
