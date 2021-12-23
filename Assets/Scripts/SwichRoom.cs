using System.Collections;
using UnityEngine;

public class SwichRoom : MonoBehaviour
{
    public Animator animator;

    public void NextRoom(GameObject nextRoom)
    {
        animator.Play("FadeOut");
        StartCoroutine(WaitToLoad(nextRoom));
    }

    private IEnumerator WaitToLoad(GameObject nextRoom)
    {
        yield return new WaitForSeconds(1);
        nextRoom.SetActive(true);
        animator.Play("FadeIn");
        transform.parent.gameObject.SetActive(false);
    }

    public void ToggleInfo(GameObject info)
    {
        info.SetActive(!info.activeSelf);
    }
}
