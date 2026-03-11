using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text messageText;

    [Header("Interact Message")]
    [SerializeField] float messageDeration = 3f;
    [SerializeField] float fadeOutTime = 0.5f;
     

    private Coroutine fadeCoroutine;

    public void DisplayMessage(string message)
    {
        if(fadeCoroutine != null)
        {
            StopCoroutine(fadeCoroutine);
        }
        fadeCoroutine = StartCoroutine(FadeOutInfoText(message));




    }

    private IEnumerator FadeOutInfoText(string message)
    {
        messageText.text = message;
        messageText.alpha = 1;
        float elapsedTime = 0f;


        yield return new WaitForSeconds(messageDeration);
        Color OriginalColor = messageText.color;

        while(elapsedTime < messageDeration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeOutTime);
            //messageText.color = new Color(OriginalColor.r, OriginalColor.g, OriginalColor.b, alpha);
            messageText.alpha = alpha;
            yield return null;
        }
        messageText.text = message;
        yield return new WaitForSeconds(3f);
        messageText.text = " ";

    }
}
