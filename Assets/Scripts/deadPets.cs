using UnityEditor;
using UnityEngine;

public class deadPets : MonoBehaviour
{
    [SerializeField] Sprite deadSprite;

    [SerializeField] Sprite currSprite;
    public GameObject pet;
    public void hitPole()
    {
        currSprite = deadSprite;
        // if pet dies, the dead sprite will be used 
        pet.GetComponent<SpriteRenderer>().sprite = currSprite;
    }

    public void outOfBounds()
    {
        currSprite = deadSprite;

        gameObject.GetComponent<SpriteRenderer>().sprite = currSprite;
    }

}
