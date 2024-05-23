using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject helmet1;
    public GameObject helmet2;
    public GameObject helmet3;
    public GameObject jaka1;
    public GameObject jaka2;
    public GameObject jaka3;
    public GameObject bikses1;
    public GameObject bikses2;
    public GameObject bikses3;
    public GameObject apavi1;
    public GameObject apavi2;
    public GameObject apavi3;
    public Sprite[] spriteArray;
    public GameObject imageHolder;
    public GameObject widthSlider;
    public GameObject heightSlider;
    public GameObject scroll;

    public void showHelmet1(bool value)
    {
        helmet1.SetActive(value);
    }

    public void showHelmet2(bool value)
    {
        helmet2.SetActive(value);
    }

    public void showHelmet3(bool value)
    {
        helmet3.SetActive(value);
    }

    public void showJaka1(bool value)
    {
        jaka1.SetActive(value);
    }

    public void showJaka2(bool value)
    {
        jaka2.SetActive(value);
    }

    public void showJaka3(bool value)
    {
        jaka3.SetActive(value);
    }

    public void showBikses1(bool value)
    {
        bikses1.SetActive(value);
    }

    public void showBikses2(bool value)
    {
        bikses2.SetActive(value);
    }
    public void showBikses3(bool value)
    {
        bikses3.SetActive(value);
    }

    public void showApavi1(bool value)
    {
        apavi1.SetActive(value);
    }

    public void showApavi2(bool value)
    {
        apavi2.SetActive(value);
    }
    public void showApavi3(bool value)
    {
        apavi3.SetActive(value);
    }

    public void changeImage(int index)
    {
        if (index >= 0 && index < spriteArray.Length)
        {
            imageHolder.GetComponent<Image>().sprite = spriteArray[index];
            imageHolder.GetComponent<RectTransform>().sizeDelta = new Vector2(
                spriteArray[index].rect.width,
                spriteArray[index].rect.height
            );
            if(index == 0) {
                scroll.GetComponent<Text>().text = "Alex is a girl about to goon a dangerous adventure! Many biomes, challenges and monsters are waiting for her. Help her to choose a good outfit so that she can face all the adventures with courage!";
            }
            
            else if(index == 1) {
                scroll.GetComponent<Text>().text = "Yuma is a guy who likes fire and danger. His favourite biome is the Nether, where he lives and travels around exploring Bastions and Fortresses. Pretty soon Yuma will have to go to the depths of Nether again, I think he needs the right clothes for that...";
            }

        }
    }

    public void changeWidth(){
    float width = widthSlider.GetComponent<Slider>().value;
    Vector3 currentScale = imageHolder.transform.localScale;
    imageHolder.transform.localScale = new Vector3(width, currentScale.y, currentScale.z);
}

    public void changeHeight(){
    float height = heightSlider.GetComponent<Slider>().value;
    Vector3 currentScale = imageHolder.transform.localScale;
    imageHolder.transform.localScale = new Vector3(currentScale.x, height, currentScale.z);
}
}
