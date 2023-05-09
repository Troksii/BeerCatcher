using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroy : MonoBehaviour
{
    // Start is called before the first frame update
  private void Awake() {
    {
      GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BGMusic");
      if (musicObj.Length > 1)
      {
          Destroy(this.gameObject);
      }
      else
      {
         DontDestroyOnLoad(this.gameObject);
      }
       
    }
  }
}
