using System;
using System.Collections;
using UnityEngine;

namespace Game
{
    public class VirtualMachine : MonoBehaviour
    {
        public Mage[] mages;
        public TextAsset[] spells;
        public float timeBetweenSpells;
        private Stack _dataStack = new Stack();

        private void Start()
        {
            StartCoroutine(CastAllSpells());
        }

        IEnumerator CastAllSpells()
        {
            for (int i = 0; i < spells.Length; i++)
            {
                yield return new WaitForSeconds(timeBetweenSpells);
                CastSpell(spells[i]);
            }
        }

        void CastSpell(TextAsset spell)
        {
            var splitFile = new string[] { "\r\n", "\r", "\n" };
            var spellLines= spell.text.Split(splitFile,StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < spellLines.Length; i++)
            {
                var line = spellLines[i];
                var lineEnum = (SpellEnum)Enum.Parse(typeof(SpellEnum), line);
                switch (lineEnum)
                {
                    case SpellEnum.SET_HEALTH:
                        int amount = (int)_dataStack.Pop();
                        int wizardID = (int)_dataStack.Pop();
                        mages[wizardID].ChangeHealth(amount);
                        break;
                    case SpellEnum.INT_VAR:
                        i++;
                        _dataStack.Push(int.Parse(spellLines[i]));
                        break;
                }
            }
        }
    }
}