using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip hitSound, playerShotSound, coinSound, itemSound, clickSound, explodeSound, impactSound, bigExplodeSound, longShotSound, followerShot;
    static AudioSource audioSrc;
    void Start()
    {
        hitSound = Resources.Load<AudioClip>("Hit 1");
        playerShotSound = Resources.Load<AudioClip>("Shoot4");
        coinSound = Resources.Load<AudioClip>("Coin 1");
        itemSound = Resources.Load<AudioClip>("Get_Item3");
        clickSound = Resources.Load<AudioClip>("Click7");
        explodeSound = Resources.Load<AudioClip>("Explode5");
        impactSound = Resources.Load<AudioClip>("Impact4");
        bigExplodeSound = Resources.Load<AudioClip>("Explode3");
        longShotSound = Resources.Load<AudioClip>("Shoot2");
        followerShot = Resources.Load<AudioClip>("Shoot6");

        audioSrc = GetComponent<AudioSource>();
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Hit 1":
                audioSrc.PlayOneShot(hitSound);
                break;
            case "Shoot4":
                audioSrc.PlayOneShot(playerShotSound);
                break;
            case "Coin 1":
                audioSrc.PlayOneShot(coinSound);
                break;
            case "Get_Item3":
                audioSrc.PlayOneShot(itemSound);
                break;
            case "Click7":
                audioSrc.PlayOneShot(clickSound);
                break;
            case "Explode5":
                audioSrc.PlayOneShot(explodeSound);
                break;
            case "Impact4":
                audioSrc.PlayOneShot(impactSound);
                break;
            case "Explode3":
                audioSrc.PlayOneShot(bigExplodeSound);
                break;
            case "Shoot2":
                audioSrc.PlayOneShot(longShotSound);
                break;
            case "Shoot6":
                audioSrc.PlayOneShot(followerShot);
                break;
        }
    }

}
