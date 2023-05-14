using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class RACE : MonoBehaviour
{
    
    public Rigidbody rb;
    
    public Image healthBarImage;

    public WheelCollider front_left;
    public WheelCollider front_right;
    public WheelCollider rear_left;
    public WheelCollider rear_right;

    public Transform Front_left;
    public Transform Front_right;
    public Transform Rear_left;
    public Transform Rear_right;

    public float acc = 0;
    public float BRK = 500f;
    public float str_angle = 10F;

    public float carspeed;

    public TMP_Text score;
    int coincounter;
    public float timer=60f;
    public TMP_Text timerrr;
    public TMP_Text GameOverMessage;

    float x, y,z;

    public GameObject GameOver_panel;
    public GameObject winPannel;
    public GameObject uipanel;
    public GameObject pausepanel;

    public int spawnno = 0;

    public Transform[] spawns;
    
    public int amountTo_be_added;

    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        x = SimpleInput.GetAxis("Horizontal");
        
        



        
        rear_left.motorTorque = acc * y;
        rear_right.motorTorque = acc * y;

        front_left.brakeTorque = BRK * z;
        front_right.brakeTorque = BRK * z;
        rear_left.brakeTorque = BRK * z * 0.7f;
        rear_right.brakeTorque = BRK * z * 0.7f;

        carspeed = (2 * Mathf.PI * (rear_left.radius * 100) * rear_left.rpm / 100) * 60 / 100;

        front_left.steerAngle = x * str_angle;
        front_right.steerAngle = x * str_angle;

        Wheelupdate(front_left, Front_left);
        Wheelupdate(front_right, Front_right);
        Wheelupdate(rear_left, Rear_left);
        Wheelupdate(rear_right, Rear_right);

        timer -= Time.deltaTime;
        timer = (float)System.Math.Round(timer, 2);

        score.text = coincounter.ToString();
        timerrr.text = timer.ToString();
        if (timer <= 0)
        {
            Time.timeScale = 0;
            GameOver_panel.SetActive(true);
        }

        if (healthBarImage.fillAmount <= 0)
        {
            uipanel.SetActive(false);
            Time.timeScale = 0;
            GameOver_panel.SetActive(true);
            GameOverMessage.text = "Your health is low";
            rb.isKinematic = true;
            
        }
        


    }
    public void Wheelupdate(WheelCollider col, Transform tran)
    {
        Vector3 pos;
        Quaternion rot;
        col.GetWorldPose(out pos, out rot);
        tran.position = pos;
        tran.rotation = rot;
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "wall" && carspeed>=5000 )
        {
            
            healthBarImage.fillAmount -= 0.3f;
            
            
        }
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gates")
        {
            spawnno++;

        }
        if (other.gameObject.tag == "hell")
        {
            
            Time.timeScale = 0;
            uipanel.SetActive(false);
            GameOver_panel.SetActive(true);
            

        }
        if (other.gameObject.tag == "coin")
        {
            coincounter++;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "HP")
        {
            other.gameObject.SetActive(false);
            healthBarImage.fillAmount = 1;
            
        }
        
        if (other.gameObject.tag == "end")
        {
            Time.timeScale = 0;
            winPannel.SetActive(true);
            uipanel.SetActive(false);

        }
        
        
    }
    public void pausebutton()
    {
        Time.timeScale = 0;
        pausepanel.SetActive(true);
        uipanel.SetActive(false);

    }
    public void resume()
    {
        Time.timeScale = 1;
        pausepanel.SetActive(false);
        uipanel.SetActive(true);
    }

    public void Resumegame()
    {
        if (coincounter >= 15 && spawnno > 0)
        {
            if (spawnno == 1)
            {
                
                transform.position = spawns[0].position;
                transform.rotation = spawns[0].rotation;
                coincounter -= 15;
                Time.timeScale = 1;
                GameOver_panel.SetActive(false);
                uipanel.SetActive(true);
                healthBarImage.fillAmount = 1;
                rb.isKinematic = false;
                if (timer < 1)
                {
                    timer = amountTo_be_added;
                }
                

            }
            if (spawnno == 2)
            {
                
                transform.position = spawns[1].position;
                transform.rotation = spawns[1].rotation;
                coincounter -= 15;
                Time.timeScale = 1;
                GameOver_panel.SetActive(false);
                uipanel.SetActive(true);
                healthBarImage.fillAmount = 1;
                rb.isKinematic = false;
                if (timer < 1)
                {
                    timer = amountTo_be_added;
                }

            }

            if (spawnno == 3)
            {
                
                transform.position = spawns[2].position;
                transform.rotation = spawns[2].rotation;
                coincounter -= 15;
                Time.timeScale = 1;
                GameOver_panel.SetActive(false);
                uipanel.SetActive(true);
                healthBarImage.fillAmount = 1;
                rb.isKinematic = false;
                if (timer < 1)
                {
                    timer = amountTo_be_added;
                }
            }
            if (spawnno == 4)
            {
                transform.position = spawns[3].position;
                transform.rotation = spawns[3].rotation;
                coincounter -= 15;
                Time.timeScale = 1;
                GameOver_panel.SetActive(false);
                uipanel.SetActive(true);
                healthBarImage.fillAmount = 1;
                rb.isKinematic = false;
                if (timer < 1)
                {
                    timer = amountTo_be_added;
                }
            }
            if (spawnno == 5)
            {
                transform.position = spawns[4].position;
                transform.rotation = spawns[4].rotation;
                coincounter -= 15;
                Time.timeScale = 1;
                GameOver_panel.SetActive(false);
                uipanel.SetActive(true);
                healthBarImage.fillAmount = 1;
                rb.isKinematic = false;
                if (timer < 1)
                {
                    timer = amountTo_be_added;
                }
            }
            if (spawnno == 6)
            {
                transform.position = spawns[5].position;
                transform.rotation = spawns[5].rotation;
                coincounter -= 15;
                Time.timeScale = 1;
                GameOver_panel.SetActive(false);
                uipanel.SetActive(true);
                healthBarImage.fillAmount = 1;
                rb.isKinematic = false;
                if (timer < 1)
                {
                    timer = amountTo_be_added;
                }
            }
        }
        
    }
    public void gaspush()
    {
        y = 1;
    }
    public void gasreleash()
    {
        y = 0;
    }
    public void reversepush()
    {
        y = -1;
    }
    public void breakpreash()
    {
        z = 1;
    }
    public void breakreleash()
    {
        z = 0;
    }

}
