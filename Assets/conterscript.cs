using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class conterscript : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text Timer;
    void Start()
    {
        StartCoroutine(Countdown(3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Countdown(int seconds)
    {
        int count = seconds;
        while (count > -1)
        {
            yield return new WaitForSeconds(1);
            Timer.text = count.ToString();
            count--;


        }
        Timer.text = "GO!";
        yield return new WaitForSeconds(1);
        dosomething();
    }
    void dosomething()
    {
        
        transform.gameObject.GetComponent<RACE>().enabled = true;
        Timer.gameObject.SetActive(false);
    }
}
