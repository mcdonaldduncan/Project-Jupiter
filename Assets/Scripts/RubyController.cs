using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        //I tried adding modifiers here but it would give me errors that I do not understand
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float characterSpeed = 3.0f;

        Vector2 rubyPosition = transform.position;
        rubyPosition.x = rubyPosition.x + characterSpeed * horizontal * Time.deltaTime;
        rubyPosition.y = rubyPosition.y + characterSpeed * vertical * Time.deltaTime;
        transform.position = rubyPosition;
    }
}
