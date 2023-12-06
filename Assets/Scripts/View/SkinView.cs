using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinView : MonoBehaviour
{
    public SpriteRenderer baseSprite;
    public SpriteRenderer headgear;
    public SpriteRenderer armor;

    private void Update()
    {
        // TODO: Remove resources.load from update
        if (baseSprite.sprite.name.Contains("CharMovement"))
        {
            string spriteName = baseSprite.sprite.name;
            spriteName = spriteName.Replace("CharMovement_", "");
            int spriteId = int.Parse(spriteName);

            if (InventorySystem.Instance.Headgear != null)
            {
                var sprites = Resources.LoadAll<Sprite>("Skins/CharMovement_" + InventorySystem.Instance.Headgear.animation);
                headgear.sprite = sprites[spriteId];
            }
            else
            {
                headgear.sprite = null;
            }

            if (InventorySystem.Instance.Armor != null)
            {
                var sprites = Resources.LoadAll<Sprite>("Skins/CharMovement_" + InventorySystem.Instance.Armor.animation);
                armor.sprite = sprites[spriteId];
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
                var sprites = Resources.LoadAll<Sprite>("Skins/CharActions_" + InventorySystem.Instance.Headgear.animation);
                headgear.sprite = sprites[spriteId];
            }
            else
            {
                headgear.sprite = null;
            }

            if (InventorySystem.Instance.Armor != null)
            {
                var sprites = Resources.LoadAll<Sprite>("Skins/CharActions_" + InventorySystem.Instance.Armor.animation);
                armor.sprite = sprites[spriteId];
            }
            else
            {
                armor.sprite = null;
            }
        }
    }
}