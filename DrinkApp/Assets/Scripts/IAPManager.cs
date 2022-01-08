using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class IAPManager : MonoBehaviour
{
    public GameObject buyButton;
    private string premiumdeck = "com.anomalystudios.iap.premiumdeck";
    public void OnPurchaseComplete(Product product)
    {
        if(product.definition.id == premiumdeck)
        {
            Debug.Log("Bought Deck");
            StartCoroutine(WaitAndClose());
        }
    }

    IEnumerator WaitAndClose()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.1f);
            buyButton.SetActive(false);
        }
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failReason)
    {
        Debug.Log(product.definition.id + " failed because" + failReason);
    }
}
