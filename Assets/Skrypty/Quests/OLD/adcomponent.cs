using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adcomponent : MonoBehaviour {
    QuestSystemLVL1 lvl1;
    QuestSystemLVL2 lvl2;
    QuestSystemLVL3 lvl3;
    QuestSystemLVL4 lvl4;
    private void Update()
    {

        switch (ZmienneTag.LVL)
        {
            case 0:
                if (!gameObject.GetComponent<QuestSystemLVL1>())
                {
                    lvl1 = gameObject.AddComponent<QuestSystemLVL1>();
                    lvl1.claim_1.GetComponent<Button>().interactable = true;
                    lvl1.claim_2.GetComponent<Button>().interactable = true;
                    lvl1.claim_3.GetComponent<Button>().interactable = true;
                    lvl1.claim_4.GetComponent<Button>().interactable = true;
                }

                break;
            case 1:
                if (!gameObject.GetComponent<QuestSystemLVL1>())
                {
                    lvl1 = gameObject.AddComponent<QuestSystemLVL1>();
                    lvl1.claim_1.GetComponent<Button>().interactable = true;
                    lvl1.claim_2.GetComponent<Button>().interactable = true;
                    lvl1.claim_3.GetComponent<Button>().interactable = true;
                    lvl1.claim_4.GetComponent<Button>().interactable = true;
                }
                break;
            case 2:
                Destroy(gameObject.GetComponent<QuestSystemLVL1>());
                if (!gameObject.GetComponent<QuestSystemLVL2>())
                {
                    lvl2 = gameObject.AddComponent<QuestSystemLVL2>();
                    lvl2.claim_1.GetComponent<Button>().interactable = true;
                    lvl2.claim_2.GetComponent<Button>().interactable = true;
                    lvl2.claim_3.GetComponent<Button>().interactable = true;
                    lvl2.claim_4.GetComponent<Button>().interactable = true;
                }
                break;
            case 3:
                Destroy(gameObject.GetComponent<QuestSystemLVL1>());
                Destroy(gameObject.GetComponent<QuestSystemLVL2>());
                if (!gameObject.GetComponent<QuestSystemLVL3>())
                {
                    lvl3 = gameObject.AddComponent<QuestSystemLVL3>();
                    lvl3.claim_1.GetComponent<Button>().interactable = true;
                    lvl3.claim_2.GetComponent<Button>().interactable = true;
                    lvl3.claim_3.GetComponent<Button>().interactable = true;
                    lvl3.claim_4.GetComponent<Button>().interactable = true;
                }
                break;
            case 4:
                Destroy(gameObject.GetComponent<QuestSystemLVL1>());
                Destroy(gameObject.GetComponent<QuestSystemLVL2>());
                Destroy(gameObject.GetComponent<QuestSystemLVL3>());
                if (!gameObject.GetComponent<QuestSystemLVL4>())
                {
                    lvl4 = gameObject.AddComponent<QuestSystemLVL4>();
                    lvl4.claim_1.GetComponent<Button>().interactable = true;
                    lvl4.claim_2.GetComponent<Button>().interactable = true;
                    lvl4.claim_3.GetComponent<Button>().interactable = true;
                    lvl4.claim_4.GetComponent<Button>().interactable = true;
                }
                break;
            default:
                break;
        }
    }

}
