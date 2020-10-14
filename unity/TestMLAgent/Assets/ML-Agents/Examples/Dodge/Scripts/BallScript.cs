using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    GameObject Agent;
    float ball_speed;
    float ball_random;

    public void setBall(GameObject Agent, float ball_speed, float ball_random)
    {
        this.Agent = Agent;
        this.ball_speed = ball_speed;
        this.ball_random = ball_random;
        Random_ball();
    }
    public void Random_ball()
    {
        Vector3 vec = new Vector3(Random.Range(-4.5f, 4.5f), 0.5f, Random.Range(-4.5f, 4.5f));
        while (Vector3.Distance(Agent.transform.localPosition, vec) < 4.0f)
        {
            vec = new Vector3(Random.Range(-4.5f, 4.5f), 0.5f, Random.Range(-4.5f, 4.5f));
        }
        this.transform.localPosition = vec;
        Rigidbody rig = this.GetComponent<Rigidbody>();
        float randAngle = Mathf.Atan2(
            (Agent.transform.localPosition.z - this.transform.localPosition.z),
            (Agent.transform.localPosition.x - this.transform.localPosition.x))
            + Random.Range(-ball_random, ball_random);
        float randSpeed = ball_speed + Random.Range(-0.5f, 0.5f);
        rig.velocity = new Vector3(randSpeed * Mathf.Cos(randAngle), 0, randSpeed * Mathf.Sin(randAngle));
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("wall"))
        {
            Random_ball();
        }
    }
}
