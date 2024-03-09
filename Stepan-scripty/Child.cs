    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using TMPro;

    public class Child : MonoBehaviour
    {
        public TextMeshProUGUI text;
        public player_script playerS;
        public List<string> childQuest = new List<string>() {};
        public int textCounter = 0;
        public float speed = 2.0f;
        public bool moveRight = true;
        private Vector3 ogTransform;
        private bool isMoving = true;

        void Start()
        {
            ogTransform = transform.position;
            text.enabled = false;
            NpcWalk();
        }

        void Update()
        {
            if (isMoving)
            {
                NpcWalk();
                    if (transform.position.x > ogTransform.x + 2)
                {
                    StartCoroutine(ChangeDirectionWithDelay(1.0f));
                    return; 
                }
                if (transform.position.x < ogTransform.x-2)
                {
                    StartCoroutine(ChangeDirectionWithDelay(1.0f)); 
                    return;
                }
            }
        }

        IEnumerator ChangeDirectionWithDelay(float delay)
        {
            isMoving = false;
            yield return new WaitForSeconds(delay);
            moveRight = !moveRight;
            isMoving = true;
        }

        public void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Child: " + text);
            text.enabled = true;
            isMoving = false;
        }

        public void OnTriggerExit2D(Collider2D other)
        {
            text.enabled = false;
            isMoving = true;
        }

        private void NpcWalk()
        {   
                if(moveRight){
                    Vector3 movement = Vector3.right * speed * 1 * Time.deltaTime;
                    transform.Translate(movement);
                }
                else{
                    Vector3 movement = Vector3.right * speed * -1 * Time.deltaTime;
                    transform.Translate(movement);
                }
        }

    public void OnClickChangeText()
    {
        if (textCounter == -1)
        {
            return;
        }
        text.text = childQuest[textCounter];
        textCounter++;
        Debug.Log(textCounter);
        if (textCounter == 2)
        {
            Variables.currentQuest = "Dones medu borcovi";
            playerS.UpdateQuest();
        }
        if (textCounter == 3)
        {
            textCounter--;
        }
        if (playerS.hasQuestItem == true)
        {
            Variables.currentQuest = "";
            text.text = "Dyk, tady mas neco za to";
            playerS.hasQuestItem = false;
            playerS.hasKey = true;
            playerS.UpdateQuest();
            textCounter = -1;
        }
    }
}

    
