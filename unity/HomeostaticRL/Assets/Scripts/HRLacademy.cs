using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using MLAgents;


public class HRLacademy : Academy
{
    //[HideInInspector]
    //public List<GameObject> actorObjs;
    //[HideInInspector]
    //public int[] players;

    //public GameObject trueAgent;
    //public float centerX, centerZ, rangeX, rangeZ, spawnY;

    //public GameObject camObject;
    //Camera cam;
    //Camera agentCam;

    // // Cube initializing setting > academy
    // [Header("Your Consumables")]
    // public Transform spawnArea;
    // public GameObject foodPref;
    // public GameObject waterPref;
    // List<GameObject> cubes = new List<GameObject>();
    // float screenX, screenZ;
    // public int numCubes;

    // // Initialize items 
    // public void InitializeItems()
    // {
    //     Vector3 pos;
    //     float posX = spawnArea.transform.position.x;
    //     float posZ = spawnArea.transform.position.z;
    //     float scaleX = spawnArea.transform.localScale.x;
    //     float scaleZ = spawnArea.transform.localScale.z;

    //     for (int i = 0; i < numCubes; i++)
    //     {
    //         screenX = Random.Range(posX - (scaleX * 5), posX + (scaleX * 5));
    //         screenZ = Random.Range(posZ - (scaleZ * 5), posZ + (scaleZ * 5));
    //         pos = new Vector3(screenX, spawnArea.transform.position.y, screenZ);

    //         GameObject food = Instantiate(foodPref, pos, spawnArea.rotation);
    //         cubes.Add(food);

    //         screenX = Random.Range(posX - (scaleX * 5), posX + (scaleX * 5));
    //         screenZ = Random.Range(posZ - (scaleZ * 5), posZ + (scaleZ * 5));
    //         pos = new Vector3(screenX, spawnArea.transform.position.y, screenZ);

    //         GameObject water = Instantiate(waterPref, pos, spawnArea.rotation);
    //         cubes.Add(water);
    //     }
    // }

    public override void InitializeAcademy()
    {
        //numCubes = (int)resetParameters["numCubes"];
        //cam = camObject.GetComponent<Camera>();
        //agentCam = GameObject.Find("agentCam").GetComponent<Camera>();
        // InitializeItems();
    }

    public void SetEnvironment()
    {
        //cam.transform.position = new Vector3(-((int)resetParameters["gridSize"] - 1) / 2f,
        //                                     (int)resetParameters["gridSize"] * 1.25f,
        //                                     -((int)resetParameters["gridSize"] - 1) / 2f);
        //cam.orthographicSize = ((int)resetParameters["gridSize"] + 5f) / 2f;

        //agentCam.orthographicSize = (gridSize) / 2f;
        //agentCam.transform.position = new Vector3((gridSize - 1) / 2f, gridSize + 1f, (gridSize - 1) / 2f);

    }

    public override void AcademyReset()
    {

        //HashSet<int> numbers = new HashSet<int>();
        //while (numbers.Count < players.Length + 1)
        //{
        //    numbers.Add(Random.Range(0, gridSize * gridSize));
        //}
        //int[] numbersA = Enumerable.ToArray(numbers);

        //for (int i = 0; i < players.Length; i++)
        //{
        //    int x = (numbersA[i]) / gridSize;
        //    int y = (numbersA[i]) % gridSize;
        //    GameObject actorObj = Instantiate(objects[players[i]]);
        //    actorObj.transform.position = new Vector3(x, -0.25f, y);
        //    actorObjs.Add(actorObj);
        //}

        //int x_a = (numbersA[players.Length]) / gridSize;
        //int y_a = (numbersA[players.Length]) % gridSize;
        //trueAgent.transform.position = new Vector3(x_a, -0.25f, y_a);

        // Removing all cubes : move from AgentRest()
        // foreach (GameObject c in cubes)
        // {
        //     DestroyImmediate(c.gameObject);
        // }
        // cubes.Clear();

        // InitializeItems();
    }

    public override void AcademyStep()
    {

    }
}
