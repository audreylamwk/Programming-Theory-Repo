using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animals : MonoBehaviour
{

    public Rigidbody rb;
    public float jumpforce = 10;
    public InputField iField;
    public string animalname;
    public int len_animalname;

    class Names
    {
        public int NameLength
        {
            get {return Name_Length;}
            set 
            {
                if (value > 5)
                {
                    Debug.LogError("You can't set a name that's too long!");
                }
                else
                {
                    Name_Length = value;
                }
            }
        }
        private int Name_Length;
            
    }

    public void SetName()
    {
        Names name = new Names();
        animalname = iField.text;
        len_animalname = animalname.Length;
        name.NameLength =  len_animalname;

    }



          
    // Start is called before the first frame update
    public virtual void Jump()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
    }
}
