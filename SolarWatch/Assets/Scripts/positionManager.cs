using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AASharp;


public class positionManager : MonoBehaviour
{
    JDNConverter JDNConv;
    public GameObject sphere;
    public GameObject Sun;
    public float distanceFactor;
    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;
    public GameObject Pluto;

    // Start is called before the first frame update
    void Start()
    {
        JDNConv = new JDNConverter();
        distanceFactor = 149.6f;
        CreateSun();
    }
    public void CreateSun()
    {
        Sun = Instantiate(Sun, Vector3.zero, new Quaternion(0,0,0,0));
        Sun.transform.localScale = Vector3.one * 1.391f;

        Sun.name = "Sun";
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
        Vector3 forward = new Vector3(x, y, z) * getDistMercury();
        Mercury = Instantiate(sphere, forward, Sun.transform.rotation);
        Mercury.transform.localScale = Vector3.one * .0048794f;
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
        Vector3 forward = new Vector3(x, y, z) * getDistVenus();
        Venus = Instantiate(sphere, forward, Sun.transform.rotation);
        Venus.transform.localScale = Vector3.one * .012104f;
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
        Vector3 forward = new Vector3(x, y, z) * getDistEarth();
        Earth = Instantiate(sphere, forward, Sun.transform.rotation);
        Earth.transform.localScale = Vector3.one * .012742f;
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
        Vector3 forward = new Vector3(x, y, z) * getDistMars();
        Mars = Instantiate(sphere, forward, Sun.transform.rotation);
        Mars.transform.localScale = Vector3.one * .006779f;
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
        Vector3 forward = new Vector3(x, y, z) * getDistJupiter();
        Jupiter = Instantiate(sphere, forward, Sun.transform.rotation);
        Jupiter.transform.localScale = Vector3.one * .13982f;
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
        Vector3 forward = new Vector3(x, y, z) * getDistSaturn();
        Saturn = Instantiate(sphere, forward, Sun.transform.rotation);
        Saturn.transform.localScale = Vector3.one * .11646f;
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
        Vector3 forward = new Vector3(x, y, z) * getDistUranus();
        Uranus = Instantiate(sphere, forward, Sun.transform.rotation);
        Uranus.transform.localScale = Vector3.one * .050724f;
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
        Vector3 forward = new Vector3(x, y, z) * getDistNeptune();
        Neptune = Instantiate(sphere, forward, Sun.transform.rotation);
        Neptune.transform.localScale = Vector3.one * .049244f;
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
        Vector3 forward = new Vector3(x, y, z) * getDistPluto();
        Pluto = Instantiate(sphere, forward, Sun.transform.rotation);
        Pluto.transform.localScale = Vector3.one * .0023766f;
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
    void lookAtSun()
    {
        GameObject[] planets = new GameObject[] { Mercury,Venus,Earth,Mars,Jupiter,Saturn,Uranus,Neptune,Pluto};
        foreach (GameObject planet in planets)
        {
            planet.transform.LookAt(Sun.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            Debug.Log("creating planets");
            CreatePlanets();
            lookAtSun();
            Debug.Log("Earth: "+ AASEarth.RadiusVector(JDNConv.getJulianDayNumberToday(), true));
            Debug.Log("Mercury: " + AASMercury.RadiusVector(JDNConv.getJulianDayNumberToday(), true));
            Debug.Log("Jupiter: " + AASJupiter.RadiusVector(JDNConv.getJulianDayNumberToday(), true));
            Debug.Log("Distance between sun and pluto: " + Vector3.Distance(Sun.transform.position, Pluto.transform.position));

        }
    }
}
