using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class Purchaser : MonoBehaviour
{
    public void OnPurchaseCompleted(Product product)
    {
        switch(product.definition.id)
        {
            case "com.serbull.iaptutorial.removeads":
                RemoveAds();
                break;
            case "com.serbull.iaptutorial.500coins":
                Add500Coins();
                break;
        }
    }

    private void RemoveAds()
    {
        PlayerPrefs.SetInt("removeads", 1);
        Debug.Log("Purchase: removeads");
        UIInfo.Instance.UpdateRemoveAdsButton();
    }

    private void Add500Coins()
    {
        int coins = PlayerPrefs.GetInt("coins");
        coins += 500;
        PlayerPrefs.SetInt("coins", coins);
        Debug.Log("Purchase: get 500 coins");
        UIInfo.Instance.UpdateCoinsText();
    }
}
