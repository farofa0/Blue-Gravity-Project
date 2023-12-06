using UnityEngine;

public class SkinView : MonoBehaviour
{
    public SpriteRenderer baseSprite;
    public SpriteRenderer headgear;
    public SpriteRenderer armor;

    private Sprite[] headgearMovementSprites;
    private Sprite[] headgearActionSprites;
    private Sprite[] armorMovementSprites;
    private Sprite[] armorActionSprites;

    private void OnEnable()
    {
        InventorySystem.onEquipItem += SetCurrentSkin;
    }

    private void OnDisable()
    {
        InventorySystem.onEquipItem -= SetCurrentSkin;
    }

    public void SetCurrentSkin()
    {
        if (InventorySystem.Instance.Headgear != null)
            headgearMovementSprites = Resources.LoadAll<Sprite>("Skins/CharMovement_" + InventorySystem.Instance.Headgear.animation);
        if (InventorySystem.Instance.Headgear != null)
            headgearActionSprites = Resources.LoadAll<Sprite>("Skins/CharActions_" + InventorySystem.Instance.Headgear.animation);

        if (InventorySystem.Instance.Armor != null)
            armorMovementSprites = Resources.LoadAll<Sprite>("Skins/CharMovement_" + InventorySystem.Instance.Armor.animation);
        if (InventorySystem.Instance.Armor != null)
            armorActionSprites = Resources.LoadAll<Sprite>("Skins/CharActions_" + InventorySystem.Instance.Armor.animation);
    }

    private void FixedUpdate()
    {
        if (baseSprite.sprite.name.Contains("CharMovement"))
        {
            string spriteName = baseSprite.sprite.name;
            spriteName = spriteName.Replace("CharMovement_", "");
            int spriteId = int.Parse(spriteName);

            if (InventorySystem.Instance.Headgear != null)
            {
                headgear.sprite = headgearMovementSprites[spriteId];
            }
            else
            {
                headgear.sprite = null;
            }

            if (InventorySystem.Instance.Armor != null)
            {
                armor.sprite = armorMovementSprites[spriteId];
            }
            else
            {
                armor.sprite = null;
            }
        }
        else if (baseSprite.sprite.name.Contains("CharActions"))
        {
            string spriteName = baseSprite.sprite.name;
            spriteName = spriteName.Replace("CharActions_", "");
            int spriteId = int.Parse(spriteName);

            if (InventorySystem.Instance.Headgear != null)
            {
                headgear.sprite = headgearActionSprites[spriteId];
            }
            else
            {
                headgear.sprite = null;
            }

            if (InventorySystem.Instance.Armor != null)
            {
                armor.sprite = armorActionSprites[spriteId];
            }
            else
            {
                armor.sprite = null;
            }
        }
    }
}