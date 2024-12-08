using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationController : MonoBehaviour
{
    public void HideNotification()
    {
        gameObject.SetActive(false);
    }
}
