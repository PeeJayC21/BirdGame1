using UnityEngine;

public class deadPets : MonoBehaviour
{
    [SerializeField] Sprite deadSprite;

    [SerializeField] Sprite currSprite;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currSprite = deadSprite;

        // if pet dies, the dead sprite will be used 
        gameObject.GetComponent<SpriteRenderer>().sprite = currSprite;
    }

}
