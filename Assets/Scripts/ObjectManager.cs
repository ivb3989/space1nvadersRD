using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject barkingDogPrefab;
    public GameObject spacecraftLPrefab;
    public GameObject spacecraftMPrefab;
    public GameObject spacecraftSPrefab;
    public GameObject itemCoinPrefab;
    public GameObject itemPowerPrefab;
    public GameObject itemBoomPrefab;
    public GameObject bulletPlayerAPrefab;
    public GameObject bulletPlayerBPrefab;
    public GameObject bulletSpacecraftAPrefab;
    public GameObject bulletSpacecraftBPrefab;
    public GameObject bulletFollowerPrefab;
    public GameObject bulletDogAPrefab;
    public GameObject bulletDogBPrefab;
    public GameObject explosionPrefab;

    GameObject[] barkingDog;
    GameObject[] spacecraftL;
    GameObject[] spacecraftM;
    GameObject[] spacecraftS;

    GameObject[] itemCoin;
    GameObject[] itemPower;
    GameObject[] itemBoom;

    GameObject[] bulletPlayerA;
    GameObject[] bulletPlayerB;
    GameObject[] bulletEnemyA;
    GameObject[] bulletEnemyB;
    GameObject[] bulletFollower;
    GameObject[] bulletDogA;
    GameObject[] bulletDogB;
    GameObject[] explosion;

    GameObject[] targetPool;

    void Awake()
    {
        barkingDog = new GameObject[2];
        spacecraftL = new GameObject[10];
        spacecraftM = new GameObject[10];
        spacecraftS = new GameObject[20];

        itemCoin = new GameObject[20];
        itemPower = new GameObject[10];
        itemBoom = new GameObject[10];

        bulletPlayerA = new GameObject[100];
        bulletPlayerB = new GameObject[100];
        bulletEnemyA = new GameObject[100];
        bulletEnemyB = new GameObject[100];
        bulletFollower = new GameObject[100];
        bulletDogA = new GameObject[50];
        bulletDogB = new GameObject[1000];
        explosion = new GameObject[20];

        Generate();
    }

    void Generate()
    {
        //#1.Enemy
        for (int index = 0; index < barkingDog.Length; index++)
        {
            barkingDog[index] = Instantiate(barkingDogPrefab);
            barkingDog[index].SetActive(false);
        }
        for (int index = 0; index < spacecraftL.Length; index++)
        {
            spacecraftL[index] = Instantiate(spacecraftLPrefab);
            spacecraftL[index].SetActive(false);
        }
        for (int index = 0; index < spacecraftM.Length; index++)
        {
            spacecraftM[index] = Instantiate(spacecraftMPrefab);
            spacecraftM[index].SetActive(false);
        }
        for (int index = 0; index < spacecraftS.Length; index++)
        {
            spacecraftS[index] = Instantiate(spacecraftSPrefab);
            spacecraftS[index].SetActive(false);
        }

        //#2.Item
        for (int index = 0; index < itemCoin.Length; index++)
        {
            itemCoin[index] = Instantiate(itemCoinPrefab);
            itemCoin[index].SetActive(false);
        }
        for (int index = 0; index < itemPower.Length; index++)
        {
            itemPower[index] = Instantiate(itemPowerPrefab);
            itemPower[index].SetActive(false);
        }
        for (int index = 0; index < itemBoom.Length; index++)
        {
            itemBoom[index] = Instantiate(itemBoomPrefab);
            itemBoom[index].SetActive(false);
        }

        //#3.Bullet
        for (int index = 0; index < bulletPlayerA.Length; index++)
        {
            bulletPlayerA[index] = Instantiate(bulletPlayerAPrefab);
            bulletPlayerA[index].SetActive(false);
        }
        for (int index = 0; index < bulletPlayerB.Length; index++)
        {
            bulletPlayerB[index] = Instantiate(bulletPlayerBPrefab);
            bulletPlayerB[index].SetActive(false);
        }
        for (int index = 0; index < bulletEnemyA.Length; index++)
        {
            bulletEnemyA[index] = Instantiate(bulletSpacecraftAPrefab);
            bulletEnemyA[index].SetActive(false);
        }
        for (int index = 0; index < bulletEnemyB.Length; index++)
        {
            bulletEnemyB[index] = Instantiate(bulletSpacecraftBPrefab);
            bulletEnemyB[index].SetActive(false);
        }
        for (int index = 0; index < bulletFollower.Length; index++)
        {
            bulletFollower[index] = Instantiate(bulletFollowerPrefab);
            bulletFollower[index].SetActive(false);
        }
        for (int index = 0; index < bulletDogA.Length; index++)
        {
            bulletDogA[index] = Instantiate(bulletDogAPrefab);
            bulletDogA[index].SetActive(false);
        }
        for (int index = 0; index < bulletDogB.Length; index++)
        {
            bulletDogB[index] = Instantiate(bulletDogBPrefab);
            bulletDogB[index].SetActive(false);
        }
        //#.Explosion
        for (int index = 0; index < explosion.Length; index++)
        {
            explosion[index] = Instantiate(explosionPrefab);
            explosion[index].SetActive(false);
        }
    }

    public GameObject MakeObj(string type)
    {
        
        switch(type)
        {
            case "BarkingDog":
                targetPool = barkingDog;
                break;
            case "SpacecraftL":
                targetPool = spacecraftL;
                break;
            case "SpacecraftM":
                targetPool = spacecraftM;
                break;
            case "SpacecraftS":
                targetPool = spacecraftS;
                break;
            case "ItemPower":
                targetPool = itemPower;
                break;
            case "ItemBoom":
                targetPool = itemBoom;
                break;
            case "ItemCoin":
                targetPool = itemCoin;
                break;
            case "BulletPlayerA":
                targetPool = bulletPlayerA;
                break;
            case "BulletPlayerB":
                targetPool = bulletPlayerB;
                break;
            case "BulletSpacecraftA":
                targetPool = bulletEnemyA;
                break;
            case "BulletSpacecraftB":
                targetPool = bulletEnemyB;
                break;
            case "BulletFollower":
                targetPool = bulletFollower;
                break;
            case "BulletDogA":
                targetPool = bulletDogA;
                break;
            case "BulletDogB":
                targetPool = bulletDogB;
                break;
            case "Explosion":
                targetPool = explosion;
                break;
        }
        for (int index = 0; index < targetPool.Length; index++)
        {
            if (!targetPool[index].activeSelf)
            {
                targetPool[index].SetActive(true);
                return targetPool[index];
            }
        }

        return null;
    }

    public GameObject[] GetPool(string type)
    {
        switch (type)
        {
            case "BarkingDog":
                targetPool = barkingDog;
                break;
            case "SpacecraftL":
                targetPool = spacecraftL;
                break;
            case "SpacecraftM":
                targetPool = spacecraftM;
                break;
            case "SpacecraftS":
                targetPool = spacecraftS;
                break;
            case "ItemPower":
                targetPool = itemPower;
                break;
            case "ItemBoom":
                targetPool = itemBoom;
                break;
            case "ItemCoin":
                targetPool = itemCoin;
                break;
            case "BulletPlayerA":
                targetPool = bulletPlayerA;
                break;
            case "BulletPlayerB":
                targetPool = bulletPlayerB;
                break;
            case "BulletSpacecraftA":
                targetPool = bulletEnemyA;
                break;
            case "BulletSpacecraftB":
                targetPool = bulletEnemyB;
                break;
            case "BulletFollower":
                targetPool = bulletFollower;
                break;
            case "BulletDogA":
                targetPool = bulletDogA;
                break;
            case "BulletDogB":
                targetPool = bulletDogB;
                break;
            case "Explosion":
                targetPool = explosion;
                break;
        }
        return targetPool;
    }
}
