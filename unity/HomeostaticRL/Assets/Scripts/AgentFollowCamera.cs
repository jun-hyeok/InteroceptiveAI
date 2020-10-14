using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentFollowCamera : MonoBehaviour
{
    public Transform agent;
    public Vector3 offset;

    void Update()
    {
        transform.position = agent.position + offset;
    }
}
