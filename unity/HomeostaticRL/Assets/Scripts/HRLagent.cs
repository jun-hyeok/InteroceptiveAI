using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MLAgents;

public class HRLagent : Agent
{
    //Sliders Setting
    [Header("Status Settings")]
    public Slider thirstSlider;
    public float maxThirst = 100;
    public float thirstFallRate = 1;
    public Slider hungerSlider;
    public float maxHunger = 100;
    public float hungerFallRate = 2;

    //Move, Rotation Setting
    [Header("Movement Settings")]
    public CharacterController controller;
    public float moveSpeed = 12f;
    public float rotateSpeed = 4f;

    //Gravity Setting
    [Header("Gravity Settings")]
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    Vector3 velocity;
    bool isGrounded;

    //Raycast setting to eat cubes
    [Header("Raycast Settings")]
    [SerializeField] private float rayLength = 10;
    [SerializeField] private LayerMask newLayerMask;
    [SerializeField] private Image crossHair;
    private GameObject raycastedObj;

    // Cube initializing setting
    [Header("Your Consumables")]
    public Transform spawnArea;
    public GameObject foodPref;
    public GameObject waterPref;
    List<GameObject> cubes = new List<GameObject>();
    float screenX, screenZ;
    public int numCubes;

    //[Tooltip("Because we want an observation right before making a decision, we can force " +
    //         "a camera to render before making a decision. Place the agentCam here if using " +
    //         "RenderTexture as observations.")]
    //public Camera renderCamera;

    //[Tooltip("Selecting will turn on action masking. Note that a model trained with action " +
    //         "masking turned on may not behave optimally when action masking is turned off.")]
    //public bool maskActions = true;


    // Initialize items 
    void InitializeItems()
    {
        Vector3 pos;
        float posX = spawnArea.position.x;
        float posZ = spawnArea.position.z;
        float scaleX = spawnArea.localScale.x;
        float scaleZ = spawnArea.localScale.z;

        for (int i = 0; i < numCubes; i++)
        {
            screenX = Random.Range(posX - (scaleX * 5), posX + (scaleX * 5));
            screenZ = Random.Range(posZ - (scaleZ * 5), posZ + (scaleZ * 5));
            pos = new Vector3(screenX, spawnArea.position.y, screenZ);

            GameObject food = Instantiate(foodPref, pos, spawnArea.rotation);
            cubes.Add(food);

            screenX = Random.Range(posX - (scaleX * 5), posX + (scaleX * 5));
            screenZ = Random.Range(posZ - (scaleZ * 5), posZ + (scaleZ * 5));
            pos = new Vector3(screenX, spawnArea.position.y, screenZ);

            GameObject water = Instantiate(waterPref, pos, spawnArea.rotation);
            cubes.Add(water);
        }
    }

    //For player to see
    void CrosshairActive(bool active = true)
    {
        if (active)
        {
            crossHair.color = Color.red;
        }
        else
        {
            crossHair.color = Color.white;
        }
    }

    private void Awake()
    {
        // Disable auto update of the physics engine.
        // Otherwise image rendering is not done every tick
        Physics.autoSimulation = false;

        // Enable Frame rate control. If you use VR, this is ignored.
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = (int)(60.0 * Time.timeScale);
    }

    public override void InitializeAgent()
    {
        base.InitializeAgent();

        // Setting slider with max values
        thirstSlider.maxValue = maxThirst;
        thirstSlider.value = maxThirst;
        hungerSlider.maxValue = maxHunger;
        hungerSlider.value = maxHunger;

        // Initialize items
        InitializeItems();
    }

    // Update is called once per frame
    void Update()
    {

        // Gravity Implementation
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        // if (controller.isGrounded){
        //     Debug.Log("Grounded");
        // }
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //Hunger Controller
        if (hungerSlider.value >= 0)
        {
            hungerSlider.value -= Time.deltaTime / hungerFallRate;
        }
        else if (hungerSlider.value <= 0)
        {
            hungerSlider.value = 0;
        }
        else if (hungerSlider.value >= maxHunger)
        {
            hungerSlider.value = maxHunger;
        }

        //Thirst Controller
        if (thirstSlider.value >= 0)
        {
            thirstSlider.value -= Time.deltaTime / thirstFallRate;
        }
        else if (thirstSlider.value <= 0)
        {
            thirstSlider.value = 0;
        }
        else if (thirstSlider.value >= maxThirst)
        {
            thirstSlider.value = maxThirst;
        }

        // Update Simulation every frame. 
        // This Update enable us to render every frame and hence provide image to the agent
        Physics.Simulate(Time.fixedDeltaTime);

        // Control of the target frame rate. Python client can control timeScale.
        Application.targetFrameRate = (int)(60.0 * Time.timeScale);
    }

    public override void CollectObservations()
    {
        AddVectorObs(hungerSlider.value);
        AddVectorObs(thirstSlider.value);

        // Vector3 relativePos = transform.position - spawnArea.position;

        // AddVectorObs(relativePos.x);
        // AddVectorObs(relativePos.z);
        // normalize Mathf.Clamp(Vector3, low, high)
    }

    /// <summary>
    /// Applies the mask for the agents action to disallow unnecessary actions.
    /// </summary>
    private void SetMask()
    {

    }

    public override void AgentAction(float[] vectorAction, string textAction)
    {
        float forwardInput = vectorAction[0];
        float leftInput = vectorAction[1];
        float rightInput = vectorAction[2];
        float eatInput = vectorAction[3];
        float noneInput = vectorAction[4];
        float horizontalInput = rightInput - leftInput;

        //Move, Rotation action
        Vector3 move = transform.forward * forwardInput;
        controller.Move(move * moveSpeed * Time.deltaTime);
        if (forwardInput==0){
            transform.Rotate(Vector3.up * horizontalInput * rotateSpeed); //playerBody
        }
        
        //Raycasting for detecting collision with cubes and eat it
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        //Drawing Raycast blue line to see
        Debug.DrawRay(transform.position, fwd * rayLength, Color.blue, 0.3f);

        //Raycast act
        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, newLayerMask.value))
        {
            //If collide object has "Consumable" as a tag
            if (hit.collider.CompareTag("Consumable"))
            {
                //Crosshair is only for player to see wether we collide or not
                CrosshairActive();

                raycastedObj = hit.collider.gameObject;

                //Since c# doesn't treat 0 or 1 as bool, 'eatInput' need to be converted
                if (System.Convert.ToBoolean(eatInput))
                {
                    bool foodbool = false;
                    bool waterbool = false;
                    float value;
                    GameObject cube;

                    raycastedObj.GetComponent<ItemProperties>().Ineration(out foodbool, out waterbool, out value, out cube);

                    if (foodbool)
                    {
                        hungerSlider.value += value;
                    }
                    else if (waterbool)
                    {
                        thirstSlider.value += value;
                    }
                    cubes.Add(cube);

                    //After eating, Destroy cube
                    raycastedObj.SetActive(false);
                    Destroy(raycastedObj);
                }
            }
        }
        else
        {
            CrosshairActive(false);
        }

        //When any slider become zero, agent will dead and reinitialze cubes
        if (hungerSlider.value <= 0 || thirstSlider.value <= 0)
        {
            Debug.Log("Done!");
            AddReward(-1f);
            Done();
        }
    }

    //Agent resetting
    public override void AgentReset()
    {
        Debug.Log("ReSet!");

        //Destroy cubes
        foreach (GameObject cube in cubes)
        {
            DestroyImmediate(cube.gameObject);
        }
        cubes.Clear();
        transform.position = spawnArea.position;
        InitializeAgent();
    }

    public void FixedUpdate()
    {
        //WaitTimeInference();
    }

    private void WaitTimeInference()
    {

    }
}
