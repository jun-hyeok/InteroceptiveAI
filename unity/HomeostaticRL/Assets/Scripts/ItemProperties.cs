using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemProperties : MonoBehaviour
{
    [Header("Your Consumables")]
    public Transform spawnArea;
    public GameObject spawnee;
    float screenX, screenZ;

    [SerializeField] private bool food;
    [SerializeField] private bool water;
    [SerializeField] private float value;

    public void Ineration(out bool foodbool, out bool waterbool, out float Val, out GameObject cube)
    {
        Vector3 pos;
        float posX = spawnArea.transform.position.x;
        float posZ = spawnArea.transform.position.z;
        float scaleX = spawnArea.transform.localScale.x;
        float scaleZ = spawnArea.transform.localScale.z;

        screenX = Random.Range(posX - (scaleX * 5), posX + (scaleX * 5));
        screenZ = Random.Range(posZ - (scaleZ * 5), posZ + (scaleZ * 5));
        pos = new Vector3(screenX, spawnArea.transform.position.y, screenZ);

        cube = Instantiate(spawnee, pos, spawnArea.rotation);

        foodbool = food;
        waterbool = water;
        Val = value;
    }
}
