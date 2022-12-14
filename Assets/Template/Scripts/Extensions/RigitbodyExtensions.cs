using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Rigitbodyの拡張メソッドをもっているScript
/// </summary>
public static class RigitbodyExtensions
{
    #region Method

    public static Rigidbody ChangeConstraints(this Rigidbody rb,Freeze type)
    {
        var constraints = (RigidbodyConstraints)type;
        rb.constraints = constraints;
        return rb;
    }

    #endregion
}
public enum Freeze
{ 
    [Tooltip("全解除")]
    None = 0,

    [Tooltip("PositionXを止める")]
    PosX = 2,

    [Tooltip("PositionYを止める")]
    PosY = 4,

    [Tooltip("PositionXとYを止める")]
    PosXY = 6,

    [Tooltip("PositionZを止める")]
    PosZ = 8,

    [Tooltip("PositionXとZを止める")]
    PosXZ = 10,

    [Tooltip("PositionYとZを止める")]
    PosYZ = 12,

    [Tooltip("Position全てを止める")]
    Pos = 14,

    [Tooltip("RotationXを止める")]
    RotX = 16,

    [Tooltip("PositionXとRotationXを止める")]
    PosXRotX = 18,

    [Tooltip("PositionYとRotationXを止める")]
    PosYRotX = 20,

    [Tooltip("PositionXYとRotationXを止める")]
    PosXYRotX = 22,

    [Tooltip("PositionZとRotationXを止める")]
    PosZRotX = 24,

    [Tooltip("PositionXZとRotationXを止める")]
    PosXZRotX = 26,

    [Tooltip("PositionYZとRotationXを止める")]
    PosYZRotX = 28,

    [Tooltip("Position全てとRotationXを止める")]
    PosRotX = 30,

    [Tooltip("RotationYを止める")]
    RotY = 32,

    [Tooltip("PositionXとRotationYを止める")]
    PosXRotY = 34,

    [Tooltip("PositionYとRotationYを止める")]
    PosYRotY = 36,

    [Tooltip("PositionXYとRotationYを止める")]
    PosXYRotY = 38,

    [Tooltip("PositionZとRotationYを止める")]
    PosZRotY = 40,

    [Tooltip("PositionXZとRotationYを止める")]
    PosXZRotY = 42,

    [Tooltip("PositionYZとRotationYを止める")]
    PosYZRotY = 44,

    [Tooltip("Position全てとRotationYを止める")]
    PosRotY = 46,

    [Tooltip("RotationXYを止める")]
    RotXY = 48,

    [Tooltip("PositionXとRotationXYを止める")]
    PosXRotXY = 50,

    [Tooltip("PositionYとRotationXYを止める")]
    PosYRotXY = 52,

    [Tooltip("PositionXYとRotationXYを止める")]
    PosXYRotXY = 54,

    [Tooltip("PositionZとRotationXYを止める")]
    PosZRotXY = 56,

    [Tooltip("PositionXZとRotationXYを止める")]
    PosXZRotXY = 58,

    [Tooltip("PositionYZとRotationXYを止める")]
    PosYZRotXY = 60,

    [Tooltip("Position全てとRotationXYを止める")]
    PosRotXY = 62,

    [Tooltip("RotationZを止める")]
    RotZ = 64,

    [Tooltip("PositionXとRotationZを止める")]
    PosXRotZ = 66,

    [Tooltip("PositionYとRotationZを止める")]
    PosYRotZ = 68,

    [Tooltip("PositionXYとRotationZを止める")]
    PosXYRotZ = 70,

    [Tooltip("PositionZとRotationZを止める")]
    PosZRotZ = 72,

    [Tooltip("PositionXZとRotationZを止める")]
    PosXZRotZ = 74,

    [Tooltip("PositionYZとRotationZを止める")]
    PosYZRotZ = 76,

    [Tooltip("Position全てとRotationZを止める")]
    PosRotZ = 78,

    [Tooltip("RotationXとZを止める")]
    RotXZ = 80,

    [Tooltip("PositionXとRotationXZを止める")]
    PosXRotXZ = 82,

    [Tooltip("PositionYとRotationXZを止める")]
    PosYRotXZ = 84,

    [Tooltip("PositionXYとRotationXZを止める")]
    PosXYRotXZ = 86,

    [Tooltip("PositionZとRotationXZを止める")]
    PosZRotXZ = 88,

    [Tooltip("PositionXZとRotationXZを止める")]
    PosXZRotXZ = 90,

    [Tooltip("PositionYZとRotationXZを止める")]
    PosYZRotXZ = 92,

    [Tooltip("Position全てとRotationXZを止める")]
    PosRotXZ = 94,

    [Tooltip("RotationYとZを止める")]
    RotYZ = 96,

    [Tooltip("PositionXとRotationYZを止める")]
    PosXRotYZ = 98,

    [Tooltip("PositionYとRotationXZを止める")]
    PosYRotYZ = 100,

    [Tooltip("PositionXYとRotationXZを止める")]
    PosXYRotYZ = 102,

    [Tooltip("PositionZとRotationXZを止める")]
    PosZRotYZ = 104,

    [Tooltip("PositionXZとRotationXZを止める")]
    PosXZRotYZ = 106,

    [Tooltip("PositionYZとRotationXZを止める")]
    PosYZRotYZ = 108,

    [Tooltip("Position全てとRotationXZを止める")]
    PosRotYZ = 110,

    [Tooltip("Rotation全てを止める")]
    Rot = 112,

    [Tooltip("PositionXとRotation全てを止める")]
    PosXRot = 114,

    [Tooltip("PositionYとRotation全てを止める")]
    PosYRot = 116,

    [Tooltip("PositionXYとRotation全てを止める")]
    PosXYRot = 118,

    [Tooltip("PositionZとRotation全てを止める")]
    PosZRot = 120,

    [Tooltip("PositionXZとRotation全てを止める")]
    PosXZRot = 122,

    [Tooltip("PositionYZとRotation全てを止める")]
    PosYZRot = 124,

    [Tooltip("全て止める")]
    All = 126,
}
