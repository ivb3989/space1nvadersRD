using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void OnEnable()
    {
        Invoke("Disable", 2);
    }

    void Disable()
    {
        gameObject.SetActive(false);
    }

    public void StartExplosion(string target)
    {
        anim.SetTrigger("OnExplosion");
        switch (target)
        {
            case "S":
                transform.localScale = Vector3.one * 0.7f;
                SoundManagerScript.PlaySound("Explode5");
                break;
            case "M":
            case "P":
                transform.localScale = Vector3.one * 1f;
                SoundManagerScript.PlaySound("Explode5");
                break;
            case "L":
                transform.localScale = Vector3.one * 2f;
                SoundManagerScript.PlaySound("Explode3");
                break;
            case "Dog":
                transform.localScale = Vector3.one * 3f;
                SoundManagerScript.PlaySound("Explode3");
                break;
        }
    }
}
