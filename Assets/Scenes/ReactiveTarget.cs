using System.Collections;
using System.Collections.Generic;
using Scenes;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour


{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ReactToHit()
    {
        WanderingAI behavior = GetComponent<WanderingAI>();
        if (behavior != null)
        {
            behavior.setAlive(false);
        }
        StartCoroutine(Die());
        
    }

    private IEnumerator Die()
    {
        this.transform.Rotate(-75, 0, 0);
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
