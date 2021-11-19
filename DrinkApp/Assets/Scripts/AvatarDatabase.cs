using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AvatarDatabase : ScriptableObject
{
    public Avatar[] avatar;

    public int AvatarCount
    {
        get
        {
            return avatar.Length;
        }
    }

    public Avatar GetAvatar(int index)
    {
        return avatar[index];
    }
}
